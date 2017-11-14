using System;
using System.Collections.Generic;
using System.Data;
using WorklabsMx.Helpers;
using WorklabsMx.Models;

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

        public bool AddOrdenVentaEncabezado(string miembro_id, string moneda_id, string impuesto_id, string promocion_id, string descuento_id, string folio, string importe_suma)
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
                command.Parameters.AddWithValue("@Promocion_Id", promocion_id);
                command.Parameters.AddWithValue("@Descuento_Id", descuento_id);
                command.Parameters.AddWithValue("@Orden_Venta_Encabezado_Folio", folio);
                command.Parameters.AddWithValue("@Orden_Venta_Encabezado_Importe_Suma", importe_suma);

                transaction = conn.BeginTransaction();

                command.Transaction = transaction;
                command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception e)
            {
                transaction.Rollback();
                SlackLogs.SendMessage(e.Message);
                return false;
            }
            finally { conn.Close(); }
            return true;
        }

        public bool AddOrdenVentaDetalle(string encabezado_id, string miembro_id, string Inscripcion_Membresia_Id, string Lista_Precio_Membresia_Id, string Producto_Id, string Lista_Precio_Producto_Id,
                                         string Orden_Venta_Detalle_Descripcion, string Orden_Venta_Detalle_Cantidad, string Orden_Venta_Detalle_Importe_Precio, string Orden_Venta_Detalle_Importe_Prorrateo,
                                         string Orden_Venta_Detalle_Importe_Suma, string Orden_Venta_Detalle_Importe_Descuento, string Orden_Venta_Detalle_Importe_Subtotal, string Orden_Venta_Detalle_Importe_Impuesto,
                                         string Orden_Venta_Detalle_Importe_Total, string Orden_Venta_Detalle_Estatus)
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
                command.Parameters.AddWithValue("@Membresia_Id", miembro_id);
                command.Parameters.AddWithValue("@Inscripcion_Membresia_Id", Inscripcion_Membresia_Id);
                command.Parameters.AddWithValue("@Lista_Precio_Membresia_Id", Lista_Precio_Membresia_Id);
                command.Parameters.AddWithValue("@Producto_Id", Producto_Id);
                command.Parameters.AddWithValue("@Lista_Precio_Producto_Id", Lista_Precio_Producto_Id);
                command.Parameters.AddWithValue("@Orden_Venta_Detalle_Descripcion", Orden_Venta_Detalle_Descripcion);
                command.Parameters.AddWithValue("@Orden_Venta_Detalle_Cantidad", Orden_Venta_Detalle_Cantidad);
                command.Parameters.AddWithValue("@Orden_Venta_Detalle_Importe_Precio", Orden_Venta_Detalle_Importe_Precio);
                command.Parameters.AddWithValue("@Orden_Venta_Detalle_Importe_Prorrateo", Orden_Venta_Detalle_Importe_Prorrateo);
                command.Parameters.AddWithValue("@Orden_Venta_Detalle_Importe_Suma", Orden_Venta_Detalle_Importe_Suma);
                command.Parameters.AddWithValue("@Orden_Venta_Detalle_Importe_Descuento", Orden_Venta_Detalle_Importe_Descuento);
                command.Parameters.AddWithValue("@Orden_Venta_Detalle_Importe_Subtotal", Orden_Venta_Detalle_Importe_Subtotal);
                command.Parameters.AddWithValue("@Orden_Venta_Detalle_Importe_Impuesto", Orden_Venta_Detalle_Importe_Impuesto);
                command.Parameters.AddWithValue("@Orden_Venta_Detalle_Importe_Total", Orden_Venta_Detalle_Importe_Total);
                command.Parameters.AddWithValue("@Orden_Venta_Detalle_Estatus", Orden_Venta_Detalle_Estatus);
                command.Parameters.Add("@Orden_Venta_Detalle_Id_Salida", SqlDbType.Int).Direction = ParameterDirection.Output;

                transaction = conn.BeginTransaction();

                command.Transaction = transaction;
                command.ExecuteNonQuery();
                transaction.Commit();
                int id = Convert.ToInt32(command.Parameters["@Orden_Venta_Detalle_Id_Salida"].Value);
            }
            catch (Exception e)
            {
                transaction.Rollback();
                SlackLogs.SendMessage(e.Message);
                return false;
            }
            finally { conn.Close(); }
            return true;
        }
    }
}
