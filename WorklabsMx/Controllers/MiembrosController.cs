using System;
using System.Collections.Generic;
using WorklabsMx.Helpers;
using WorklabsMx.Models;

namespace WorklabsMx.Controllers
{
    public class MiembrosController : DataBaseModel
    {
        /// <summary>
        /// Obtiene la información del miembro
        /// </summary>
        /// <returns>Información del miembro</returns>
        /// <param name="miembro_id">Identificador del miembro</param>
        public MiembroModel GetMemberData(string miembro_id, string tipo)
        {
            MiembroModel miembro = new MiembroModel();
            string query = "select * from vw_pro_Usuarios_Directorio where Usuario_Id = @miembro_id AND Usuario_Tipo = @tipo";
            command = CreateCommand(query);
            command.Parameters.AddWithValue("@miembro_id", miembro_id);
            command.Parameters.AddWithValue("@tipo", tipo);
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    miembro = new MiembroModel();
                    miembro.Miembro_Id = reader["Usuario_Id"].ToString();
                    miembro.Miembro_Nombre = reader["Usuario_Nombre"].ToString();
                    miembro.Miembro_Apellidos = reader["Usuario_Apellidos"].ToString();
                    miembro.Miembro_Fecha_Nacimiento = reader["Usuario_Fecha_Nacimiento"].ToString();
                    miembro.Genero_Id = reader["Usuario_Genero_Id"].ToString();
                    miembro.Genero_Descripcion = reader["Usuario_Genero_Descripcion"].ToString();
                    miembro.Miembro_Correo_Electronico = reader["Usuario_Correo_Electronico"].ToString();
                    miembro.Miembro_Telefono = reader["Usuario_Telefono"].ToString();
                    miembro.Miembro_Celular = reader["Usuario_Celular"].ToString();
                    miembro.Miembro_Profesion = reader["Usuario_Profesion"].ToString();
                    miembro.Miembro_Puesto = reader["Usuario_Puesto"].ToString();
                    miembro.Miembro_Habilidades = reader["Usuario_Habilidades"].ToString();
                    miembro.Miembro_Identificacion = reader["Usuario_Identificacion"].ToString();
                    miembro.Miembro_Llave_Acceso = reader["Usuario_Llave_Acceso"].ToString();
                    miembro.Miembro_Fotografia = reader["Usuario_Fotografia"].ToString();
                    miembro.Miembro_Fecha_Registro = reader["Usuario_Fecha_Registro"].ToString();
                    miembro.Miembro_Estatus = reader["Usuario_Estatus"].ToString();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                SlackLogs.SendMessage(e.Message);
            }
            finally { conn.Close(); }
            return miembro;
        }

        /// <summary>
        /// Obtener el nombre del miembro
        /// </summary>
        /// <returns>Nombre del miembro</returns>
        /// <param name="miembro_id">Identificador del miembro</param>
        public Dictionary<string, string> GetMemberName(string miembro_id, string tipo)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            string query = "select Concat(Usuario_Nombre, ' ', Usuario_Apellidos) as Nombre, Usuario_Fotografia from vw_pro_Usuarios_Directorio " +
                "where Usuario_Id = @miembro_id AND Usuario_Tipo = @tipo";
            command = CreateCommand(query);
            command.Parameters.AddWithValue("@miembro_id", miembro_id);
            command.Parameters.AddWithValue("@tipo", tipo);
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    data.Add("Nombre", reader["Nombre"].ToString());
                    data.Add("Fotografia", reader["Usuario_Fotografia"].ToString().Replace(@"\", "/"));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                SlackLogs.SendMessage(e.Message);
            }
            finally { conn.Close(); }
            return data;
        }

