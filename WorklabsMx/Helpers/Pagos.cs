using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using WorklabsMx.Controllers;
using WorklabsMx.Models;

namespace WorklabsMx.Helpers
{
    public class Pagos
    {
        List<ConfiguracionesModel> Parametros;
        public void GenerarPago()
        {
            Parametros = new ConfigurationsController().GetListConfiguraciones("6,12");

            string varEstatus = "Correcto|0";
            try
            {
                if (Parametros.Count > 0)
                {
                    //Cpnfiguración
                    string varServidor = Parametros[0].Parametro_Varchar_1;
                    string varIp = Parametros[0].Parametro_Varchar_2;
                    string varSolicitudUrl = Parametros[0].Parametro_Varchar_3;
                    string varCuenta = Parametros[0].Parametro_Varchar_4;
                    string varPuerto = Parametros[0].Parametro_Int_1;
                    string varVersion = Parametros[0].Parametro_Int_2;
                    string varTerminalId = Parametros[1].Parametro_Varchar_1;

                    //Transacción
                    string varTransaccionFecha = DateTime.Today.ToString("MMddyyyy");
                    string varCuentaDatos = "";
                    string varTransaccionCodigo = "";
                    string varSolicitudTipo = "";
                    decimal varPagoImportePagado = 0;
                    string varTransaccionImporte = Math.Truncate(varPagoImportePagado * 100).ToString();
                    string varSesionId = "";
                    string varOrdenVentaId = "";
                    string varMiembroId = "";

                    //Post
                    string varEnviar = "Request=" + varSolicitudTipo;
                    varEnviar += "&Version=" + varVersion;
                    varEnviar += "&HD.Network_Status_Byte=*";
                    varEnviar += "&HD.Application_ID=HZ0000GC";
                    varEnviar += "&HD.Terminal_ID=" + varTerminalId;
                    varEnviar += "&HD.Device_Tag=" + varSesionId;
                    varEnviar += "&01.POS_Entry_Capability=02";
                    varEnviar += "&01.Account_Entry_Mode=01";
                    varEnviar += "&01.Partial_Auth_Indicator=0";
                    varEnviar += "&01.Account_Data=" + varCuentaDatos;
                    varEnviar += "&01.Transaction_Amount=" + varTransaccionImporte;
                    varEnviar += "&10.CVV2_Indicator=9";
                    varEnviar += "&10.CVV2_Value=" + varTransaccionCodigo;
                    //varEnviar += "&11.Customer_Code=WL100000000000000"; //+ varMiembroId;
                    //varEnviar += "&12.Invoice_Number=" + varOrdenVentaId; //Este valor se utiliza para incluir la factura de la transacción local del TPV o el número de pedido. Este es un valor necesario para transacciones de pedido por correo y comercio electrónico.
                    //varEnviar += "&12.Shipping_Date=" + varTransaccionFecha; //El valor es la fecha en que se enviaron los bienes del consumidor.Este valor es la "Fecha de transacción" para las transacciones de marketing directo y de comercio electrónico.
                    byte[] varDatos = Encoding.ASCII.GetBytes(varEnviar);

                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    var varUrl = "https://" + varServidor + ":" + varPuerto + varSolicitudUrl;
                    var wbrSolicitud = (HttpWebRequest)WebRequest.Create(new Uri(varUrl));
                    wbrSolicitud.Method = "POST";
                    wbrSolicitud.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/60.0.3112.101 Safari/537.36";
                    wbrSolicitud.Host = varServidor + ":" + varPuerto;
                    wbrSolicitud.Accept = "application/x-www-form-urlencoded";
                    wbrSolicitud.ContentType = "application/x-www-form-urlencoded";
                    wbrSolicitud.ContentLength = varDatos.Length;
                    wbrSolicitud.Headers.Add("Registration-Key", varCuenta);

                    Stream srmDatosSolicitud = wbrSolicitud.GetRequestStream();
                    srmDatosSolicitud.Write(varDatos, 0, varDatos.Length);
                    srmDatosSolicitud.Close();

                    WebResponse wbrRespuesta = wbrSolicitud.GetResponse();
                    string varRespuestaEstatus = ((HttpWebResponse)wbrRespuesta).StatusDescription;

                    if (varRespuestaEstatus == "OK")
                    {
                        srmDatosSolicitud = wbrRespuesta.GetResponseStream();
                        StreamReader srmDatosRespuesta = new StreamReader(srmDatosSolicitud, Encoding.UTF8);

                        string varLinea = string.Empty;
                        string varTransaccionId = string.Empty;
                        string varTransaccionAutorizacion = string.Empty;
                        string varTransaccionNumero = string.Empty;
                        string varRespuestaCompleta = string.Empty;

                        while ((varLinea = srmDatosRespuesta.ReadLine()) != null)
                        {
                            if (varLinea.Contains("RD.Device_Tag="))
                            {
                                int varCaracterInicio = varLinea.IndexOf("=") + 1;
                                int varCaracterFin = varLinea.Length - varCaracterInicio;
                                varTransaccionId = varLinea.Substring(varCaracterInicio, varCaracterFin);
                            }

                            if (varLinea.Contains("02.Authorization_Response="))
                            {
                                int varCaracterInicio = varLinea.IndexOf("=") + 1;
                                int varCaracterFin = varLinea.Length - varCaracterInicio;
                                varTransaccionAutorizacion = varLinea.Substring(varCaracterInicio, varCaracterFin);
                            }

                            if (varLinea.Contains("02.Trace_Number="))
                            {
                                int varCaracterInicio = varLinea.IndexOf("=") + 1;
                                int varCaracterFin = varLinea.Length - varCaracterInicio;
                                varTransaccionNumero = varLinea.Substring(varCaracterInicio, varCaracterFin);
                            }

                            varRespuestaCompleta = varRespuestaCompleta + varLinea + "\r\n";
                        }

                        if (varTransaccionId == varSesionId)
                        {
                            if (string.IsNullOrEmpty(varRespuestaCompleta) == false)
                            {
                                ConfiguracionesModel rutaPagos = new ConfigurationsController().GetConfiguraciones("10");

                                if (rutaPagos.Equals(null))
                                {
                                    string varArchivo = "ID ORDEN DE VENTA " + varOrdenVentaId + ", ID MIEMBRO " + varMiembroId + ", ID SESION " + varSesionId + ".txt";

                                    if (varTransaccionAutorizacion == "APROBADA" || varTransaccionAutorizacion == "APPROVAL")
                                    {
                                        string varArchivoPago = Path.Combine("", rutaPagos.Parametro_Varchar_3 + varArchivo);
                                        File.WriteAllText(varArchivoPago, varRespuestaCompleta, Encoding.UTF8);
                                        varEstatus = "Correcto|" + varTransaccionNumero.Trim().Replace("02.Trace_Number=", "");
                                    }
                                    else
                                    {
                                        string varArchivoPago = Path.Combine("", rutaPagos.Parametro_Varchar_4 + varArchivo);
                                        File.WriteAllText(varArchivoPago, varRespuestaCompleta, Encoding.UTF8);
                                        varEstatus = "Incorrecto|0";
                                    }
                                }
                            }
                            else
                            {
                                varEstatus = "Incorrecto|0";
                            }
                        }
                        else
                        {
                            varEstatus = "Incorrecto|0";
                        }
                        srmDatosRespuesta.Close();
                    }
                    else
                    {
                        varEstatus = "Incorrecto|0";
                    }

                    srmDatosSolicitud.Close();
                    wbrRespuesta.Close();
                }
            }
            catch (Exception e) { SlackLogs.SendMessage(e.Message); }
        }
    }
}