using System;
using System.Collections.Generic;
using WorklabsMx.iOS.Models;
using WorklabsMx.Controllers;
using WorklabsMx.Models;
using SuitemCommerce;
using WorklabsMx.Handlers;

namespace WorklabsMx.iOS
{
    public partial class EjemploPagos : SuiteControllerDelegate
    {
        SuiteController suiteController;
        Bean3DS bean3DS;
        BeanTokenization beanTokenization;


        public EjemploPagos()
        {
        }

        public void Pagar(VentaDetalleTableViewController VistaPagos, string Total)
        {
            this.MostrarVistaTarjeta(VistaPagos, Total);
        }

        private void MostrarVistaTarjeta(VentaDetalleTableViewController VistaPagos, string total)
        {
            suiteController = new SuiteController(SuitemCommerce.Environment.Qa, VistaPagos, this);
            beanTokenization = new BeanTokenization
            {
                Branch = "000025",
                Company = "Z703",
                Country = "MX",
                User = "Z703CSES0",
                Password = "OOMYO17MS7",
                Merchant = "158198",
                Currency = Currency.Mxn,
                OperationType = "6",
                Token = "158128",
                Reference = "Referencia dada por el usuario",
                Amount = total
            };

            bean3DS = new Bean3DS
            {
                Branch = "000025",
                Company = "Z703",
                Country = "MX",
                User = "Z703CSES0",
                Password = "OOMYO17MS7",
                Merchant = "158198",
                Currency = Currency.Mxn,
                Reference = "Referencia dada por el usuario",
                AuthKey = "516883685552545048505454"
            };
            suiteController.AuthenticateWithBeanTokenization(beanTokenization, bean3DS);
            suiteController.SndPayWithTokenWithBeanTokenization(beanTokenization, bean3DS);
        }

        private void GuardarPagoServer()
        {
            PagosHandler pagos = new PagosHandler();
            OrdenVentaEncabezado encabezado = pagos.GetEncabezado();
            List<OrdenVentaDetalle> detalles = pagos.GetDetalles();


            bool VentaRealizada = false;

            if (Helpers.InternetConectionHelper.VerificarConexion())
            {
                int ValorEncabezado = new PagosController().AddOrdenVentaEncabezado(encabezado.Usuario_Id, encabezado.Moneda_Id, encabezado.Impuesto_Id, encabezado.Promocion_Id, encabezado.Descuento_Id, encabezado.Folio, Convert.ToDecimal(encabezado.Importe_Suma), Convert.ToDecimal(encabezado.Porcentaje_Descuento), Convert.ToDecimal(encabezado.Importe_Descuento), Convert.ToDecimal(encabezado.Importe_Subtotal), Convert.ToDecimal(encabezado.Importe_Impuesto), Convert.ToDecimal(encabezado.Importe_Total), Convert.ToDecimal(encabezado.Importe_Pagado), Convert.ToDecimal(encabezado.Importe_Facturado));
                if (ValorEncabezado >= 0)
                {
                    foreach (OrdenVentaDetalle membresia in detalles)
                    {
                        int ValorDetalle = new PagosController().AddOrdenVentaDetalle(ValorEncabezado, membresia.Membresia_Id, membresia.Inscripcion_Membresia_Id, membresia.Lista_Precio_Membresia_Id, membresia.Producto_Id, membresia.Lista_Precio_Producto_Id, membresia.Orden_Venta_Detalle_Descripcion, membresia.Orden_Venta_Detalle_Cantidad, Convert.ToDecimal(membresia.Orden_Venta_Detalle_Importe_Precio), Convert.ToDecimal(membresia.Orden_Venta_Detalle_Importe_Prorrateo), Convert.ToDecimal(membresia.Orden_Venta_Detalle_Importe_Suma), Convert.ToDecimal(membresia.Orden_Venta_Detalle_Importe_Descuento), Convert.ToDecimal(membresia.Orden_Venta_Detalle_Importe_Subtotal), Convert.ToDecimal(membresia.Orden_Venta_Detalle_Importe_Impuesto), Convert.ToDecimal(membresia.Orden_Venta_Detalle_Importe_Total), membresia.Tipos_Servicios);
                        if (ValorDetalle >= 0)
                        {
                            VentaRealizada = true;
                        }
                        else
                        {
                            VentaRealizada = false;
                        }
                    }
                    if (VentaRealizada)
                    {
                        new MessageDialog().SendToast("El pago fue realizado exitosamente");

                    }
                }
                else
                {
                    new MessageDialog().SendToast("No se pudo realizar el pago");
                }
            }
            else
            {
                new MessageDialog().SendToast("No tienes conexión a internet, intenta mas tarde");
            }

        }


        public override void DidFinishAuthenticationProcess(BeanTokenizeResponse tokenizeResponse, SuiteError error)
        {
            //throw new NotImplementedException();
            this.GuardarPagoServer();
        }

        public override void DidFinishPayProcess(string response, SuiteError error)
        {
            //throw new NotImplementedException();

        }

        public override void DidFinishTokenizeTransantion(BeanPaymentWithToken beanPaymentWithToken, SuiteError error)
        {
            
            //throw new NotImplementedException();
        }

        public override void OperationCanceledByUser()
        {
            new MessageDialog().SendToast("Operación cancelada por el usuario");
            //throw new NotImplementedException();
        }
    }



}
