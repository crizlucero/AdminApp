using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.View;
using Android.Views;
using Android.Widget;
using Java.Lang;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using WorklabsMx.Droid.Helpers;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/app_name")]
    public class SalasJuntasActivity : Activity
    {
        ViewPager _viewPager;
        List<int> horas;
        List<double> HorasNoDisponibles;
        string fecha_seleccionada;
        readonly SimpleStorage storage;
        AlertDialog dialog;
        List<SalaJuntasModel> salas;
        readonly SalasJuntasController SalasController;
        readonly UsuarioModel usuario;
        LinearLayout llhHorario;
        double creditos;
        readonly Dictionary<string, Dictionary<string, List<double>>> Horarios;
        Dictionary<string, string> niveles;
        public SalasJuntasActivity()
        {
            HorasNoDisponibles = new List<double>();
            storage = SimpleStorage.EditGroup("Login");
            fecha_seleccionada = DateTime.Now.ToString("d");
            SalasController = new SalasJuntasController();
            Horarios = new Dictionary<string, Dictionary<string, List<double>>>();
            horas = new List<int>();
            for (int i = 1; i < 25; i++)
                horas.Add(i);
            usuario = new UsuariosController().GetMemberData(storage.Get("Usuario_Id"), storage.Get("Usuario_Tipo"));

        }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ReservaSalaJuntasLayout);
            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.ReservaSala);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            _viewPager = FindViewById<ViewPager>(Resource.Id.vpSucursal);
            salas = SalasController.GetSalaJuntas(Intent.GetStringExtra("sucursal_id"));
            niveles = SalasController.GetNivelesSucursal(Intent.GetStringExtra("sucursal_id"));
            _viewPager.Adapter = new SalaJuntasAdapter(this, salas);
            Horarios.Add(salas[_viewPager.CurrentItem].Sala_Id, new Dictionary<string, List<double>>());
            Horarios[salas[_viewPager.CurrentItem].Sala_Id].Add(fecha_seleccionada, new List<double>());
            FindViewById<TextView>(Resource.Id.lblCreditosDisponibles).Text = SalasController.GetCreditosDisponibles(storage.Get("Usuario_Id")).ToString();
            FindViewById<LinearLayout>(Resource.Id.llSeleccionarFecha).Click += (sender, e) =>
            {
                DatePickerMinFragment frag = DatePickerMinFragment.NewInstance(delegate (DateTime time)
                {
                    FindViewById<TextView>(Resource.Id.lblDiaFecha).Text = time.DayOfWeek.ToString().Substring(0, 3);
                    FindViewById<TextView>(Resource.Id.lblDiaNumero).Text = time.Day.ToString();
                    fecha_seleccionada = time.ToString("d");
                    UpdateHorasNoDisponibles();
                });
                frag.Show(FragmentManager, Resources.GetString(Resource.String.ReservaSala));
            };
            FindViewById<TextView>(Resource.Id.lblDiaFecha).Text = DateTime.Parse(fecha_seleccionada).DayOfWeek.ToString().Substring(0, 3);
            FindViewById<TextView>(Resource.Id.lblDiaNumero).Text = DateTime.Parse(fecha_seleccionada).Day.ToString();
            FindViewById<TextView>(Resource.Id.lblHorasTotal).Text = Horarios[salas[_viewPager.CurrentItem].Sala_Id][fecha_seleccionada].Count.ToString();
            FindViewById<TextView>(Resource.Id.lblCreditosUsados).Text = creditos.ToString();
            Spinner spNivel = FindViewById<Spinner>(Resource.Id.spNivel);
            spNivel.Adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerItem, niveles.Keys.ToList());
            spNivel.SetSelection(niveles.Count - 1);
            spNivel.ItemSelected += (sender, e) =>
            {
                salas = SalasController.GetSalaJuntas(Intent.GetStringExtra("sucursal_id"), niveles[((Spinner)sender).SelectedItem.ToString()]);
                _viewPager.Adapter = new SalaJuntasAdapter(this, salas);
            };
            llhHorario = FindViewById<LinearLayout>(Resource.Id.llhHorario);
            SalasController.GetHorasNoDisponibles(fecha_seleccionada, salas[_viewPager.CurrentItem].Sala_Id).ForEach(horas =>
            {
                HorasNoDisponibles.Add(DateTime.Parse(horas.Sala_Hora_Fin).Hour);
                UpdateHorasNoDisponibles();
            });

            _viewPager.PageSelected += (sender, e) =>
            {
                HorasNoDisponibles.Clear();
                SalasController.GetHorasNoDisponibles(fecha_seleccionada, salas[_viewPager.CurrentItem].Sala_Id).ForEach(horas =>
                {
                    HorasNoDisponibles.Add(DateTime.Parse(horas.Sala_Hora_Fin).Hour);
                });
                if (!Horarios.ContainsKey(salas[_viewPager.CurrentItem].Sala_Id))
                    Horarios.Add(salas[_viewPager.CurrentItem].Sala_Id, new Dictionary<string, List<double>>());
                if (!Horarios[salas[_viewPager.CurrentItem].Sala_Id].ContainsKey(fecha_seleccionada))
                    Horarios[salas[_viewPager.CurrentItem].Sala_Id].Add(fecha_seleccionada, new List<double>());
                UpdateHorasNoDisponibles();
                FillHorario();
            };
            FindViewById<RelativeLayout>(Resource.Id.rlAgendar).Click += (sender, e) => ShowConfirmacion();
            UpdateHorasNoDisponibles();
            FillHorario();
            HorizontalScrollView scrollHoras = FindViewById<HorizontalScrollView>(Resource.Id.hsvHorario);

            scrollHoras.SmoothScrollBy(scrollHoras.Width, 0);
        }

        void UpdateHorasNoDisponibles()
        {
            if (DateTime.Parse(fecha_seleccionada).ToString("d") == DateTime.Now.ToString("d"))
                for (double i = 0; i <= DateTime.Now.Hour; i += .5)
                    if (!HorasNoDisponibles.Contains(i))
                        HorasNoDisponibles.Add(i);
        }

        void FillHorario()
        {
            llhHorario.RemoveAllViews();
            PutZeroHour();
            horas.ForEach(hora =>
            {
                LayoutInflater liView = LayoutInflater;
                View HorarioView = liView.Inflate(Resource.Layout.HorarioItemLayout, null, true);
                if (hora < 24)
                    HorarioView.FindViewById<TextView>(Resource.Id.lblHora).Text = hora.ToString();
                else
                    HorarioView.FindViewById<TextView>(Resource.Id.lblHora).Text = "0";
                ImageView horarioInf = HorarioView.FindViewById<ImageView>(Resource.Id.ivHoraInf);
                ImageView horarioSup = HorarioView.FindViewById<ImageView>(Resource.Id.ivHoraSup);

                if (HorasNoDisponibles.Contains(hora))
                {
                    horarioInf.SetBackgroundColor(Color.Rgb(85, 85, 85));
                    horarioInf.SetImageResource(Resource.Mipmap.ic_diagonal_lines);
                }
                if (HorasNoDisponibles.Contains(hora - .5))
                {
                    horarioSup.SetBackgroundColor(Color.Rgb(85, 85, 85));
                    horarioSup.SetImageResource(Resource.Mipmap.ic_diagonal_lines);
                }
                if (Horarios[salas[_viewPager.CurrentItem].Sala_Id][fecha_seleccionada].Contains(hora))
                {
                    horarioInf.SetBackgroundColor(Color.Rgb(162, 219, 255));
                }
                if (Horarios[salas[_viewPager.CurrentItem].Sala_Id][fecha_seleccionada].Contains(hora - .5))
                {
                    horarioSup.SetBackgroundColor(Color.Rgb(162, 219, 255));
                }
                horarioInf.Click += delegate
                {
                    if (!HorasNoDisponibles.Contains(hora - 1))
                    {
                        if (!Horarios[salas[_viewPager.CurrentItem].Sala_Id][fecha_seleccionada].Contains(hora - 1))
                        {
                            horarioInf.SetBackgroundColor(Color.Rgb(162, 219, 255));
                            Horarios[salas[_viewPager.CurrentItem].Sala_Id][fecha_seleccionada].Add(hora - 1);
                        }
                        else
                        {
                            horarioInf.SetBackgroundColor(Color.Rgb(225, 252, 195));
                            Horarios[salas[_viewPager.CurrentItem].Sala_Id][fecha_seleccionada].Remove(hora - 1);
                        }
                        CalculoCreditos();
                    }
                };

                horarioSup.Click += delegate
                {
                    if (!HorasNoDisponibles.Contains(hora - .5))
                    {
                        if (!Horarios[salas[_viewPager.CurrentItem].Sala_Id][fecha_seleccionada].Contains(hora - .5))
                        {
                            horarioSup.SetBackgroundColor(Color.Rgb(162, 219, 255));
                            Horarios[salas[_viewPager.CurrentItem].Sala_Id][fecha_seleccionada].Add(hora - .5);
                        }
                        else
                        {
                            horarioSup.SetBackgroundColor(Color.Rgb(225, 252, 195));
                            Horarios[salas[_viewPager.CurrentItem].Sala_Id][fecha_seleccionada].Remove(hora - .5);
                        }
                        CalculoCreditos();
                    }
                };
                llhHorario.AddView(HorarioView);
            });
        }

        void CalculoCreditos()
        {
            double totalHoras = 0;

            creditos = 0;
            salas.ForEach(sala =>
            {
                if (Horarios.ContainsKey(sala.Sala_Id))
                {
                    foreach (KeyValuePair<string, List<double>> fechaHorario in Horarios[sala.Sala_Id])
                    {
                        totalHoras += fechaHorario.Value.Count / 2;
                        fechaHorario.Value.ForEach(time =>
                        {
                            creditos++;
                            if (sala.Sala_Capacidad == "10" && time > 10 && time < 18)
                                creditos += .5;
                        });
                    }
                }
            });
            FindViewById<TextView>(Resource.Id.lblHorasTotal).Text = totalHoras.ToString();
            FindViewById<TextView>(Resource.Id.lblCreditosUsados).Text = creditos.ToString();
        }

        void PutZeroHour()
        {
            GridLayout glZero = new GridLayout(this)
            {
                ColumnCount = 3,
                RowCount = 1
            };
            glZero.SetBackgroundColor(Color.White);
            glZero.AddView(new TextView(this)
            {
                Text = "0"
            });
            View line = new View(this);
            line.SetBackgroundColor(Color.Rgb(149, 152, 154));
            line.SetMinimumWidth(1);
            line.SetMinimumHeight(60);
            line.SetForegroundGravity(GravityFlags.Right);
            glZero.AddView(line);
            llhHorario.AddView(glZero);
        }

        public override bool OnCreateOptionsMenu(IMenu menu) => base.OnCreateOptionsMenu(menu);

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            StartActivity(new Intent(this, typeof(SalasJuntasSucursalActivity)));
            Finish();
            return base.OnOptionsItemSelected(item);
        }

        void ShowConfirmacion()
        {

            AlertDialog.Builder builder = new AlertDialog.Builder(this);

            LayoutInflater liView = LayoutInflater;

            View customView = liView.Inflate(Resource.Layout.DetallesReservacionLayout, null, true);
            Dictionary<double, double> aux = new Dictionary<double, double>();
            Horarios[salas[_viewPager.CurrentItem].Sala_Id][fecha_seleccionada].Sort();
            double aux2 = Horarios[salas[_viewPager.CurrentItem].Sala_Id][fecha_seleccionada][0];
            aux.Add(aux2, aux2 + .5);

            for (int i = 1; i < Horarios[salas[_viewPager.CurrentItem].Sala_Id][fecha_seleccionada].Count; i++)
            {
                /*if (Horarios[salas[_viewPager.CurrentItem].Sala_Id][fecha_seleccionada][i] - .5 < 0)
                {

                }*/
                Console.WriteLine(Horarios[salas[_viewPager.CurrentItem].Sala_Id][fecha_seleccionada][i]);
                if (aux[aux2] == Horarios[salas[_viewPager.CurrentItem].Sala_Id][fecha_seleccionada][i])
                    aux[aux2] = Horarios[salas[_viewPager.CurrentItem].Sala_Id][fecha_seleccionada][i] + .5;
                else
                {
                    aux2 = Horarios[salas[_viewPager.CurrentItem].Sala_Id][fecha_seleccionada][i];
                    aux.Add(aux2, aux2 + .5);
                }
            }


            TableLayout tlReservaciones = customView.FindViewById<TableLayout>(Resource.Id.tlReservaciones);

            foreach (KeyValuePair<double, double> hora in aux)
            {
                LayoutInflater li = LayoutInflater;

                View detalleView = li.Inflate(Resource.Layout.DetallesReservacionSalaJuntaLayout, null, true);
                detalleView.FindViewById<TextView>(Resource.Id.lblSalasJuntas).Text = salas[_viewPager.CurrentItem].Sala_Descripcion;
                detalleView.FindViewById<TextView>(Resource.Id.lblPiso).Text = "Nivel " + salas[_viewPager.CurrentItem].Sala_Nivel;
                detalleView.FindViewById<TextView>(Resource.Id.lblFechaNumero).Text = DateTime.Parse(fecha_seleccionada).ToString("M");

                detalleView.FindViewById<TextView>(Resource.Id.lblHorario).Text = TimeSpan.FromHours(hora.Key).ToString().Substring(0, 5) + " - " + TimeSpan.FromHours(hora.Value).ToString().Substring(0, 5);//hora.Value.ToString("00") + ":00";

                TableRow row = new TableRow(this);
                row.AddView(detalleView);
                tlReservaciones.AddView(row);
            }
            AssetManager asset = Assets;
            string correoInvitacion = new StreamReader(asset.Open("SalaJuntasReserva.html")).ReadToEnd();
            new Emails().SendMail(usuario.Usuario_Correo_Electronico, usuario.Usuario_Nombre + " " + usuario.Usuario_Apellidos,
                                       correoInvitacion.Replace("{{NOMBRE}}", usuario.Usuario_Nombre + " " + usuario.Usuario_Apellidos)
                                        .Replace("{{NOMBRESALA}}", salas[_viewPager.CurrentItem].Sala_Descripcion)
                                  .Replace("{{CAPACIDADSALA}}", salas[_viewPager.CurrentItem].Sala_Capacidad)
                                  .Replace("{{DIALETRA}}", new CultureInfo("es-MX").DateTimeFormat.GetDayName(DateTime.Parse(fecha_seleccionada).DayOfWeek).Substring(0, 3))
                                  .Replace("{{DIANUMERO}}", DateTime.Parse(fecha_seleccionada).Day.ToString())
                                  .Replace("{{HORARIO}}", TimeSpan.FromHours(Horarios[salas[_viewPager.CurrentItem].Sala_Id][fecha_seleccionada][0]).ToString().Substring(0, 5) + " - " + TimeSpan.FromHours(Horarios[salas[_viewPager.CurrentItem].Sala_Id][fecha_seleccionada][0] + .5).ToString().Substring(0, 5)),
                                  "Worklabs - Confirmación de sala de junta");
            customView.FindViewById<Button>(Resource.Id.btnCancelar).Click += (sender, e) => dialog.Dismiss();
            customView.FindViewById<Button>(Resource.Id.btnConfirmar).Click += delegate
            {
                Horarios[salas[_viewPager.CurrentItem].Sala_Id][fecha_seleccionada].ForEach(hora =>
                {
                    if (SalasController.AsignarSalaJuntas("ALTA", salas[_viewPager.CurrentItem].Sala_Id, storage.Get("Usuario_Id"),
                                                      storage.Get("Usuario_Tipo"), DateTime.Parse(fecha_seleccionada),
                                                         TimeSpan.FromHours(hora).ToString().Substring(0, 5), TimeSpan.FromHours(hora + .5).ToString().Substring(0, 5)) == -1)
                        WorklabsMx.Helpers.SlackLogs.SendMessage("ERROR: Registro de sala de junta " + TimeSpan.FromHours(hora).ToString().Substring(0, 5) + " - " + TimeSpan.FromHours(hora + .5).ToString().Substring(0, 5));

                }
                );
                dialog.Dismiss();
                SetContentView(Resource.Layout.SalasJuntasConfirmacionLayout);

                FindViewById<TextView>(Resource.Id.lblDiaSemana).Text = new CultureInfo("es-MX").DateTimeFormat.GetDayName(DateTime.Parse(fecha_seleccionada).DayOfWeek).Substring(0, 3);
                FindViewById<TextView>(Resource.Id.lblDiaNumero).Text = DateTime.Parse(fecha_seleccionada).Day.ToString();
                FindViewById<TextView>(Resource.Id.lblHorario).Text = TimeSpan.FromHours(Horarios[salas[_viewPager.CurrentItem].Sala_Id][fecha_seleccionada][0]).ToString().Substring(0, 5) + " - " + TimeSpan.FromHours(Horarios[salas[_viewPager.CurrentItem].Sala_Id][fecha_seleccionada][0] + .5).ToString().Substring(0, 5);
                FindViewById<Button>(Resource.Id.btnContinuar).Click += delegate
                {
                    StartActivity(new Intent(this, typeof(TabSalasJuntasHistorialActivity)));
                    Finish();
                };
            };
            builder.SetView(customView);
            builder.Create();
            dialog = builder.Show();
            dialog.Window.SetGravity(GravityFlags.Top | GravityFlags.Center);
        }

        void SelecccionarNivel()
        {

        }
    }

    class SalaJuntasAdapter : PagerAdapter
    {
        Context context;
        List<SalaJuntasModel> salaJuntas;
        public SalaJuntasAdapter(Context context, List<SalaJuntasModel> salaJuntas)
        {
            this.context = context;
            this.salaJuntas = salaJuntas;
        }

        public override Java.Lang.Object InstantiateItem(View container, int position)
        {
            LayoutInflater liView = (LayoutInflater)context.GetSystemService(Context.LayoutInflaterService);
            View SucursalView = liView.Inflate(Resource.Layout.SalasJuntasLayout, null, true);
            SucursalView.FindViewById<TextView>(Resource.Id.lblSalaJunta).Text = salaJuntas[position].Sala_Descripcion;
            SucursalView.FindViewById<TextView>(Resource.Id.tvCapacidad).Text = salaJuntas[position].Sala_Capacidad + "-" + (Convert.ToInt32(salaJuntas[position].Sala_Capacidad) + 2).ToString();
            SucursalView.FindViewById<TextView>(Resource.Id.tvNivel).Text = "Nivel " + Convert.ToInt32(salaJuntas[position].Sala_Nivel).ToString("00");
            var viewPager = container.JavaCast<ViewPager>();
            viewPager.AddView(SucursalView);
            return SucursalView;
        }

        public override int Count => salaJuntas.Count;

        public override bool IsViewFromObject(View view, Java.Lang.Object @object) => view == @object;

        public override ICharSequence GetPageTitleFormatted(int position) => new Java.Lang.String(salaJuntas[position].Sala_Descripcion);

        public override void DestroyItem(View container, int position, Java.Lang.Object @object) => container.JavaCast<ViewPager>().RemoveView(@object as View);
    }
}
