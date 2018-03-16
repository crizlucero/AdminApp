using System;
using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using Com.Mitec.Suitemcommerce.Beans;
using WorklabsMx.Controllers;
using WorklabsMx.Droid.Models;
using WorklabsMx.Handlers;
using WorklabsMx.Models;

namespace WorklabsMx.Droid
{
    [Activity(Label = "ResultActivity")]
    public class ResultActivity : Activity
    {
        ImageView imageResult;
        TextView reference, response, auth, error, ccName, ccNum, amount, type;
        BeanResponse beanPaymentResponse;
        /*Token response*/
        BeanTokenizeResponse beanTokenizeResponse;

        /*Payment with token*/
        BeanPaymentWithToken beanPaymentWithToken;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ResultPaymentLayout);

            imageResult = (ImageView)FindViewById(Resource.Id.imageResponse);
            reference = (TextView)FindViewById(Resource.Id.reference);
            response = (TextView)FindViewById(Resource.Id.response);
            auth = (TextView)FindViewById(Resource.Id.auth);
            error = (TextView)FindViewById(Resource.Id.error);
            ccName = (TextView)FindViewById(Resource.Id.name);
            ccNum = (TextView)FindViewById(Resource.Id.number);
            amount = (TextView)FindViewById(Resource.Id.amount);
            type = (TextView)FindViewById(Resource.Id.type);


            beanPaymentResponse = (BeanResponse)Intent.GetSerializableExtra("beanPaymentResponse");
            beanTokenizeResponse = (BeanTokenizeResponse)Intent.GetSerializableExtra("beanTokenizeResponse");
            beanPaymentWithToken = (BeanPaymentWithToken)Intent.GetSerializableExtra("beanPaymentWithToken");
            LinearLayout linearLayoutError = FindViewById<LinearLayout>(Resource.Id.layoutError);
            LinearLayout linearLayoutAuth = FindViewById<LinearLayout>(Resource.Id.layoutAuth);
            LinearLayout linearLayoutNumber = FindViewById<LinearLayout>(Resource.Id.layoutNumber);
            LinearLayout linearLayoutType = FindViewById<LinearLayout>(Resource.Id.layoutType);
            LinearLayout linearLayoutName = FindViewById<LinearLayout>(Resource.Id.layoutName);
            LinearLayout linearLayoutAmount = FindViewById<LinearLayout>(Resource.Id.layoutAmount);
            LinearLayout linearLayoutReference = FindViewById<LinearLayout>(Resource.Id.layoutReference);

