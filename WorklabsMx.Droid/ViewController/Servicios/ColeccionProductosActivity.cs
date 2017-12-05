using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Views.InputMethods;
using Android.Widget;
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
        readonly Dictionary<string, CarritoModel> Productos, Membresias;
        SimpleStorage Storage;
        ArrayAdapter adapter;
        TableRow.LayoutParams param;
        AlertDialog dialog;
        public ColeccionProductosActivity()
        {
            Storage = SimpleStorage.EditGroup("Login");
            Productos = new Dictionary<string, CarritoModel>();
            Membresias = new Dictionary<string, CarritoModel>();
            param = new TableRow.LayoutParams
            {
                Column = 1,
                Span = 3
            };
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ProductosLayout);

            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.Productos);
            ActionBar.SetDisplayHomeAsUpEnabled(true);

            adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleDropDownItem1Line, new SucursalController().GetSucursalNombres().ToArray());
            FindViewById<ImageButton>(Resource.Id.btnProductos).Click += delegate
            {
                FindViewById<TableLayout>(Resource.Id.tlProductos).RemoveAllViews();
                FillDataProductos();
            };

            FindViewById<ImageButton>(Resource.Id.btnMembresias).Click += delegate
            {
                FindViewById<TableLayout>(Resource.Id.tlProductos).RemoveAllViews();
                FillDataMembresias();
            };

            FillDataProductos();
        }

        void FillDataMembresias()
        {
            TableLayout tlMembresias = FindViewById<TableLayout>(Resource.Id.tlProductos);
            new PickerItemsController().GetMembresias().ForEach(membresia =>
            {
                double subtotal = membresia.Membresia_Precio_Base_Neto;
                int mesMembresia = 1;
                TextView lblProporcional = new TextView(this), lblTotal = new TextView(this);
                EditText txtMesesMembresias = new EditText(this)
                {
                    TextSize = 14,
                    InputType = Android.Text.InputTypes.NumberFlagSigned
                }, dtFechaInicio = new EditText(this)
                {
                    Text = DateTime.Now.ToString("d"),
                    InputType = Android.Text.InputTypes.DatetimeVariationDate
                };
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

                TableRow trMembresia = new TableRow(this);
                View line = new View(this);
                line.SetBackgroundColor(Android.Graphics.Color.Cyan);
                line.LayoutParameters = new TableRow.LayoutParams(ViewGroup.LayoutParams.MatchParent, 5);

                trMembresia.AddView(line);
                tlMembresias.AddView(trMembresia, param);

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
                    Text = Membresias[membresia.Membresia_Id].Membresia_Cantidad.ToString(),
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
                        subtotal = (membresia.Membresia_Precio_Base_Neto / DateHelper.GetMonthsDays(DateTime.Parse(dtFechaInicio.Text)) *
                                    (DateHelper.GetMonthsDays(DateTime.Parse(dtFechaInicio.Text)) - DateTime.Parse(dtFechaInicio.Text).Day + 1));
                        lblProporcional.Text = subtotal.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
                        lblTotal.Text = (((membresia.Membresia_Precio_Base_Neto * ((Convert.ToDouble(txtMesesMembresias.Text) - 1)) + subtotal + membresia.Inscripcion_Precio_Base_Neto)
                                          * Convert.ToDouble(txtCantidadMembresias.Text))).ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
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
                    subtotal = (membresia.Membresia_Precio_Base_Neto / DateHelper.GetMonthsDays(DateTime.Parse(dtFechaInicio.Text)) *
                                (DateHelper.GetMonthsDays(DateTime.Parse(dtFechaInicio.Text)) - DateTime.Parse(dtFechaInicio.Text).Day + 1));
                    lblProporcional.Text = subtotal.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
                    lblTotal.Text = (((membresia.Membresia_Precio_Base_Neto * ((Convert.ToDouble(txtMesesMembresias.Text) - 1)) + subtotal + membresia.Inscripcion_Precio_Base_Neto)
                                      * Convert.ToDouble(txtCantidadMembresias.Text))).ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
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
                        subtotal = (membresia.Membresia_Precio_Base_Neto / DateHelper.GetMonthsDays(DateTime.Parse(dtFechaInicio.Text)) *
                                    (DateHelper.GetMonthsDays(DateTime.Parse(dtFechaInicio.Text)) - DateTime.Parse(dtFechaInicio.Text).Day + 1));
                        lblProporcional.Text = subtotal.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
                        lblTotal.Text = (((membresia.Membresia_Precio_Base_Neto * ((Convert.ToDouble(txtMesesMembresias.Text) - 1)) + subtotal + membresia.Inscripcion_Precio_Base_Neto)
                                          * Convert.ToDouble(txtCantidadMembresias.Text))).ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
                    }
                    else
                        Toast.MakeText(this, Resource.String.NumeroInferior, ToastLength.Short).Show();
                };

                trMembresia.AddView(btnLess, 3);

                tlMembresias.AddView(trMembresia);
                trMembresia = new TableRow(this);
                trMembresia.AddView(new TextView(this) { Text = "Tarifa Mensual" });

                trMembresia.AddView(new TextView(this) { Text = membresia.Membresia_Precio_Base_Neto.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx")) }, param);

                tlMembresias.AddView(trMembresia);
                trMembresia = new TableRow(this);
                trMembresia.AddView(new TextView(this) { Text = "Tarifa Inscripción" });

                trMembresia.AddView(new TextView(this) { Text = membresia.Inscripcion_Precio_Base_Neto.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx")) }, param);

                tlMembresias.AddView(trMembresia);

                trMembresia = new TableRow(this);
                Spinner spSucursales = new Spinner(this);
                spSucursales.Adapter = adapter;
                trMembresia.AddView(spSucursales);
                tlMembresias.AddView(trMembresia);

                trMembresia = new TableRow(this);
                trMembresia.AddView(new TextView(this) { Text = "Fecha de inicio" }, 0);

                dtFechaInicio.Touch += (sender, e) =>
                {
                    if (dialog == null || !dialog.IsShowing)
                    {
                        InputMethodManager mgr = (InputMethodManager)GetSystemService(Context.InputMethodService);
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

                trMembresia.AddView(dtFechaInicio, 1, param);
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
                            Membresias[membresia.Membresia_Id].Meses_Adelantados = mesMembresia;
                            subtotal = (membresia.Membresia_Precio_Base_Neto / DateHelper.GetMonthsDays(DateTime.Parse(dtFechaInicio.Text)) *
                                        (DateHelper.GetMonthsDays(DateTime.Parse(dtFechaInicio.Text)) - DateTime.Parse(dtFechaInicio.Text).Day + 1));
                            lblProporcional.Text = subtotal.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
                            lblTotal.Text = (((membresia.Membresia_Precio_Base_Neto * ((Convert.ToDouble(txtMesesMembresias.Text) - 1)) + subtotal + membresia.Inscripcion_Precio_Base_Neto)
                                              * Convert.ToDouble(txtCantidadMembresias.Text))).ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
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
                    ++Membresias[membresia.Membresia_Id].Meses_Adelantados;
                    txtMesesMembresias.Text = mesMembresia.ToString();
                    subtotal = (membresia.Membresia_Precio_Base_Neto / DateHelper.GetMonthsDays(DateTime.Parse(dtFechaInicio.Text)) *
                                (DateHelper.GetMonthsDays(DateTime.Parse(dtFechaInicio.Text)) - DateTime.Parse(dtFechaInicio.Text).Day + 1));
                    lblProporcional.Text = subtotal.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
                    lblTotal.Text = (((membresia.Membresia_Precio_Base_Neto * ((Convert.ToDouble(txtMesesMembresias.Text) - 1)) + subtotal + membresia.Inscripcion_Precio_Base_Neto)
                                      * Convert.ToDouble(txtCantidadMembresias.Text))).ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
                };

                trMembresia.AddView(btnMesesPlus, 2);

                ImageButton btnMesesLess = new ImageButton(this);
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
                        Toast.MakeText(this, Resource.String.NumeroInferior, ToastLength.Short).Show();
                };

                trMembresia.AddView(btnMesesLess, 3);

                tlMembresias.AddView(trMembresia);

                trMembresia = new TableRow(this);
                trMembresia.AddView(new TextView(this) { Text = "Proporcional al mes" });
                subtotal = (membresia.Membresia_Precio_Base_Neto / DateHelper.GetMonthsDays(DateTime.Parse(dtFechaInicio.Text)) *
                            (DateHelper.GetMonthsDays(DateTime.Parse(dtFechaInicio.Text)) - DateTime.Parse(dtFechaInicio.Text).Day + 1));
                lblProporcional.Text = 0.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
                trMembresia.AddView(lblProporcional, param);

                tlMembresias.AddView(trMembresia);

                trMembresia = new TableRow(this);
                trMembresia.AddView(new TextView(this) { Text = "Total" });

                lblTotal.Text = 0.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
                trMembresia.AddView(lblTotal, param);

                tlMembresias.AddView(trMembresia);
            });
        }

        void FillDataProductos()
        {
            TableLayout tlProductos = FindViewById<TableLayout>(Resource.Id.tlProductos);
            new PickerItemsController().GetProductos().ForEach((producto) =>
            {
                double subtotal = producto.Producto_Precio_Base_Neto;
                int mesProducto = 1;
                TextView lblProporcional = new TextView(this), lblTotal = new TextView(this);
                EditText txtMesesProductos = new EditText(this)
                {
                    Text = "1",
                    TextSize = 14,
                    InputType = Android.Text.InputTypes.NumberFlagSigned
                }, dtFechaInicio = new EditText(this)
                {
                    Text = DateTime.Now.ToString("d"),
                    InputType = Android.Text.InputTypes.DatetimeVariationDate
                };
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

                TableRow trProducto = new TableRow(this);
                View line = new View(this);
                line.SetBackgroundColor(Android.Graphics.Color.Cyan);
                line.LayoutParameters = new TableRow.LayoutParams(ViewGroup.LayoutParams.MatchParent, 5);

                trProducto.AddView(line);
                tlProductos.AddView(trProducto);

                trProducto = new TableRow(this);

                TextView lblNombre = new TextView(this)
                {
                    Text = producto.Producto_Descripcion,
                    TextSize = 14
                };
                lblNombre.SetMaxWidth(Resources.DisplayMetrics.WidthPixels * 2 / 3);
                trProducto.AddView(lblNombre, 0);

                EditText txtCantidadProductos = new EditText(this)
                {
                    Text = Productos[producto.Producto_Id].Producto_Cantidad.ToString(),
                    TextSize = 14,
                    InputType = Android.Text.InputTypes.NumberFlagSigned
                };
                txtCantidadProductos.SetMaxWidth(70);
                txtCantidadProductos.SetFadingEdgeLength(2);
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

                trProducto.AddView(txtCantidadProductos, 1);

                ImageButton btnPlus = new ImageButton(this)
                {
                };
                btnPlus.SetImageResource(Resource.Mipmap.ic_add);
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

                trProducto.AddView(btnPlus, 2);

                ImageButton btnLess = new ImageButton(this)
                {

                };
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

                trProducto.AddView(btnLess, 3);

                tlProductos.AddView(trProducto);

                trProducto = new TableRow(this);
                trProducto.AddView(new TextView(this) { Text = "Tarifa Mensual" });

                trProducto.AddView(new TextView(this) { Text = producto.Producto_Precio_Base_Neto.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx")) }, param);

                tlProductos.AddView(trProducto);

                trProducto = new TableRow(this);
                Spinner spSucursales = new Spinner(this);
                spSucursales.Adapter = adapter;
                trProducto.AddView(spSucursales);
                tlProductos.AddView(trProducto);

                if (producto.Producto_Disponibilidad.Contains("RECURRENTE"))
                {
                    trProducto = new TableRow(this);
                    trProducto.AddView(new TextView(this) { Text = "Fecha de inicio" }, 0);

                    dtFechaInicio.Touch += (sender, e) =>
                    {
                        if (dialog == null || !dialog.IsShowing)
                        {
                            InputMethodManager mgr = (InputMethodManager)GetSystemService(Context.InputMethodService);
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
                    trProducto.AddView(dtFechaInicio, 1, param);
                    tlProductos.AddView(trProducto);

                    trProducto = new TableRow(this);
                    trProducto.AddView(new TextView(this) { Text = "Cantidad de meses" }, 0);

                    txtMesesProductos.Text = "1";
                    txtMesesProductos.SetMaxWidth(70);
                    txtMesesProductos.SetFadingEdgeLength(2);
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
                                Toast.MakeText(this, Resource.String.NumeroInferior, ToastLength.Short).Show();
                    };

                    trProducto.AddView(txtMesesProductos, 1);

                    ImageButton btnMesesPlus = new ImageButton(this);
                    btnMesesPlus.SetImageResource(Resource.Mipmap.ic_add);
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

                    trProducto.AddView(btnMesesPlus, 2);

                    ImageButton btnMesesLess = new ImageButton(this);
                    btnMesesLess.SetImageResource(Resource.Mipmap.ic_remove);
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
                            Toast.MakeText(this, Resource.String.NumeroInferior, ToastLength.Short).Show();
                    };

                    trProducto.AddView(btnMesesLess, 3);

                    tlProductos.AddView(trProducto);

                    trProducto = new TableRow(this);
                    trProducto.AddView(new TextView(this) { Text = "Proporcional al mes" });
                    subtotal = (producto.Producto_Precio_Base_Neto / DateHelper.GetMonthsDays(DateTime.Parse(dtFechaInicio.Text)) *
                                (DateHelper.GetMonthsDays(DateTime.Parse(dtFechaInicio.Text)) - DateTime.Parse(dtFechaInicio.Text).Day + 1));
                    lblProporcional.Text = subtotal.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
                    trProducto.AddView(lblProporcional, param);

                    tlProductos.AddView(trProducto);
                }
                trProducto = new TableRow(this);
                trProducto.AddView(new TextView(this) { Text = "Total" });

                lblTotal.Text = 0.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
                trProducto.AddView(lblTotal, param);

                tlProductos.AddView(trProducto);
            });
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

        void ShowCalendarView(EditText fecha)
        {

            AlertDialog.Builder builder = new AlertDialog.Builder(this);

            LayoutInflater liView = LayoutInflater;

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
