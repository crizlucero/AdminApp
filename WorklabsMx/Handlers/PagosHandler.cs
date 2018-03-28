using System;
using System.Collections.Generic;
using System.Linq;
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
                connection = new SQLiteConnection(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/worklabs.db");
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
                DeleteRecords();
            }
        }

        public OrdenVentaEncabezado GetEncabezado()
        {
            OrdenVentaEncabezado encabezado = new OrdenVentaEncabezado();
            try
            {
                encabezado = connection.Table<OrdenVentaEncabezado>().First();
            }
            catch (Exception e)
            {
                SlackLogs.SendMessage(e.Message, GetType().Name, "GetEncabezado");
                this.DeleteRecords();
            }
            return encabezado;
        }

        public List<OrdenVentaDetalle> GetDetalles()
        {
            List<OrdenVentaDetalle> detalles = new List<OrdenVentaDetalle>();
            try
            {
                detalles = connection.Table<OrdenVentaDetalle>().ToList();
            }
            catch (Exception e)
            {
                SlackLogs.SendMessage(e.Message, GetType().Name, "GetDetalles");
                this.DeleteRecords();
            }
            return detalles;
        }

        public bool DeleteRecords()
        {
            try
            {
                connection.DeleteAll<OrdenVentaEncabezado>();
                connection.DeleteAll<OrdenVentaDetalle>();
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
