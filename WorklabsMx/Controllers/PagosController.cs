using System;
using System.Collections.Generic;
using System.Data;
using WorklabsMx.Enum;
using WorklabsMx.Helpers;
using WorklabsMx.Models;
using WorklabsMx.Models.Pagos;

namespace WorklabsMx.Controllers
{
    public class PagosController : DataBaseModel
    {
        public PromocionModel AplicarCupon(string cupon)
        {
            PromocionModel promo = new PromocionModel();
            string query = "SELECT Descuento_Id, Promocion_Descripcion, Descuento_Descripcion, Descuento_Porcentaje, Codigo_Promocion_Descripcion " +
                "FROM vw_cat_Promociones_Codigos WHERE Codigo_Promocion_Descripcion = @cupon AND " +
                "GETDATE() Between Promocion_Fecha_Inicio AND Promocion_Fecha_Fin";
            command = CreateCommand(query);
            command.Parameters.AddWithValue("@cupon", cupon);
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    promo = new PromocionModel
                    {
                        Descuento_Id = reader["Descuento_Id"].ToString(),
                        Descuento_Descripcion = reader["Descuento_Descripcion"].ToString(),
                        Descuento_Porcentaje = Convert.ToDecimal(reader["Descuento_Porcentaje"].ToString()),
                        Promocion_Descripcion = reader["Promocion_Descripcion"].ToString(),
                        Codigo_Promocion_Descripcion = reader["Codigo_Promocion_Descripcion"].ToString()
                    };
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                SlackLogs.SendMessage(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return promo;
        }

        public List<RenovacionPagosModel> GetRenovaciones()
        {
            List<RenovacionPagosModel> renovaciones = new List<RenovacionPagosModel>();
            string query = "SELECT * FROM vw_pro_Miembros_Productos_Servicios_Renovacion_Morosos";
            try
            {
                conn.Open();
                command = CreateCommand(query);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    renovaciones.Add(new RenovacionPagosModel
                    {
                        Empresa_Id = reader["Membresia_Miembro_Id"].ToString(),
                        Num_Tarjeta = reader["Transaccion_Pago_Tarjeta"].ToString(),
                        Fecha_Vencimiento = reader["Transaccion_Pago_Tarjeta_Vencimiento"].ToString(),
                        Monto_Pagar = reader["Transaccion_Pago_Importe"].ToString(),
                        Titular = reader["Transaccion_Pago_Titular"].ToString()
                    });
                }
            }
            catch (Exception e) { SlackLogs.SendMessage(e.Message); }
            finally { conn.Close(); }

            return renovaciones;
        }

        public int AddOrdenVentaEncabezado(int miembro_id, int moneda_id, int impuesto_id, int promocion_id, int descuento_id, string folio, decimal importe_suma, decimal porcentaje_descuento,
                                           decimal importe_descuento, decimal importe_subtotal, decimal importe_impuesto, decimal importe_total, decimal importe_pagado, decimal importe_facturado)
        {
            try
            {
                conn.Open();
                command = CreateCommand();
                command.Connection = conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_pro_Orden_Venta_Encabezado";

                command.Parameters.AddWithValue("@Trasaccion", "ALTA");
                command.Parameters.AddWithValue("@Orden_Venta_Encabezado_Id", DBNull.Value);
                command.Parameters.AddWithValue("@Empresa_Miembro_Id", miembro_id);
                command.Parameters.AddWithValue("@Moneda_Id", moneda_id);
                command.Parameters.AddWithValue("@Impuesto_Id", impuesto_id);
                if (promocion_id != 0)
                {
                    command.Parameters.AddWithValue("@Promocion_Id", promocion_id);
                    command.Parameters.AddWithValue("@Descuento_Id", descuento_id);
                }
                command.Parameters.AddWithValue("@Orden_Venta_Encabezado_Folio", folio);
                command.Parameters.AddWithValue("@Orden_Venta_Encabezado_Importe_Suma", importe_suma);
                command.Parameters.AddWithValue("@Orden_Venta_Encabezado_Porcentaje_Descuento", porcentaje_descuento);
                command.Parameters.AddWithValue("@Orden_Venta_Encabezado_Importe_Descuento", importe_descuento);
                command.Parameters.AddWithValue("@Orden_Venta_Encabezado_Importe_Subtotal", importe_subtotal);
                command.Parameters.AddWithValue("@Orden_Venta_Encabezado_Importe_Impuesto", importe_impuesto);
                command.Parameters.AddWithValue("@Orden_Venta_Encabezado_Importe_Total", importe_total);
                command.Parameters.AddWithValue("@Orden_Venta_Encabezado_Importe_Pagado", importe_pagado);
                command.Parameters.AddWithValue("@Orden_Venta_Encabezado_Importe_Facturado", importe_facturado);
                command.Parameters.AddWithValue("@Orden_Venta_Encabezado_Estatus", 1);
                command.Parameters.Add("@Orden_Venta_Encabezado_Id_Salida", SqlDbType.Int).Direction = ParameterDirection.Output;

                transaction = conn.BeginTransaction();

                command.Transaction = transaction;
                command.ExecuteNonQuery();
                transaction.Commit();
                return Convert.ToInt32(command.Parameters["@Orden_Venta_Encabezado_Id_Salida"].Value);
            }
            catch (Exception e)
            {
                transaction.Rollback();
                SlackLogs.SendMessage(e.Message);
                return -1;
            }
            finally { conn.Close(); }
        }

