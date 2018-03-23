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
<<<<<<< HEAD
                encabezado = connection.Get<OrdenVentaEncabezado>("SELECT * FROM OrdenVentaEncabezado");
=======
                encabezado = connection.Table<OrdenVentaEncabezado>().First();
>>>>>>> 4ddbc7ed5c2fe7a7fa43f8e21beecc39549495e7
            }
            catch (Exception e)
            {
                SlackLogs.SendMessage(e.Message, GetType().Name, "GetEncabezado");
<<<<<<< HEAD
                this.DeleteRecords();
=======
                DeleteRecords();
>>>>>>> 4ddbc7ed5c2fe7a7fa43f8e21beecc39549495e7
            }
            return encabezado;
        }

        public List<OrdenVentaDetalle> GetDetalles()
        {
            List<OrdenVentaDetalle> detalles = new List<OrdenVentaDetalle>();
            try
            {
<<<<<<< HEAD
                detalles = connection.Get<List<OrdenVentaDetalle>>("SELECT * FROM OrdenVentaDetalle");
=======
                detalles = connection.Table<OrdenVentaDetalle>().ToList();
>>>>>>> 4ddbc7ed5c2fe7a7fa43f8e21beecc39549495e7
            }
            catch (Exception e)
            {
                SlackLogs.SendMessage(e.Message, GetType().Name, "GetDetalles");
<<<<<<< HEAD
                this.DeleteRecords();
=======
                DeleteRecords();
>>>>>>> 4ddbc7ed5c2fe7a7fa43f8e21beecc39549495e7
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
