using System;
using System.Collections.Generic;
using System.Data;
using WorklabsMx.Helpers;
using WorklabsMx.Models;

namespace WorklabsMx.Controllers
{
    public class ColaboradoresController : DataBaseModel
    {
        /// <summary>
        /// Obtiene los colaboradores de un miembro
        /// </summary>
        /// <returns>Colaboradores de un miembro</returns>
        /// <param name="miembro_id">Identificador del miembro</param>
        public List<ColaboradorModel> GetColaboradoresMiembro(string miembro_id, string busqueda = "", string status = "1")
        {
            List<ColaboradorModel> colaboradores = new List<ColaboradorModel>();
            string query = "select c.* from vw_cat_Miembros_Empresas_Colaboradores as c inner join vw_cat_Miembros_Empresas as m on c.Empresa_Miembro_Id = m.Empresa_Miembro_Id WHERE Miembro_Id  = @miembro_id";
            command = CreateCommand(query);
            command.Parameters.AddWithValue("@miembro_id", miembro_id);
            //command.Parameters.AddWithValue("@buqueda", busqueda);
            //command.Parameters.AddWithValue("@status", status);
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
					colaboradores.Add(new ColaboradorModel()
					{
						Colaborador_Id = reader["Colaborador_Empresa_Id"].ToString(),
						Genero_Descripcion = reader["Genero_Descripcion"].ToString(),
						Colaborador_Nombre = reader["Colaborador_Empresa_Nombre"].ToString(),
						Colaborador_Apellidos = reader["Colaborador_Empresa_Apellidos"].ToString(),
						Colaborador_Fecha_Nacimiento = reader["Colaborador_Empresa_Fecha_Nacimiento"].ToString(),
						Colaborador_Correo_Electronico = reader["Colaborador_Empresa_Correo_Electronico"].ToString(),
						Colaborador_Telefono = reader["Colaborador_Empresa_Telefono"].ToString(),
						Colaborador_Celular = reader["Colaborador_Empresa_Celular"].ToString(),
						Colaborador_Profesion = reader["Colaborador_Empresa_Profesion"].ToString(),
						Colaborador_Puesto = reader["Colaborador_Empresa_Puesto"].ToString(),
						Colaborador_Habilidades = reader["Colaborador_Empresa_Habilidades"].ToString(),
						Colaborador_Llave_Acceso = reader["Colaborador_Empresa_Llave_Acceso"].ToString(),
						Colaborador_Fotografia = reader["Colaborador_Empresa_Fotografia"].ToString(),
						//colaborador.//Colaborador_Fecha_Registro = reader["Colaborador_Empresa_Fecha_Registro"].ToString(),
						Colaborador_Estatus = reader["Colaborador_Empresa_Estatus"].ToString(),
						//colaborador.Colaborador_Fecha_Alta = reader["Colaborador_Empresa_Fecha_Alta"].ToString();
						//colaborador.Colaborador_Fecha_Modificacion = reader["Colaborador_Empresa_Fecha_Modificacion"].ToString();
						//colaborador.Colaborador_Fecha_Baja = reader["Colaborador_Empresa_Fecha_Baja"].ToString();
						Colaborador_Disponibilidad = reader["Colaborador_Empresa_Disponibilidad_Trabajo"].ToString()
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
            return colaboradores;
        }
        /// <summary>
        /// Obtiene los datos de un colaborador
        /// </summary>
        /// <returns>Colaborador</returns>
        /// <param name="colaborador_id">Identificador del colaborador</param>
        public ColaboradorModel GetColaborador(string colaborador_id)
        {
            ColaboradorModel colaborador = new ColaboradorModel();
            string query = "SELECT * FROM vw_cat_Miembros_Empresas_Colaboradores where Colaborador_Id = @colaborador_id";
            command = CreateCommand(query);
            command.Parameters.AddWithValue("@colaborador_id", colaborador_id);
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    colaborador = new ColaboradorModel
                    {
                        Colaborador_Id = reader["Colaborador_Id"].ToString(),
                        Genero_Id = reader["Genero_Id"].ToString(),
                        Colaborador_Nombre = reader["Colaborador_Nombre"].ToString(),
                        Colaborador_Apellidos = reader["Colaborador_Apellidos"].ToString(),
                        Colaborador_Fecha_Nacimiento = reader["Colaborador_Fecha_Nacimiento"].ToString(),
                        Colaborador_Correo_Electronico = reader["Colaborador_Correo_Electronico"].ToString(),
                        Colaborador_Telefono = reader["Colaborador_Telefono"].ToString(),
                        Colaborador_Celular = reader["Colaborador_Celular"].ToString(),
                        Colaborador_Profesion = reader["Colaborador_Profesion"].ToString(),
                        Colaborador_Puesto = reader["Colaborador_Puesto"].ToString(),
                        Colaborador_Habilidades = reader["Colaborador_Habilidades"].ToString(),
                        Colaborador_Llave_Acceso = reader["Colaborador_Llave_Acceso"].ToString(),
                        Colaborador_Fotografia = reader["Colaborador_Fotografia"].ToString(),
                        Colaborador_Fecha_Registro = reader["Colaborador_Fecha_Registro"].ToString(),
                        Colaborador_Estatus = reader["Colaborador_Estatus"].ToString(),
                        Colaborador_Fecha_Alta = reader["Colaborador_Fecha_Alta"].ToString(),
                        Colaborador_Fecha_Modificacion = reader["Colaborador_Fecha_Modificacion"].ToString(),
                        Colaborador_Fecha_Baja = reader["Colaborador_Fecha_Baja"].ToString(),
                        Colaborador_Disponibilidad = reader["Colaborador_Disponibilidad"].ToString()

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
            return colaborador;
        }

        public bool AddChangeColaborador(string empresa_id, string nombre, string apellidos, string mail,
                                         string telefono, string celular, string profesion, string puesto,
                                         string habilidades, string fecha_nacimiento, string colaborador_id)
        {
            PassSecurity password = new PassSecurity();
            string pwd = password.GeneraIdentifier();
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                command = CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                if (colaborador_id != null)
                {
                    command.CommandText = "sp_Miembros_Empresas_Colaboradores";
                    command.Parameters.AddWithValue("@Colaborador_Contrasena", password.EncodePassword(pwd));
                    command.Parameters.AddWithValue("@Colaborador_Llave_Acceso", pwd);
                    command.Parameters.AddWithValue("@Colaborador_Fecha_Registro", DateTime.Now);
                }
                else
                {
                    command.CommandText = "sp_Miembros_Update_Colaboradores";
                    command.Parameters.AddWithValue("@Colaborador_ID", colaborador_id);
                    command.Parameters.AddWithValue("@Colaborador_Fecha_Modificacion", DateTime.Now);
                }
                command.Parameters.AddWithValue("@Miembro_Empresa_Id", empresa_id);

                command.Parameters.AddWithValue("@Colaborador_Nombre", nombre);
                command.Parameters.AddWithValue("@Colaborador_Apellidos", apellidos);
                command.Parameters.AddWithValue("@Colaborador_Correo_Electronico", mail);
                command.Parameters.AddWithValue("@Colaborador_Telefono", telefono);
                command.Parameters.AddWithValue("@Colaborador_Celular", celular);
                command.Parameters.AddWithValue("@Colaborador_Profesion", profesion);
                command.Parameters.AddWithValue("@Colaborador_Puesto", puesto);
                command.Parameters.AddWithValue("@Colaborador_Habilidades", habilidades);

                command.Parameters.AddWithValue("@Colaborador_Fecha_Nacimiento", fecha_nacimiento);

            }
            catch (Exception e)
            {
                transaction.Rollback();
                Console.WriteLine(e.Message);
                SlackLogs.SendMessage(e.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
            new Emails().SendMail(mail, nombre + " " + apellidos, pwd);
            return true;
        }
    }
}
