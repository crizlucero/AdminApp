using System;
using System.Collections.Generic;
using System.Data;
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
            command = CreateCommand("select * from vw_pro_Usuarios_Directorio where Usuario_Id = @miembro_id AND Usuario_Tipo = @tipo");
            command.Parameters.AddWithValue("@miembro_id", miembro_id);
            command.Parameters.AddWithValue("@tipo", tipo);
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    miembro = new MiembroModel
                    {
                        Miembro_Id = reader["Usuario_Id"].ToString(),
                        Miembro_Nombre = reader["Usuario_Nombre"].ToString(),
                        Miembro_Apellidos = reader["Usuario_Apellidos"].ToString(),
                        Miembro_Fecha_Nacimiento = reader["Usuario_Fecha_Nacimiento"].ToString(),
                        Genero_Id = reader["Usuario_Genero_Id"].ToString(),
                        Genero_Descripcion = reader["Usuario_Genero_Descripcion"].ToString(),
                        Miembro_Correo_Electronico = reader["Usuario_Correo_Electronico"].ToString(),
                        Miembro_Telefono = reader["Usuario_Telefono"].ToString(),
                        Miembro_Celular = reader["Usuario_Celular"].ToString(),
                        Miembro_Profesion = reader["Usuario_Profesion"].ToString(),
                        Miembro_Puesto = reader["Usuario_Puesto"].ToString(),
                        Miembro_Habilidades = reader["Usuario_Habilidades"].ToString(),
                        Miembro_Identificacion = reader["Usuario_Identificacion"].ToString(),
                        Miembro_Llave_Acceso = reader["Usuario_Llave_Acceso"].ToString(),
                        Miembro_Fotografia = reader["Usuario_Fotografia"].ToString(),
                        Miembro_Fecha_Registro = reader["Usuario_Fecha_Registro"].ToString(),
                        Miembro_Estatus = reader["Usuario_Estatus"].ToString(),
                        Miembro_Tipo = reader["Usuario_Tipo"].ToString()
                    };
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
        public KeyValuePair<string, string> GetMemberName(string miembro_id, string tipo)
        {
            KeyValuePair<string, string> data = new KeyValuePair<string, string>();
            command = CreateCommand("select Concat(Usuario_Nombre, ' ', Usuario_Apellidos) as Nombre, Usuario_Fotografia from vw_pro_Usuarios_Directorio " +
                "where Usuario_Id = @miembro_id AND Usuario_Tipo = @tipo");
            command.Parameters.AddWithValue("@miembro_id", miembro_id);
            command.Parameters.AddWithValue("@tipo", tipo);
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    data = new KeyValuePair<string, string>(reader["Nombre"].ToString(), reader["Usuario_Fotografia"].ToString().Replace(@"\", "/"));
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
            command = CreateCommand("SELECT Usuario_Llave_Acceso FROM vw_pro_Usuarios_Directorio WHERE Usuario_Id = @usuario_id AND Usuario_Tipo = @tipo");
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
        public List<MiembroModel> GetDirectorioUsuarios(string nombre = "", string apellido = "", string puesto = "", string profesion = "", string habilidades = "",
                                                        bool disponibilidad = true, string pais = "", string estado = "", string municipio = "")
        {
            List<MiembroModel> usuarios = new List<MiembroModel>();

            command = CreateCommand("select * from vw_pro_Usuarios_Directorio WHERE Usuario_Nombre IS NOT NULL AND Usuario_Estatus = 1 AND " +
                "Usuario_Nombre LIKE @nombre AND Usuario_Apellidos LIKE @apellido AND " +
                "Usuario_Profesion LIKE @profesion AND Usuario_Puesto LIKE @puesto AND " +
                "Usuario_Habilidades LIKE @habilidades AND Usuario_Empresa_Pais_Descripcion LIKE @pais AND " +
                "Usuario_Empresa_Estado_Descripcion LIKE @estado and Usuario_Empresa_Municipio_Descripcion LIKE @municipio AND Usuario_Disponibilidad_Trabajo LIKE @disponibilidad");
            command.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
            command.Parameters.AddWithValue("@apellido", "%" + apellido + "%");
            command.Parameters.AddWithValue("@profesion", "%" + profesion + "%");
            command.Parameters.AddWithValue("@puesto", "%" + puesto + "%");
            command.Parameters.AddWithValue("@habilidades", "%" + habilidades + "%");
            command.Parameters.AddWithValue("@pais", "%" + pais + "%");
            command.Parameters.AddWithValue("@estado", "%" + estado + "%");
            command.Parameters.AddWithValue("@municipio", "%" + municipio + "%");
            command.Parameters.AddWithValue("@disponibilidad", "%" + disponibilidad + "%");
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    usuarios.Add(new MiembroModel
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
                    });
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
        /// <summary>
        /// Actualiza los datos del usuario
        /// </summary>
        /// <returns><c>true</c>, Se pudo hacer el cambio de datos, <c>false</c> existió algún error.</returns>
        /// <param name="usuario_id">Identificador del usuario</param>
        /// <param name="nombre">Nombre del usuario</param>
        /// <param name="apellido">Apellido del usuario</param>
        /// <param name="correo">Correo del usuario</param>
        /// <param name="telefono">Telefono del usuario</param>
        /// <param name="celular">Celular del usuario</param>
        /// <param name="profesion">Profesion del usuario</param>
        /// <param name="puesto">Puesto del usuario</param>
        /// <param name="habilidades">Habilidades del usuario</param>
        /// <param name="fechaNacimiento">Fecha nacimiento del usuario</param>
        /// <param name="foto">Foto del usuario</param>
        public bool UpdateDataMiembros(int usuario_id, string nombre, string apellido, string correo, string telefono, string celular,
                                       string profesion, string puesto, string habilidades, DateTime fechaNacimiento, string foto)
        {
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                command = CreateCommand();
                command.Connection = conn;
                command.Transaction = transaction;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_Perfil_Miembros";

                command.Parameters.AddWithValue("@Miembro_Id", usuario_id);
                command.Parameters.AddWithValue("@Miembro_Nombre", nombre);
                command.Parameters.AddWithValue("@Miembro_Apellidos", apellido);
                command.Parameters.AddWithValue("@Miembro_Correo_Electronico", correo);
                command.Parameters.AddWithValue("@Miembro_Telefono", telefono);
                command.Parameters.AddWithValue("@Miembro_Celular", celular);
                command.Parameters.AddWithValue("@Miembro_Profesion", profesion);
                command.Parameters.AddWithValue("@Miembro_Puesto", puesto);
                command.Parameters.AddWithValue("@Miembro_Habilidades", habilidades);
                command.Parameters.AddWithValue("@Miembro_Fecha_Nacimiento", fechaNacimiento);
                command.Parameters.AddWithValue("@Miembro_Fotografia", foto);

                command.Transaction = transaction;
                command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception e)
            {
                SlackLogs.SendMessage(e.Message);
                transaction.Rollback();
                return false;
            }
            finally { conn.Close(); }
            return true;
        }
        /// <summary>
        /// Revisa si el usuario es favorito.
        /// </summary>
        /// <returns>Regresa el identificador y estatus del usuario favorito</returns>
        /// <param name="miembro_id">Identificador del usuario</param>
        /// <param name="miembro_tipo">Tipo del usuario</param>
        /// <param name="miembro_favorito_id">Identificador del usuario favorito</param>
        /// <param name="miembro_favorito_tipo">Tipo del usuario favorito</param>
        public KeyValuePair<int, bool> IsMiembroFavorito(string miembro_id, string miembro_tipo, string miembro_favorito_id, string miembro_favorito_tipo)
        {
            KeyValuePair<int, bool> Favorito = new KeyValuePair<int, bool>();
            try
            {
                conn.Open();
                command = CreateCommand("SELECT Miembros_Favoritos_Id, CAST(Miembros_Favoritos_Estatus AS BIT) AS Estatus FROM pro_Miembros_Favoritos WHERE " +
                "Usuario_Id = @miembro_id AND Usuario_Tipo = @miembro_tipo AND Usuario_Favorito_Id = @miembro_favorito_id AND Usuario_Favorito_Tipo = @miembro_favorito_tipo AND Usuario_Estatus = 1");
                command.Parameters.AddWithValue("@miembro_id", miembro_id);
                command.Parameters.AddWithValue("@miembro_tipo", miembro_tipo);
                command.Parameters.AddWithValue("@miembro_favorito_id", miembro_favorito_id);
                command.Parameters.AddWithValue("@miembro_favorito_tipo", miembro_favorito_tipo);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Favorito = new KeyValuePair<int, bool>(reader.GetInt32(0), reader.GetBoolean(1));
                }
            }
            catch (Exception e) { SlackLogs.SendMessage(e.Message); }
            finally { conn.Close(); }
            return Favorito;
        }
        /// <summary>
        /// Agrega a algún favorito
        /// </summary>
        /// <returns><c>true</c>, Si fue agregado a los favoritos, <c>false</c> algún error.</returns>
        /// <param name="miembro_id">Identificador del usuario</param>
        /// <param name="miembro_tipo">Tipo del usuario</param>
        /// <param name="miembro_favorito_id">Identificador del usuario favorito</param>
        /// <param name="miembro_favorito_tipo">Tipo del usuario favorito</param>
        public bool AddMiembroFavorito(string miembro_id, string miembro_tipo, string miembro_favorito_id, string miembro_favorito_tipo)
        {
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                command = CreateCommand();
                command.Connection = conn;
                command.Transaction = transaction;
                command.CommandText = "sp_pro_Miembros_Favoritos";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Transaccion", "ALTA");
                command.Parameters.AddWithValue("@Miembro_Id", miembro_id);
                command.Parameters.AddWithValue("@Miembro_Tipo", miembro_tipo);
                command.Parameters.AddWithValue("@Miembro_Favorito_Id", miembro_favorito_id);
                command.Parameters.AddWithValue("@Miembro_Favorito_Tipo", miembro_favorito_tipo);
                command.Parameters.AddWithValue("@Miembros_Favoritos_Estatus", 1);

                command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception e)
            {
                SlackLogs.SendMessage(e.Message);
                transaction.Rollback();
                return false;
            }
            finally { conn.Close(); }
            return true;
        }
        /// <summary>
        /// Cambia el estatus de los favoritos
        /// </summary>
        /// <returns><c>true</c>, Si el miembro favorito fue removido, <c>false</c> algún error.</returns>
        /// <param name="Favorite">Favorite.</param>
        public bool RemoveMiembroFavorito(KeyValuePair<int, bool> Favorite)
        {
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                command = CreateCommand();
                command.Connection = conn;
                command.Transaction = transaction;
                command.CommandText = "sp_pro_Miembros_Favoritos";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Transaccion", "BAJA");
                command.Parameters.AddWithValue("@Miembros_Favoritos_Id", Favorite.Key);
                command.Parameters.AddWithValue("@Miembros_Favoritos_Estatus", !Favorite.Value);

                command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception e)
            {
                SlackLogs.SendMessage(e.Message);
                transaction.Rollback();
                return false;
            }
            finally { conn.Close(); }
            return true;
        }

        public List<MiembroModel> GetMiembrosFavoritos(string usuario_id, string usuario_tipo)
        {
            List<MiembroModel> usuarios = new List<MiembroModel>();

            command = CreateCommand("select duf.* from pro_Miembros_Favoritos AS mf " +
                                    "inner join vw_pro_Usuarios_Directorio as duf on mf.Usuario_Favorito_Id = duf.Usuario_Id " +
                                    "AND mf.Usuario_Favorito_Tipo = duf.Usuario_Tipo " +
                                    "WHERE Miembros_Favoritos_Estatus = 1 " +
                                    "AND mf.Usuario_Id = @usuario_id AND mf.Usuario_Tipo = @usuario_tipo");
            command.Parameters.AddWithValue("@usuario_id", usuario_id);
            command.Parameters.AddWithValue("@usuario_tipo", usuario_tipo);
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    usuarios.Add(new MiembroModel
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
                    });
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