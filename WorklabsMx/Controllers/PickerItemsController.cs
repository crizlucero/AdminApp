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

        public int GetGiroId(string giro)
        {
            string query = "SELECT Giro_Id FROM cat_Miembros_Empresas_Giros WHERE Giro_Descripcion = @giro";
            command = CreateCommand(query);
            command.Parameters.AddWithValue("@giro", giro);
            try
            {
                conn.Open();
                return Convert.ToInt32(command.ExecuteScalar().ToString());
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
            return -1;
        }
        /// <summary>
        /// Obtiene las colonias
        /// </summary>
        /// <returns>Colonias</returns>
        /// <param name="municipio">Municipio seleccionado</param>
        public List<string> GetColonias(string codigopostal)
        {
            List<string> colonias = new List<string>();

            string query = "SELECT DISTINCT Territorio_Colonia_Descripcion FROM vw_cat_Territorios " +
                "WHERE Territorio_Cp = @codigopostal ORDER BY Territorio_Colonia_Descripcion";
            command = CreateCommand(query);
            command.Parameters.AddWithValue("@codigopostal", codigopostal);
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

        public int GetColonia(string colonia)
        {
            string query = "SELECT Territorio_Colonia_Id FROM vw_cat_Territorios WHERE Territorio_Colonia_Descripcion = @colonia";
            try
            {
                command = CreateCommand(query);
                command.Parameters.AddWithValue("@colonia", colonia);
                conn.Open();
                return Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception e)
            {
                SlackLogs.SendMessage(e.Message);
            }
            finally { conn.Close(); }
            return -1;
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

            string query = "select mdd.Membresia_Id, mdd.Membresia_Descripcion, " +
                "count(Distribucion_Membresia_Espacio) as Membresia_Espacios_Disponibles, " +
                "mlp.Lista_Precio_Membresia_Precio_Base_Neto, mlp.Lista_Precio_Membresia_Precio_Inscripcion_Neto, " +
                "mlp.Lista_Precio_Membresia_Precio_Base, mlp.Lista_Precio_Membresia_Precio_Inscripcion," +
                "mlp.Lista_Precio_Membresia_Precio_Prorrateo " +
                "FROM vw_cat_Membresias_Distribuciones_Disponibles AS mdd " +
                "INNER JOIN vw_cat_Membresias_Listas_Precios AS mlp ON mlp.Membresia_Id = mdd.Membresia_Id " +
                "WHERE mdd.Distribucion_Membresia_Estatus = 1 " +
                "GROUP BY mdd.Membresia_Id, mdd.Membresia_Descripcion, mlp.Lista_Precio_Membresia_Precio_Base_Neto, mlp.Lista_Precio_Membresia_Precio_Inscripcion_Neto, " +
                "mlp.Lista_Precio_Membresia_Precio_Base, mlp.Lista_Precio_Membresia_Precio_Inscripcion, mlp.Lista_Precio_Membresia_Precio_Prorrateo";
            command = CreateCommand(query);
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    membresias.Add(new MembresiaModel
                    {
                        Membresia_Id = reader["Membresia_Id"].ToString(),
                        Membresia_Descripcion = reader["Membresia_Descripcion"].ToString(),
                        Membresia_Espacios_Disponibles = reader["Membresia_Espacios_Disponibles"].ToString(),
                        Membresia_Precio_Base_Neto = Convert.ToDouble(reader["Lista_Precio_Membresia_Precio_Base_Neto"]),
                        Inscripcion_Precio_Base_Neto = Convert.ToDouble(reader["Lista_Precio_Membresia_Precio_Inscripcion_Neto"]),
                        Membresia_Precio_Base = Convert.ToDouble(reader["Lista_Precio_Membresia_Precio_Base"]),
                        Inscripcion_Precio_Base = Convert.ToDouble(reader["Lista_Precio_Membresia_Precio_Inscripcion"]),
                        Membresia_Precio_Prorrateo = Convert.ToDouble(reader["Lista_Precio_Membresia_Precio_Prorrateo"])
                    });
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
            try
            {
                string membresias_id = string.Empty;
                foreach (KeyValuePair<string, int> key in dictMembresias)
                {
                    if (key.Value != 0)
                        membresias_id += key.Key + ",";
                }
                string query = "SELECT Membresia_Id, Membresia_Descripcion, " +
                    "Lista_Precio_Membresia_Precio_Base_Neto as Membresia_Precio_Base, " +
                    "Lista_Precio_Membresia_Precio_Inscripcion_Neto as Membresia_Precio_Inscripcion, " +
                    "Lista_Precio_Membresia_Precio_Prorrateo as Membresia_Precio_Prorrateo " +
                    "FROM vw_cat_Membresias_Listas_Precios " +
                    " " +
                    "WHERE Membresia_Id in (" + membresias_id.Substring(0, membresias_id.Length - 1) + ")";

                command = CreateCommand(query);
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    membresias.Add(new MembresiaModel
                    {
                        Membresia_Id = reader["Membresia_Id"].ToString(),
                        Membresia_Descripcion = reader["Membresia_Descripcion"].ToString(),
                        Membresia_Precio_Base = Convert.ToDouble(reader["Membresia_Precio_Base"]),
                        Inscripcion_Precio_Base = Convert.ToDouble(reader["Membresia_Precio_Inscripcion"]),
                        Membresia_Precio_Prorrateo = Convert.ToDouble(reader["Membresia_Precio_Prorrateo"]),
                    });
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

            string query = "select p.Producto_Id, p.Producto_Descripcion, p.Disponibilidad_Producto_Descripcion, " +
                "plp.Lista_Precio_Producto_Precio_Base_Neto, " +
                "plp.Lista_Precio_Producto_Precio_Base " +
                "FROM vw_cat_Productos AS p INNER JOIN vw_cat_Productos_Listas_Precios AS plp " +
                "ON p.Producto_Id = plp.Lista_Precio_Producto_Id " +
                "WHERE Producto_Estatus = 1 ORDER BY Disponibilidad_Producto_Descripcion";
            command = CreateCommand(query);
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    productos.Add(new ProductoModel
                    {
                        Producto_Id = reader["Producto_Id"].ToString(),
                        Producto_Descripcion = reader["Producto_Descripcion"].ToString(),
                        Producto_Disponibilidad = reader["Disponibilidad_Producto_Descripcion"].ToString(),
                        Producto_Precio_Base_Neto = Convert.ToInt32(reader["Lista_Precio_Producto_Precio_Base_Neto"]),
                        Producto_Precio_Base = Convert.ToInt32(reader["Lista_Precio_Producto_Precio_Base"])
                    });
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
            try
            {
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
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    productos.Add(new ProductoModel
                    {
                        Producto_Id = reader["Producto_Id"].ToString(),
                        Producto_Descripcion = reader["Producto_Descripcion"].ToString(),
                        Producto_Precio_Base = Convert.ToInt32(reader["Producto_Precio_Base"])
                    });
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

        public List<string> GetCodigosPostales()
        {
            List<string> CPs = new List<string>();
            string query = "SELECT Territorio_Cp FROM vw_cat_Territorios";
            try
            {
                command = CreateCommand(query);
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    CPs.Add(reader.GetString(0));
                }
            }
            catch (Exception e)
            {
                SlackLogs.SendMessage(e.Message);
            }
            finally { conn.Close(); }
            return CPs;
        }
    }
}