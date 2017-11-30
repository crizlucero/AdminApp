using System;
using System.Collections.Generic;
using System.Data;
using WorklabsMx.Helpers;
using WorklabsMx.Models;

namespace WorklabsMx.Controllers
{
    public class EmpresaController : DataBaseModel
    {
        /// <summary>
        /// Obtiene los datos de la empresa
        /// </summary>
        /// <returns>Datos de la empresa</returns>
        /// <param name="miembro_id">Identificador del miembro</param>
        public EmpresaModel GetEmpresaMiembro(string miembro_id)
        {
            EmpresaModel empresa = new EmpresaModel();
            string query = "SELECT Giro_Descripcion, Empresa_Miembro_Red_Social_3, Empresa_Miembro_Red_Social_2, " +
                "Empresa_Miembro_Red_Social_1, Empresa_Miembro_Pagina_Web, Empresa_Miembro_Telefono, " +
                "Empresa_Miembro_Correo_Electronico, Empresa_Miembro_Numero_Interior, " +
                "Empresa_Miembro_Numero_Exterior, Empresa_Miembro_Calle, Empresa_Miembro_Nombre, " +
                "Empresa_Miembro_Rfc, Empresa_Miembro_Razon_Social, Empresa_Miembro_Id, Territorio_Estado_Descripcion, " +
                "Territorio_Municipio_Descripcion, Territorio_Colonia_Descripcion, Territorio_Cp, Empresa_Miembro_Logotipo " +
                "FROM vw_cat_Miembros_Empresas WHERE Miembro_Id = @miembro_id";

            try
            {
                conn.Open();
                command = CreateCommand(query);
                command.Parameters.AddWithValue("@miembro_id", miembro_id);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    empresa = new EmpresaModel
                    {
                        Giro_Descripcion = reader["Giro_Descripcion"].ToString(),
                        Empresa_Miembro_Red_Social_3 = reader["Empresa_Miembro_Red_Social_3"].ToString(),
                        Empresa_Miembro_Red_Social_2 = reader["Empresa_Miembro_Red_Social_2"].ToString(),
                        Empresa_Miembro_Red_Social_1 = reader["Empresa_Miembro_Red_Social_1"].ToString(),
                        Empresa_Miembro_Pagina_Web = reader["Empresa_Miembro_Pagina_Web"].ToString(),
                        Empresa_Miembro_Telefono = reader["Empresa_Miembro_Telefono"].ToString(),
                        Empresa_Miembro_Correo_Electronico = reader["Empresa_Miembro_Correo_Electronico"].ToString(),
                        Empresa_Miembro_Numero_Interior = reader["Empresa_Miembro_Numero_Interior"].ToString(),
                        Empresa_Miembro_Numero_Exterior = reader["Empresa_Miembro_Numero_Exterior"].ToString(),
                        Empresa_Miembro_Calle = reader["Empresa_Miembro_Calle"].ToString(),
                        Empresa_Miembro_Nombre = reader["Empresa_Miembro_Nombre"].ToString(),
                        Empresa_Miembro_Rfc = reader["Empresa_Miembro_Rfc"].ToString(),
                        Empresa_Miembro_Razon_Social = reader["Empresa_Miembro_Razon_Social"].ToString(),
                        Empresa_Miembro_Logotipo = reader["Empresa_Miembro_Logotipo"].ToString(),
                        Empresa_Miembro_Id = reader["Empresa_Miembro_Id"].ToString(),
                        Territorio_Estado_Descripcion = reader["Territorio_Estado_Descripcion"].ToString(),
                        Territorio_Municipio_Descripcion = reader["Territorio_Municipio_Descripcion"].ToString(),
                        Territorio_Colonia_Descripcion = reader["Territorio_Colonia_Descripcion"].ToString(),
                        Territorio_Cp = reader["Territorio_Cp"].ToString()
                    };
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                SlackLogs.SendMessage(e.Message);
            }
            finally { conn.Close(); }

            return empresa;
        }
        /// <summary>
        /// Obtiene los datos fiscales
        /// </summary>
        /// <returns>Datos fiscales</returns>
        /// <param name="miembro_id">Identificador del miembro</param>
        public DatosFiscales GetDatosFiscales(string miembro_id)
        {
            DatosFiscales datosfiscales = new DatosFiscales();
            string query = "select Domicilio_Fiscal_Empresa_Id, Domicilio_Fiscal_Empresa_Calle, Domicilio_Fiscal_Empresa_Numero_Exterior, " +
                "Domicilio_Fiscal_Empresa_Numero_Interior, Domicilio_Fiscal_Empresa_Correo_Electronico, Empresa_Miembro_Razon_Social, " +
                "Empresa_Miembro_Rfc, Territorio_Pais_Descripcion, Territorio_Estado_Descripcion, Territorio_Municipio_Descripcion, " +
                "Territorio_Colonia_Descripcion, Territorio_Cp from vw_Miembros_Empresas_Domicilios WHERE Empresa_Miembro_Id = @miembro_id";
            command = CreateCommand(query);
            command.Parameters.AddWithValue("@miembro_id", miembro_id);
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    datosfiscales = new DatosFiscales()
                    {
                        Domicilio_Fiscal_Empresa_Id = reader["Domicilio_Fiscal_Empresa_Id"].ToString(),
                        Domicilio_Fiscal_Empresa_Calle = reader["Domicilio_Fiscal_Empresa_Calle"].ToString(),
                        Domicilio_Fiscal_Empresa_Numero_Exterior = reader["Domicilio_Fiscal_Empresa_Numero_Exterior"].ToString(),
                        Domicilio_Fiscal_Empresa_Numero_Interior = reader["Domicilio_Fiscal_Empresa_Numero_Interior"].ToString(),
                        Domicilio_Fiscal_Empresa_Correo_Electronico = reader["Domicilio_Fiscal_Empresa_Correo_Electronico"].ToString(),
                        Razon_Social = reader["Empresa_Miembro_Razon_Social"].ToString(),
                        RFC = reader["Empresa_Miembro_Rfc"].ToString(),
                        Territorio_Pais = reader["Territorio_Pais_Descripcion"].ToString(),
                        Territorio_Estado = reader["Territorio_Estado_Descripcion"].ToString(),
                        Territorio_Municipio = reader["Territorio_Municipio_Descripcion"].ToString(),
                        Territorio_Colonia = reader["Territorio_Colonia_Descripcion"].ToString(),
                        Territorio_CP = reader["Territorio_Cp"].ToString()
                    };
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                SlackLogs.SendMessage(e.Message);
            }
            finally { conn.Close(); }
            return datosfiscales;
        }
        /// <summary>
        /// Obtiene el directorio de empresas
        /// </summary>
        /// <returns>Directorio de empresas</returns>
        /// <param name="nombre">Nombre</param>
        /// <param name="pais">Pais</param>
        /// <param name="estado">Estado</param>
        /// <param name="municipio">Municipio</param>
        /// <param name="giro">Giro de la empresa</param>
        public List<EmpresaModel> GetDirectorioEmpresas(string nombre = "", string pais = "", string estado = "", string municipio = "", string giro = "")
        {
            List<EmpresaModel> empresas = new List<EmpresaModel>();

            string query = "SELECT Giro_Descripcion, Empresa_Miembro_Red_Social_3, Empresa_Miembro_Red_Social_2, "
                + "Empresa_Miembro_Red_Social_1, Empresa_Miembro_Pagina_Web, Empresa_Miembro_Telefono, " +
                "Empresa_Miembro_Correo_Electronico, Empresa_Miembro_Numero_Interior, " +
                "Empresa_Miembro_Numero_Exterior, Empresa_Miembro_Calle, Empresa_Miembro_Nombre, " +
                "Empresa_Miembro_Rfc, Empresa_Miembro_Razon_Social, Empresa_Miembro_Id, Territorio_Estado_Descripcion, " +
                "Territorio_Municipio_Descripcion, Territorio_Colonia_Descripcion, Territorio_Cp, Empresa_Miembro_Logotipo " +
                "FROM vw_cat_Miembros_Empresas WHERE Empresa_Miembro_Nombre LIKE @nombre AND Territorio_Pais_Descripcion like @pais " +
                "AND Territorio_Estado_Descripcion LIKE @estado AND Territorio_Municipio_Descripcion LIKE @municipio " +
                "AND Giro_Descripcion LIKE @giro";
            command = CreateCommand(query);
            command.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
            command.Parameters.AddWithValue("@pais", "%" + pais + "%");
            command.Parameters.AddWithValue("@estado", "%" + estado + "%");
            command.Parameters.AddWithValue("@municipio", "%" + municipio + "%");
            command.Parameters.AddWithValue("@giro", "%" + giro + "%");
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    empresas.Add(new EmpresaModel
                    {
                        Giro_Descripcion = reader["Giro_Descripcion"].ToString(),
                        Empresa_Miembro_Red_Social_3 = reader["Empresa_Miembro_Red_Social_3"].ToString(),
                        Empresa_Miembro_Red_Social_2 = reader["Empresa_Miembro_Red_Social_2"].ToString(),
                        Empresa_Miembro_Red_Social_1 = reader["Empresa_Miembro_Red_Social_1"].ToString(),
                        Empresa_Miembro_Pagina_Web = reader["Empresa_Miembro_Pagina_Web"].ToString(),
                        Empresa_Miembro_Telefono = reader["Empresa_Miembro_Telefono"].ToString(),
                        Empresa_Miembro_Correo_Electronico = reader["Empresa_Miembro_Correo_Electronico"].ToString(),
                        Empresa_Miembro_Numero_Interior = reader["Empresa_Miembro_Numero_Interior"].ToString(),
                        Empresa_Miembro_Numero_Exterior = reader["Empresa_Miembro_Numero_Exterior"].ToString(),
                        Empresa_Miembro_Calle = reader["Empresa_Miembro_Calle"].ToString(),
                        Empresa_Miembro_Nombre = reader["Empresa_Miembro_Nombre"].ToString(),
                        Empresa_Miembro_Rfc = reader["Empresa_Miembro_Rfc"].ToString(),
                        Empresa_Miembro_Razon_Social = reader["Empresa_Miembro_Razon_Social"].ToString(),
                        Empresa_Miembro_Logotipo = reader["Empresa_Miembro_Logotipo"].ToString(),
                        Empresa_Miembro_Id = reader["Empresa_Miembro_Id"].ToString(),
                        Territorio_Estado_Descripcion = reader["Territorio_Estado_Descripcion"].ToString(),
                        Territorio_Municipio_Descripcion = reader["Territorio_Municipio_Descripcion"].ToString(),
                        Territorio_Colonia_Descripcion = reader["Territorio_Colonia_Descripcion"].ToString(),
                        Territorio_Cp = reader["Territorio_Cp"].ToString()
                    });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                SlackLogs.SendMessage(e.Message);
            }
            finally { conn.Close(); }
            return empresas;
        }
        /// <summary>
        /// Actualiza los datos fiscales.
        /// </summary>
        /// <returns><c>true</c>, Si los datos fiscales fueron actualizados, <c>false</c> Existió un error.</returns>
        /// <param name="Domicilio_Fiscal_Empresa_Id">Identificador del domicilio fiscal de la empresa</param>
        /// <param name="empresa_miembro_id">Identificador del id del miembro de la Empresa</param>
        public bool UpdateDatosFiscales(string Domicilio_Fiscal_Empresa_Id, string empresa_miembro_id, string territorio_id, string calle, string numExterior, string numInterior, string correo)
        {
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                command = CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_cat_Miembros_Empresas_Domicilios_Fiscales";
                command.Connection = conn;
                command.Parameters.AddWithValue("@Trasaccion", "MODIFICAR");
                command.Parameters.AddWithValue("@Domicilio_Fiscal_Empresa_Id", Domicilio_Fiscal_Empresa_Id);
                command.Parameters.AddWithValue("@Empresa_Miembro_Id", empresa_miembro_id);
                command.Parameters.AddWithValue("@Territorio_Id", territorio_id);
                command.Parameters.AddWithValue("@Domicilio_Fiscal_Empresa_Calle", calle);
                command.Parameters.AddWithValue("@Domicilio_Fiscal_Empresa_Numero_Exterior", numExterior);
                command.Parameters.AddWithValue("@Domicilio_Fiscal_Empresa_Numero_Interior", numInterior);
                command.Parameters.AddWithValue("@Domicilio_Fiscal_Empresa_Correo_Electronico", correo);
                command.Parameters.AddWithValue("@Domicilio_Fiscal_Empresa_Estatus", 1);
                command.Parameters.Add("@Domicilio_Fiscal_Empresa_Id_Salida", SqlDbType.Int).Direction = ParameterDirection.Output;

                command.Transaction = transaction;
                command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                SlackLogs.SendMessage(e.Message);
                transaction.Rollback();
                return false;
            }
            finally { conn.Close(); }

            return true;
        }

        public bool UpdateDataEmpresa(string empresa_id, string miembro_id, string giro_id, string territorio_id, string razonSocial,
                                      string rfc, string nombre, string calle, string numExterior, string numInterior, string correo,
                                     string telefono, string paginaWeb, string facebook, string twitter, string instagram, string logo)
        {
            try
            {
                conn.Open();
                //transaction = conn.BeginTransaction();
                command = CreateCommand();
                command.Connection = conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_cat_Miembros_Empresas";
                command.Parameters.AddWithValue("@Trasaccion", "MODIFICAR");
                command.Parameters.AddWithValue("@Empresa_Miembro_Id", empresa_id);
                command.Parameters.AddWithValue("@Miembro_Id", miembro_id);
                command.Parameters.AddWithValue("@Giro_Id", giro_id);
                command.Parameters.AddWithValue("@Territorio_Id", territorio_id);
                command.Parameters.AddWithValue("@Empresa_Miembro_Razon_Social", razonSocial);
                command.Parameters.AddWithValue("@Empresa_Miembro_Rfc", rfc);
                command.Parameters.AddWithValue("@Empresa_Miembro_Nombre", nombre);
                command.Parameters.AddWithValue("@Empresa_Miembro_Calle", calle);
                command.Parameters.AddWithValue("@Empresa_Miembro_Numero_Exterior", numExterior);
                command.Parameters.AddWithValue("@Empresa_Miembro_Numero_Interior", numInterior);
                command.Parameters.AddWithValue("@Empresa_Miembro_Correo_Electronico", correo);
                command.Parameters.AddWithValue("@Empresa_Miembro_Telefono", telefono);
                command.Parameters.AddWithValue("@Empresa_Miembro_Pagina_Web", paginaWeb);
                command.Parameters.AddWithValue("@Empresa_Miembro_Red_Social_1", facebook);
                command.Parameters.AddWithValue("@Empresa_Miembro_Red_Social_2", twitter);
                command.Parameters.AddWithValue("@Empresa_Miembro_Red_Social_3", instagram);
                command.Parameters.AddWithValue("@Empresa_Miembro_Logotipo", logo);
                command.Parameters.AddWithValue("@Empresa_Miembro_Estatus", 1);
                command.Parameters.Add("@Empresa_Miembro_Id_Salida", SqlDbType.Int).Direction = ParameterDirection.Output;

                //command.Transaction = transaction;
                command.ExecuteNonQuery();
                //transaction.Commit();
            }
            catch (Exception e)
            {
                SlackLogs.SendMessage(e.Message);
                //transaction.Rollback();
                return false;
            }
            finally { conn.Close(); }
            return true;
        }
    }
}