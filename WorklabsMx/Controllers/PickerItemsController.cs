using System;
using System.Collections.Generic;
using System.Data;
using WorklabsMx.Enum;
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
        /// Obtiene el identificador del giro
        /// </summary>
        /// <returns>Identificador del giro.</returns>
        /// <param name="giro">Nombre del giro.</param>
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
        /// <param name="codigopostal">Municipio seleccionado</param>
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

        /// <summary>
        /// Obtiene el identificador de la colonia
        /// </summary>
        /// <returns>Identificador de la colonia.</returns>
        /// <param name="colonia">Nombre de la colonia.</param>
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
                "mlp.Lista_Precio_Membresia_Precio_Prorrateo, Lista_Precio_Membresia_Id, Moneda_Id, Impuesto_Id " +
                "FROM vw_cat_Membresias_Distribuciones_Disponibles AS mdd " +
                "INNER JOIN vw_cat_Membresias_Listas_Precios AS mlp ON mlp.Membresia_Id = mdd.Membresia_Id " +
                "WHERE mdd.Distribucion_Membresia_Estatus = 1 " +
                "GROUP BY mdd.Membresia_Id, mdd.Membresia_Descripcion, mlp.Lista_Precio_Membresia_Precio_Base_Neto, mlp.Lista_Precio_Membresia_Precio_Inscripcion_Neto, " +
                "mlp.Lista_Precio_Membresia_Precio_Base, mlp.Lista_Precio_Membresia_Precio_Inscripcion, mlp.Lista_Precio_Membresia_Precio_Prorrateo, Lista_Precio_Membresia_Id, Moneda_Id, Impuesto_Id";
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
                        Membresia_Precio_Prorrateo = Convert.ToDouble(reader["Lista_Precio_Membresia_Precio_Prorrateo"]),
                        Lista_Precio_Id = Convert.ToInt32(reader["Lista_Precio_Membresia_Id"]),
                        Moneda_Id = Convert.ToInt32(reader["Moneda_Id"]),
                        Impuesto_Id = Convert.ToInt32(reader["Impuesto_Id"])
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

        /// <summary>
        /// Obtiene el listado de precios de la membresías
        /// </summary>
        /// <returns>TListado de precios de la membresías.</returns>
        /// <param name="dictMembresias">Diccionario de membresías.</param>
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

        /// <summary>
        /// Obtiene el listado de productos
        /// </summary>
        /// <returns>Listado de productos.</returns>
        public List<ProductoModel> GetProductos()
        {
            List<ProductoModel> productos = new List<ProductoModel>();

            string query = "select p.Producto_Id, p.Producto_Descripcion, p.Disponibilidad_Producto_Descripcion, " +
                "plp.Lista_Precio_Producto_Precio_Base_Neto, " +
                "plp.Lista_Precio_Producto_Precio_Base, " +
                "Lista_Precio_Producto_Id, Moneda_Id, Impuesto_id " +
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
                        Producto_Precio_Base_Neto = Convert.ToDouble(reader["Lista_Precio_Producto_Precio_Base_Neto"]),
                        Producto_Precio_Base = Convert.ToDouble(reader["Lista_Precio_Producto_Precio_Base"]),
                        Lista_Precio_Id = Convert.ToInt32(reader["Lista_Precio_Producto_Id"]),
                        Moneda_Id = Convert.ToInt32(reader["Moneda_Id"]),
                        Impuesto_Id = Convert.ToInt32(reader["Impuesto_Id"])
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

        /// <summary>
        /// Obtiene el listado de precios de los productos
        /// </summary>
        /// <returns>Listado de precios de los productos.</returns>
        /// <param name="dictProductos">Diccionario de productos.</param>
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
                    "Lista_Precio_Producto_Precio_Base_Neto as Producto_Precio_Base, " +
                    "Lista_Precio_Producto_Precio_Prorrateo_Neto AS Producto_Precio_Prorrateo " +
                    "FROM vw_cat_Productos_Listas_Precios " +
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
                        Producto_Precio_Base = Convert.ToDouble(reader["Producto_Precio_Base"]),
                        Producto_Precio_Prorrateo = Convert.ToDouble(reader["Producto_Precio_Prorrateo"])
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

        /// <summary>
        /// Obtiene los códigos postales
        /// </summary>
        /// <returns>Listado de los códigos postales.</returns>
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

        /// <summary>
        /// Crea un carrito de compra detallado
        /// </summary>
        /// <returns>Carrito de compras detallado.</returns>
        /// <param name="referencia_tipo">Tipo de referencia.</param>
        /// <param name="referencia_id">Identificador de producto/membresías.</param>
        /// <param name="referencia_cantidad">Cantidad de producto/membresías.</param>
        /// <param name="referencia_meses">Meses de producto/membresías.</param>
        /// <param name="referencia_fecha_inicio">Fecha inicio producto/membresías.</param>
        /// <param name="precio_id">Identificador del precio.</param>
        /// <param name="moneda_id">Identificador de la moneda.</param>
        /// <param name="impuesto_id">Identificador del impuesto.</param>
        /// <param name="descuento_id">Identificador del descuento.</param>
        public List<CarritoComprasDetalle> GetProductosMembresias(TiposServicios referencia_tipo, int referencia_id, int referencia_cantidad, int referencia_meses,
                                                         string referencia_fecha_inicio, int precio_id, int moneda_id, int impuesto_id, int descuento_id)
        {
            List<CarritoComprasDetalle> carrito = new List<CarritoComprasDetalle>();
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                command = CreateCommand();
                command.Connection = conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_vw_pro_Carrito_Compras";
                command.Parameters.AddWithValue("@Referencia_Tipo", referencia_tipo.ToString());
                command.Parameters.AddWithValue("@Referencia_Id", referencia_id);
                command.Parameters.AddWithValue("@Referencia_Cantidad", referencia_cantidad);
                command.Parameters.AddWithValue("@Referencia_Meses", referencia_meses);
                command.Parameters.AddWithValue("@Referencia_Vigencia_Fecha_Inicio", referencia_fecha_inicio);
                command.Parameters.AddWithValue("@Referencia_Lista_Precio_Id", precio_id);
                command.Parameters.AddWithValue("@Referencia_Moneda_Id", moneda_id);
                command.Parameters.AddWithValue("@Referencia_Impuesto_Id", impuesto_id);
                if (descuento_id != 0)
                    command.Parameters.AddWithValue("@Referencia_Descuento_Id", descuento_id);
                command.Transaction = transaction;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    carrito.Add(new CarritoComprasDetalle
                    {
                        Membresia_Id = reader["Membresia_Id"].ToString(),
                        Inscripcion_Membresia_Id = reader["Inscripcion_Membresia_Id"].ToString(),
                        Lista_Precio_Membresia_Id = reader["Lista_Precio_Membresia_Id"].ToString(),
                        Producto_Id = reader["Producto_Id"].ToString(),
                        Lista_Precio_Producto_Id = reader["Lista_Precio_Producto_Id"].ToString(),
                        Servicio_Id = reader["Servicio_Id"].ToString(),
                        Lista_Precio_Servicio_Id = reader["Lista_Precio_Servicio_Id"].ToString(),
                        Carrito_Compras_Detalle_Descripcion = reader["Carrito_Compras_Detalle_Descripcion"].ToString(),
                        Carrito_Compras_Detalle_Cantidad = reader["Carrito_Compras_Detalle_Cantidad"].ToString(),
                        Carrito_Compras_Detalle_Importe_Precio = reader["Carrito_Compras_Detalle_Importe_Precio"].ToString(),
                        Carrito_Compras_Detalle_Importe_Prorrateo = reader["Carrito_Compras_Detalle_Importe_Prorrateo"].ToString(),
                        Carrito_Compras_Detalle_Importe_Suma = reader["Carrito_Compras_Detalle_Importe_Suma"].ToString(),
                        Carrito_Compras_Detalle_Importe_Descuento = reader["Carrito_Compras_Detalle_Importe_Descuento"].ToString(),
                        Carrito_Compras_Detalle_Importe_Subtotal = reader["Carrito_Compras_Detalle_Importe_Subtotal"].ToString(),
                        Carrito_Compras_Detalle_Importe_Impuesto = reader["Carrito_Compras_Detalle_Importe_Impuesto"].ToString(),
                        Carrito_Compras_Detalle_Importe_Total = reader["Carrito_Compras_Detalle_Importe_Total"].ToString(),
                        Carrito_Compras_Detalle_Estatus = reader["Carrito_Compras_Detalle_Estatus"].ToString(),
                        Carrito_Compras_Detalle_Vigencia_Fecha_Inicio = reader["Carrito_Compras_Detalle_Vigencia_Fecha_Inicio"].ToString(),
                        Carrito_Compras_Detalle_Vigencia_Fecha_Fin = reader["Carrito_Compras_Detalle_Vigencia_Fecha_Fin"].ToString(),
                        Carrito_Compras_Detalle_Vigencia_Fecha = reader["Carrito_Compras_Detalle_Vigencia_Fecha"].ToString(),
                        Carrito_Compras_Detalle_Importe_Suma_Texto = reader["Carrito_Compras_Detalle_Importe_Suma_Texto"].ToString(),
                        Carrito_Compras_Detalle_Importe_Descuento_Texto = reader["Carrito_Compras_Detalle_Importe_Descuento_Texto"].ToString(),
                        Carrito_Compras_Detalle_Importe_Subtotal_Texto = reader["Carrito_Compras_Detalle_Importe_Subtotal_Texto"].ToString(),
                        Carrito_Compras_Detalle_Importe_Impuesto_Texto = reader["Carrito_Compras_Detalle_Importe_Impuesto_Texto"].ToString(),
                        Carrito_Compras_Detalle_Importe_Total_Texto = reader["Carrito_Compras_Detalle_Importe_Total_Texto"].ToString()
                    });
                }
                transaction.Commit();
            }
            catch (Exception e)
            {
                SlackLogs.SendMessage(e.Message);
                transaction.Rollback();
            }
            finally { conn.Close(); }
            return carrito;
        }

        public List<RedSocialModel> GetRedesSociales(string usuario_id, string usuario_tipo)
        {
            List<RedSocialModel> redesSociales = new List<RedSocialModel>();
            try
            {
                command = CreateCommand("select Usuario_Red_Social_Id, Red_Social_Id, Red_Social_Nombre, Red_Social_Icono_Android, Red_Social_Icono_iOS, Red_Social_Icono_Web " +
                                       "from vw_pro_Directorio_Usuarios Where Usuario_Id = @Usuario_Id and Usuario_Tipo = @Usuario_Tipo");
                command.Parameters.AddWithValue("@Usuario_Id",usuario_id);
                command.Parameters.AddWithValue("@Usuario_Tipo", usuario_tipo);
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    redesSociales.Add(new RedSocialModel
                    {
                        Usuario_Red_Social_Id = reader["Usuario_Red_Social_Id"].ToString(),
                        Red_Social_Id = reader["Red_Social_Id"].ToString(),
                        Red_Social_Nombre = reader["Red_Social_Nombre"].ToString(),
                        Red_Social_Icono_Android = reader["Red_Social_Icono_Android"].ToString(),
                        Red_Social_Icono_iOS = reader["Red_Social_Icono_iOS"].ToString(),
                        Red_Social_Icono_Web = reader["Red_Social_Icono_Web"].ToString()
                    });
                }
            }
            catch (Exception e)
            {
                SlackLogs.SendMessage(e.Message);
            }
            finally { conn.Close(); }
            return redesSociales;
        }

        public List<EtiquetaModel> GetEtiquetas(string usuario_id, string usuario_tipo)
        {
            List<EtiquetaModel> etiquetas = new List<EtiquetaModel>();
            try
            {
                command = CreateCommand("select Usuario_Etiqueta_Id, Etiqueta_Id, Usuario_Etiqueta_Estatus, Etiqueta_Nombre, Etiqueta_Tipo " +
                                        "from vw_pro_Directorio_Usuarios Where Usuario_Id = @Usuario_Id and Usuario_Tipo = @Usuario_Tipo");
                command.Parameters.AddWithValue("@Usuario_Id", usuario_id);
                command.Parameters.AddWithValue("@Usuario_Tipo", usuario_tipo);
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    etiquetas.Add(new EtiquetaModel
                    {
                        
                        Etiqueta_Id = reader["Etiqueta_Id"].ToString(),
                        Etiqueta_Nombre = reader["Etiqueta_Nombre"].ToString(),
                        Etiqueta_Tipo = reader["Etiqueta_Tipo"].ToString(),
                        Usuario_Etiqueta_Estatus = reader["Usuario_Etiqueta_Estatus"].ToString(),
                        Usuario_Etiqueta_Id = reader["Usuario_Etiqueta_Id"].ToString()
                    });
                }
            }
            catch (Exception e)
            {
                SlackLogs.SendMessage(e.Message);
            }
            finally { conn.Close(); }
            return etiquetas;
        }
    }
}