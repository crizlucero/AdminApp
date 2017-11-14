using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Views;
using Android.Widget;
using Newtonsoft.Json;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using WorklabsMx.Helpers;
using WorklabsMx.Models;
using WorklabsMx.Enum;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/app_name")]
    public class ShoppingCartActivity : Activity
    {
        List<CarritoComprasDetalle> membresias = null, productos = null;
        Dictionary<string, CarritoModel> CarritoMembresia, CarritoProducto;
        TableLayout tlCarrito;
        decimal Descuento, Subtotal, IVA = 1.16M, Total, IVATotal;
        readonly List<decimal> Descuentos;
        SimpleStorage Storage;
        PickerItemsController controller;
        View customView;
        AlertDialog dialog;
        public ShoppingCartActivity()
        {
            Descuentos = new List<decimal>();
            membresias = new List<CarritoComprasDetalle>();
            productos = new List<CarritoComprasDetalle>();
            controller = new PickerItemsController();
            Storage = SimpleStorage.EditGroup("Login");
        }


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.CarritoLayout);
            CarritoMembresia = JsonConvert.DeserializeObject<Dictionary<string, CarritoModel>>(Intent.GetStringExtra("Membresias"));
            CarritoProducto = JsonConvert.DeserializeObject<Dictionary<string, CarritoModel>>(Intent.GetStringExtra("Productos"));

            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.ConfirmacionPago);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            tlCarrito = FindViewById<TableLayout>(Resource.Id.tlCarrito);
            CalculaPrecios();
            FindViewById<ImageButton>(Resource.Id.btnApply).Click += AplicarDescuento_Click;
        }

        void FillPrices()
        {
            FindViewById<TextView>(Resource.Id.tvSubtotal).Text = Subtotal.ToString("C");
            FindViewById<TextView>(Resource.Id.tvDescuento).Text = Descuento.ToString("C");
            FindViewById<TextView>(Resource.Id.tvIVA).Text = IVATotal.ToString("C");
            FindViewById<TextView>(Resource.Id.tvTotal).Text = Total.ToString("C");
        }

        void AddMembresiaDescripcion()
        {
            membresias.ForEach(precio =>
            {
                TableRow trDescripcion = new TableRow(this);

                TextView lblCantidad = new TextView(this)
                {
                    Text = precio.Carrito_Compras_Detalle_Cantidad
                };
                trDescripcion.AddView(lblCantidad, 0);

                TextView lblDescripcion = new TextView(this)
                {
                    Text = precio.Carrito_Compras_Detalle_Descripcion
                };
                lblDescripcion.SetWidth(120);
                lblDescripcion.Click += (sender, e) => ShowDesglose(precio);
                trDescripcion.AddView(lblDescripcion, 1);

                TextView lblTotal = new TextView(this)
                {
                    Text = Convert.ToDecimal(precio.Carrito_Compras_Detalle_Importe_Suma) != 0 ? precio.Carrito_Compras_Detalle_Importe_Suma_Texto : Convert.ToDecimal(precio.Carrito_Compras_Detalle_Importe_Prorrateo).ToString("C") + "MXN"
                };
                trDescripcion.AddView(lblTotal, 2);
                tlCarrito.AddView(trDescripcion);

                Subtotal += Convert.ToDecimal(precio.Carrito_Compras_Detalle_Importe_Suma) != 0 ? Convert.ToDecimal(precio.Carrito_Compras_Detalle_Importe_Suma) : Convert.ToDecimal(precio.Carrito_Compras_Detalle_Importe_Prorrateo);
            });
        }

        void AddProductosDescripcion()
        {
            productos.ForEach(precio =>
            {
                TableRow trDescripcion = new TableRow(this);

                TextView lblCantidad = new TextView(this)
                {
                    Text = precio.Carrito_Compras_Detalle_Cantidad
                };
                trDescripcion.AddView(lblCantidad, 0);

                TextView lblDescripcion = new TextView(this)
                {
                    Text = precio.Carrito_Compras_Detalle_Descripcion
                };
                lblDescripcion.SetWidth(120);
                lblDescripcion.Click += (sender, e) => ShowDesglose(precio);
                trDescripcion.AddView(lblDescripcion, 1);

                TextView lblTotal = new TextView(this)
                {
                    Text = precio.Carrito_Compras_Detalle_Importe_Suma_Texto
                };
                trDescripcion.AddView(lblTotal, 2);

                tlCarrito.AddView(trDescripcion);

                Subtotal += Convert.ToDecimal(precio.Carrito_Compras_Detalle_Importe_Suma);
            });

        }

        void AplicarDescuento_Click(object sender, EventArgs e)
        {
            PromocionModel promo = new PagosController().AplicarCupon(FindViewById<EditText>(Resource.Id.txtCupon).Text);
            if (!promo.Equals(null))
            {
                foreach (KeyValuePair<string, CarritoModel> producto in CarritoProducto)
                {
                    producto.Value.Descuento_Id = Convert.ToInt32(promo.Descuento_Id);
                }
                foreach (KeyValuePair<string, CarritoModel> membresia in CarritoMembresia)
                {
                    membresia.Value.Descuento_Id = Convert.ToInt32(promo.Descuento_Id);
                }
                Descuento = Subtotal * promo.Descuento_Porcentaje;
                Total = (Subtotal - Descuento) * IVA;
                IVATotal = Total - (Subtotal - Descuento);
                FillPrices();
                TableRow trCupon = new TableRow(this);

                TextView tvDescuentoDescripcion = new TextView(this)
                {
                    Text = promo.Descuento_Descripcion,
                    TextSize = 12
                };
                trCupon.AddView(tvDescuentoDescripcion, 0);

                TextView tvPromoDescripcion = new TextView(this)
                {
                    Text = promo.Promocion_Descripcion,
                    TextSize = 12
                };
                trCupon.AddView(tvPromoDescripcion, 1);
                FindViewById<TableLayout>(Resource.Id.tlCupones).AddView(trCupon);
                Toast.MakeText(this, Resource.String.CodigoIngresado, ToastLength.Short).Show();
                ((ImageButton)sender).Enabled = false;
                FindViewById<EditText>(Resource.Id.txtCupon).Text = "";
                FindViewById<EditText>(Resource.Id.txtCupon).Hint = "Cupón Agregado";
            }
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.payment_menu, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.menu_payment:
                    Intent intent = new Intent(this, typeof(PaymentActivity));
                    intent.PutExtra("Descuento", Descuento.ToString());
                    intent.PutExtra("Subtotal", Subtotal.ToString());
                    intent.PutExtra("IVA", IVATotal.ToString());
                    intent.PutExtra("Total", Total.ToString());
                    StartActivity(intent);
                    break;
                default:
                    base.OnBackPressed();
                    break;
            }
            return base.OnOptionsItemSelected(item);
        }

        void CalculaPrecios()
        {
            try
            {
                if (CarritoMembresia.Count > 0)
                    controller.GetMembresias().ForEach(membresia =>
                    {
                        if (CarritoMembresia[membresia.Membresia_Id].Membresia_Cantidad > 0)
                        {

                            membresias.AddRange(controller.GetProductosMembresias(TiposServicios.Membresia, Convert.ToInt32(membresia.Membresia_Id),
                                                                                  CarritoMembresia[membresia.Membresia_Id].Membresia_Cantidad,
                                                                                  CarritoMembresia[membresia.Membresia_Id].Meses_Adelantados,
                                                                                  CarritoMembresia[membresia.Membresia_Id].Membresia_Fecha_Inicio,
                                                                                  CarritoMembresia[membresia.Membresia_Id].Lista_Precio_Id,
                                                                                  CarritoMembresia[membresia.Membresia_Id].Moneda_Id,
                                                                                  CarritoMembresia[membresia.Membresia_Id].Impuesto_Id,
                                                                                  CarritoMembresia[membresia.Membresia_Id].Descuento_Id));
                        }
                    });
                if (CarritoProducto.Count > 0)
                    controller.GetProductos().ForEach(producto =>
                    {
                        if (CarritoProducto[producto.Producto_Id].Producto_Cantidad > 0)
                            productos.AddRange(controller.GetProductosMembresias(TiposServicios.Producto, Convert.ToInt32(producto.Producto_Id),
                                                                                 CarritoProducto[producto.Producto_Id].Producto_Cantidad,
                                                                                 CarritoProducto[producto.Producto_Id].Meses_Adelantados,
                                                                                 CarritoProducto[producto.Producto_Id].Membresia_Fecha_Inicio,
                                                                                 CarritoProducto[producto.Producto_Id].Lista_Precio_Id,
                                                                                 CarritoProducto[producto.Producto_Id].Moneda_Id,
                                                                                 CarritoProducto[producto.Producto_Id].Impuesto_Id,
                                                                                 CarritoProducto[producto.Producto_Id].Descuento_Id));
                    });
            }
            catch (Exception e)
            {
                SlackLogs.SendMessage(e.Message);
            }
            if (productos.Count > 0)
                AddProductosDescripcion();
            if (membresias.Count > 0)
                AddMembresiaDescripcion();

            Total = Subtotal * IVA;
            IVATotal = Total - Subtotal;

            FillPrices();
        }

        void ShowDesglose(CarritoComprasDetalle despliegue)
        {
            AlertDialog.Builder builder = new AlertDialog.Builder(this);

            LayoutInflater liView = LayoutInflater;

            customView = liView.Inflate(Resource.Layout.DesgloseIndividualLayout, null, true);
            if (despliegue.Producto_Id != "")
                if (!CarritoProducto[despliegue.Producto_Id].Tipo.Contains("RECURRENTE"))
                {
                    customView.FindViewById<TextView>(Resource.Id.lblMesesAdelantados).Visibility = ViewStates.Gone;
                    customView.FindViewById<TextView>(Resource.Id.txtMesesAdelantados).Visibility = ViewStates.Gone;
                    customView.FindViewById<TextView>(Resource.Id.lblPeriodo).Visibility = ViewStates.Gone;
                    customView.FindViewById<TextView>(Resource.Id.txtPeriodo).Visibility = ViewStates.Gone;

                }
            customView.FindViewById<TextView>(Resource.Id.lblDespliegue).Text = despliegue.Carrito_Compras_Detalle_Descripcion;
            customView.FindViewById<TextView>(Resource.Id.txtCantidad).Text = despliegue.Carrito_Compras_Detalle_Cantidad;
            customView.FindViewById<TextView>(Resource.Id.txtPeriodo).Text = despliegue.Carrito_Compras_Detalle_Vigencia_Fecha;
            customView.FindViewById<TextView>(Resource.Id.txtSubtotal).Text = despliegue.Carrito_Compras_Detalle_Importe_Subtotal_Texto;
            customView.FindViewById<TextView>(Resource.Id.txtIva).Text = despliegue.Carrito_Compras_Detalle_Importe_Impuesto_Texto;
            customView.FindViewById<TextView>(Resource.Id.txtTotal).Text = despliegue.Carrito_Compras_Detalle_Importe_Total_Texto;

            builder.SetView(customView);
            builder.Create();
            dialog = builder.Show();
            dialog.Window.SetGravity(GravityFlags.Top | GravityFlags.Center);
        }
    }
}