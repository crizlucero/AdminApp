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
        /// <param name="empresa_id">Identificador de la empresa</param>
        public List<ColaboradorModel> GetColaboradoresMiembro(string empresa_id, int estatus = 1, string nombre = "", string apellido = "", string puesto = "",
                                                              string profesion = "", string habilidades = "",
                                                              string disponibilidad = "N/A")
        {
            List<ColaboradorModel> colaboradores = new List<ColaboradorModel>();
            command = CreateCommand("select * from vw_pro_Usuarios_Directorio " +
                "WHERE Usuario_Empresa_Id  = @empresa_id AND Usuario_Nombre LIKE @nombre AND Usuario_Apellidos LIKE @apellido " +
                "AND Usuario_Profesion LIKE @profesion AND Usuario_Puesto LIKE @puesto AND Usuario_Habilidades LIKE @habilidades AND " +
                                    "Usuario_Puesto LIKE @puesto AND Usuario_Disponibilidad_Laboral_Descripcion LIKE @disponibilidad AND " +
                                    "Usuario_Estatus = @estatus AND Usuario_Tipo = 2");
            command.Parameters.AddWithValue("@empresa_id", empresa_id);
            command.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
            command.Parameters.AddWithValue("@apellido", "%" + apellido + "%");
            command.Parameters.AddWithValue("@profesion", "%" + profesion + "%");
            command.Parameters.AddWithValue("@puesto", "%" + puesto + "%");
            command.Parameters.AddWithValue("@habilidades", "%" + habilidades + "%");
            command.Parameters.AddWithValue("@disponibilidad", disponibilidad);
            command.Parameters.AddWithValue("@estatus", estatus);
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    colaboradores.Add(new ColaboradorModel
                    {
                        Colaborador_Id = reader["Usuario_Id"].ToString(),
                        Genero_Descripcion = reader["Usuario_Genero_Descripcion"].ToString(),
                        Colaborador_Nombre = reader["Usuario_Nombre"].ToString(),
                        Colaborador_Apellidos = reader["Usuario_Apellidos"].ToString(),
                        Colaborador_Fecha_Nacimiento = reader["Usuario_Fecha_Nacimiento"].ToString(),
                        Colaborador_Correo_Electronico = reader["Usuario_Correo_Electronico"].ToString(),
                        Colaborador_Telefono = reader["Usuario_Telefono"].ToString(),
                        Colaborador_Celular = reader["Usuario_Celular"].ToString(),
                        Colaborador_Profesion = reader["Usuario_Profesion"].ToString(),
                        Colaborador_Puesto = reader["Usuario_Puesto"].ToString(),
                        Colaborador_Habilidades = reader["Usuario_Habilidades"].ToString(),
                        Colaborador_Fotografia = reader["Usuario_Fotografia"].ToString(),
                        Colaborador_Estatus = reader["Usuario_Estatus"].ToString(),
                        Colaborador_Disponibilidad = reader["Usuario_Disponibilidad_Laboral_Descripcion"].ToString()
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
        public ColaboradorModel GetColaborador(string usuario_id)
        {
            ColaboradorModel colaborador = new ColaboradorModel();
            string query = "SELECT * FROM vw_pro_Usuarios_Directorio where Usuario_Id = @usuario_id AND Usuario_Tipo = 2";
            command = CreateCommand(query);
            command.Parameters.AddWithValue("@usuario_id", usuario_id);
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {

                    colaborador.Colaborador_Id = reader["Usuario_Id"].ToString();
                    colaborador.Genero_Id = reader["Usuario_Genero_Id"].ToString();
                    colaborador.Colaborador_Nombre = reader["Usuario_Nombre"].ToString();
                    colaborador.Colaborador_Apellidos = reader["Usuario_Apellidos"].ToString();
                    colaborador.Colaborador_Fecha_Nacimiento = reader["Usuario_Fecha_Nacimiento"].ToString();
                    colaborador.Colaborador_Correo_Electronico = reader["Usuario_Correo_Electronico"].ToString();
                    colaborador.Colaborador_Telefono = reader["Usuario_Telefono"].ToString();
                    colaborador.Colaborador_Celular = reader["Usuario_Celular"].ToString();
                    colaborador.Colaborador_Profesion = reader["Usuario_Profesion"].ToString();
                    colaborador.Colaborador_Puesto = reader["Usuario_Puesto"].ToString();
                    colaborador.Colaborador_Habilidades = reader["Usuario_Habilidades"].ToString();
                    //colaborador.Colaborador_Llave_Acceso = reader["Usuario_Llave_Acceso"].ToString();
                    colaborador.Colaborador_Fotografia = reader["Usuario_Fotografia"].ToString();
                    colaborador.Colaborador_Fecha_Registro = reader["Usuario_Fecha_Registro"].ToString();
                    colaborador.Colaborador_Estatus = reader["Usuario_Estatus"].ToString();
                    colaborador.Colaborador_Disponibilidad = reader["Usuario_Disponibilidad_Laboral_Descripcion"].ToString();

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

        public bool ChangeColaboradorEstatus(string colaborador_id, int estatus)
        {
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                command = CreateCommand();
                command.Connection = conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_Colaborador_Estatus";
                command.Parameters.AddWithValue("@Colaborador_Id", colaborador_id);

                command.Parameters.AddWithValue("@Colaborador_Estatus", estatus);
                command.Transaction = transaction;
                command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception e)
            {
                transaction.Rollback();
                Console.WriteLine(e.Message);
                SlackLogs.SendMessage(e.Message);
                return false;
            }
            finally { conn.Close(); }
            return true;
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
                command.Connection = conn;
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
                command.Transaction = transaction;
                command.ExecuteNonQuery();
                transaction.Commit();
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