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
    [Activity(Label = "@string/Productos")]
    public class ProductosActivity : Activity
    {
        readonly Dictionary<string, CarritoModel> Carrito, Productos;
        bool CanPay;
        SimpleStorage Storage;
        ArrayAdapter adapter;
        TableRow.LayoutParams param;
        public ProductosActivity()
        {
            Storage = SimpleStorage.EditGroup("Login");
            Productos = new Dictionary<string, CarritoModel>();
            CanPay = false;
            Carrito = new CarritoController().GetCarrito(Storage.Get("Usuario_Id"), TiposServicios.Producto);
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
            ActionBar.SetHomeAsUpIndicator(Resource.Mipmap.ic_menu);

            adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleDropDownItem1Line, new SucursalController().GetSucursalNombres().ToArray());
            FillData();
        }

        void FillData()
        {
            TableLayout tlProductos = FindViewById<TableLayout>(Resource.Id.tlProductos);
            new PickerItemsController().GetProductos().ForEach((producto) =>
            {
                double subtotal = producto.Producto_Precio_Base;
                int mesProducto = 1;
                TextView lblProporcional = new TextView(this), lblTotal = new TextView(this);
                EditText dpFechaInicio = new EditText(this)
                {
                    InputType = Android.Text.InputTypes.DatetimeVariationDate
                }, txtMesesProductos = new EditText(this)
                {
                    Text = "1",
                    TextSize = 14,
                    InputType = Android.Text.InputTypes.NumberFlagSigned
                };
                Productos.Add(producto.Producto_Id, new CarritoModel { Producto_Cantidad = 0, Sucursal_Id = 0 });
                if (Carrito.ContainsKey(producto.Producto_Id))
                {
                    if (DateTime.Parse(Productos[producto.Producto_Id].Membresia_Fecha_Inicio) >= DateTime.Now)
                    {
                        Productos[producto.Producto_Id].Producto_Cantidad = (int)Carrito[producto.Producto_Id].Producto_Cantidad;
                        Productos[producto.Producto_Id].Sucursal_Id = Carrito[producto.Producto_Id].Sucursal_Id;
                        Productos[producto.Producto_Id].Membresia_Fecha_Inicio = Carrito[producto.Producto_Id].Membresia_Fecha_Inicio;
                        CanPay = true;
                    }
                }

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
                                subtotal = (producto.Producto_Precio_Base / DateHelper.GetMonthsDays(DateTime.Parse(dpFechaInicio.Text)) *
                                    (DateHelper.GetMonthsDays(DateTime.Parse(dpFechaInicio.Text)) - (DateTime.Parse(dpFechaInicio.Text)).Day + 1));
                            else
                                subtotal = producto.Producto_Precio_Base;
                            lblProporcional.Text = subtotal.ToString("C");
                            lblTotal.Text = (((producto.Producto_Precio_Base * ((Convert.ToDouble(txtMesesProductos.Text) - 1)) + subtotal)
                                              * Convert.ToDouble(txtCantidadProductos.Text))).ToString("C");
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
                        subtotal = (producto.Producto_Precio_Base / DateHelper.GetMonthsDays(DateTime.Parse(dpFechaInicio.Text)) *
                            (DateHelper.GetMonthsDays(DateTime.Parse(dpFechaInicio.Text)) - (DateTime.Parse(dpFechaInicio.Text)).Day + 1));
                    else
                        subtotal = producto.Producto_Precio_Base;
                    lblProporcional.Text = subtotal.ToString("C");
                    lblTotal.Text = (((producto.Producto_Precio_Base * ((Convert.ToDouble(txtMesesProductos.Text) - 1)) + subtotal)
                                      * Convert.ToDouble(txtCantidadProductos.Text))).ToString("C");
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
                            subtotal = (producto.Producto_Precio_Base / DateHelper.GetMonthsDays(DateTime.Parse(dpFechaInicio.Text)) *
                                (DateHelper.GetMonthsDays(DateTime.Parse(dpFechaInicio.Text)) - (DateTime.Parse(dpFechaInicio.Text)).Day + 1));
                        else
                            subtotal = producto.Producto_Precio_Base;
                        lblProporcional.Text = subtotal.ToString("C");
                        lblTotal.Text = (((producto.Producto_Precio_Base * ((Convert.ToDouble(txtMesesProductos.Text) - 1)) + subtotal)
                                          * Convert.ToDouble(txtCantidadProductos.Text))).ToString("C");
                    }
                };

                trProducto.AddView(btnLess, 3);

                tlProductos.AddView(trProducto);

                trProducto = new TableRow(this);
                trProducto.AddView(new TextView(this) { Text = "Tarifa Mensual" });

                trProducto.AddView(new TextView(this) { Text = producto.Producto_Precio_Base.ToString("C") }, param);

                tlProductos.AddView(trProducto);

                trProducto = new TableRow(this);
                Spinner spSucursales = new Spinner(this);
                spSucursales.Adapter = adapter;
                trProducto.AddView(spSucursales);
                tlProductos.AddView(trProducto);
                if (producto.Producto_Disponibilidad.Contains("RECURRENTE"))
                {
                    trProducto = new TableRow(this);
                    trProducto.AddView(new TextView(this) { Text = "Fecha de Inicio" });
                    dpFechaInicio.Text = !string.IsNullOrEmpty(Productos[producto.Producto_Id].Membresia_Fecha_Inicio) ? Productos[producto.Producto_Id].Membresia_Fecha_Inicio : DateTime.Now.ToString("dd/MM/yyyy");
                    dpFechaInicio.TextChanged += (sender, e) =>
                    {
                        if (DateTime.TryParse(dpFechaInicio.Text, out DateTime fecha))
                        {
                            if (fecha >= DateTime.Now)
                            {
                                mesProducto = Convert.ToInt32(txtMesesProductos.Text);
                                subtotal = (producto.Producto_Precio_Base / DateHelper.GetMonthsDays(DateTime.Parse(dpFechaInicio.Text)) *
                                        (DateHelper.GetMonthsDays(DateTime.Parse(dpFechaInicio.Text)) - (DateTime.Parse(dpFechaInicio.Text)).Day + 1));
                                lblProporcional.Text = subtotal.ToString("C");
                                lblTotal.Text = (((producto.Producto_Precio_Base * ((Convert.ToDouble(txtMesesProductos.Text) - 1)) + subtotal)
                                                  * Convert.ToDouble(txtCantidadProductos.Text))).ToString("C");
                            }
                        }
                    };
                    trProducto.AddView(dpFechaInicio, param);

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
                                mesProducto = Convert.ToInt32(txtMesesProductos.Text);
                                subtotal = (producto.Producto_Precio_Base / DateHelper.GetMonthsDays(DateTime.Parse(dpFechaInicio.Text)) *
                                            (DateHelper.GetMonthsDays(DateTime.Parse(dpFechaInicio.Text)) - (DateTime.Parse(dpFechaInicio.Text)).Day + 1));
                                lblProporcional.Text = subtotal.ToString("C");
                                lblTotal.Text = (((producto.Producto_Precio_Base * ((Convert.ToDouble(txtMesesProductos.Text) - 1)) + subtotal)
                                                  * Convert.ToDouble(txtCantidadProductos.Text))).ToString("C");
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
                        txtMesesProductos.Text = txtMesesProductos.ToString();
                        subtotal = (producto.Producto_Precio_Base / DateHelper.GetMonthsDays(DateTime.Parse(dpFechaInicio.Text)) *
                                        (DateHelper.GetMonthsDays(DateTime.Parse(dpFechaInicio.Text)) - (DateTime.Parse(dpFechaInicio.Text)).Day + 1));
                        lblProporcional.Text = subtotal.ToString("C");
                        lblTotal.Text = (((producto.Producto_Precio_Base * ((Convert.ToDouble(txtMesesProductos.Text) - 1)) + subtotal)
                                          * Convert.ToDouble(txtCantidadProductos.Text))).ToString("C");
                    };

                    trProducto.AddView(btnMesesPlus, 2);

                    ImageButton btnMesesLess = new ImageButton(this);
                    btnMesesLess.SetImageResource(Resource.Mipmap.ic_remove);
                    btnMesesLess.Click += (sender, e) =>
                    {
                        if (mesProducto > 1)
                        {
                            --mesProducto;
                            txtMesesProductos.Text = txtMesesProductos.ToString();
                            subtotal = (producto.Producto_Precio_Base / DateHelper.GetMonthsDays(DateTime.Parse(dpFechaInicio.Text)) *
                                            (DateHelper.GetMonthsDays(DateTime.Parse(dpFechaInicio.Text)) - (DateTime.Parse(dpFechaInicio.Text)).Day + 1));
                            lblProporcional.Text = subtotal.ToString("C");
                            lblTotal.Text = (((producto.Producto_Precio_Base * ((Convert.ToDouble(txtMesesProductos.Text) - 1)) + subtotal)
                                              * Convert.ToDouble(txtCantidadProductos.Text))).ToString("C");
                        }
                        else
                            Toast.MakeText(this, Resource.String.NumeroInferior, ToastLength.Short).Show();
                    };

                    trProducto.AddView(btnMesesLess, 3);

                    tlProductos.AddView(trProducto);

                    trProducto = new TableRow(this);
                    trProducto.AddView(new TextView(this) { Text = "Proporcional al mes" });
                    subtotal = (producto.Producto_Precio_Base / DateHelper.GetMonthsDays(DateTime.Parse(dpFechaInicio.Text)) *
                                            (DateHelper.GetMonthsDays(DateTime.Parse(dpFechaInicio.Text)) - (DateTime.Parse(dpFechaInicio.Text)).Day + 1));
                    lblProporcional.Text = subtotal.ToString("C");
                    trProducto.AddView(lblProporcional, param);

                    tlProductos.AddView(trProducto);
                }
                trProducto = new TableRow(this);
                trProducto.AddView(new TextView(this) { Text = "Total" });

                lblTotal.Text = Carrito.ContainsKey(producto.Producto_Id) ?
                    (((producto.Producto_Precio_Base * ((Convert.ToDouble(txtMesesProductos.Text) - 1)) + subtotal)
                                          * Convert.ToDouble(txtCantidadProductos.Text))).ToString("C") : 0.ToString("C");
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
                    if (new CarritoController().AddCarrito(Productos, TiposServicios.Producto, Storage.Get("Usuario_Id")))
                        StartActivity(new Intent(this, typeof(ShoppingCartActivity)));
                    else
                        Toast.MakeText(this, Resource.String.ErrorAlGuardar, ToastLength.Short).Show();
                    break;
                default:
                    base.OnBackPressed();
                    break;
            }
            return base.OnOptionsItemSelected(item);
        }
    }
}
