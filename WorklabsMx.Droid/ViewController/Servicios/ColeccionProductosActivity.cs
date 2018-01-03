using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.View;
using Android.Views;
using Android.Views.InputMethods;
using Android.Widget;
using Java.Lang;
using Newtonsoft.Json;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using WorklabsMx.Helpers;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/app_name")]
    public class ColeccionProductosActivity : Activity
    {
        Dictionary<string, CarritoModel> Productos, Membresias;

        ViewPager _viewPager;
        public ColeccionProductosActivity()
        {
            Productos = new Dictionary<string, CarritoModel>();
            Membresias = new Dictionary<string, CarritoModel>();
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.CarritoComprasLayout);

            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.Productos);
            ActionBar.SetDisplayHomeAsUpEnabled(true);

            _viewPager = FindViewById<ViewPager>(Resource.Id.vpSucursal);
            _viewPager.Adapter = new ComprasAdapter(this, new List<string> { "Productos", "Membresias" }, ref Productos, ref Membresias);

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
                    if (Productos.Count != 0 || Membresias.Count != 0)
                    {
                        Intent intent = new Intent(this, typeof(ShoppingCartActivity));
                        intent.PutExtra("Productos", JsonConvert.SerializeObject(Productos));
                        intent.PutExtra("Membresias", JsonConvert.SerializeObject(Membresias));
                        StartActivity(intent);
                    }
                    else
                        Toast.MakeText(this, "Debe seleccionar algún producto o membresía", ToastLength.Short).Show();
                    break;
                default:
                    StartActivity(new Intent(this, typeof(MainActivity)));
                    Finish();
                    break;
            }
            return base.OnOptionsItemSelected(item);
        }


    }

    class ComprasAdapter : PagerAdapter
    {
        Context context;
        List<string> compras;
        View TiposComprasView;
        public Dictionary<string, CarritoModel> Productos, Membresias;
        SimpleStorage Storage;
        TableRow.LayoutParams param;
        ArrayAdapter adapter;
        AlertDialog dialog;
        public ComprasAdapter(Context context, List<string> compras, ref Dictionary<string, CarritoModel> Productos, ref Dictionary<string, CarritoModel> Membresias)
        {
            this.context = context;
            this.compras = compras;
            this.Productos = Productos;
            this.Membresias = Membresias;
            adapter = new ArrayAdapter(context, Android.Resource.Layout.SimpleDropDownItem1Line, new SucursalController().GetSucursalNombres().ToArray());
            param = new TableRow.LayoutParams
            {
                Column = 1,
                Span = 3
            };
        }

        public override Java.Lang.Object InstantiateItem(View container, int position)
        {
            LayoutInflater liView = (LayoutInflater)context.GetSystemService(Context.LayoutInflaterService);
            switch (compras[position])
            {
                case "Productos":
                    TiposComprasView = liView.Inflate(Resource.Layout.ProductosLayout, null, true);
                    FillDataProductos(); break;
                default:
                    TiposComprasView = liView.Inflate(Resource.Layout.MembresiasLayout, null, true);
                    FillDataMembresias(); break;
            }
            var viewPager = container.JavaCast<ViewPager>();
            viewPager.AddView(TiposComprasView);
            return TiposComprasView;
        }

        public override int Count => compras.Count;

        public override bool IsViewFromObject(View view, Java.Lang.Object @object) => view == @object;

        public override ICharSequence GetPageTitleFormatted(int position) => new Java.Lang.String(compras[position]);

        public override void DestroyItem(View container, int position, Java.Lang.Object @object) => container.JavaCast<ViewPager>().RemoveView(@object as View);

        void FillDataMembresias()
        {
            TableLayout tlMembresias = TiposComprasView.FindViewById<TableLayout>(Resource.Id.tlMembresias);
            new PickerItemsController().GetMembresias().ForEach(membresia =>
            {
                LayoutInflater liView = (LayoutInflater)context.GetSystemService(Context.LayoutInflaterService); ;

                View CarritoView = liView.Inflate(Resource.Layout.CarritoMembresiaLayout, null, true);

                CarritoView.FindViewById<TextView>(Resource.Id.lblProducto).Text = membresia.Membresia_Descripcion;
                TextView lblProporcional = CarritoView.FindViewById<TextView>(Resource.Id.txtProporcional),
                lblTotal = CarritoView.FindViewById<TextView>(Resource.Id.lblTotal);
                EditText txtMesesMembresias = CarritoView.FindViewById<EditText>(Resource.Id.txtCantidadMeses),
                dtFechaInicio = CarritoView.FindViewById<EditText>(Resource.Id.txtFechaInicio);
                if (!Membresias.ContainsKey(membresia.Membresia_Id))
                    Membresias.Add(membresia.Membresia_Id, new CarritoModel
                    {
                        Membresia_Cantidad = 0,
                        Sucursal_Id = 0,
                        Meses_Adelantados = 1,
                        Membresia_Fecha_Inicio = DateTime.Now.ToString("d"),
                        Lista_Precio_Id = membresia.Lista_Precio_Id,
                        Moneda_Id = membresia.Moneda_Id,
                        Impuesto_Id = membresia.Impuesto_Id
                    });

                double subtotal = membresia.Membresia_Precio_Base_Neto;
                int mesMembresia = 1;

                EditText txtCantidadMembresias = CarritoView.FindViewById<EditText>(Resource.Id.txtCantidad);
                txtCantidadMembresias.Text = Membresias[membresia.Membresia_Id].Membresia_Cantidad.ToString();
                txtCantidadMembresias.TextChanged += (sender, e) =>
                {
                    if (!string.IsNullOrEmpty(txtCantidadMembresias.Text))
                    {
                        Membresias[membresia.Membresia_Id].Membresia_Cantidad = Convert.ToInt32(txtCantidadMembresias.Text);
                        subtotal = (membresia.Membresia_Precio_Base_Neto / DateHelper.GetMonthsDays(DateTime.Parse(dtFechaInicio.Text)) *
                                    (DateHelper.GetMonthsDays(DateTime.Parse(dtFechaInicio.Text)) - DateTime.Parse(dtFechaInicio.Text).Day + 1));
                        lblProporcional.Text = subtotal.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
                        lblTotal.Text = (((membresia.Membresia_Precio_Base_Neto * ((Convert.ToDouble(txtMesesMembresias.Text) - 1)) + subtotal + membresia.Inscripcion_Precio_Base_Neto)
                                          * Convert.ToDouble(txtCantidadMembresias.Text))).ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
                    }
                    //else
                    //    Toast.MakeText(this, Resource.String.NumeroInferior, ToastLength.Short).Show();
                };

                ImageButton btnPlus = CarritoView.FindViewById<ImageButton>(Resource.Id.btnAddCantidad);
                btnPlus.Click += (sender, e) =>
                {
                    ++Membresias[membresia.Membresia_Id].Membresia_Cantidad;

                    txtCantidadMembresias.Text = Membresias[membresia.Membresia_Id].Membresia_Cantidad.ToString();
                    subtotal = (membresia.Membresia_Precio_Base_Neto / DateHelper.GetMonthsDays(DateTime.Parse(dtFechaInicio.Text)) *
                                (DateHelper.GetMonthsDays(DateTime.Parse(dtFechaInicio.Text)) - DateTime.Parse(dtFechaInicio.Text).Day + 1));
                    lblProporcional.Text = subtotal.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
                    lblTotal.Text = (((membresia.Membresia_Precio_Base_Neto * ((Convert.ToDouble(txtMesesMembresias.Text) - 1)) + subtotal + membresia.Inscripcion_Precio_Base_Neto)
                                      * Convert.ToDouble(txtCantidadMembresias.Text))).ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
                };

                ImageButton btnLess = CarritoView.FindViewById<ImageButton>(Resource.Id.btnRemoveCantidad);
                btnLess.Click += (sender, e) =>
                {
                    if (Membresias[membresia.Membresia_Id].Membresia_Cantidad > 0)
                    {
                        --Membresias[membresia.Membresia_Id].Membresia_Cantidad;
                        txtCantidadMembresias.Text = Membresias[membresia.Membresia_Id].Membresia_Cantidad.ToString();
                        subtotal = (membresia.Membresia_Precio_Base_Neto / DateHelper.GetMonthsDays(DateTime.Parse(dtFechaInicio.Text)) *
                                    (DateHelper.GetMonthsDays(DateTime.Parse(dtFechaInicio.Text)) - DateTime.Parse(dtFechaInicio.Text).Day + 1));
                        lblProporcional.Text = subtotal.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
                        lblTotal.Text = (((membresia.Membresia_Precio_Base_Neto * ((Convert.ToDouble(txtMesesMembresias.Text) - 1)) + subtotal + membresia.Inscripcion_Precio_Base_Neto)
                                          * Convert.ToDouble(txtCantidadMembresias.Text))).ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
                    }
                    else
                        Toast.MakeText(context, Resource.String.NumeroInferior, ToastLength.Short).Show();
                };

                CarritoView.FindViewById<TextView>(Resource.Id.lblTarifaMensual).Text = membresia.Membresia_Precio_Base_Neto.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
                CarritoView.FindViewById<TextView>(Resource.Id.lblTarifaInscripcion).Text = membresia.Inscripcion_Precio_Base_Neto.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
                Spinner spSucursales = CarritoView.FindViewById<Spinner>(Resource.Id.spSucursal);
                spSucursales.Adapter = adapter;

                dtFechaInicio.Text = DateTime.Now.ToString("d");
                dtFechaInicio.Touch += (sender, e) =>
                {
                    if (dialog == null || !dialog.IsShowing)
                    {
                        InputMethodManager mgr = (InputMethodManager)context.GetSystemService(Context.InputMethodService);
                        mgr.HideSoftInputFromWindow(dtFechaInicio.WindowToken, HideSoftInputFlags.None);
                        ShowCalendarView((EditText)sender);
                    }
                };

                dtFechaInicio.TextChanged += delegate
                {
                    if (DateTime.TryParse(dtFechaInicio.Text, out DateTime fecha))
                    {
                        if (fecha >= DateTime.Now)
                        {
                            mesMembresia = Convert.ToInt32(txtMesesMembresias.Text);
                            subtotal = (membresia.Membresia_Precio_Base_Neto / DateHelper.GetMonthsDays(DateTime.Parse(dtFechaInicio.Text)) *
                                    (DateHelper.GetMonthsDays(DateTime.Parse(dtFechaInicio.Text)) - DateTime.Parse(dtFechaInicio.Text).Day + 1));
                            lblProporcional.Text = subtotal.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
                            lblTotal.Text = (((membresia.Membresia_Precio_Base_Neto * ((Convert.ToDouble(txtMesesMembresias.Text) - 1)) + subtotal)
                                              * Convert.ToDouble(txtCantidadMembresias.Text))).ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
                        }
                    }
                };

                txtMesesMembresias.Text = "1";
                txtMesesMembresias.SetMaxWidth(70);
                txtMesesMembresias.SetFadingEdgeLength(2);
                txtMesesMembresias.TextChanged += (sender, e) =>
                {
                    if (!string.IsNullOrEmpty(txtMesesMembresias.Text))
                        if (mesMembresia > 1)
                        {
                            mesMembresia = Convert.ToInt32(txtMesesMembresias.Text);
                            Membresias[membresia.Membresia_Id].Meses_Adelantados = mesMembresia;
                            subtotal = (membresia.Membresia_Precio_Base_Neto / DateHelper.GetMonthsDays(DateTime.Parse(dtFechaInicio.Text)) *
                                        (DateHelper.GetMonthsDays(DateTime.Parse(dtFechaInicio.Text)) - DateTime.Parse(dtFechaInicio.Text).Day + 1));
                            lblProporcional.Text = subtotal.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
                            lblTotal.Text = (((membresia.Membresia_Precio_Base_Neto * ((Convert.ToDouble(txtMesesMembresias.Text) - 1)) + subtotal + membresia.Inscripcion_Precio_Base_Neto)
                                              * Convert.ToDouble(txtCantidadMembresias.Text))).ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
                        }
                        else
                            Toast.MakeText(context, Resource.String.NumeroInferior, ToastLength.Short).Show();
                };

                ImageButton btnMesesPlus = CarritoView.FindViewById<ImageButton>(Resource.Id.btnAddMeses);
                btnMesesPlus.SetImageResource(Resource.Mipmap.ic_add);
                btnMesesPlus.Click += (sender, e) =>
                {

                    ++mesMembresia;
                    ++Membresias[membresia.Membresia_Id].Meses_Adelantados;
                    txtMesesMembresias.Text = mesMembresia.ToString();
                    subtotal = (membresia.Membresia_Precio_Base_Neto / DateHelper.GetMonthsDays(DateTime.Parse(dtFechaInicio.Text)) *
                                (DateHelper.GetMonthsDays(DateTime.Parse(dtFechaInicio.Text)) - DateTime.Parse(dtFechaInicio.Text).Day + 1));
                    lblProporcional.Text = subtotal.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
                    lblTotal.Text = (((membresia.Membresia_Precio_Base_Neto * ((Convert.ToDouble(txtMesesMembresias.Text) - 1)) + subtotal + membresia.Inscripcion_Precio_Base_Neto)
                                      * Convert.ToDouble(txtCantidadMembresias.Text))).ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
                };

                ImageButton btnMesesLess = CarritoView.FindViewById<ImageButton>(Resource.Id.btnRemoveMeses);
                btnMesesLess.SetImageResource(Resource.Mipmap.ic_remove);
                btnMesesLess.Click += (sender, e) =>
                {
                    if (mesMembresia > 1)
                    {
                        --mesMembresia;
                        --Membresias[membresia.Membresia_Id].Meses_Adelantados;
                        txtMesesMembresias.Text = mesMembresia.ToString();
                        subtotal = (membresia.Membresia_Precio_Base_Neto / DateHelper.GetMonthsDays(DateTime.Parse(dtFechaInicio.Text)) *
                                    (DateHelper.GetMonthsDays(DateTime.Parse(dtFechaInicio.Text)) - DateTime.Parse(dtFechaInicio.Text).Day + 1));
                        lblProporcional.Text = subtotal.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
                        lblTotal.Text = (((membresia.Membresia_Precio_Base_Neto * ((Convert.ToDouble(txtMesesMembresias.Text) - 1)) + subtotal + membresia.Inscripcion_Precio_Base_Neto)
                                          * Convert.ToDouble(txtCantidadMembresias.Text))).ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
                    }
                    else
                        Toast.MakeText(context, Resource.String.NumeroInferior, ToastLength.Short).Show();
                };
                subtotal = (membresia.Membresia_Precio_Base_Neto / DateHelper.GetMonthsDays(DateTime.Parse(dtFechaInicio.Text)) *
                            (DateHelper.GetMonthsDays(DateTime.Parse(dtFechaInicio.Text)) - DateTime.Parse(dtFechaInicio.Text).Day + 1));
                lblProporcional.Text = 0.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));

                lblTotal.Text = 0.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
                TableRow row = new TableRow(context);

                row.AddView(CarritoView);
                tlMembresias.AddView(row);
            });
        }

        void FillDataProductos()
        {
            TableLayout tlProductos = TiposComprasView.FindViewById<TableLayout>(Resource.Id.tlProductos);
            new PickerItemsController().GetProductos().ForEach((producto) =>
            {
                LayoutInflater liView = (LayoutInflater)context.GetSystemService(Context.LayoutInflaterService);

                View CarritoView;
                if (producto.Producto_Disponibilidad.Contains("RECURRENTE"))
                    CarritoView = liView.Inflate(Resource.Layout.CarritoRecurrenteLayout, null, true);
                else
                    CarritoView = liView.Inflate(Resource.Layout.CarritoUnicoLayout, null, true);

                CarritoView.FindViewById<TextView>(Resource.Id.lblProducto).Text = producto.Producto_Descripcion;
                TextView lblProporcional = CarritoView.FindViewById<TextView>(Resource.Id.txtProporcional),
                lblTotal = CarritoView.FindViewById<TextView>(Resource.Id.lblTotal);
                EditText txtMesesProductos = CarritoView.FindViewById<EditText>(Resource.Id.txtCantidadMeses),
                    dtFechaInicio = CarritoView.FindViewById<EditText>(Resource.Id.txtFechaInicio);
                double subtotal = producto.Producto_Precio_Base_Neto;
                int mesProducto = 1;
                if (!Productos.ContainsKey(producto.Producto_Id))
                    Productos.Add(producto.Producto_Id, new CarritoModel
                    {
                        Producto_Cantidad = 0,
                        Sucursal_Id = 1,
                        Membresia_Fecha_Inicio = DateTime.Now.ToString("d"),
                        Meses_Adelantados = 1,
                        Lista_Precio_Id = producto.Lista_Precio_Id,
                        Impuesto_Id = producto.Moneda_Id,
                        Moneda_Id = producto.Moneda_Id,
                        Tipo = producto.Producto_Disponibilidad
                    });

                TableRow row = new TableRow(context);

                EditText txtCantidadProductos = CarritoView.FindViewById<EditText>(Resource.Id.txtCantidad);
                txtCantidadProductos.TextChanged += (sender, e) =>
                {
                    if (!string.IsNullOrEmpty(txtCantidadProductos.Text))
                        if (Convert.ToInt32(txtCantidadProductos.Text) >= 0)
                        {
                            Productos[producto.Producto_Id].Producto_Cantidad = Convert.ToInt32(txtCantidadProductos.Text);
                            if (producto.Producto_Disponibilidad.Contains("RECURRENTE"))
                                subtotal = (producto.Producto_Precio_Base_Neto / DateHelper.GetMonthsDays(DateTime.Parse(dtFechaInicio.Text)) *
                                            (DateHelper.GetMonthsDays(DateTime.Parse(dtFechaInicio.Text)) - DateTime.Parse(dtFechaInicio.Text).Day + 1));
                            else
                                subtotal = producto.Producto_Precio_Base_Neto;
                            lblProporcional.Text = subtotal.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
                            lblTotal.Text = (((producto.Producto_Precio_Base_Neto * ((Convert.ToDouble(txtMesesProductos.Text) - 1)) + subtotal)
                                              * Convert.ToDouble(txtCantidadProductos.Text))).ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
                        }
                };

                ImageButton btnPlus = CarritoView.FindViewById<ImageButton>(Resource.Id.btnAddCantidad);
                btnPlus.Click += (sender, e) =>
                {
                    ++Productos[producto.Producto_Id].Producto_Cantidad;

                    txtCantidadProductos.Text = Productos[producto.Producto_Id].Producto_Cantidad.ToString();
                    if (producto.Producto_Disponibilidad.Contains("RECURRENTE"))
                        subtotal = (producto.Producto_Precio_Base_Neto / DateHelper.GetMonthsDays(DateTime.Parse(dtFechaInicio.Text)) *
                                    (DateHelper.GetMonthsDays(DateTime.Parse(dtFechaInicio.Text)) - DateTime.Parse(dtFechaInicio.Text).Day + 1));
                    else
                        subtotal = producto.Producto_Precio_Base_Neto;
                    lblProporcional.Text = subtotal.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
                    lblTotal.Text = (((producto.Producto_Precio_Base_Neto * ((Convert.ToDouble(txtMesesProductos.Text) - 1)) + subtotal)
                                      * Convert.ToDouble(txtCantidadProductos.Text))).ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
                };


                ImageButton btnLess = CarritoView.FindViewById<ImageButton>(Resource.Id.btnRemoveCantidad); ;
                btnLess.SetImageResource(Resource.Mipmap.ic_remove);
                btnLess.Click += (sender, e) =>
                {
                    if (Productos[producto.Producto_Id].Producto_Cantidad > 0)
                    {
                        --Productos[producto.Producto_Id].Producto_Cantidad;
                        txtCantidadProductos.Text = Productos[producto.Producto_Id].Producto_Cantidad.ToString();
                        if (producto.Producto_Disponibilidad.Contains("RECURRENTE"))
                            subtotal = (producto.Producto_Precio_Base_Neto / DateHelper.GetMonthsDays(DateTime.Parse(dtFechaInicio.Text)) *
                                        (DateHelper.GetMonthsDays(DateTime.Parse(dtFechaInicio.Text)) - DateTime.Parse(dtFechaInicio.Text).Day + 1));
                        else
                            subtotal = producto.Producto_Precio_Base_Neto;
                        lblProporcional.Text = subtotal.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
                        lblTotal.Text = (((producto.Producto_Precio_Base_Neto * ((Convert.ToDouble(txtMesesProductos.Text) - 1)) + subtotal)
                                          * Convert.ToDouble(txtCantidadProductos.Text))).ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
                    }
                };

                CarritoView.FindViewById<TextView>(Resource.Id.lblTarifaMensual).Text = producto.Producto_Precio_Base_Neto.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));

                Spinner spSucursales = CarritoView.FindViewById<Spinner>(Resource.Id.spSucursal);
                spSucursales.Adapter = adapter;

                if (producto.Producto_Disponibilidad.Contains("RECURRENTE"))
                {
                    dtFechaInicio.Text = DateTime.Now.ToString("d");
                    dtFechaInicio.Touch += (sender, e) =>
                    {
                        if (dialog == null || !dialog.IsShowing)
                        {
                            InputMethodManager mgr = (InputMethodManager)context.GetSystemService(Context.InputMethodService);
                            mgr.HideSoftInputFromWindow(dtFechaInicio.WindowToken, HideSoftInputFlags.None);
                            ShowCalendarView((EditText)sender);
                        }
                    };

                    dtFechaInicio.TextChanged += delegate
                    {
                        if (DateTime.TryParse(dtFechaInicio.Text, out DateTime fecha))
                        {
                            if (fecha >= DateTime.Now)
                            {
                                mesProducto = Convert.ToInt32(txtMesesProductos.Text);
                                subtotal = (producto.Producto_Precio_Base_Neto / DateHelper.GetMonthsDays(DateTime.Parse(dtFechaInicio.Text)) *
                                        (DateHelper.GetMonthsDays(DateTime.Parse(dtFechaInicio.Text)) - DateTime.Parse(dtFechaInicio.Text).Day + 1));
                                lblProporcional.Text = subtotal.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
                                lblTotal.Text = (((producto.Producto_Precio_Base * ((Convert.ToDouble(txtMesesProductos.Text) - 1)) + subtotal)
                                                  * Convert.ToDouble(txtCantidadProductos.Text))).ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
                            }
                        }
                    };

                    txtMesesProductos.TextChanged += (sender, e) =>
                    {
                        if (!string.IsNullOrEmpty(txtMesesProductos.Text))
                            if (mesProducto > 1)
                            {
                                Productos[producto.Producto_Id].Meses_Adelantados = Convert.ToInt32(txtMesesProductos.Text);
                                mesProducto = Convert.ToInt32(txtMesesProductos.Text);
                                subtotal = (producto.Producto_Precio_Base_Neto / DateHelper.GetMonthsDays(DateTime.Parse(dtFechaInicio.Text)) *
                                            (DateHelper.GetMonthsDays(DateTime.Parse(dtFechaInicio.Text)) - DateTime.Parse(dtFechaInicio.Text).Day + 1));
                                lblProporcional.Text = subtotal.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
                                lblTotal.Text = (((producto.Producto_Precio_Base_Neto * ((Convert.ToDouble(txtMesesProductos.Text) - 1)) + subtotal)
                                                  * Convert.ToDouble(txtCantidadProductos.Text))).ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
                            }
                            else
                                Toast.MakeText(context, Resource.String.NumeroInferior, ToastLength.Short).Show();
                    };

                    ImageButton btnMesesPlus = CarritoView.FindViewById<ImageButton>(Resource.Id.btnAddMeses);
                    btnMesesPlus.Click += (sender, e) =>
                    {
                        ++mesProducto;
                        txtMesesProductos.Text = mesProducto.ToString();
                        Productos[producto.Producto_Id].Meses_Adelantados = Convert.ToInt32(txtMesesProductos.Text);
                        subtotal = (producto.Producto_Precio_Base_Neto / DateHelper.GetMonthsDays(DateTime.Parse(dtFechaInicio.Text)) *
                                    (DateHelper.GetMonthsDays(DateTime.Parse(dtFechaInicio.Text)) - DateTime.Parse(dtFechaInicio.Text).Day + 1));
                        lblProporcional.Text = subtotal.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
                        lblTotal.Text = (((producto.Producto_Precio_Base_Neto * ((Convert.ToDouble(txtMesesProductos.Text) - 1)) + subtotal)
                                          * Convert.ToDouble(txtCantidadProductos.Text))).ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
                    };

                    ImageButton btnMesesLess = CarritoView.FindViewById<ImageButton>(Resource.Id.btnRemoveMeses);
                    btnMesesLess.Click += (sender, e) =>
                    {
                        if (mesProducto > 1)
                        {
                            --mesProducto;
                            txtMesesProductos.Text = mesProducto.ToString();
                            Productos[producto.Producto_Id].Meses_Adelantados = Convert.ToInt32(txtMesesProductos.Text);
                            subtotal = (producto.Producto_Precio_Base_Neto / DateHelper.GetMonthsDays(DateTime.Parse(dtFechaInicio.Text)) *
                                        (DateHelper.GetMonthsDays(DateTime.Parse(dtFechaInicio.Text)) - DateTime.Parse(dtFechaInicio.Text).Day + 1));
                            lblProporcional.Text = subtotal.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
                            lblTotal.Text = (((producto.Producto_Precio_Base_Neto * ((Convert.ToDouble(txtMesesProductos.Text) - 1)) + subtotal)
                                              * Convert.ToDouble(txtCantidadProductos.Text))).ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
                        }
                        else
                            Toast.MakeText(context, Resource.String.NumeroInferior, ToastLength.Short).Show();
                    };
                    subtotal = (producto.Producto_Precio_Base_Neto / DateHelper.GetMonthsDays(DateTime.Parse(dtFechaInicio.Text)) *
                                (DateHelper.GetMonthsDays(DateTime.Parse(dtFechaInicio.Text)) - DateTime.Parse(dtFechaInicio.Text).Day + 1));
                    lblProporcional.Text = subtotal.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));

                }

                lblTotal.Text = 0.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
                row.AddView(CarritoView);
                tlProductos.AddView(row);
            });
        }
        void ShowCalendarView(EditText fecha)
        {

            AlertDialog.Builder builder = new AlertDialog.Builder(context);

            LayoutInflater liView = (LayoutInflater)context.GetSystemService(Context.LayoutInflaterService);

            View customView = liView.Inflate(Resource.Layout.CalendarioLayout, null, true);

            CalendarView calendar = customView.FindViewById<CalendarView>(Resource.Id.cvCalendario);
            calendar.MinDate = new Java.Util.Date().Time;
            calendar.DateChange += (sender, e) =>
            {
                fecha.Text = e.DayOfMonth + "/" + e.Month + "/" + e.Year;
                dialog.Dismiss();
            };
            builder.SetView(customView);
            builder.Create();
            dialog = builder.Show();
            dialog.Window.SetGravity(GravityFlags.Top | GravityFlags.Center);
        }
    }
}
