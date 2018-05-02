using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using WorklabsMx.Enum;
using WorklabsMx.Helpers;
using WorklabsMx.Models;

namespace WorklabsMx.Controllers
{
    public class EscritorioController : DataBaseModel
    {
        UploadImages ImageHelper;
        readonly string usuario_imagen_path, publicaciones_imagen_path;
        public EscritorioController()
        {
            ImageHelper = new UploadImages();
            List<ConfiguracionesModel> config = new ConfigurationsController().GetListConfiguraciones();
            usuario_imagen_path = config.Find(parametro => parametro.Parametro_Descripcion == "RUTA DE IMAGENES DE PERFILES DE USUARIOS").Parametro_Varchar_1;
            publicaciones_imagen_path = config.Find(parametro => parametro.Parametro_Descripcion == "RUTA DE IMAGENES DE PUBLICACIONES").Parametro_Varchar_1;
        }
        /// <summary>
        /// Obtiene los posts del muro
        /// </summary>
        /// <returns>Posts</returns>
        public List<PostModel> GetMuroPosts(string usuario_id, string usuario_tipo, int pagina_actual, int pagina_tamanio)
        {
            List<PostModel> posts = new List<PostModel>();
            List<UsuarioModel> usuarios = new List<UsuarioModel>();
            string post_user_id = string.Empty;
            try
            {
                conn.Open();
                command = CreateCommand();
                command.Connection = conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_vw_pro_Red_Social_Publicaciones_Paginacion";
                command.Parameters.AddWithValue("@Usuario_Id", usuario_id);
                command.Parameters.AddWithValue("@Usuario_Tipo", usuario_tipo);
                command.Parameters.AddWithValue("@Current_Page", pagina_actual);
                command.Parameters.AddWithValue("@Total_Pages", pagina_tamanio);

                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    post_user_id = !string.IsNullOrEmpty(reader["Miembro_Id"].ToString()) ? reader["Miembro_Id"].ToString() : reader["Colaborador_Empresa_Id"].ToString();
                    UsuarioModel usuario = usuarios.Find(user => user.Usuario_Id == post_user_id && user.Usuario_Tipo == reader["Usuario_Tipo"].ToString());
                    if (usuario == null)
                    {
                        usuario = new UsuarioModel
                        {
                            Usuario_Id = !string.IsNullOrEmpty(reader["Miembro_Id"].ToString()) ? reader["Miembro_Id"].ToString() : reader["Colaborador_Empresa_Id"].ToString(),
                            Usuario_Nombre = reader["Usuario_Nombre"].ToString(),
                            Usuario_Tipo = reader["Usuario_Tipo"].ToString(),
                            Usuario_Fotografia = reader["Usuario_Fotografia"].ToString(),
                            Usuario_Puesto = reader["Usuario_Puesto"].ToString(),
                            Usuario_Fotografia_Perfil = null//ImageHelper.DownloadFileFTP(reader["Usuario_Fotografia"].ToString(), usuario_imagen_path)
                        };
                        usuarios.Add(usuario);
                    }

                    posts.Add(new PostModel
                    {
                        Publicacion_Id = reader["Publicacion_Id"].ToString(),
                        Usuario = usuario,
                        Publicacion_Contenido = reader["Publicacion_Contenido"].ToString(),
                        Publicacion_Imagen = reader["Publicacion_Imagen"].ToString(),
                        Publicacion_Imagen_Ruta = reader["Publicacion_Imagen_Ruta"].ToString(),
                        Publicacion_Imagen_Post = null, //ImageHelper.DownloadFileFTP(reader["Publicacion_Imagen"].ToString(), publicaciones_imagen_path),
                        Publicacion_Fecha = reader["Publicacion_Fecha"].ToString(),
                        Publicacion_Comentarios_Cantidad = reader["Publicacion_Comentarios_Cantidad"].ToString(),
                        Publicacion_Me_Gustan_Cantidad = reader["Publicacion_Me_Gustan_Cantidad"].ToString(),
                        Publicacion_Me_Gusta_Usuario = reader["Publicacion_Me_Gusta_Usuario"].ToString()
                    });
                }
            }
            catch (Exception e)
            {
                SlackLogs.SendMessage(e.Message, GetType().Name, "GetMuroPosts");
                return null;
            }
            finally
            {
                conn.Close();
            }
            return posts;
        }
        /// <summary>
        /// Obtiene el listado de posts del usuario
        /// </summary>
        /// <returns>Listado de posts del usuario.</returns>
        /// <param name="usuario_id">Identificador del Usuario.</param>
		/// <param name="tipo">Tipo de usuario.</param>
        /// <param name="page">Pagina del post.</param>
        public List<PostModel> GetPerfilPosts(string usuario_id, string tipo, int page = 0)
        {
            List<PostModel> posts = new List<PostModel>();
            string query = "select * FROM vw_pro_Red_Social_Publicaciones " +
                "WHERE Publicacion_Estatus = 1 AND ";
            query += " Miembro_Id = ";
            if (tipo == ((int)TiposUsuarios.Colaborador).ToString())
                query += " Colaborador_Empresa_Id = ";
            query += "@usuario_id AND Usuario_Tipo = @tipo ORDER BY Publicacion_Fecha_Alta DESC OFFSET @page ROWS Fetch next 10 rows only";
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
                        Publicacion_Id = reader["Publicacion_Id"].ToString(),
                        Usuario = new UsuarioModel
                        {
                            Usuario_Id = reader["Miembro_Id"].ToString() == "" ? reader["Miembro_Id"].ToString() : reader["Colaborador_Empresa_Id"].ToString(),
                            Usuario_Nombre = reader["Usuario_Nombre"].ToString(),
                            Usuario_Tipo = reader["Usuario_Tipo"].ToString(),
                            Usuario_Fotografia = reader["Usuario_Fotografia"].ToString(),
                            Usuario_Puesto = reader["Usuario_Puesto"].ToString()
                        },
                        Publicacion_Contenido = reader["Publicacion_Contenido"].ToString(),
                        Publicacion_Imagen = reader["Publicacion_Imagen"].ToString(),
                        Publicacion_Imagen_Ruta = reader["Publicacion_Imagen_Ruta"].ToString(),
                        Publicacion_Fecha = reader["Publicacion_Fecha"].ToString(),
                        Publicacion_Comentarios_Cantidad = reader["Publicacion_Comentarios_Cantidad"].ToString(),
                        Publicacion_Me_Gustan_Cantidad = reader["Publicacion_Me_Gustan_Cantidad"].ToString()
                    });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                SlackLogs.SendMessage(e.Message, GetType().Name, "GetPerfilPosts");
            }
            finally { conn.Close(); }
            return posts;
        }
        /// <summary>
        /// Obtiene los likes del post
        /// </summary>
        /// <returns>Likes del post</returns>
        /// <param name="post_id">Identificador del post</param>
        public string GetLikesPublish(string post_id)
        {
            string query = "select Count(Me_Gusta_Publicacion_Id) FROM vw_pro_Red_Social_Publicaciones_Me_Gustan Where Publicacion_Id = @post_id AND Me_Gusta_Publicacion_Estatus = 1";
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
                SlackLogs.SendMessage(e.Message, GetType().Name, "GetLikesPublish");
            }
            finally { conn.Close(); }
            return "";
        }
        /// <summary>
        /// Obtiene los likes del comentario
        /// </summary>
        /// <returns>Cantidad de likes del comentario.</returns>
        /// <param name="comment_id">Identificador del comentario.</param>
        public string GetLikesComments(string comment_id)
        {
            string query = "select Count(Me_Gusta_Comentario_Id) FROM vw_pro_Red_Social_Publicaciones_Comentarios_Me_Gustan Where Comentario_Id = @comment_id AND Me_Gusta_Comentario_Estatus = 1";
            command = CreateCommand(query);
            command.Parameters.AddWithValue("@comment_id", comment_id);
            try
            {
                conn.Open();
                return command.ExecuteScalar().ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                SlackLogs.SendMessage(e.Message, GetType().Name, "GetLikesComments");
            }
            finally { conn.Close(); }
            return "";
        }
        /// <summary>
        /// Obtiene los comentarios del post
        /// </summary>
        /// <returns>Comentarios del post</returns>
        /// <param name="post_id">Identificador del post</param>
        public List<ComentarioModel> GetComentariosPost(string post_id, string usuario_id, string usuario_tipo, int pagina_actual, int pagina_tamanio)
        {
            List<ComentarioModel> comentarios = new List<ComentarioModel>();
            List<UsuarioModel> usuarios = new List<UsuarioModel>();
            string post_user_id = string.Empty;
            command = CreateCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_vw_pro_Red_Social_Publicaciones_Comentarios_Paginacion";
            command.Parameters.AddWithValue("@Post_Id", post_id);
            command.Parameters.AddWithValue("@Usuario_Id", usuario_id);
            command.Parameters.AddWithValue("@Usuario_Tipo", usuario_tipo);
            command.Parameters.AddWithValue("@Current_Page", pagina_actual);
            command.Parameters.AddWithValue("@Total_Pages", pagina_tamanio);

            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    post_user_id = !string.IsNullOrEmpty(reader["Miembro_Id"].ToString()) ? reader["Miembro_Id"].ToString() : reader["Colaborador_Empresa_Id"].ToString();
                    UsuarioModel usuario = usuarios.Find(user => user.Usuario_Id == post_user_id && user.Usuario_Tipo == reader["Usuario_Tipo"].ToString());
                    if (usuario == null)
                    {
                        usuario = new UsuarioModel
                        {
                            Usuario_Id = !string.IsNullOrEmpty(reader["Miembro_Id"].ToString()) ? reader["Miembro_Id"].ToString() : reader["Colaborador_Empresa_Id"].ToString(),
                            Usuario_Nombre = reader["Usuario_Nombre"].ToString(),
                            Usuario_Tipo = reader["Usuario_Tipo"].ToString(),
                            Usuario_Fotografia = reader["Usuario_Fotografia"].ToString(),
                            Usuario_Puesto = reader["Usuario_Puesto"].ToString(),
                            Usuario_Fotografia_Perfil = null //new UploadImages().DownloadFileFTP(reader["Usuario_Fotografia_Ruta"].ToString(), new ConfigurationsController().GetListConfiguraciones().Find(parametro => parametro.Parametro_Descripcion == "RUTA DE IMAGENES DE PERFILES DE USUARIOS").Parametro_Varchar_1)
                        };
                        usuarios.Add(usuario);
                    }

                    comentarios.Add(new ComentarioModel
                    {
                        Comentario_Id = reader["Comentario_Id"].ToString(),
                        Publicacion_Id = reader["Publicacion_Id"].ToString(),
                        Usuario = usuario,
                        Comentario_Contenido = reader["Comentario_Contenido"].ToString(),
                        Comentario_Imagen = reader["Comentario_Imagen"].ToString(),
                        //Comentario_Imagen_Comentario = ImageHelper.DownloadFileFTP(reader["Comentario_Imagen"].ToString(), publicaciones_imagen_path),
                        Comentario_Imagen_Ruta = reader["Comentario_Imagen_Ruta"].ToString(),
                        Comentario_Fecha = reader["Comentario_Fecha"].ToString(),
                        Comentario_Me_Gustan_Cantidad = reader["Comentario_Me_Gustan_Cantidad"].ToString(),
                        Comentario_Me_Gusta_Usuario = reader["Comentario_Me_Gusta_Usuario"].ToString()
                    });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                SlackLogs.SendMessage(e.Message, GetType().Name, "GetComentariosPost");
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
            string query = "SELECT * FROM cat_Menu WHERE Menu_Padre_Id " + (string.IsNullOrEmpty(menu_id) ? " IS NULL " : " = @menu_id ") + " AND Menu_Estatus = 1 ORDER BY Menu_Orden_Aparicion ASC";
            if (tipo == (int)TiposUsuarios.Colaborador)
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
                SlackLogs.SendMessage(e.Message, GetType().Name, "GetMenuiOS");
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
            string query = "select * from cat_Menu Where Menu_Estatus = 1 ORDER BY Menu_Orden_Aparicion";
            if (tipo == (int)TiposUsuarios.Colaborador)
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
                        Principal = false,
                        Menu_Padre_Id = reader["Menu_Padre_Id"].ToString()
                    });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                SlackLogs.SendMessage(e.Message, GetType().Name, "GetMenuAndroid");
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
        public bool PostLike(string post_id, string usuario_id, string usuario_tipo, string transaccion)
        {
            string miembro_id = null;
            string colaborador_id = null;
            if (usuario_tipo == ((int)TiposUsuarios.Miembro).ToString())
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
                command.CommandText = "sp_pro_Red_Social_Publicaciones_Me_Gustan";
                command.Parameters.AddWithValue("@Trasaccion", transaccion);
                command.Parameters.AddWithValue("@Publicacion_Id", post_id);
                command.Parameters.AddWithValue("@Miembro_Id", miembro_id);
                command.Parameters.AddWithValue("@Colaborador_Empresa_Id", colaborador_id);
                command.Parameters.AddWithValue("@Me_Gusta_Publicacion_Estatus", 1);
                command.Parameters.AddWithValue("@Me_Gusta_Publicacion_Id", "");

                command.Transaction = transaction;
                command.ExecuteNonQuery();
                transaction.Commit();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                transaction.Rollback();
                SlackLogs.SendMessage(e.Message, GetType().Name, "PostLike");
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }

        /// <summary>
        /// Agrega un like al post
        /// </summary>
        /// <param name="comentario_id">Identificador del comentario</param>
        /// <param name="usuario_id">Identificador del usuario</param>
        public bool CommentLike(string comentario_id, string usuario_id, string tipo, string transaccion)
        {
            string miembro_id = null;
            string colaborador_id = null;
            if (tipo == ((int)TiposUsuarios.Miembro).ToString())
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
                command.CommandText = "sp_pro_Red_Social_Publicaciones_Comentarios_Me_Gustan";
                command.Parameters.AddWithValue("@Trasaccion", transaccion);
                command.Parameters.AddWithValue("@Comentario_Id", comentario_id);
                command.Parameters.AddWithValue("@Miembro_Id", miembro_id);
                command.Parameters.AddWithValue("@Colaborador_Empresa_Id", colaborador_id);
                command.Parameters.AddWithValue("@Me_Gusta_Comentario_Estatus", 1);
                command.Parameters.AddWithValue("@Me_Gusta_Comentario_Id", DBNull.Value);

                command.Transaction = transaction;
                command.ExecuteNonQuery();
                transaction.Commit();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                transaction.Rollback();
                SlackLogs.SendMessage(e.Message, GetType().Name, "CommentLike");
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
        /// <param name="usuario_id">Identificador del miembro</param>
        /// <param name="tipo">Tipo de miembro</param>
        /// <param name="comentario">Comentario realizado</param>
        /// <param name="fotografia">Imagen a guardar</param> 
        /// <returns><c>true</c> Si el post fue comentado, <c>false</c> Existió algún error.</returns>
        public bool CommentPost(string post_id, string usuario_id, string tipo, string comentario, byte[] fotografia)
        {
            string miembro_id = null, colaborador_id = null, fotoNombre = null;
            if (tipo == ((int)TiposUsuarios.Miembro).ToString())
                miembro_id = usuario_id;
            else
                colaborador_id = usuario_id;
            try
            {
                if (fotografia.Length != 0)
                {
                    fotoNombre = Guid.NewGuid().ToString() + ".png";
                    if (!new UploadImages().UploadBitmapAsync(fotoNombre, fotografia, publicaciones_imagen_path))
                    {
                        return false;
                    }
                }
                conn.Open();
                transaction = conn.BeginTransaction();
                command = CreateCommand();
                command.Connection = conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_pro_Red_Social_Publicaciones_Comentarios";
                command.Parameters.AddWithValue("@Trasaccion", "ALTA");
                command.Parameters.AddWithValue("@Comentario_Id", DBNull.Value);
                if (!string.IsNullOrEmpty(miembro_id))
                    command.Parameters.AddWithValue("@miembro_Id", miembro_id);
                else
                    command.Parameters.AddWithValue("@miembro_Id", DBNull.Value);
                if (!string.IsNullOrEmpty(colaborador_id))
                    command.Parameters.AddWithValue("@Colaborador_Empresa_Id", colaborador_id);
                else
                    command.Parameters.AddWithValue("@Colaborador_Empresa_Id", DBNull.Value);
                command.Parameters.AddWithValue("@Comentario_Contenido", comentario);
                command.Parameters.AddWithValue("@Publicacion_Id", post_id);
                command.Parameters.AddWithValue("@Comentario_Estatus", 1);
                command.Parameters.AddWithValue("@Comentario_Imagen", fotoNombre);

                command.Transaction = transaction;
                command.ExecuteNonQuery();
                transaction.Commit();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                transaction.Rollback();
                SlackLogs.SendMessage(e.Message, GetType().Name, "CommentPost");
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
        /// <param name="fotografia">Bytes de la fotografía</param>
        public bool SetPost(string usuario_id, string tipo, string comentario, byte[] fotografia)
        {
            string miembro_id = null, colaborador_id = null, fotoNombre = null;
            if (tipo == ((int)TiposUsuarios.Miembro).ToString())
                miembro_id = usuario_id;
            else
                colaborador_id = usuario_id;
            try
            {
                conn.Open();
                if (fotografia.Length != 0)
                {
                    fotoNombre = Guid.NewGuid().ToString() + ".png";
                    var result = new UploadImages().UploadBitmapAsync(fotoNombre, fotografia, publicaciones_imagen_path);
                    if (!result)
                    {
                        return false;
                    }

                }
                transaction = conn.BeginTransaction();
                command = CreateCommand();
                command.Connection = conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_pro_Red_Social_Publicaciones";

                command.Parameters.AddWithValue("@Trasaccion", "ALTA");

                command.Parameters.AddWithValue("@Publicacion_Id", "");

                if (!string.IsNullOrEmpty(miembro_id))
                    command.Parameters.AddWithValue("@miembro_Id", miembro_id);
                else
                    command.Parameters.AddWithValue("@miembro_Id", DBNull.Value);
                if (!string.IsNullOrEmpty(colaborador_id))
                    command.Parameters.AddWithValue("@Colaborador_Empresa_Id", colaborador_id);
                else
                    command.Parameters.AddWithValue("@Colaborador_Empresa_Id", DBNull.Value);

                command.Parameters.AddWithValue("@Publicacion_Estatus", 1);

                command.Parameters.AddWithValue("@Publicacion_Contenido", comentario);

                command.Parameters.AddWithValue("@Publicacion_Imagen", fotoNombre);

                command.Transaction = transaction;
                command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                transaction.Rollback();
                SlackLogs.SendMessage(e.Message, GetType().Name, "SetPost");
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
            string query = "select * FROM vw_pro_Red_Social_Publicaciones " +
                "WHERE Publicacion_Id = @post_id";
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
                        Publicacion_Id = reader["Publicacion_Id"].ToString(),
                        Usuario = new UsuarioModel
                        {
                            Usuario_Id = reader["Miembro_Id"].ToString() == "" ? reader["Miembro_Id"].ToString() : reader["Colaborador_Empresa_Id"].ToString(),
                            Usuario_Nombre = reader["Usuario_Nombre"].ToString(),
                            Usuario_Tipo = reader["Usuario_Tipo"].ToString(),
                            Usuario_Fotografia = reader["Usuario_Fotografia"].ToString(),
                            Usuario_Puesto = reader["Usuario_Puesto"].ToString(),
                            //Usuario_Fotografia_Perfil = ImageHelper.DownloadFileFTP(reader["Usuario_Fotografia"].ToString(), usuario_imagen_path)
                        },
                        Publicacion_Contenido = reader["Publicacion_Contenido"].ToString(),
                        Publicacion_Imagen = reader["Publicacion_Imagen"].ToString(),
                        Publicacion_Imagen_Ruta = reader["Publicacion_Imagen_Ruta"].ToString(),
                        Publicacion_Fecha = reader["Publicacion_Fecha"].ToString(),
                        Publicacion_Comentarios_Cantidad = reader["Publicacion_Comentarios_Cantidad"].ToString(),
                        Publicacion_Me_Gustan_Cantidad = reader["Publicacion_Me_Gustan_Cantidad"].ToString()
                    };
                }
            }
            catch (Exception e)
            {
                SlackLogs.SendMessage(e.Message, GetType().Name, "GetSinglePost");
            }
            finally { conn.Close(); }
            return post;
        }
        /// <summary>
        /// Oculta el post
        /// </summary>
        /// <returns><c>true</c>, Si el post se ocultó <c>false</c> Existió algún error</returns>
        /// <param name="post_id">Identificador del post</param>
        public bool OcultarPost(string usuario_id, string usuario_tipo, string post_id)
        {
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                command = CreateCommand();
                command.Connection = conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_pro_Red_Social_Publicaciones";
                command.Parameters.AddWithValue("@Trasaccion", "BAJA");
                if (usuario_tipo == ((int)TiposUsuarios.Miembro).ToString())
                {
                    command.Parameters.AddWithValue("@Miembro_Id", usuario_id);
                    command.Parameters.AddWithValue("@Colaborador_Empresa_Id", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@Miembro_Id", DBNull.Value);
                    command.Parameters.AddWithValue("@Colaborador_Empresa_Id", usuario_id);
                }
                command.Parameters.AddWithValue("@Publicacion_Id", post_id);
                command.Parameters.AddWithValue("@Publicacion_Estatus", 0);
                command.Parameters.AddWithValue("@Publicacion_Contenido", "");
                command.Parameters.AddWithValue("@Publicacion_Imagen", "");

                command.Transaction = transaction;
                command.ExecuteNonQuery();
                transaction.Commit();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                transaction.Rollback();
                SlackLogs.SendMessage(e.Message, GetType().Name, "OcultarPost");
                return false;
            }
            finally
            {
                conn.Close();
            }

            return true;
        }

        public bool OcultarComment(string usuario_id, string usuario_tipo, string post_id, string comment_id)
        {
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                command = CreateCommand();
                command.Connection = conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_pro_Red_Social_Publicaciones_Comentarios";
                command.Parameters.AddWithValue("@Trasaccion", "BAJA");
                if (usuario_tipo == ((int)TiposUsuarios.Miembro).ToString())
                {
                    command.Parameters.AddWithValue("@Miembro_Id", usuario_id);
                    command.Parameters.AddWithValue("@Colaborador_Empresa_Id", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@Miembro_Id", DBNull.Value);
                    command.Parameters.AddWithValue("@Colaborador_Empresa_Id", usuario_id);
                }
                command.Parameters.AddWithValue("@Publicacion_Id", post_id);
                command.Parameters.AddWithValue("@Comentario_Id", comment_id);
                command.Parameters.AddWithValue("@Comentario_Estatus", 0);
                command.Parameters.AddWithValue("@Comentario_Contenido", "");
                command.Parameters.AddWithValue("@Comentario_Imagen", "");

                command.Transaction = transaction;
                command.ExecuteNonQuery();
                transaction.Commit();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                transaction.Rollback();
                SlackLogs.SendMessage(e.Message, GetType().Name, "OcultarPost");
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
            catch (Exception e) { SlackLogs.SendMessage(e.Message, GetType().Name, "GetMensajesReporte"); }
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
                command.CommandText = "sp_pro_Red_Social_Publicaciones_Reportes";
                command.Parameters.AddWithValue("@Trasaccion", "ALTA");
                command.Parameters.AddWithValue("@Reporte_Publicacion_Id", DBNull.Value);
                command.Parameters.AddWithValue("@Publicacion_Id", post_id);
                command.Parameters.AddWithValue("@Mensaje_Id", mensaje_id);
                if (miembro_tipo == TiposUsuarios.Miembro.ToString())
                {
                    command.Parameters.AddWithValue("@Miembro_Id", miembro_id);
                    command.Parameters.AddWithValue("@Colaborador_Empresa_Id", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@Colaborador_Empresa_Id", miembro_id);
                }

                command.Parameters.AddWithValue("@Reporte_Publicacion_Estatus", 1);

                command.Transaction = transaction;
                command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception e)
            {
                transaction.Rollback();
                SlackLogs.SendMessage(e.Message, GetType().Name, "ReportarPost");
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
                command.Parameters.AddWithValue("@Comment_Reporte_Fecha", DateTime.Now);

                command.Transaction = transaction;
                command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception e)
            {
                transaction.Rollback();
                SlackLogs.SendMessage(e.Message, GetType().Name, "ReportarComment");
                return false;
            }
            finally { conn.Close(); }
            return true;
        }

        public List<string> GetMuroPostID(int page = 0)
        {
            List<string> posts_id = new List<string>();
            string query = "select POST_ID FROM (SELECT POST_ID, POST_ESTATUS, Post_Fecha from Muro_Posts as p " +
                "INNER JOIN vw_pro_Usuarios_Directorio as m on p.Miembro_ID = m.Usuario_Id WHERE m.Usuario_Tipo = 1 " +
                "union all " +
                "SELECT POST_ID, POST_ESTATUS, Post_Fecha from Muro_Posts as p " +
                "INNER JOIN vw_pro_Usuarios_Directorio as c on p.Colaborador_Id = c.Usuario_Id WHERE c.Usuario_Tipo = 2) as Posts " +
                "WHERE POST_ESTATUS = 1 ORDER BY Post_Fecha DESC OFFSET @page ROWS Fetch next 10 rows only";
            command = CreateCommand(query);
            command.Parameters.AddWithValue("@page", page);
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    posts_id.Add(reader["POST_ID"].ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                SlackLogs.SendMessage(e.Message, GetType().Name, "GetMuroPostID");
            }
            finally
            {
                conn.Close();
            }
            return posts_id;
        }
        /// <summary>
        /// Cantidad de comentarios del post
        /// </summary>
        /// <returns>Cantidad de comentarios.</returns>
        /// <param name="post_id">Identificador del Post.</param>
        public string TotalComments(string post_id)
        {
            string query = "select count(Post_ID) from vw_Muro_Comments Where Post_ID = @post_id AND COMM_ESTATUS = 1";
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
                SlackLogs.SendMessage(e.Message, GetType().Name, "TotalComments");
            }
            finally
            {
                conn.Close();
            }
            return "0";
        }
    }
}