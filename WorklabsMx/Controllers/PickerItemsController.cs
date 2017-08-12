using System;
using System.Collections.Generic;
using WorklabsMx.Helpers;
using WorklabsMx.Models;

namespace WorklabsMx.Controllers
{
    public class PickerItemsController : DataBaseModel
    {
        /// <summary>
        /// Obtiene los generos
        /// </summary>
        /// <returns>Generos</returns>
        public List<string> GetGeneros()
        {
            List<string> generos = new List<string>();

            string query = "SELECT Genero_Descripcion FROM cat_Generos ORDER BY Genero_Descripcion";
            command = CreateCommand(query);
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    generos.Add(reader.GetString(0));
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

            return generos;
        }
        /// <summary>
        /// Obtiene los paises
        /// </summary>
        /// <returns>Paises</returns>
        public List<string> GetPaises()
        {
            List<string> paises = new List<string>();

            string query = "SELECT DISTINCT Territorio_Pais_Descripcion FROM vw_cat_Territorios ORDER BY Territorio_Pais_Descripcion";
            command = CreateCommand(query);
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    paises.Add(reader.GetString(0));
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

            return paises;
        }
        /// <summary>
        /// Obtiene los estados
        /// </summary>
        /// <returns>Estados</returns>
        /// <param name="pais">Pais seleccionado</param>
        public List<string> GetEstados(string pais)
        {
            List<string> estados = new List<string>();

            string query = "SELECT DISTINCT Territorio_Estado_Descripcion FROM vw_cat_Territorios " +
                "WHERE Territorio_Pais_Descripcion = @pais ORDER BY Territorio_Estado_Descripcion";
            command = CreateCommand(query);
            command.Parameters.AddWithValue("@pais", pais);
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    estados.Add(reader.GetString(0));
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

            return estados;
        }
        /// <summary>
        /// Obtiene los municipios
        /// </summary>
        /// <returns>Municipios</returns>
        /// <param name="estado">Estado seleccionado</param>
        public List<string> GetMunicipios(string estado)
        {
            List<string> municipios = new List<string>();

            string query = "SELECT DISTINCT Territorio_Municipio_Descripcion FROM vw_cat_Territorios " +
                "WHERE Territorio_Estado_Descripcion = @estado ORDER BY Territorio_Municipio_Descripcion";
            command = CreateCommand(query);
            command.Parameters.AddWithValue("@estado", estado);
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    municipios.Add(reader.GetString(0));
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

            return municipios;
        }
        /// <summary>
        /// Obtiene los giros de las empresas
        /// </summary>
        /// <returns>Giros de las empresas</returns>
        public List<string> GetGiros()
        {
            List<string> giros = new List<string>();

            string query = "SELECT Giro_Descripcion FROM cat_Miembros_Empresas_Giros ORDER BY Giro_Descripcion";
            command = CreateCommand(query);
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    giros.Add(reader.GetString(0));
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

            return giros;
        }
        /// <summary>
        /// Obtiene las colonias
        /// </summary>
        /// <returns>Colonias</returns>
        /// <param name="municipio">Municipio seleccionado</param>
        public List<string> GetColonias(string municipio)
        {
            List<string> colonias = new List<string>();

            string query = "SELECT DISTINCT Territorio_Colonia_Descripcion FROM vw_cat_Territorios " +
                "WHERE Territorio_Municipio_Descripcion = @municipio ORDER BY Territorio_Colonia_Descripcion";
            command = CreateCommand(query);
            command.Parameters.AddWithValue("@municipio", municipio);
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    colonias.Add(reader.GetString(0));
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

            return colonias;
        }
        /// <summary>
        /// Obtiene las sucursales
        /// </summary>
        /// <returns>Sucursales</returns>
        public List<string> GetSucursales()
        {
            List<string> sucursales = new List<string>();

            string query = "SELECT Sucursal_Descripcion FROM vw_cat_Sucursales ORDER BY Sucursal_Descripcion";
            command = CreateCommand(query);
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sucursales.Add(reader.GetString(0));
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

            return sucursales;
        }
        /// <summary>
        /// Obtiene las membresias disponibles.
        /// </summary>
        /// <returns>Membresias</returns>
        public List<MembresiaModel> GetMembresias()
        {
            List<MembresiaModel> membresias = new List<MembresiaModel>();

            string query = "select Membresia_Id, Membresia_Descripcion, " +
                "count(Distribucion_Membresia_Espacio) as Membresia_Espacios_Disponibles " +
                "FROM vw_cat_Membresias_Distribuciones_Disponibles " +
                "WHERE Distribucion_Membresia_Estatus = 1 " +
                "GROUP BY Membresia_Id, Membresia_Descripcion";
            command = CreateCommand(query);
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    MembresiaModel membresia = new MembresiaModel
                    {
                        Membresia_Id = reader["Membresia_Id"].ToString(),
                        Membresia_Descripcion = reader["Membresia_Descripcion"].ToString(),
                        Membresia_Espacios_Disponibles = reader["Membresia_Espacios_Disponibles"].ToString()
                    };
                    membresias.Add(membresia);
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

            return membresias;
        }