        public string GetLlaveAcceso(string usuario_id, string tipo)
        {
            string query = "SELECT Usuario_Llave_Acceso FROM vw_pro_Usuarios_Directorio WHERE Usuario_Id = @usuario_id AND Usuario_Tipo = @tipo";
            command = CreateCommand(query);
            command.Parameters.AddWithValue("@usuario_id", usuario_id);
            command.Parameters.AddWithValue("@tipo", tipo);
            try
            {
                conn.Open();
                return command.ExecuteScalar().ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                SlackLogs.SendMessage(e.Message);
            }
            finally { conn.Close(); }
            return "";
        }

        /// <summary>
        /// Obtiene el directorio de usuarios
        /// </summary>
        /// <returns>Directorio de usuarios</returns>
        /// <param name="nombre">Nombre</param>
        /// <param name="apellido">Apellidos</param>
        /// <param name="puesto">Puesto</param>
        /// <param name="profesion">Profesion</param>
        /// <param name="habilidades">Habilidades</param>
        /// <param name="disponibilidad">Si es <c>true</c> el usuario tiene disponibilidad para trabajar</param>
        public List<MiembroModel> GetDirectorioUsuarios(string nombre, string apellido, string puesto, string profesion, string habilidades,
                                                        bool disponibilidad, string pais, string estado, string municipio)
        {
            List<MiembroModel> usuarios = new List<MiembroModel>();

            string query = "select * from vw_pro_Usuarios_Directorio WHERE Usuario_Nombre IS NOT NULL AND " +
                "Usuario_Nombre LIKE @nombre AND Usuario_Apellidos LIKE @apellido AND " +
                "Usuario_Profesion LIKE @profesion AND Usuario_Puesto LIKE @puesto AND " +
                "Usuario_Habilidades LIKE @habilidades AND Usuario_Empresa_Pais_Descripcion LIKE @pais AND " +
                "Usuario_Empresa_Estado_Descripcion LIKE @estado and Usuario_Empresa_Municipio_Descripcion LIKE @municipio";

            command = CreateCommand(query);
            command.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
            command.Parameters.AddWithValue("@apellido", "%" + apellido + "%");
            command.Parameters.AddWithValue("@profesion", "%" + profesion + "%");
            command.Parameters.AddWithValue("@puesto", "%" + puesto + "%");
            command.Parameters.AddWithValue("@habilidades", "%" + habilidades + "%");
            command.Parameters.AddWithValue("@pais", "%" + pais + "%");
            command.Parameters.AddWithValue("@estado", "%" + estado + "%");
            command.Parameters.AddWithValue("@municipio", "%" + municipio + "%");
            command.Parameters.AddWithValue("@disponibilidad", disponibilidad);
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    MiembroModel usuario = new MiembroModel()
                    {
                        Miembro_Id = reader["Usuario_Id"].ToString(),
                        Miembro_Nombre = reader["Usuario_Nombre"].ToString(),
                        Miembro_Apellidos = reader["Usuario_Apellidos"].ToString(),
                        Miembro_Profesion = reader["Usuario_Profesion"].ToString(),
                        Miembro_Puesto = reader["Usuario_Puesto"].ToString(),
                        Miembro_Habilidades = reader["Usuario_Habilidades"].ToString(),
                        Miembro_Fotografia = reader["Usuario_Fotografia"].ToString(),
                        Miembro_Correo_Electronico = reader["Usuario_Correo_Electronico"].ToString(),
                        Miembro_Telefono = reader["Usuario_Telefono"].ToString(),
                        Miembro_Celular = reader["Usuario_Celular"].ToString(),
                        Miembro_Fecha_Nacimiento = reader["Usuario_Fecha_Nacimiento"].ToString(),
                        Miembro_Fecha_Registro = reader["Usuario_Fecha_Registro"].ToString(),
                        Genero_Descripcion = reader["Usuario_Genero_Descripcion"].ToString(),
                        Miembro_Empresa = reader["Usuario_Empresa_Nombre"].ToString(),
                        Miembro_Tipo = reader["Usuario_Tipo"].ToString()
                    };
                    usuarios.Add(usuario);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                SlackLogs.SendMessage(e.Message);
            }
            finally { conn.Close(); }
            return usuarios;
        }
    }
}
