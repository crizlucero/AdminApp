using System;
using System.Collections.Generic;
using System.Data;
using WorklabsMx.Helpers;
using WorklabsMx.Models;

namespace WorklabsMx.Controllers
{
    public class EscritorioController : DataBaseModel
    {
        /// <summary>
        /// Obtiene los posts del muro
        /// </summary>
        /// <returns>Posts</returns>
        public List<PostModel> GetMuroPosts(int page = 0)
        {

            List<PostModel> posts = new List<PostModel>();
            string query = "select * FROM (SELECT p.*, Usuario_Id, Usuario_Nombre, Usuario_Apellidos, Usuario_Fotografia, Usuario_Tipo from Muro_Posts as p " +
                "INNER JOIN vw_pro_Usuarios_Directorio as m on p.Miembro_ID = m.Usuario_Id WHERE m.Usuario_Tipo = 0 " +
                "union all " +
                "SELECT p.*, Usuario_Id, Usuario_Nombre, Usuario_Apellidos, Usuario_Fotografia, Usuario_Tipo from Muro_Posts as p " +
                "INNER JOIN vw_pro_Usuarios_Directorio as c on p.Colaborador_Id = c.Usuario_Id WHERE c.Usuario_Tipo = 1) as Posts " +
                "WHERE POST_ESTATUS = 1 ORDER BY Post_Fecha DESC OFFSET @page ROWS Fetch next 10 rows only";
            command = CreateCommand(query);
            command.Parameters.AddWithValue("@page", page);
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    posts.Add(new PostModel
                    {
                        POST_ID = reader["POST_ID"].ToString(),
                        Tipo = reader["Usuario_Tipo"].ToString(),
                        MIEMBRO_ID = reader["Usuario_Id"].ToString(),
                        POST_FECHA = reader["POST_FECHA"].ToString(),
                        POST_FOTO_URL = reader["POST_FOTO_URL"].ToString(),
                        POST_CONTENIDO = reader["POST_CONTENIDO"].ToString(),
                        Miembro_Nombre = reader["Usuario_Nombre"].ToString(),
                        Miembro_Apellidos = reader["Usuario_Apellidos"].ToString(),
                        Miembro_Fotografia = reader["Usuario_Fotografia"].ToString()
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
            return posts;
        }

        public List<PostModel> GetPerfilPosts(string usuario_id, string tipo, int page = 0)
        {

            List<PostModel> posts = new List<PostModel>();
            string query = "select * FROM (SELECT p.*, Usuario_Id, Usuario_Nombre, Usuario_Apellidos, Usuario_Fotografia, Usuario_Tipo from Muro_Posts as p " +
                "INNER JOIN vw_pro_Usuarios_Directorio as m on p.Miembro_ID = m.Usuario_Id WHERE m.Usuario_Tipo = 0 " +
                "union all " +
                "SELECT p.*, Usuario_Id, Usuario_Nombre, Usuario_Apellidos, Usuario_Fotografia, Usuario_Tipo from Muro_Posts as p " +
                "INNER JOIN vw_pro_Usuarios_Directorio as c on p.Colaborador_Id = c.Usuario_Id WHERE c.Usuario_Tipo = 1) as Posts " +
                "WHERE POST_ESTATUS = 1 AND Usuario_Id = @usuario_id AND Usuario_Tipo = @tipo ORDER BY Post_Fecha DESC OFFSET @page ROWS Fetch next 10 rows only";
            command = CreateCommand(query);
            command.Parameters.AddWithValue("@page", page);
            command.Parameters.AddWithValue("@usuario_id", usuario_id);
            command.Parameters.AddWithValue("@tipo", tipo);
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    posts.Add(new PostModel
                    {
                        POST_ID = reader["POST_ID"].ToString(),
                        Tipo = reader["Usuario_Tipo"].ToString(),
                        MIEMBRO_ID = reader["MIEMBRO_ID"].ToString(),
                        POST_FECHA = reader["POST_FECHA"].ToString(),
                        POST_FOTO_URL = reader["POST_FOTO_URL"].ToString(),
                        POST_CONTENIDO = reader["POST_CONTENIDO"].ToString(),
                        Miembro_Nombre = reader["Usuario_Nombre"].ToString(),
                        Miembro_Apellidos = reader["Usuario_Apellidos"].ToString(),
                        Miembro_Fotografia = reader["Usuario_Fotografia"].ToString()
                    });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                SlackLogs.SendMessage(e.Message);
            }
            finally { conn.Close(); }
            return posts;
        }
        /// <summary>
        /// Obtiene los likes del post
        /// </summary>
        /// <returns>Likes del post</returns>
        /// <param name="post_id">Identificador del post</param>
        public string GetLikes(string post_id)
        {
            string query = "SELECT count(POST_ID) FROM MuroPosts_Likes muro WHERE POST_ID = @post_id AND LIKE_ESTATUS = 1";
            command = CreateCommand(query);
            command.Parameters.AddWithValue("@post_id", post_id);
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
        /// Obtiene los comentarios del post
        /// </summary>
        /// <returns>Comentarios del post</returns>
        /// <param name="post_id">Identificador del post</param>
        public List<ComentarioModel> GetComentariosPost(string post_id)
        {
            List<ComentarioModel> comentarios = new List<ComentarioModel>();
            string query = "SELECT mc.*, CONCAT(d.Usuario_Nombre,' ', d.Usuario_Apellidos) as Nombre, d.Usuario_Fotografia, d.Usuario_Tipo FROM vw_Muro_Comments mc " +
                "INNER JOIN vw_pro_Usuarios_Directorio d on mc.MIEMBRO_ID = d.Usuario_Id " +
                "WHERE POST_ID = @post_id AND COMM_ESTATUS = 0 AND d.Usuario_Tipo = CASE WHEN mc.Tipo = 'MIEMBRO' Then 0 ELSE 1 END ORDER by COMM_FECHA";
            command = CreateCommand(query);
            command.Parameters.AddWithValue("@post_id", post_id);
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comentarios.Add(new ComentarioModel
                    {
                        COMM_ID = reader["COMM_ID"].ToString(),
                        USUARIO_ID = reader["MIEMBRO_ID"].ToString(),
                        POST_ID = reader["POST_ID"].ToString(),
                        COMM_FECHA = reader["COMM_FECHA"].ToString(),
                        COMM_CONTENIDO = reader["COMM_CONTENIDO"].ToString(),
                        COMM_ESTATUS = reader["COMM_ESTATUS"].ToString(),
                        Nombre = reader["Nombre"].ToString(),
                        Miembro_Fotografia = reader["Miembro_Fotografia"].ToString(),
                        USUARIO_TIPO = reader["Usuario_Tipo"].ToString()
                    });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                SlackLogs.SendMessage(e.Message);
            }
            finally { conn.Close(); }
            return comentarios;
        }
        /// <summary>
        /// Obtiene el menú de iOS
        /// </summary>
        /// <returns>Menu</returns>
        /// <param name="menu_id">Identificador del menu (si no es raiz)</param>
        public List<ItemsMenu> GetMenuiOS(int tipo, string menu_id = null)
        {
            List<ItemsMenu> menus = new List<ItemsMenu>();
            string query = "SELECT * FROM cat_Menu WHERE Menu_Padre_Id " + (menu_id == null ? " IS NULL" : " = @menu_id ");
            if (tipo == 1)
            {
                query += " AND Menu_Solo_Admin = 0";
            }
            command = CreateCommand(query);
            if (menu_id != null)
                command.Parameters.AddWithValue("@menu_id", menu_id);

            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    menus.Add(new ItemsMenu
                    {
                        Menu_Id = reader["Menu_Id"].ToString(),
                        Label = reader["Menu_Nombre"].ToString(),
                        Controller = reader["Menu_Controller_iOS"].ToString(),
                        Admin = Convert.ToBoolean(reader["Menu_Solo_Admin"]),
                        Image = reader["Menu_Imagen_iOS"].ToString(),
                        Principal = false
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

            return menus;
        }
        /// <summary>
        /// Obtiene el menú de Android
        /// </summary>
        /// <returns>Menu</returns>
        /// <param name="menu_id">Identificador del menu (si no es raiz)</param>
        public List<ItemsMenu> GetMenuAndroid(int tipo, string menu_id = null)
        {
            List<ItemsMenu> menus = new List<ItemsMenu>();
            string query = "SELECT * FROM cat_Menu WHERE Menu_Padre_Id " + (string.IsNullOrEmpty(menu_id) ? " IS NULL" : " = @menu_id ");
            if (tipo == 1)
            {
                query += " AND Menu_Solo_Admin = 0";
            }
            command = CreateCommand(query);
            if (menu_id != null)
                command.Parameters.AddWithValue("@menu_id", menu_id);

            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    menus.Add(new ItemsMenu
                    {
                        Menu_Id = reader["Menu_Id"].ToString(),
                        Label = reader["Menu_Nombre"].ToString(),
                        Controller = reader["Menu_Controller_Android"].ToString(),
                        Admin = Convert.ToBoolean(reader["Menu_Solo_Admin"]),
                        Image = reader["Menu_Imagen_Android"].ToString(),
                        Principal = false
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

            return menus;
        }
        /// <summary>
        /// Agrega un like al post
        /// </summary>
        /// <param name="post_id">Identificador del post</param>
        /// <param name="usuario_id">Identificador del usuario</param>
        public bool PostLike(string post_id, string usuario_id, string tipo)
        {
            string miembro_id = null;
            string colaborador_id = null;
            if (tipo == "0")
                miembro_id = usuario_id;
            else
                colaborador_id = usuario_id;
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                command = CreateCommand();
                command.Connection = conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_Miembros_Posts_Likes";
                command.Parameters.AddWithValue("@Post_Id", post_id);
                command.Parameters.AddWithValue("@MIEMBRO_Id", miembro_id);
                command.Parameters.AddWithValue("@COLABORADOR_Id", colaborador_id);
                command.Parameters.AddWithValue("@Like_Estatus", 1);
                command.Parameters.AddWithValue("@Like_Fecha", DateTime.Now);

                command.Transaction = transaction;
                command.ExecuteNonQuery();
                transaction.Commit();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                transaction.Rollback();
                SlackLogs.SendMessage(e.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }
        /// <summary>
        /// Agrega un comentario al post
        /// </summary>
        /// <param name="post_id">Identificador del post</param>
        /// <param name="miembro_id">Identificador del miembro</param>
        /// <param name="comentario">Comentario realizado</param>
        /// <returns><c>true</c> Si el post fue comentado, <c>false</c> Existió algún error.</returns>
        public bool CommentPost(string post_id, string usuario_id, string tipo, string comentario)
        {
			string miembro_id = null;
			string colaborador_id = null;
			if (tipo == "0")
				miembro_id = usuario_id;
			else
				colaborador_id = usuario_id;
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                command = CreateCommand();
                command.Connection = conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_Comentar";
                command.Parameters.AddWithValue("@MIEMBRO_Id", miembro_id);
                command.Parameters.AddWithValue("@Comm_Contenido", comentario);
                command.Parameters.AddWithValue("@Comm_Fecha", DateTime.Now);
                command.Parameters.AddWithValue("@Comm_Post_Id", post_id);
                command.Parameters.AddWithValue("@colaborador_Id", colaborador_id);
                command.Parameters.AddWithValue("@comm_estatus", 1);

                command.Transaction = transaction;
                command.ExecuteNonQuery();
                transaction.Commit();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                transaction.Rollback();
                SlackLogs.SendMessage(e.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }

            return true;
        }
        /// <summary>
        /// Guarda el post
        /// </summary>
        /// <returns><c>true</c>, si se guarda el post <c>false</c> existió algún problema.</returns>
        /// <param name="usuario_id">Identificador del usuario</param>
        /// <param name="tipo">Tipo de usuario</param>
        /// <param name="comentario">Comentario.</param>
        /// <param name="fotoNombre">Nombre de la fotografía</param>
        /// <param name="fotografia">Bytes de la fotografía</param>
        public bool SetPost(string usuario_id, string tipo, string comentario, string fotoNombre, byte[] fotografia)
        {
            string miembro_id = null;
            string colaborador_id = null;
            if (tipo == "0")
                miembro_id = usuario_id;
            else
                colaborador_id = usuario_id;
            try
            {
                conn.Open();
                if (fotografia != null)
                {
                    new UploadImages().UploadBitmapAsync(fotografia);
                }
                transaction = conn.BeginTransaction();
                command = CreateCommand();
                command.Connection = conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_Postear";
                if (!string.IsNullOrEmpty(miembro_id))
                    command.Parameters.AddWithValue("@miembro_Id", miembro_id);
                else
                    command.Parameters.AddWithValue("@miembro_Id", DBNull.Value);
                if (!string.IsNullOrEmpty(colaborador_id))
                    command.Parameters.AddWithValue("@colaborador_Id", colaborador_id);
                else
                    command.Parameters.AddWithValue("@colaborador_Id", DBNull.Value);

                command.Parameters.AddWithValue("@Post_Fecha", DateTime.Now);
                command.Parameters.AddWithValue("@Post_Estatus", 1);

                command.Parameters.AddWithValue("@Post_Contenido", comentario);

                command.Parameters.AddWithValue("@Post_Fotografia", fotoNombre);

                command.Transaction = transaction;
                command.ExecuteNonQuery();
                transaction.Commit();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                transaction.Rollback();
                SlackLogs.SendMessage(e.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }

            return true;
        }
        /// <summary>
        /// Obtiene un sólo post
        /// </summary>
        /// <returns>Post</returns>
        /// <param name="post_id">Identificador del post</param>
        public PostModel GetSinglePost(string post_id)
        {
            PostModel post = new PostModel();
            string query = "select * FROM (SELECT p.*, Usuario_Nombre, Usuario_Apellidos, Usuario_Fotografia, Usuario_Tipo from Muro_Posts as p " +
                "INNER JOIN vw_pro_Usuarios_Directorio as m on p.Miembro_ID = m.Usuario_Id WHERE m.Usuario_Tipo = 0 " +
                "union all " +
                "SELECT p.*, Usuario_Nombre, Usuario_Apellidos, Usuario_Fotografia, Usuario_Tipo from Muro_Posts as p " +
                "INNER JOIN vw_pro_Usuarios_Directorio as c on p.Colaborador_Id = c.Usuario_Id WHERE c.Usuario_Tipo = 1) as Posts " +
                "WHERE POST_ID = @post_id";
            try
            {
                conn.Open();
                command = CreateCommand(query);
                command.Parameters.AddWithValue("@post_id", post_id);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    post = new PostModel
                    {
                        POST_ID = reader["POST_ID"].ToString(),
                        Tipo = reader["Usuario_Tipo"].ToString(),
                        MIEMBRO_ID = reader["MIEMBRO_ID"].ToString(),
                        POST_FECHA = reader["POST_FECHA"].ToString(),
                        POST_FOTO_URL = reader["POST_FOTO_URL"].ToString(),
                        POST_CONTENIDO = reader["POST_CONTENIDO"].ToString(),
                        Miembro_Nombre = reader["Usuario_Nombre"].ToString(),
                        Miembro_Apellidos = reader["Usuario_Apellidos"].ToString(),
                        Miembro_Fotografia = reader["Usuario_Fotografia"].ToString()
                    };
                }
            }
            catch (Exception e)
            {
                SlackLogs.SendMessage(e.Message);
            }
            finally { conn.Close(); }
            return post;
        }
        /// <summary>
        /// Oculta el post
        /// </summary>
        /// <returns><c>true</c>, Si el post se ocultó <c>false</c> Existió algún error</returns>
        /// <param name="miembro_id">Identificador del miembro</param>
        /// <param name="post_id">Identificador del post</param>
        /// <param name="post_estatus">Estado del post</param>
        public bool OcultarPost(string miembro_id, string post_id, int post_estatus)
        {
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                command = CreateCommand();
                command.Connection = conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_Muro_Posts_Ocultar";
                command.Parameters.AddWithValue("@miembro_Id", miembro_id);
                command.Parameters.AddWithValue("@Post_Id", post_id);
                command.Parameters.AddWithValue("@Post_Estatus", post_estatus);

                command.Transaction = transaction;
                command.ExecuteNonQuery();
                transaction.Commit();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                transaction.Rollback();
                SlackLogs.SendMessage(e.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }

            return true;
        }

        public bool OcultarComment(string comment_id, int comment_estatus)
        {
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                command = CreateCommand();
                command.Connection = conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_Muro_Comentarios_Ocultar";
                command.Parameters.AddWithValue("@Comment_Id", comment_id);
                command.Parameters.AddWithValue("@Comment_Estatus", comment_estatus);

                command.Transaction = transaction;
                command.ExecuteNonQuery();
                transaction.Commit();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                transaction.Rollback();
                SlackLogs.SendMessage(e.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }

            return true;
        }

        /// <summary>
        /// Mensajes para reportar
        /// </summary>
        /// <returns>Mensajes</returns>
        public Dictionary<int, string> GetMensajesReporte()
        {
            Dictionary<int, string> reportes = new Dictionary<int, string>();
            string query = "SELECT * FROM cat_Posts_Reportes_Mensajes";
            try
            {
                conn.Open();
                command = CreateCommand(query);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    reportes.Add(Convert.ToInt32(reader["Post_Reporte_Id"]), reader["Reporte_Mensaje_Descripcion"].ToString());
                }
            }
            catch (Exception e) { SlackLogs.SendMessage(e.Message); }
            finally { conn.Close(); }

            return reportes;
        }
        /// <summary>
        /// Se reporta el post
        /// </summary>
        /// <returns><c>true</c>, Si fue reportado <c>false</c> Existió algún error</returns>
        /// <param name="post_id">Identificador del post</param>
        /// <param name="miembro_id">Identificador del miembro que reporta</param>
        /// <param name="miembro_tipo">Tipo del miembro que reporta.</param>
        /// <param name="mensaje_id">Identificador del mensaje de reporte</param>
        public bool ReportarPost(string post_id, string miembro_id, string miembro_tipo, int mensaje_id)
        {
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                command = CreateCommand();
                command.Connection = conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_pro_Reportar_Post";
                command.Parameters.AddWithValue("@Post_Id", post_id);
                command.Parameters.AddWithValue("@Miembro_Id", miembro_id);
                command.Parameters.AddWithValue("@Miembro_Tipo", miembro_tipo);
                command.Parameters.AddWithValue("@Mensaje_Id", mensaje_id);

                command.Transaction = transaction;
                command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception e)
            {
                transaction.Rollback();
                SlackLogs.SendMessage(e.Message);
                return false;
            }
            finally { conn.Close(); }
            return true;
        }

        public bool ReportarComment(string comment_id, string miembro_id, string miembro_tipo, int mensaje_id)
        {
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                command = CreateCommand();
                command.Connection = conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_pro_Reportar_Comentario";
                command.Parameters.AddWithValue("@Comment_Id", comment_id);
                command.Parameters.AddWithValue("@Miembro_Id", miembro_id);
                command.Parameters.AddWithValue("@Miembro_Tipo", miembro_tipo);
                command.Parameters.AddWithValue("@Mensaje_Id", mensaje_id);

                command.Transaction = transaction;
                command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception e)
            {
                transaction.Rollback();
                SlackLogs.SendMessage(e.Message);
                return false;
            }
            finally { conn.Close(); }
            return true;
        }
    }
}