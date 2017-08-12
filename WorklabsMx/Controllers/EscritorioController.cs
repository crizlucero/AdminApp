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
            string query = "SELECT p.*, Usuario_Nombre, Usuario_Apellidos, Usuario_Fotografia, Usuario_Tipo from Muro_Posts as p " +
                "INNER JOIN vw_pro_Usuarios_Directorio as m on p.Miembro_ID = m.Usuario_Id " +
                "WHERE POST_ESTATUS = 1 ORDER BY Post_Fecha DESC OFFSET @page ROWS Fetch next 5 rows only";
            command = CreateCommand(query);
            command.Parameters.AddWithValue("@page", page);
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    PostModel post = new PostModel()
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
                    posts.Add(post);
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
			string query = "SELECT p.*, Usuario_Nombre, Usuario_Apellidos, Usuario_Fotografia, Usuario_Tipo from Muro_Posts as p " +
				"INNER JOIN vw_pro_Usuarios_Directorio as m on p.Miembro_ID = m.Usuario_Id " +
				"WHERE POST_ESTATUS = 1 AND m.Usuario_Id = @usuario_id AND m.Usuario_Tipo = @tipo " +
                "ORDER BY Post_Fecha DESC OFFSET @page ROWS Fetch next 5 rows only";
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
					PostModel post = new PostModel()
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
					posts.Add(post);
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
            finally
            {
                conn.Close();
            }
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
            string query = "SELECT TOP 10 mc.*, CONCAT(m.Miembro_Nombre,' ', m.Miembro_Apellidos) as Nombre, m.Miembro_Fotografia FROM Muro_Comments mc " +
                "INNER JOIN cat_Miembros m on mc.MIEMBRO_ID = m.MIEMBRO_ID " +
                "WHERE COMM_POST_ID = @post_id";
            command = CreateCommand(query);
            command.Parameters.AddWithValue("@post_id", post_id);
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ComentarioModel comentario = new ComentarioModel
                    {
                        COMM_ID = reader["COMM_ID"].ToString(),
                        MIEMBRO_ID = reader["MIEMBRO_ID"].ToString(),
                        COMM_POST_ID = reader["COMM_POST_ID"].ToString(),
                        COMM_FECHA = reader["COMM_FECHA"].ToString(),
                        COMM_CONTENIDO = reader["COMM_CONTENIDO"].ToString(),
                        COLABORADOR_ID = reader["COLABORADOR_ID"].ToString(),
                        COMM_ESTATUS = reader["COMM_ESTATUS"].ToString(),
                        Nombre = reader["Nombre"].ToString(),
                        Miembro_Fotografia = reader["Miembro_Fotografia"].ToString()
                    };

                    comentarios.Add(comentario);
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
            return comentarios;
        }
        /// <summary>
        /// Obtain the menu
        /// </summary>
        /// <returns>Menu</returns>
        /// <param name="menu_id">Identificador del menu (si no es raiz)</param>
        public List<ItemsMenu> GetMenu(int tipo, string menu_id = null)
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
                    ItemsMenu menu = new ItemsMenu
                    {
                        Menu_Id = reader["Menu_Id"].ToString(),
                        Label = reader["Menu_Nombre"].ToString(),
                        Controller = reader["Menu_Controller_iOS"].ToString(),
                        Admin = Convert.ToBoolean(reader["Menu_Solo_Admin"]),
                        Image = reader["Menu_Imagen_iOS"].ToString(),
                        Principal = false
                    };
                    menus.Add(menu);
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
        public bool CommentPost(string post_id, string miembro_id, string comentario)
        {
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

        public bool SetPost(string miembro_id, string colaborador_id, string comentario, string fotoNombre, byte[] fotografia)
        {
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
                command.Parameters.AddWithValue("@miembro_Id", miembro_id);
                command.Parameters.AddWithValue("@colaborador_Id", colaborador_id);
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
    }
}