using System;
using System.Collections.Generic;
using WorklabsMx.Helpers;
using WorklabsMx.Models;

namespace WorklabsMx.Controllers
{
    public class SuscripcionesController : DataBaseModel
    {
        public List<MembresiaModel> GetMembresiasContratadas(string usuario_id)
        {
            List<MembresiaModel> membresias = new List<MembresiaModel>();
            string query = "";
            try
            {
                conn.Open();
                command = CreateCommand(query);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    membresias.Add(new MembresiaModel
                    {
                        Membresia_Id = reader["Membresia_Id"].ToString(),
                        Membresia_Descripcion = reader["Membresia_Descriocion"].ToString()
                    });
                }
            }
            catch (Exception e) { SlackLogs.SendMessage(e.Message, GetType().Name, "GetMembresiasContratadas"); }
            finally { conn.Close(); }
            return membresias;
        }

        public List<ProductoModel> GetProductosContratados(string usuario_id)
        {
            List<ProductoModel> productos = new List<ProductoModel>();
            string query = "";
            try
            {
                conn.Open();
                command = CreateCommand(query);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    productos.Add(new ProductoModel
                    {
                        Producto_Id = reader["Producto_Id"].ToString(),
                        Producto_Descripcion = reader["Producto_Descripcion"].ToString()
                    });
                }
            }
            catch (Exception e) { SlackLogs.SendMessage(e.Message, GetType().Name, "GetProductosContratados"); }
            finally { conn.Close(); }
            return productos;
        }
    }
}
