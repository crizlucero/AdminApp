using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidHUD;
using Newtonsoft.Json;
using PerpetualEngine.Storage;
using WorklabsMx.Controllers;
using WorklabsMx.Enum;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    [Activity(Label = "@string/app_name")]
    public class PaymentActivity : Activity
    {
        List<CarritoComprasDetalle> membresias = null, productos = null;
        decimal Descuento, Descuento_Porcentaje, Subtotal, Total, IVATotal;
        PagosController controller;
        SimpleStorage storage;

        int Descuento_Id;
        public PaymentActivity()
        {
            membresias = new List<CarritoComprasDetalle>();
            productos = new List<CarritoComprasDetalle>();
            controller = new PagosController();
            storage = SimpleStorage.EditGroup("Login");
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.PagoLayout);

            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = Resources.GetString(Resource.String.RealizaPago);
            ActionBar.SetDisplayHomeAsUpEnabled(true);

            membresias = JsonConvert.DeserializeObject<List<CarritoComprasDetalle>>(Intent.GetStringExtra("Membresias"));
            productos = JsonConvert.DeserializeObject<List<CarritoComprasDetalle>>(Intent.GetStringExtra("Productos"));
            Descuento_Id = Convert.ToInt32(Intent.GetStringExtra("Descuento_Id"));
            Descuento_Porcentaje = Convert.ToDecimal(Intent.GetStringExtra("Descuento_Porcentaje"));
            Descuento = Convert.ToDecimal(Intent.GetStringExtra("Descuento"));
            Subtotal = Convert.ToDecimal(Intent.GetStringExtra("Subtotal"));
            IVATotal = Convert.ToDecimal(Intent.GetStringExtra("IVA"));
            Total = Convert.ToDecimal(Intent.GetStringExtra("Total"));
            FillPrices();
        }

        void FillPrices()
        {
            FindViewById<TextView>(Resource.Id.tvSubtotal).Text = Subtotal.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
            FindViewById<TextView>(Resource.Id.tvDescuento).Text = Descuento.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
            FindViewById<TextView>(Resource.Id.tvIVA).Text = IVATotal.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
            FindViewById<TextView>(Resource.Id.tvTotal).Text = Total.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-mx"));
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
                    int Encabezado_Id = controller.AddOrdenVentaEncabezado(Convert.ToInt32(storage.Get("Usuario_Id")), 1, 1, Descuento_Id, Descuento_Id, "OWL-", Subtotal - Descuento,
                                                                           Descuento_Porcentaje, Descuento, Subtotal, IVATotal, Total, Total, 0);
                    if (Encabezado_Id != -1)
                    {
                        membresias.ForEach(membresia =>
                        {
                            if (controller.AddOrdenVentaDetalle(Encabezado_Id, membresia.Membresia_Id, membresia.Inscripcion_Membresia_Id,
                                                            membresia.Lista_Precio_Membresia_Id, membresia.Producto_Id, membresia.Lista_Precio_Producto_Id,
                                                            membresia.Carrito_Compras_Detalle_Descripcion, Convert.ToInt32(membresia.Carrito_Compras_Detalle_Cantidad),
                                                            Convert.ToDecimal(membresia.Carrito_Compras_Detalle_Importe_Precio), Convert.ToDecimal(membresia.Carrito_Compras_Detalle_Importe_Prorrateo),
                                                            Convert.ToDecimal(membresia.Carrito_Compras_Detalle_Importe_Suma), Convert.ToDecimal(membresia.Carrito_Compras_Detalle_Importe_Descuento),
                                                            Convert.ToDecimal(membresia.Carrito_Compras_Detalle_Importe_Subtotal), Convert.ToDecimal(membresia.Carrito_Compras_Detalle_Importe_Impuesto),
                                                               Convert.ToDecimal(membresia.Carrito_Compras_Detalle_Importe_Total), TiposServicios.Membresia) != -1)
                                Console.WriteLine("");
                        });
                        productos.ForEach(producto =>
                        {
                            controller.AddOrdenVentaDetalle(Encabezado_Id, producto.Membresia_Id, producto.Inscripcion_Membresia_Id,
                                                            producto.Lista_Precio_Membresia_Id, producto.Producto_Id, producto.Lista_Precio_Producto_Id,
                                                            producto.Carrito_Compras_Detalle_Descripcion, Convert.ToInt32(producto.Carrito_Compras_Detalle_Cantidad),
                                                            Convert.ToDecimal(producto.Carrito_Compras_Detalle_Importe_Precio), Convert.ToDecimal(producto.Carrito_Compras_Detalle_Importe_Prorrateo),
                                                            Convert.ToDecimal(producto.Carrito_Compras_Detalle_Importe_Suma), Convert.ToDecimal(producto.Carrito_Compras_Detalle_Importe_Descuento),
                                                            Convert.ToDecimal(producto.Carrito_Compras_Detalle_Importe_Subtotal), Convert.ToDecimal(producto.Carrito_Compras_Detalle_Importe_Impuesto),
                                                            Convert.ToDecimal(producto.Carrito_Compras_Detalle_Importe_Total), TiposServicios.Producto);
                        });
                    }
                    else
                    {
                        Toast.MakeText(this, Resource.String.ErrorAlGuardar, ToastLength.Short);
                    }
                    break;
                default:
                    base.OnBackPressed();
                    Finish();
                    break;
            }
            return base.OnOptionsItemSelected(item);
        }
    }
}