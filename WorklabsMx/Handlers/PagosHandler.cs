using System;
using System.Collections.Generic;
using SQLite;
using WorklabsMx.Helpers;
using WorklabsMx.Models;

namespace WorklabsMx.Handlers
{
    public class PagosHandler
    {
        readonly SQLiteConnection connection;
        public PagosHandler()
        {
            try
            {
                connection = new SQLiteConnection(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+ "worklabs.db");
                connection.CreateTable<OrdenVentaEncabezado>();
                connection.CreateTable<OrdenVentaDetalle>();
            }
            catch (Exception e)
            {
                SlackLogs.SendMessage(e.Message, GetType().Name, "PagosHandler");
            }
        }

        public void InsertData(OrdenVentaEncabezado encabezado, List<OrdenVentaDetalle> detalles)
        {
            try
            {
                if (connection.Insert(encabezado) != 0)
                    connection.Update(encabezado);
                detalles.ForEach(detalle =>
                {
                    detalle.Orden_Venta_Encabezado_Id = encabezado.Orden_Venta_Encabezado_Id;
                    if (connection.Insert(detalle) != 0)
                        connection.Update(detalle);
                });
            }
            catch (Exception e)
            {
                SlackLogs.SendMessage(e.Message, GetType().Name, "InsertData");
            }
        }

        public OrdenVentaEncabezado GetEncabezado()
        {
            OrdenVentaEncabezado encabezado = new OrdenVentaEncabezado();
            try
            {
                encabezado = connection.ExecuteScalar<OrdenVentaEncabezado>("SELECT * FROM OrdenVentaEncabezado");
            }
            catch (Exception e)
            {
                SlackLogs.SendMessage(e.Message, GetType().Name, "GetEncabezado");
            }
            return encabezado;
        }

        public List<OrdenVentaDetalle> GetDetalles()
        {
            List<OrdenVentaDetalle> detalles = new List<OrdenVentaDetalle>();
            try
            {
                detalles = connection.ExecuteScalar<List<OrdenVentaDetalle>>("SELECT * FROM OrdenVentaDetalle");
            }
            catch (Exception e)
            {
                SlackLogs.SendMessage(e.Message, GetType().Name, "GetDetalles");
            }
            return detalles;
        }

        public bool DeleteRecords()
        {
            try
            {
                connection.DropTable<OrdenVentaEncabezado>();
                connection.DropTable<OrdenVentaDetalle>();
            }
            catch (Exception e)
            {
                SlackLogs.SendMessage(e.Message, GetType().Name, "DeleteRecords");
                return false;
            }
            return true;
        }
    }
}
