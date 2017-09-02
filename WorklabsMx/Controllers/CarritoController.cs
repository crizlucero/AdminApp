using System;
using System.Collections.Generic;
using System.Data;
using WorklabsMx.Helpers;
using WorklabsMx.Models;

namespace WorklabsMx.Controllers
{
    public class CarritoController : DataBaseModel
    {
        /// <summary>
        /// Gets the carrito.
        /// </summary>
        /// <returns>The carrito.</returns>
        /// <param name="miembro_id">Miembro identifier.</param>
        /// <param name="tipo">Tipo.</param>
        public Dictionary<string, CarritoModel> GetCarrito(string miembro_id, string tipo)
        {
            Dictionary<string, CarritoModel> carrito = new Dictionary<string, CarritoModel>();
            string query = "SELECT * FROM vw_pro_Carrito_Compras WHERE Miembro_Id = @miembro_id AND Pedido_Estatus = 1 ";
            switch (tipo)
            {
                case "Producto": query += " AND Producto_Id IS NOT NULL"; break;
                case "Membresia": query += " AND Membresia_Id IS NOT NULL"; break;
            }
            try
            {
                conn.Open();
                command = CreateCommand(query);
                command.Parameters.AddWithValue("@miembro_id", miembro_id);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (tipo == "Producto")
                    {
                        carrito.Add(reader["Producto_Id"].ToString(), new CarritoModel()
                        {
                            Pedido_Id = reader["Pedido_Id"].ToString(),
                            Miembro_Id = reader["Miembro_Id"].ToString(),
                            Producto_Id = reader["Producto_Id"].ToString(),
                            Producto_Cantidad = Convert.ToDouble(reader["Producto_Cantidad"].ToString()),
                            Pedido_Estatus = reader["Pedido_Estatus"].ToString(),
                            Precio_Base = reader["Lista_Precio_Producto_Precio_Prorrateo_Neto"].ToString(),
                            Dias_Prorrateo = (DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month) - DateTime.Now.Day).ToString(),//reader["Lista_Precio_Producto_Dias_Prorrateo"].ToString(),
                            Pedido_Total = reader["Lista_Precio_Producto_Precio_Prorrateo_Neto"].ToString()
                        });
                    }
                    else if (!string.IsNullOrEmpty(reader["Membresia_Id"].ToString()))
                    {
                        CarritoModel model = new CarritoModel();
                        model.Pedido_Id = reader["Pedido_Id"].ToString();
                        model.Miembro_Id = reader["Miembro_Id"].ToString();
                        model.Membresia_Id = reader["Membresia_Id"].ToString();
                        model.Membresia_Cantidad = Convert.ToDouble(reader["Membresia_Cantidad"].ToString());
                        model.Pedido_Estatus = reader["Pedido_Estatus"].ToString();
                        model.Precio_Base = reader["Lista_Precio_Membresia_Precio_Prorrateo_Neto"].ToString();
                        model.Dias_Prorrateo = (DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month) - DateTime.Now.Day).ToString();//reader["Lista_Precio_Producto_Dias_Prorrateo"].ToString(),
                        model.Pedido_Total = reader["Lista_Precio_Membresia_Precio_Prorrateo_Neto"].ToString();
                        carrito.Add(reader["Membresia_Id"].ToString(), model);
                    }
                }
            }
            catch (Exception e)
            {
                SlackLogs.SendMessage(e.Message);
            }
            finally { conn.Close(); }
            return carrito;
        }
        /// <summary>
        /// Updates the carrito.
        /// </summary>
        /// <param name="miembro_id">Miembro identifier.</param>
        /// <param name="producto_id">Producto identifier.</param>
        /// <param name="producto_cantidad">Producto cantidad.</param>
        /// <param name="membresia_id">Membresia identifier.</param>
        /// <param name="membresia_cantidad">Membresia cantidad.</param>
        /// <param name="pedido_estatus">Pedido estatus.</param>
        /// <param name="pedido_total">Pedido total.</param>
        public void UpdateCarrito(string miembro_id, string producto_id, string producto_cantidad,
                                  string membresia_id, string membresia_cantidad, string pedido_estatus, string pedido_total)
        {
            try
            {
                conn.Open();
                command = CreateCommand();
                command.Connection = conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_pro_Carrito_Compras";

                command.Parameters.AddWithValue("@miembro_id", miembro_id);
                command.Parameters.AddWithValue("@producto_id", producto_id);
                command.Parameters.AddWithValue("@producto_cantidad", producto_cantidad);
                command.Parameters.AddWithValue("@membresia_id", membresia_id);
                command.Parameters.AddWithValue("@membresia_cantidad", membresia_cantidad);
                command.Parameters.AddWithValue("@Pedido_Estatus", pedido_estatus);
                command.Parameters.AddWithValue("@Pedido_Total", pedido_total);

                transaction = conn.BeginTransaction();

                command.Transaction = transaction;
                command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception e)
            {
                SlackLogs.SendMessage(e.Message);
                transaction.Rollback();
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// Genera el encabezado de la orden de venta.
        /// </summary>
        /// <returns>Identificador del encabezado de la orden de venta</returns>
        /// <param name="empresa_miembro_id">Identificador de la empresa</param>
        /// <param name="moneda_id">Identificador de la moneda</param>
        /// <param name="impuesto_id">Identificador del impuesto </param>
        /// <param name="promocion_id">Identificador de la promoción</param>
        /// <param name="descuento_id">Identificador del descuento</param>
        /// <param name="folio">Folio de la orden de venta</param>
        /// <param name="suma">Cantidad total de productos</param>
        /// <param name="porcentajeDescuento">Porcentaje del descuento total</param>
        /// <param name="descuento">Descuento de la venta</param>
        /// <param name="subTotal">Subtotal de la venta</param>
        /// <param name="impuesto">Total de impuestos de la venta</param>
        /// <param name="total">Total de la venta</param>
        /// <param name="pagado">Cantidad de lo pagado</param>
        /// <param name="facturado">Cantidad de lo facturado</param>
        /// <param name="estatus">Estatus de la orden de venta</param>
        public int GenerarOrdenVentaEncabezado(string empresa_miembro_id, string moneda_id, string impuesto_id, string promocion_id, string descuento_id, string folio,
                                               string suma, string porcentajeDescuento, string descuento, string subTotal, string impuesto, string total, string pagado,
                                               string facturado, string estatus)
        {
            int encabezado_id = 0;
            try
            {
                conn.Open();
                command = CreateCommand();
                command.Connection = conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_pro_Orden_Venta_Encabezado";

                command.Parameters.AddWithValue("@Transaccion", "ALTA");
                command.Parameters.AddWithValue("@Empresa_Miembro_Id", empresa_miembro_id);
                command.Parameters.AddWithValue("@Moneda_Id", moneda_id);
                command.Parameters.AddWithValue("@Impuesto_Id", impuesto_id);
                command.Parameters.AddWithValue("@Promocion_Id", promocion_id);
                command.Parameters.AddWithValue("@Descuento_Id", descuento_id);
                command.Parameters.AddWithValue("@Orden_Venta_Encabezado_Folio", folio);
                command.Parameters.AddWithValue("@Orden_Venta_Encabezado_Importe_Suma", suma);
                command.Parameters.AddWithValue("@Orden_Venta_Encabezado_Porcentaje_Descuento", porcentajeDescuento);
                command.Parameters.AddWithValue("@Orden_Venta_Encabezado_Importe_Descuento", descuento);
                command.Parameters.AddWithValue("@Orden_Venta_Encabezado_Importe_Subtotal", subTotal);
                command.Parameters.AddWithValue("@Orden_Venta_Encabezado_Importe_Impuesto", impuesto);
                command.Parameters.AddWithValue("@Orden_Venta_Encabezado_Importe_Total", total);
                command.Parameters.AddWithValue("@Orden_Venta_Encabezado_Importe_Pagado", pagado);
                command.Parameters.AddWithValue("@Orden_Venta_Encabezado_Importe_Facturado", facturado);
                command.Parameters.AddWithValue("@Orden_Venta_Encabezado_Estatus", estatus);
                encabezado_id = Convert.ToInt32(command.Parameters["@Orden_Venta_Encabezado_Id_Salida"].Value);

                transaction = conn.BeginTransaction();

                command.Transaction = transaction;
                command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception e)
            {
                SlackLogs.SendMessage(e.Message);
                transaction.Rollback();
            }
            finally { conn.Close(); }
            return encabezado_id;
        }
        /// <summary>
        /// Genera el detalle de la orden de venta
        /// </summary>
        /// <returns>Identificador de los productos de la orden de venta</returns>
        /// <param name="detalle_id">Identificador del Detalle</param>
        /// <param name="encabezado_id">Identificador del encabezado de la orden de venta</param>
        /// <param name="membresia_id">Identificador de la Membresia</param>
        /// <param name="inscripcion_membresia_id">Identificador de la inscripcion de la membresia</param>
        /// <param name="precio_membresia_id">Identificador del precio de la membresia</param>
        /// <param name="producto_id">Identificador del Producto</param>
        /// <param name="precio_producto_id">Identificador del precio del producto</param>
        /// <param name="detalle_descripcion">Descripción del detalle</param>
        /// <param name="detalle_cantidad">Cantidad del producto</param>
        /// <param name="importe_precio">Importe del producto</param>
        /// <param name="importe_prorrateo">Importe de prorrateo del producto</param>
        /// <param name="importe_descuento">Importe del descuento del producto</param>
        /// <param name="importe_subtotal">Importe del subtotal del producto</param>
        /// <param name="importe_impuesto">Importe del impuesto del producto</param>
        /// <param name="importe_total">Importe del total del producto</param>
        /// <param name="estatus">Estatus del producto</param>
        public int GenerarOrdenVentaDetalle(string detalle_id, string encabezado_id, string membresia_id, string inscripcion_membresia_id, string precio_membresia_id, string producto_id,
                                             string precio_producto_id, string detalle_descripcion, string detalle_cantidad, string importe_precio, string importe_prorrateo,
                                             string importe_descuento, string importe_subtotal, string importe_impuesto, string importe_total, string estatus)
        {
            int detalle = 0;
            try
            {
                conn.Open();
                command = CreateCommand();
                command.Connection = conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_pro_Orden_Venta_Detalle";

                command.Parameters.AddWithValue("@Transaccion", "ALTA");
                command.Parameters.AddWithValue("@Orden_Venta_Detalle_Id", detalle_id);
                command.Parameters.AddWithValue("@Orden_Venta_Encabezado_Id", encabezado_id);
                command.Parameters.AddWithValue("@Membresia_Id", membresia_id);
                command.Parameters.AddWithValue("@Inscripcion_Membresia_Id", inscripcion_membresia_id);
                command.Parameters.AddWithValue("@Lista_Precio_Membresia_Id", precio_membresia_id);
                command.Parameters.AddWithValue("@Producto_Id", producto_id);
                command.Parameters.AddWithValue("@Lista_Precio_Producto_Id", precio_producto_id);
                command.Parameters.AddWithValue("@Orden_Venta_Detalle_Descripcion", detalle_descripcion);
                command.Parameters.AddWithValue("@Orden_Venta_Detalle_Cantidad", detalle_cantidad);
                command.Parameters.AddWithValue("@Orden_Venta_Detalle_Importe_Precio", importe_precio);
                command.Parameters.AddWithValue("@Orden_Venta_Detalle_Importe_Prorrateo", importe_prorrateo);
                command.Parameters.AddWithValue("@Orden_Venta_Detalle_Importe_Descuento", importe_descuento);
                command.Parameters.AddWithValue("@Orden_Venta_Detalle_Importe_Subtotal", importe_subtotal);
                command.Parameters.AddWithValue("@Orden_Venta_Detalle_Importe_Impuesto", importe_impuesto);
                command.Parameters.AddWithValue("@Orden_Venta_Detalle_Importe_Total", importe_total);
                command.Parameters.AddWithValue("@Orden_Venta_Detalle_Estatus", estatus);
                detalle = Convert.ToInt32(command.Parameters["@Orden_Venta_Detalle_Id_Salida"].Value);

                transaction = conn.BeginTransaction();

                command.Transaction = transaction;
                command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception e)
            {
                SlackLogs.SendMessage(e.Message);
                transaction.Rollback();
            }
            finally { conn.Close(); }
            return detalle;
        }
    }
}
