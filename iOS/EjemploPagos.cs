using System;
using UIKit;
using System.Collections.Generic;
using BigTed;
using WorklabsMx.iOS.Models;
using WorklabsMx.Controllers;
using WorklabsMx.Models;
using Foundation;
using System.Threading.Tasks;
//using PerpetualEngine.Storage;
using WorklabsMx.iOS.Helpers;
using SuitemCommerce;

namespace WorklabsMx.iOS
{
    public partial class EjemploPagos : SuiteControllerDelegate
    {
        SuiteController suiteController;
        Bean3DS bean3DS;
        BeanTokenization beanTokenization;

        OrdenVentaController ordenventaLocal;
        List<CarritoComprasDetalle> membresiasLocal;

        public EjemploPagos()
        {
        }

        public void Pagar(VentaDetalleTableViewController VistaPagos, OrdenVentaController ordenventa, List<CarritoComprasDetalle> membresias)
        {
            this.ordenventaLocal = ordenventa;
            this.membresiasLocal = membresias;
            this.MostrarVistaTarjeta(VistaPagos, ordenventa.total);
        }

        private void MostrarVistaTarjeta(VentaDetalleTableViewController VistaPagos, string total)
        {
            suiteController = new SuiteController(SuitemCommerce.Environment.Sandbox, VistaPagos, this);
            beanTokenization = new BeanTokenization
            {
                Branch = "0001",
                Company = "SX001",
                Country = "MX",
                User = "SNDBXUS3R",
                Password = "SNDBXP44S",
                Merchant = "123456",
                Currency = Currency.Mxn,
                OperationType = "6",
                Token = "1234567890124242",
                Reference = "REFERENCIA SNDBX001",
                Amount = total
            };

            bean3DS = new Bean3DS
            {
                Branch = "0001",
                Company = "SX001",
                Country = "MX",
                User = "SNDBXUS3R",
                Password = "SNDBXP44S",
                Merchant = "123456",
                Currency = Currency.Mxn,
                Reference = "REFERENCIA SNDBX001",
                AuthKey = "516883575148515057485348"
            };
            suiteController.AuthenticateWithBeanTokenization(beanTokenization, bean3DS);
            suiteController.SndPayWithTokenWithBeanTokenization(beanTokenization, bean3DS);
        }

        private void GuardarPagoServer(OrdenVentaController ordenventa, List<CarritoComprasDetalle> membresias)
        {
            bool VentaRealizada = false;
            if (ordenventa.promocion_id == null)
            {
                ordenventa.promocion_id = "0";
            }

            if (Helpers.InternetConectionHelper.VerificarConexion())
            {
                int ValorEncabezado = new PagosController().AddOrdenVentaEncabezado(int.Parse(ordenventa.empresa_miembro_id), int.Parse(ordenventa.moneda_id), int.Parse(ordenventa.impuesto_id), int.Parse(ordenventa.promocion_id), int.Parse(ordenventa.descuento_id), ordenventa.folio, Convert.ToDecimal(ordenventa.suma), Convert.ToDecimal(ordenventa.porcentajeDecuento), Convert.ToDecimal(ordenventa.descuento), Convert.ToDecimal(ordenventa.subTotal), Convert.ToDecimal(ordenventa.impuesto), Convert.ToDecimal(ordenventa.total), Convert.ToDecimal(ordenventa.pagado), Convert.ToDecimal(ordenventa.facturado));
                if (ValorEncabezado >= 0)
                {
                    foreach (CarritoComprasDetalle membresia in membresias)
                    {
                        int ValorDetalle = new PagosController().AddOrdenVentaDetalle(ValorEncabezado, membresia.Membresia_Id, membresia.Inscripcion_Membresia_Id, membresia.Lista_Precio_Membresia_Id, membresia.Producto_Id, membresia.Lista_Precio_Producto_Id, membresia.Carrito_Compras_Detalle_Descripcion, int.Parse(membresia.Carrito_Compras_Detalle_Cantidad), Convert.ToDecimal(membresia.Carrito_Compras_Detalle_Importe_Precio), Convert.ToDecimal(membresia.Carrito_Compras_Detalle_Importe_Prorrateo), Convert.ToDecimal(membresia.Carrito_Compras_Detalle_Importe_Suma), Convert.ToDecimal(membresia.Carrito_Compras_Detalle_Importe_Descuento), Convert.ToDecimal(membresia.Carrito_Compras_Detalle_Importe_Subtotal), Convert.ToDecimal(membresia.Carrito_Compras_Detalle_Importe_Impuesto), Convert.ToDecimal(membresia.Carrito_Compras_Detalle_Importe_Total), membresia.Tipo);
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
            this.GuardarPagoServer(ordenventaLocal, membresiasLocal);
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
            //throw new NotImplementedException();
        }
    }



}