        public List<MembresiaModel> GetMembresiasPrecios(Dictionary<string, int> dictMembresias)
        {
            List<MembresiaModel> membresias = new List<MembresiaModel>();
            string membresias_id = string.Empty;
            foreach (KeyValuePair<string, int> key in dictMembresias)
            {
                if (key.Value != 0)
                    membresias_id += key.Key + ",";
            }
            string query = "SELECT Membresia_Id, Membresia_Descripcion, " +
                "Lista_Precio_Membresia_Precio_Base_Neto as Membresia_Precio_Base, " +
                "Lista_Precio_Membresia_Precio_Inscripcion_Neto as Membresia_Precio_Inscripcion " +
                "FROM vw_cat_Membresias_Listas_Precios " +
                " " +
                "WHERE Membresia_Id in (" + membresias_id.Substring(0, membresias_id.Length - 1) + ")";

            command = CreateCommand(query);
            //command.Parameters.AddWithValue("@productos_id", productos_id.Substring(0, productos_id.Length - 1));
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    MembresiaModel membresia = new MembresiaModel
                    {
                        Membresia_Id = reader["Membresia_Id"].ToString(),
                        Membresia_Descripcion = reader["Membresia_Descripcion"].ToString(),
                        Membresia_Precio_Base = reader["Membresia_Precio_Base"].ToString(),
                        Inscripcion_Precio_Base = reader["Membresia_Precio_Inscripcion"].ToString()
                    };
                    membresias.Add(membresia);
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

            return membresias;
        }

        public List<ProductoModel> GetProductos()
        {
            List<ProductoModel> productos = new List<ProductoModel>();

            string query = "select Producto_Id, Producto_Descripcion, Disponibilidad_Producto_Descripcion " +
                "FROM vw_cat_Productos " +
                "WHERE Producto_Estatus = 1 ";
            command = CreateCommand(query);
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ProductoModel producto = new ProductoModel
                    {
                        Producto_Id = reader["Producto_Id"].ToString(),
                        Producto_Descripcion = reader["Producto_Descripcion"].ToString(),
                        Producto_Disponibilidad = reader["Disponibilidad_Producto_Descripcion"].ToString()
                    };
                    productos.Add(producto);
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

            return productos;
        }

        public List<ProductoModel> GetProductosPrecios(Dictionary<string, int> dictProductos)
        {
            List<ProductoModel> productos = new List<ProductoModel>();
            string productos_id = string.Empty;
            foreach (KeyValuePair<string, int> key in dictProductos)
            {
                if (key.Value != 0)
                    productos_id += key.Key + ",";
            }
            string query = "SELECT Producto_Id, Producto_Descripcion, " +
                "Lista_Precio_Producto_Precio_Base_Neto as Producto_Precio_Base FROM vw_cat_Productos_Listas_Precios " +
                "Where Producto_Id in (" + productos_id.Substring(0, productos_id.Length - 1) + ")";

            command = CreateCommand(query);
            //command.Parameters.AddWithValue("@productos_id", productos_id.Substring(0, productos_id.Length - 1));
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ProductoModel producto = new ProductoModel
                    {
                        Producto_Id = reader["Producto_Id"].ToString(),
                        Producto_Descripcion = reader["Producto_Descripcion"].ToString(),
                        Producto_Precio_Base = reader["Producto_Precio_Base"].ToString()
                    };
                    productos.Add(producto);
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

            return productos;
        }


    }
}