            /**Payment response*/
            if (beanPaymentResponse != null)
            {
                if (beanPaymentResponse.getResponse().Equals("approved"))
                {
                    imageResult.SetImageResource(Resource.Mipmap.ic_like);
                    linearLayoutError.Visibility = ViewStates.Gone;
                }
                else
                {
                    linearLayoutError.Visibility = ViewStates.Visible;
                    linearLayoutAuth.Visibility = ViewStates.Gone;
                    linearLayoutNumber.Visibility = ViewStates.Gone;
                    linearLayoutType.Visibility = ViewStates.Gone;
                    linearLayoutAmount.Visibility = ViewStates.Gone;
                }

                reference.Text = (beanPaymentResponse.getReference());
                response.Text = (beanPaymentResponse.getResponse());
                auth.Text = (beanPaymentResponse.getAuth());
                error.Text = (beanPaymentResponse.getError());
                ccName.Text = (beanPaymentResponse.getCcName());
                ccNum.Text = (beanPaymentResponse.getCcNum());
                amount.Text = (beanPaymentResponse.getAmount());
                type.Text = (beanPaymentResponse.getType());
            }
            /**Tokenize response*/
            if (beanTokenizeResponse != null)
            {
                if (beanTokenizeResponse.NbResponse.Equals("success"))
                {
                    imageResult.SetImageResource(Resource.Mipmap.ic_like);
                    linearLayoutError.Visibility = ViewStates.Gone;
                }
                else
                {
                    linearLayoutReference.Visibility = ViewStates.Gone;

                }
                TextView labelRefence = FindViewById<TextView>(Resource.Id.labelReference);
                labelRefence.Text = "Token";
                reference.Text = (beanTokenizeResponse.Token);
                response.Text = (beanTokenizeResponse.NbResponse);

                linearLayoutAuth.Visibility = ViewStates.Gone;
                linearLayoutNumber.Visibility = ViewStates.Gone;
                linearLayoutType.Visibility = ViewStates.Gone;
                linearLayoutError.Visibility = ViewStates.Gone;
                linearLayoutName.Visibility = ViewStates.Gone;
                linearLayoutAmount.Visibility = ViewStates.Gone;
            }
            /**Payment with token response*/
            if (beanPaymentWithToken != null)
            {
                if (beanPaymentWithToken.Response.Equals("approved"))
                {
                    imageResult.SetImageResource(Resource.Mipmap.ic_like);
                    linearLayoutError.Visibility = ViewStates.Gone;
                    linearLayoutName.Visibility = ViewStates.Gone;
                    linearLayoutNumber.Visibility = ViewStates.Gone;
                    TextView labelType = FindViewById<TextView>(Resource.Id.labelType);
                    labelType.Text = ("Folio");
                    type.Text = (beanPaymentWithToken.Folio);
                }
                else
                {
                    linearLayoutAuth.Visibility = ViewStates.Gone;
                    linearLayoutNumber.Visibility = ViewStates.Gone;
                    linearLayoutType.Visibility = ViewStates.Gone;
                    linearLayoutName.Visibility = ViewStates.Gone;
                    linearLayoutAmount.Visibility = ViewStates.Gone;
                }
                reference.Text = (beanPaymentWithToken.Reference);
                response.Text = (beanPaymentWithToken.Response);
                if (beanPaymentWithToken.Response.Equals("denied"))
                    error.Text = (beanPaymentWithToken.CdResponse);
                else
                    error.Text = (beanPaymentWithToken.NbError);
                amount.Text = (beanPaymentWithToken.Amount);
                reference.Text = (beanPaymentWithToken.Reference);
                auth.Text = (beanPaymentWithToken.Auth);
            }
        }

        void AgregarRegistro(bool pagado)
        {
            PagosController controller = new PagosController();
            PagosHandler pagos = new PagosHandler();
            OrdenVentaEncabezado encabezado = pagos.GetEncabezado();
            List<OrdenVentaDetalle> detalles = pagos.GetDetalles();
            if (pagado)
            {
                encabezado.Importe_Pagado = encabezado.Importe_Total;
                pagos.InsertData(encabezado, detalles);
            }

            int Encabezado_Id = controller.AddOrdenVentaEncabezado(Convert.ToInt32(encabezado.Usuario.Usuario_Id), encabezado.Moneda_Id, encabezado.Impuesto_Id, encabezado.Descuento_Id, encabezado.Descuento_Id, encabezado.Folio,
                                                                   encabezado.Importe_Suma, encabezado.Porcentaje_Descuento, encabezado.Importe_Descuento, encabezado.Importe_Subtotal, encabezado.Importe_Impuesto,
                                                                   encabezado.Importe_Total, encabezado.Importe_Pagado, 0);
            if (Encabezado_Id != -1)
            {
                detalles.ForEach(detalle =>
                {
                    controller.AddOrdenVentaDetalle(Encabezado_Id, detalle.Membresia_Id, detalle.Inscripcion_Membresia_Id,
                                                    detalle.Lista_Precio_Membresia_Id, detalle.Producto_Id, detalle.Lista_Precio_Producto_Id,
                                                    detalle.Orden_Venta_Detalle_Descripcion, detalle.Orden_Venta_Detalle_Cantidad,
                                                    detalle.Orden_Venta_Detalle_Importe_Precio, detalle.Orden_Venta_Detalle_Importe_Prorrateo,
                                                    detalle.Orden_Venta_Detalle_Importe_Suma, detalle.Orden_Venta_Detalle_Importe_Descuento,
                                                    detalle.Orden_Venta_Detalle_Importe_Subtotal, detalle.Orden_Venta_Detalle_Importe_Impuesto,
                                                    detalle.Orden_Venta_Detalle_Importe_Total, detalle.Tipos_Servicios);
                });
            }
        }
    }
}
