using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using WorklabsMx.Helpers;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/app_name")]
    public class MisColaboradoresBajaActivity : Activity
    {
        ScrollView svDirectorio;
        SimpleStorage storage;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Directorio();
        }

        protected override void OnResume()
        {
            base.OnResume();
            Directorio();
        }

        void Directorio(string nombre = "", string apellido = "", string puesto = "", string profesion = "",
                      string habilidades = "", string disponibilidad = "N/A")
        {
            SetContentView(Resource.Layout.ColaboradoresLayout);
            storage = SimpleStorage.EditGroup("Login");
            svDirectorio = FindViewById<ScrollView>(Resource.Id.svDirectorio);
            FillDirectorioColaboradores(storage.Get("Usuario_Id"), nombre, apellido, puesto, profesion, habilidades, disponibilidad);
        }

        void FillDirectorioColaboradores(string miembro_id, string nombre, string apellido, string puesto, string profesion, string habilidades,
                                                        string disponibilidad)
        {
            LinearLayout llDirectorio = new LinearLayout(this)
            {
                LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent),
                Orientation = Orientation.Vertical
            };
            new UsuariosController().GetColaboradoresMiembro(miembro_id, 0, nombre, apellido, puesto, profesion, habilidades, disponibilidad).ForEach((colaborador) =>
            {
                LinearLayout llColaborador = new LinearLayout(this)
                {
                    LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent),
                    Orientation = Orientation.Vertical
                };
                RelativeLayout rlNombre = new RelativeLayout(this)
                {
                    LayoutParameters = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent)
                };
                TextView txtNombre = new TextView(this)
                {
                    Text = colaborador.Usuario_Nombre + " " + colaborador.Usuario_Apellidos,
                    TextSize = 20
                };
                rlNombre.AddView(txtNombre);

                ImageButton btnAlta = new ImageButton(this);
                btnAlta.SetImageResource(Resource.Mipmap.ic_add);
                btnAlta.SetX(Resources.DisplayMetrics.WidthPixels - 120);
                btnAlta.Click += (sender, e) =>
                {
                    new UsuariosController().ChangeColaboradorEstatus(colaborador.Usuario_Id, 1);
                    llDirectorio.RemoveView(llColaborador);
                };
                rlNombre.AddView(btnAlta);
                llColaborador.AddView(rlNombre);
                LinearLayout llEmail = new LinearLayout(this)
                {
                    LayoutParameters = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent)
                };
                TextView txtEmail = new TextView(this)
                {
                    TextSize = 14,
                    Text = colaborador.Usuario_Correo_Electronico
                };
                txtEmail.Click += (sender, e) =>
                {
                    try
                    {
                        Intent email = new Intent(Intent.ActionSend);
                        email.PutExtra(Intent.ExtraEmail,
                                       new string[] { colaborador.Usuario_Correo_Electronico });
                        email.PutExtra(Intent.ExtraSubject, Resources.GetString(Resource.String.AsuntoCorreo));
                        email.SetType("message/rfc822");
                        StartActivity(email);
                    }
                    catch (Exception ex)
                    {
                        SlackLogs.SendMessage(ex.Message);
                    }
                };
                llEmail.AddView(txtEmail);

                llColaborador.AddView(llEmail);

                ScrollView svInfo = new ScrollView(this)
                {
                    LayoutParameters = new FrameLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, 600)
                };
                LinearLayout llInfo = new LinearLayout(this)
                {
                    LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent),
                    Orientation = Orientation.Vertical
                };

                LinearLayout llImg = new LinearLayout(this)
                {
                    Orientation = Orientation.Vertical
                };
                ImageView imgInfo = new ImageView(this);

                llImg.AddView(imgInfo);
                llInfo.AddView(llImg);
                #region Genero
                RelativeLayout rlGenero = new RelativeLayout(this)
                {
                    LayoutParameters = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent)
                };

                ImageView imgGenero = new ImageView(this);
                imgGenero.SetImageResource(Resource.Mipmap.ic_person);
                rlGenero.AddView(imgGenero);
                TextView txtGenero = new TextView(this)
                {
                    Text = Resources.GetString(Resource.String.str_profile_gender)
                };
                txtGenero.SetX(100);
                rlGenero.AddView(txtGenero);
                llInfo.AddView(rlGenero);

                LinearLayout llGenero = new LinearLayout(this)
                {
                    LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent),
                    Orientation = Orientation.Vertical
                };
                TextView txtMiembroGenero = new TextView(this)
                {
                    Text = colaborador.Genero.Genero_Descripcion
                };
                txtMiembroGenero.SetX(50);
                llGenero.AddView(txtMiembroGenero);
                llInfo.AddView(llGenero);
                #endregion
                #region Fecha de Nacimiento
                RelativeLayout rlFechaNacimiento = new RelativeLayout(this)
                {
                    LayoutParameters = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent)
                };

                ImageView imgFechaNacimiento = new ImageView(this);
                imgFechaNacimiento.SetImageResource(Resource.Mipmap.ic_today);
                rlFechaNacimiento.AddView(imgFechaNacimiento);
                TextView txtFechaNacimiento = new TextView(this)
                {
                    Text = Resources.GetString(Resource.String.str_profile_birthdate)
                };
                txtFechaNacimiento.SetX(100);
                rlFechaNacimiento.AddView(txtFechaNacimiento);
                llInfo.AddView(rlFechaNacimiento);

                LinearLayout llFechaNacimiento = new LinearLayout(this)
                {
                    LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent),
                    Orientation = Orientation.Vertical
                };
                TextView txtMiembroFechaNacimiento = new TextView(this)
                {
                    Text = colaborador.Usuario_Fecha_Nacimiento
                };
                txtMiembroFechaNacimiento.SetX(50);
                llFechaNacimiento.AddView(txtMiembroFechaNacimiento);
                llInfo.AddView(llFechaNacimiento);
                #endregion
                #region Profesión
                RelativeLayout rlProfesion = new RelativeLayout(this)
                {
                    LayoutParameters = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent)
                };

                ImageView imgProfesion = new ImageView(this);
                imgProfesion.SetImageResource(Resource.Mipmap.ic_school);
                rlProfesion.AddView(imgProfesion);
                TextView txtProfesion = new TextView(this)
                {
                    Text = Resources.GetString(Resource.String.Profesion)
                };
                txtProfesion.SetX(100);
                rlProfesion.AddView(txtProfesion);
                llInfo.AddView(rlProfesion);

                LinearLayout llProfesion = new LinearLayout(this)
                {
                    LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent),
                    Orientation = Orientation.Vertical
                };
                TextView txtMiembroProfesion = new TextView(this)
                {
                    Text = colaborador.Usuario_Profesion
                };
                txtMiembroProfesion.SetX(50);
                llProfesion.AddView(txtMiembroProfesion);
                llInfo.AddView(llProfesion);
                #endregion
                #region Puesto
                RelativeLayout rlPuesto = new RelativeLayout(this)
                {
                    LayoutParameters = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent)
                };

                ImageView imgPuesto = new ImageView(this);
                imgPuesto.SetImageResource(Resource.Mipmap.ic_work);
                rlPuesto.AddView(imgPuesto);
                TextView txtPuesto = new TextView(this)
                {
                    Text = Resources.GetString(Resource.String.Puesto)
                };
                txtPuesto.SetX(100);
                rlPuesto.AddView(txtPuesto);
                llInfo.AddView(rlPuesto);

                LinearLayout llPuesto = new LinearLayout(this)
                {
                    LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent),
                    Orientation = Orientation.Vertical
                };
                TextView txtMiembroPuesto = new TextView(this)
                {
                    Text = colaborador.Usuario_Puesto
                };
                txtMiembroPuesto.SetX(50);
                llPuesto.AddView(txtMiembroPuesto);
                llInfo.AddView(llPuesto);
                #endregion
                #region Habilidades
                RelativeLayout rlHabilidades = new RelativeLayout(this)
                {
                    LayoutParameters = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent)
                };

                ImageView imgHabilidades = new ImageView(this);
                imgHabilidades.SetImageResource(Resource.Mipmap.ic_create);
                rlHabilidades.AddView(imgHabilidades);
                TextView txtHabilidades = new TextView(this)
                {
                    Text = Resources.GetString(Resource.String.str_profile_hability)
                };
                txtHabilidades.SetX(100);
                rlHabilidades.AddView(txtHabilidades);
                llInfo.AddView(rlHabilidades);

                LinearLayout llHabilidades = new LinearLayout(this)
                {
                    LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent),
                    Orientation = Orientation.Vertical
                };
                TextView txtMiembroHabilidades = new TextView(this)
                {
                    //Text = colaborador.Usuario_Habilidades
                };
                txtMiembroHabilidades.SetX(50);
                llHabilidades.AddView(txtMiembroHabilidades);
                llInfo.AddView(llHabilidades);
                #endregion
                #region Empresa
                RelativeLayout rlEmpresa = new RelativeLayout(this)
                {
                    LayoutParameters = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent)
                };

                ImageView imgEmpresa = new ImageView(this);
                imgEmpresa.SetImageResource(Resource.Mipmap.ic_domain);
                rlEmpresa.AddView(imgEmpresa);
                TextView txtEmpresa = new TextView(this)
                {
                    Text = Resources.GetString(Resource.String.str_profile_my_company)
                };
                txtEmpresa.SetX(100);
                rlEmpresa.AddView(txtEmpresa);
                llInfo.AddView(rlEmpresa);
                #endregion
                #region Telefono
                RelativeLayout rlTelefono = new RelativeLayout(this)
                {
                    LayoutParameters = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent)
                };

                ImageView imgTelefono = new ImageView(this);
                imgTelefono.SetImageResource(Resource.Mipmap.ic_call);
                rlTelefono.AddView(imgTelefono);
                TextView txtTelefono = new TextView(this)
                {
                    Text = Resources.GetString(Resource.String.Telefono)
                };
                txtTelefono.SetX(100);
                rlTelefono.AddView(txtTelefono);
                llInfo.AddView(rlTelefono);

                LinearLayout llTelefono = new LinearLayout(this)
                {
                    LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent),
                    Orientation = Orientation.Vertical
                };
                TextView txtMiembroTelefono = new TextView(this)
                {
                    Text = colaborador.Usuario_Telefono
                };
                txtMiembroTelefono.SetX(50);
                llTelefono.AddView(txtMiembroTelefono);
                llInfo.AddView(llTelefono);
                #endregion

                #region Celular
                RelativeLayout rlCelular = new RelativeLayout(this)
                {
                    LayoutParameters = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent)
                };

                ImageView imgCelular = new ImageView(this);
                imgCelular.SetImageResource(Resource.Mipmap.ic_cellphone);
                rlCelular.AddView(imgCelular);
                TextView txtCelular = new TextView(this)
                {
                    Text = Resources.GetString(Resource.String.Celular)
                };
                txtCelular.SetX(100);
                rlCelular.AddView(txtCelular);
                llInfo.AddView(rlCelular);

                LinearLayout llCelular = new LinearLayout(this)
                {
                    LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent),
                    Orientation = Orientation.Vertical
                };
                TextView txtMiembroCelular = new TextView(this)
                {
                    Text = colaborador.Usuario_Celular
                };
                txtMiembroCelular.SetX(50);
                llCelular.AddView(txtMiembroCelular);
                llInfo.AddView(llCelular);
                #endregion

                svInfo.AddView(llInfo);
                llColaborador.AddView(svInfo);
                llDirectorio.AddView(llColaborador);
            });
            svDirectorio.AddView(llDirectorio);
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.search_menu, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {

            switch (item.ItemId)
            {
                case Resource.Id.menu_search:
                    SearchView();
                    break;
                default:
                    StartActivity(new Intent(this, typeof(MainActivity)));
                    Finish();
                    break;
            }
            return base.OnOptionsItemSelected(item);
        }

        void SearchView()
        {
            SetContentView(Resource.Layout.SearchUserLayout);
            FindViewById<ImageButton>(Resource.Id.btnClear).Click += (sender, e) =>
            {
                Directorio();
            };

            FindViewById<Button>(Resource.Id.btnBuscar).Click += (sender, e) =>
            {
                Directorio(FindViewById<TextView>(Resource.Id.txtNombre).Text, FindViewById<TextView>(Resource.Id.txtApellidos).Text,
                           FindViewById<TextView>(Resource.Id.txtPuesto).Text, FindViewById<TextView>(Resource.Id.txtProfesion).Text,
                           FindViewById<TextView>(Resource.Id.txtHabilidades).Text, FindViewById<CheckBox>(Resource.Id.cbDisponibilidad).Checked ? "Disponible" : "No Disponible");
            };
            FindViewById<LinearLayout>(Resource.Id.llLblPais).Visibility = ViewStates.Gone;
            FindViewById<LinearLayout>(Resource.Id.llLblEstado).Visibility = ViewStates.Gone;
            FindViewById<LinearLayout>(Resource.Id.llLblMunicipio).Visibility = ViewStates.Gone;
            FindViewById<LinearLayout>(Resource.Id.llPais).Visibility = ViewStates.Gone;
            FindViewById<LinearLayout>(Resource.Id.llEstado).Visibility = ViewStates.Gone;
            FindViewById<LinearLayout>(Resource.Id.llMunicipio).Visibility = ViewStates.Gone;


            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.DirectorioUsuario);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            //ActionBar.SetHomeAsUpIndicator(Resource.Mipmap.ic_menu);
        }
    }
}
