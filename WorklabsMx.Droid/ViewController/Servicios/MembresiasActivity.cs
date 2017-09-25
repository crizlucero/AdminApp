using System;
using System.Collections.Generic;
using System.Linq;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using WorklabsMx.Helpers;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    [Activity(Label = "MembresiasActivity")]
    public class MembresiasActivity : Activity
    {
        bool CanPay;
        SimpleStorage Storage;
        Dictionary<string, CarritoModel> Carrito, Membresias;
        ArrayAdapter adapter;
        TableRow.LayoutParams param;
        public MembresiasActivity()
        {
            Storage = SimpleStorage.EditGroup("Login");
            Membresias = new Dictionary<string, CarritoModel>();
            Carrito = new CarritoController().GetCarrito(Storage.Get("Usuario_Id"), TiposServicios.Membresia);
            CanPay = false;
            param = new TableRow.LayoutParams
            {
                Column = 1,
                Span = 3
            };
        }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.MembresiasLayout);

            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.Membresias);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            ActionBar.SetHomeAsUpIndicator(Resource.Mipmap.ic_menu);

            adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleDropDownItem1Line, new SucursalController().GetSucursalNombres().ToArray());
            FillData();
        }

        void FillData()
        {
            TableLayout tlMembresias = FindViewById<TableLayout>(Resource.Id.tlMembresias);
            foreach (MembresiaModel membresia in new PickerItemsController().GetMembresias())
            {
                double subtotal = membresia.Membresia_Precio_Base;
                int mesMembresia = 1;
                TextView lblProporcional = new TextView(this), lblTotal = new TextView(this);
                EditText dpFechaInicio = new EditText(this)
                {
                    InputType = Android.Text.InputTypes.DatetimeVariationDate
                }, txtMesesMembresias = new EditText(this)
                {
                    TextSize = 14,
                    InputType = Android.Text.InputTypes.NumberFlagSigned
                };

                Membresias.Add(membresia.Membresia_Id, new CarritoModel { Membresia_Cantidad = 0, Sucursal_Id = 0 });
                if (Carrito.ContainsKey(membresia.Membresia_Id))
                {
                    Membresias[membresia.Membresia_Id].Membresia_Cantidad = (int)Carrito[membresia.Membresia_Id].Membresia_Cantidad;
                    Membresias[membresia.Membresia_Id].Sucursal_Id = Carrito[membresia.Membresia_Id].Sucursal_Id;
                    Membresias[membresia.Membresia_Id].Membresia_Fecha_Inicio = Carrito[membresia.Membresia_Id].Membresia_Fecha_Inicio;
                    CanPay = true;
                }

                TableRow trMembresia = new TableRow(this);
                View line = new View(this);
                line.SetBackgroundColor(Android.Graphics.Color.Cyan);
                line.LayoutParameters = new TableRow.LayoutParams(ViewGroup.LayoutParams.MatchParent, 5);

                trMembresia.AddView(line);
                tlMembresias.AddView(trMembresia);

                trMembresia = new TableRow(this);
                TextView lblNombre = new TextView(this)
                {
                    Text = membresia.Membresia_Descripcion,
                    TextSize = 14
                };
                lblNombre.SetMaxWidth(Resources.DisplayMetrics.WidthPixels * 2 / 3);
                trMembresia.AddView(lblNombre, 0);

                EditText txtCantidadMembresias = new EditText(this)
                {
                    Text = Carrito.ContainsKey(membresia.Membresia_Id) ? Carrito[membresia.Membresia_Id].Membresia_Cantidad.ToString() : "0",
                    TextSize = 14,
                    InputType = Android.Text.InputTypes.NumberFlagSigned
                };
                txtCantidadMembresias.SetMaxWidth(70);
                txtCantidadMembresias.SetFadingEdgeLength(2);
                txtCantidadMembresias.TextChanged += (sender, e) =>
                {
                    if (!string.IsNullOrEmpty(txtCantidadMembresias.Text))
                    {
                        Membresias[membresia.Membresia_Id].Membresia_Cantidad = Convert.ToInt32(txtCantidadMembresias.Text);
                        subtotal = (membresia.Membresia_Precio_Base / DateHelper.GetMonthsDays(DateTime.Parse(dpFechaInicio.Text)) *
                            (DateHelper.GetMonthsDays(DateTime.Parse(dpFechaInicio.Text)) - (DateTime.Parse(dpFechaInicio.Text)).Day + 1));
                        lblProporcional.Text = subtotal.ToString("C");
                        lblTotal.Text = (((membresia.Membresia_Precio_Base * ((Convert.ToDouble(txtMesesMembresias.Text) - 1)) + subtotal + membresia.Inscripcion_Precio_Base)
                                          * Convert.ToDouble(txtCantidadMembresias.Text))).ToString("C");
                    }
                    //else
                    //    Toast.MakeText(this, Resource.String.NumeroInferior, ToastLength.Short).Show();
                };

                trMembresia.AddView(txtCantidadMembresias, 1);

                ImageButton btnPlus = new ImageButton(this);
                btnPlus.SetImageResource(Resource.Mipmap.ic_add);
                btnPlus.Click += (sender, e) =>
                {
                    ++Membresias[membresia.Membresia_Id].Membresia_Cantidad;

                    txtCantidadMembresias.Text = Membresias[membresia.Membresia_Id].Membresia_Cantidad.ToString();
                    subtotal = (membresia.Membresia_Precio_Base / DateHelper.GetMonthsDays(DateTime.Parse(dpFechaInicio.Text)) *
                            (DateHelper.GetMonthsDays(DateTime.Parse(dpFechaInicio.Text)) - (DateTime.Parse(dpFechaInicio.Text)).Day + 1));
                    lblProporcional.Text = subtotal.ToString("C");
                    lblTotal.Text = (((membresia.Membresia_Precio_Base * ((Convert.ToDouble(txtMesesMembresias.Text) - 1)) + subtotal + membresia.Inscripcion_Precio_Base)
                                          * Convert.ToDouble(txtCantidadMembresias.Text))).ToString("C");
                };

                trMembresia.AddView(btnPlus, 2);

                ImageButton btnLess = new ImageButton(this);
                btnLess.SetImageResource(Resource.Mipmap.ic_remove);
                btnLess.Click += (sender, e) =>
                {
                    if (Membresias[membresia.Membresia_Id].Membresia_Cantidad > 0)
                    {
                        --Membresias[membresia.Membresia_Id].Membresia_Cantidad;
                        txtCantidadMembresias.Text = Membresias[membresia.Membresia_Id].Membresia_Cantidad.ToString();
                        subtotal = (membresia.Membresia_Precio_Base / DateHelper.GetMonthsDays(DateTime.Parse(dpFechaInicio.Text)) *
                            (DateHelper.GetMonthsDays(DateTime.Parse(dpFechaInicio.Text)) - (DateTime.Parse(dpFechaInicio.Text)).Day + 1));
                        lblProporcional.Text = subtotal.ToString("C");
                        lblTotal.Text = (((membresia.Membresia_Precio_Base * ((Convert.ToDouble(txtMesesMembresias.Text) - 1)) + subtotal + membresia.Inscripcion_Precio_Base)
                                          * Convert.ToDouble(txtCantidadMembresias.Text))).ToString("C");
                    }
                    else
                        Toast.MakeText(this, Resource.String.NumeroInferior, ToastLength.Short).Show();
                };

                trMembresia.AddView(btnLess, 3);

                tlMembresias.AddView(trMembresia);
                trMembresia = new TableRow(this);
                trMembresia.AddView(new TextView(this) { Text = "Tarifa Mensual" });

                trMembresia.AddView(new TextView(this) { Text = membresia.Membresia_Precio_Base.ToString("C") }, param);

                tlMembresias.AddView(trMembresia);
                trMembresia = new TableRow(this);
                trMembresia.AddView(new TextView(this) { Text = "Tarifa Inscripción" });

                trMembresia.AddView(new TextView(this) { Text = membresia.Inscripcion_Precio_Base.ToString("C") }, param);

                tlMembresias.AddView(trMembresia);

                trMembresia = new TableRow(this);
                Spinner spSucursales = new Spinner(this);
                spSucursales.Adapter = adapter;
                trMembresia.AddView(spSucursales);
                tlMembresias.AddView(trMembresia);

                trMembresia = new TableRow(this);
                trMembresia.AddView(new TextView(this) { Text = "Fecha de Inicio" });
                dpFechaInicio.Text = !string.IsNullOrEmpty(membresia.Membresia_Fecha_Inicio) ? membresia.Membresia_Fecha_Inicio : DateTime.Now.ToString("dd/MM/yyyy");
                dpFechaInicio.TextChanged += (sender, e) =>
                {
                    if (DateTime.TryParse(dpFechaInicio.Text, out DateTime fecha))
                    {
                        if (fecha >= DateTime.Now)
                        {
                            mesMembresia = Convert.ToInt32(txtMesesMembresias.Text);
                            subtotal = (membresia.Membresia_Precio_Base / DateHelper.GetMonthsDays(DateTime.Parse(dpFechaInicio.Text)) *
                                    (DateHelper.GetMonthsDays(DateTime.Parse(dpFechaInicio.Text)) - (DateTime.Parse(dpFechaInicio.Text)).Day + 1));
                            lblProporcional.Text = subtotal.ToString("C");
                            lblTotal.Text = (((membresia.Membresia_Precio_Base * ((Convert.ToDouble(txtMesesMembresias.Text) - 1)) + subtotal + membresia.Inscripcion_Precio_Base)
                                          * Convert.ToDouble(txtCantidadMembresias.Text))).ToString("C");
                        }
                    }
                };
                trMembresia.AddView(dpFechaInicio, param);

                tlMembresias.AddView(trMembresia);

                trMembresia = new TableRow(this);
                trMembresia.AddView(new TextView(this) { Text = "Cantidad de meses" }, 0);

                txtMesesMembresias.Text = "1";
                txtMesesMembresias.SetMaxWidth(70);
                txtMesesMembresias.SetFadingEdgeLength(2);
                txtMesesMembresias.TextChanged += (sender, e) =>
                {
                    if (!string.IsNullOrEmpty(txtMesesMembresias.Text))
                        if (mesMembresia > 1)
                        {
                            mesMembresia = Convert.ToInt32(txtMesesMembresias.Text);
                            subtotal = (membresia.Membresia_Precio_Base / DateHelper.GetMonthsDays(DateTime.Parse(dpFechaInicio.Text)) *
                                    (DateHelper.GetMonthsDays(DateTime.Parse(dpFechaInicio.Text)) - (DateTime.Parse(dpFechaInicio.Text)).Day + 1));
                            lblProporcional.Text = subtotal.ToString("C");
                            lblTotal.Text = (((membresia.Membresia_Precio_Base * ((Convert.ToDouble(txtMesesMembresias.Text) - 1)) + subtotal + membresia.Inscripcion_Precio_Base)
                                          * Convert.ToDouble(txtCantidadMembresias.Text))).ToString("C");
                        }
                        else
                            Toast.MakeText(this, Resource.String.NumeroInferior, ToastLength.Short).Show();
                };

                trMembresia.AddView(txtMesesMembresias, 1);

                ImageButton btnMesesPlus = new ImageButton(this);
                btnMesesPlus.SetImageResource(Resource.Mipmap.ic_add);
                btnMesesPlus.Click += (sender, e) =>
                {
                    ++mesMembresia;
                    txtMesesMembresias.Text = mesMembresia.ToString();
                    subtotal = (membresia.Membresia_Precio_Base / DateHelper.GetMonthsDays(DateTime.Parse(dpFechaInicio.Text)) *
                            (DateHelper.GetMonthsDays(DateTime.Parse(dpFechaInicio.Text)) - (DateTime.Parse(dpFechaInicio.Text)).Day + 1));
                    lblProporcional.Text = subtotal.ToString("C");
                    lblTotal.Text = (((membresia.Membresia_Precio_Base * ((Convert.ToDouble(txtMesesMembresias.Text) - 1)) + subtotal + membresia.Inscripcion_Precio_Base)
                                          * Convert.ToDouble(txtCantidadMembresias.Text))).ToString("C");
                };

                trMembresia.AddView(btnMesesPlus, 2);

                ImageButton btnMesesLess = new ImageButton(this);
                btnMesesLess.SetImageResource(Resource.Mipmap.ic_remove);
                btnMesesLess.Click += (sender, e) =>
                {
                    if (mesMembresia > 1)
                    {
                        --mesMembresia;
                        txtMesesMembresias.Text = mesMembresia.ToString();
                        subtotal = (membresia.Membresia_Precio_Base / DateHelper.GetMonthsDays(DateTime.Parse(dpFechaInicio.Text)) *
                                    (DateHelper.GetMonthsDays(DateTime.Parse(dpFechaInicio.Text)) - (DateTime.Parse(dpFechaInicio.Text)).Day + 1));
                        lblProporcional.Text = subtotal.ToString("C");
                        lblTotal.Text = (((membresia.Membresia_Precio_Base * ((Convert.ToDouble(txtMesesMembresias.Text) - 1)) + subtotal + membresia.Inscripcion_Precio_Base)
                                          * Convert.ToDouble(txtCantidadMembresias.Text))).ToString("C");
                    }
                    else
                        Toast.MakeText(this, Resource.String.NumeroInferior, ToastLength.Short).Show();
                };

                trMembresia.AddView(btnMesesLess, 3);

                tlMembresias.AddView(trMembresia);

                trMembresia = new TableRow(this);
                trMembresia.AddView(new TextView(this) { Text = "Proporcional al mes" });
                subtotal = (membresia.Membresia_Precio_Base / DateHelper.GetMonthsDays(DateTime.Parse(dpFechaInicio.Text)) *
                            (DateHelper.GetMonthsDays(DateTime.Parse(dpFechaInicio.Text)) - (DateTime.Parse(dpFechaInicio.Text)).Day + 1));
                lblProporcional.Text = Carrito.ContainsKey(membresia.Membresia_Id) ? subtotal.ToString("C") : 0.ToString("C");
                trMembresia.AddView(lblProporcional, param);

                tlMembresias.AddView(trMembresia);

                trMembresia = new TableRow(this);
                trMembresia.AddView(new TextView(this) { Text = "Total" });

                lblTotal.Text = Carrito.ContainsKey(membresia.Membresia_Id) ?
                    (((membresia.Membresia_Precio_Base * ((Convert.ToDouble(txtMesesMembresias.Text) - 1)) + subtotal + membresia.Inscripcion_Precio_Base)
                      * Convert.ToDouble(txtCantidadMembresias.Text))).ToString("C") : 0.ToString("C");
                trMembresia.AddView(lblTotal, param);

                tlMembresias.AddView(trMembresia);
            }
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.shopping_menu, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.menu_cart:
                    if (CanPay)
                    {
                        Intent intent = new Intent(this, typeof(ShoppingCartActivity));
                        intent.PutExtra("Datos", "{" + string.Join(",", Membresias.Select(d => string.Format("\"{0}\": {1}", d.Key, string.Join(",", d.Value)))) + "}");
                        intent.PutExtra("Tipo", false);
                        StartActivity(intent);
                    }
                    Toast.MakeText(this, Resource.String.NoSeleccionMembresia, ToastLength.Short);
                    break;
                default:
                    base.OnBackPressed();
                    break;
            }
            return base.OnOptionsItemSelected(item);
        }
    }
}