        public int AddOrdenVentaDetalle(int encabezado_id, string Membresia_Id, string Inscripcion_Membresia_Id, string Lista_Precio_Membresia_Id, string Producto_Id, string Lista_Precio_Producto_Id,
                                         string Orden_Venta_Detalle_Descripcion, int Orden_Venta_Detalle_Cantidad, decimal Orden_Venta_Detalle_Importe_Precio, decimal Orden_Venta_Detalle_Importe_Prorrateo,
                                         decimal Orden_Venta_Detalle_Importe_Suma, decimal Orden_Venta_Detalle_Importe_Descuento, decimal Orden_Venta_Detalle_Importe_Subtotal, decimal Orden_Venta_Detalle_Importe_Impuesto,
                                         decimal Orden_Venta_Detalle_Importe_Total, TiposServicios tipo)
        {
            try
            {
                conn.Open();
                command = CreateCommand();
                command.Connection = conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_pro_Orden_Venta_Detalle";

                command.Parameters.AddWithValue("@Trasaccion", "ALTA");
                command.Parameters.AddWithValue("@Orden_Venta_Detalle_Id", DBNull.Value);
                command.Parameters.AddWithValue("@Orden_Venta_Encabezado_Id", encabezado_id);
                if (tipo == TiposServicios.Membresia)
                {
                    if (!string.IsNullOrEmpty(Membresia_Id))
                        command.Parameters.AddWithValue("@Membresia_Id", Membresia_Id);
                    if (!string.IsNullOrEmpty(Membresia_Id))
                        command.Parameters.AddWithValue("@Inscripcion_Membresia_Id", Inscripcion_Membresia_Id);
                    command.Parameters.AddWithValue("@Lista_Precio_Membresia_Id", Lista_Precio_Membresia_Id);
                }
                else if (tipo == TiposServicios.Producto)
                {
                    command.Parameters.AddWithValue("@Producto_Id", Producto_Id);
                    command.Parameters.AddWithValue("@Lista_Precio_Producto_Id", Lista_Precio_Producto_Id);
                }

                command.Parameters.AddWithValue("@Orden_Venta_Detalle_Descripcion", Orden_Venta_Detalle_Descripcion);
                command.Parameters.AddWithValue("@Orden_Venta_Detalle_Cantidad", Orden_Venta_Detalle_Cantidad);
                command.Parameters.AddWithValue("@Orden_Venta_Detalle_Importe_Precio", Orden_Venta_Detalle_Importe_Precio);
                command.Parameters.AddWithValue("@Orden_Venta_Detalle_Importe_Prorrateo", Orden_Venta_Detalle_Importe_Prorrateo);
                command.Parameters.AddWithValue("@Orden_Venta_Detalle_Importe_Suma", Orden_Venta_Detalle_Importe_Suma);
                command.Parameters.AddWithValue("@Orden_Venta_Detalle_Importe_Descuento", Orden_Venta_Detalle_Importe_Descuento);
                command.Parameters.AddWithValue("@Orden_Venta_Detalle_Importe_Subtotal", Orden_Venta_Detalle_Importe_Subtotal);
                command.Parameters.AddWithValue("@Orden_Venta_Detalle_Importe_Impuesto", Orden_Venta_Detalle_Importe_Impuesto);
                command.Parameters.AddWithValue("@Orden_Venta_Detalle_Importe_Total", Orden_Venta_Detalle_Importe_Total);
                command.Parameters.AddWithValue("@Orden_Venta_Detalle_Estatus", 1);
                command.Parameters.Add("@Orden_Venta_Detalle_Id_Salida", SqlDbType.Int).Direction = ParameterDirection.Output;

                transaction = conn.BeginTransaction();

                command.Transaction = transaction;
                command.ExecuteNonQuery();
                transaction.Commit();
                return Convert.ToInt32(command.Parameters["@Orden_Venta_Detalle_Id_Salida"].Value);
            }
            catch (Exception e)
            {
                transaction.Rollback();
                SlackLogs.SendMessage(e.Message);
                return -1;
            }
            finally { conn.Close(); }
        }

        public string GetUrlPayment(string monto)
        {
            string response = "";
            try
            {
                string xml = "<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>" +
                             "<P>" +
                             "<business>" +
                             "<id_company>0001</id_company>" +
                             "<id_branch>0001</id_branch>" +
                             "<user>0001USER</user>" +
                             "<pwd>SECRETO</pwd>" +
                             "</business>" +
                             "<url>" +
                             "<reference>FACTURA001</reference>" +
                             "<amount>" + monto + "</amount>" +
                             "<moneda>MXN</moneda>" +
                             "<canal>W</canal>" +
                             "<omitir_notif_default>1</omitir_notif_default>" +
                             "<st_correo>1</st_correo>" +
                             "<mail_cliente>tarjetahabiente@correo.com.mx</mail_cliente>" +
                             "<datos_adicionales>" +
                             "<data id=\"1\" display=\"true\">" +
                             "<label>Nombre</label>" +
                             "<value>EL CLIENTE</value>" +
                             "</data>" +
                             "</datos_adicionales>" +
                             "</url>" +
                             "</P>";
                /*P p = new P
                {
                    bussiness = new bussiness
                    {
                        id_company = "0001",
                        id_branch = "0001",
                        user = "0001USER",
                        pwd = "SECRETO"
                    },
                    url = new url
                    {
                        reference = "FACTURA001",
                        amount = monto,
                        moneda = "MXN",
                        mail_cliente = "christian.lucero@worklabs.mx",
                        datos_adicionales = new datos_adicionales
                        {
                            data = new data
                            {
                                label = "Nombre",
                                value = "EL CLIENTE"
                            }
                        }
                    }
                };*/

                string PostToSend = "<pgs><data0>1234ABCD</data0><data>" + PassSecurity.EncryptAES128(xml, "SECRETO") + "</data></pgs>";
                response = new HttpRequest().POST("https://qa5.mitec.com.mx/p/gen", PostToSend);

            }
            catch (Exception e) { SlackLogs.SendMessage(e.Message); }
            return response;

        }
    }
}
