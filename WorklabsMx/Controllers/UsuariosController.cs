using System;
using System.Collections.Generic;
using WorklabsMx.Models;
using WorklabsMx.Helpers;
using WorklabsMx.Enum;
using System.Data;

namespace WorklabsMx.Controllers
{
    public class UsuariosController : DataBaseModel
    {
        UploadImages ImageHelper;
        readonly string usuario_imagen_path, empresa_imagen_path;

        public UsuariosController()
        {
            ImageHelper = new UploadImages();
            usuario_imagen_path = (new ConfigurationsController().GetListConfiguraciones() != null) ? new ConfigurationsController().GetListConfiguraciones().Find(parametro => parametro.Parametro_Descripcion == "RUTA DE IMAGENES DE PERFILES DE USUARIOS").Parametro_Varchar_1 : "";
            empresa_imagen_path = (new ConfigurationsController().GetListConfiguraciones() != null) ? new ConfigurationsController().GetListConfiguraciones().Find(parametro => parametro.Parametro_Descripcion == "RUTA DE IMAGENES DE PERFILES DE EMPRESAS").Parametro_Varchar_1 : "";
        }

        /// <summary>
        /// Obtiene la información del miembro
        /// </summary>
        /// <returns>Información del miembro</returns>
        /// <param name="miembro_id">Identificador del miembro</param>
        public UsuarioModel GetMemberData(string miembro_id, string tipo)
        {
            UsuarioModel miembro = new UsuarioModel();
            command = CreateCommand("select * from vw_pro_Directorio_Usuarios where Usuario_Id = @miembro_id AND Usuario_Tipo = @tipo");
            command.Parameters.AddWithValue("@miembro_id", miembro_id);
            command.Parameters.AddWithValue("@tipo", tipo);
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    miembro = new UsuarioModel
                    {
                        Usuario_Id = reader["Usuario_Id"].ToString(),
                        Usuario_Nombre = reader["Usuario_Nombre"].ToString(),
                        Usuario_Apellidos = reader["Usuario_Apellidos"].ToString(),
                        Usuario_Fecha_Nacimiento = reader["Usuario_Fecha_Nacimiento"].ToString(),
                        Genero = new GeneroModel
                        {
                            Genero_Id = reader["Genero_Id"].ToString(),
                            Genero_Descripcion = reader["Genero_Descripcion"].ToString(),
                        },
                        Usuario_Correo_Electronico = reader["Usuario_Correo_Electronico"].ToString(),
                        Usuario_Telefono = reader["Usuario_Telefono"].ToString(),
                        Usuario_Celular = reader["Usuario_Celular"].ToString(),
                        Usuario_Profesion = reader["Usuario_Profesion"].ToString(),
                        Usuario_Puesto = reader["Usuario_Puesto"].ToString(),
                        Usuario_Identificacion = reader["Usuario_Identificacion"].ToString(),
                        Usuario_Fotografia = reader["Usuario_Fotografia"].ToString(),
                        Usuario_Fecha_Registro = reader["Usuario_Fecha_Registro"].ToString(),
                        Usuario_Estatus = reader["Usuario_Estatus"].ToString(),
                        Usuario_Tipo = reader["Usuario_Tipo"].ToString(),
                        Usuario_Descripcion = reader["Usuario_Descripcion"].ToString(),
                        Usuario_Fotografia_Perfil = null,//ImageHelper.DownloadFileFTP(reader["Usuario_Fotografia"].ToString(), usuario_imagen_path),
                        Empresa_Actual = new EmpresaModel
                        {
                            Empresa_Id = reader["Usuario_Empresa_Id"].ToString(),
                            Empresa_Nombre = reader["Usuario_Empresa_Nombre"].ToString(),
                            Empresa_Logotipo = reader["Usuario_Empresa_Logotipo"].ToString(),
                            Empresa_Correo_Electronico = reader["Empresa_Miembro_Correo_Electronico"].ToString(),
                            Empresa_Logotipo_Perfil = null,//ImageHelper.DownloadFileFTP(reader["Usuario_Empresa_Logotipo"].ToString(), empresa_imagen_path),
                            Territorio = new TerritorioModel
                            {
                                Municipio = reader["Empresa_Municipio_Descripcion"].ToString(),
                                Estado = reader["Empresa_Estado_Descripcion"].ToString(),
                                Pais = reader["Empresa_Pais_Descripcion"].ToString()
                            }
                        }

                    };
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                SlackLogs.SendMessage(e.Message);
            }
            finally { conn.Close(); }
            List<string> contadores = GetContadoresSocial(miembro_id, tipo);
            miembro.Red_Social_Publicaciones = contadores[0];
            miembro.Red_Social_Seguidores = contadores[1];
            miembro.Red_Social_Siguiendo = contadores[2];
            miembro.Etiquetas = GetUsuarioEtiquetas(miembro.Usuario_Id, miembro.Usuario_Tipo);
            miembro.Redes_Sociales = GetUsuarioRedesSociales(miembro.Usuario_Id, miembro.Usuario_Tipo);

            return miembro;
        }

        /// <summary>
        /// Obtiene el nombre del miembro
        /// </summary>
        /// <returns>Nombre del miembro</returns>
        /// <param name="miembro_id">Identificador del miembro</param>
        public List<string> GetMemberName(string miembro_id, string tipo)
        {
            List<string> data = new List<string>();
            command = CreateCommand("select Concat(Usuario_Nombre, ' ', Usuario_Apellidos) as Nombre, Usuario_Fotografia, Usuario_Puesto, Usuario_Empresa_Nombre from vw_pro_Directorio_Usuarios " +
                "where Usuario_Id = @miembro_id AND Usuario_Tipo = @tipo");
            command.Parameters.AddWithValue("@miembro_id", miembro_id);
            command.Parameters.AddWithValue("@tipo", tipo);
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    data = new List<string> {
                        reader["Nombre"].ToString(),
                        reader["Usuario_Fotografia"].ToString().Replace(@"\", "/"),
                        reader["Usuario_Puesto"].ToString(),
                        reader["Usuario_Empresa_Nombre"].ToString()
                    };
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                SlackLogs.SendMessage(e.Message);
                return null;
            }
            finally { conn.Close(); }
            return data;
        }

        public string GetLlaveAcceso(string usuario_id, string tipo)
        {
            command = CreateCommand("SELECT Usuario_Servicio_Contrasena FROM vw_pro_Usuarios_Accesos WHERE Usuario_Id = @usuario_id AND Usuario_Tipo = @tipo AND Usuario_Servicio_Id = @servicio_id");
            command.Parameters.AddWithValue("@usuario_id", usuario_id);
            command.Parameters.AddWithValue("@tipo", tipo);
            command.Parameters.AddWithValue("@servicio_id", (int)TiposAccesosServicios.AccesoEdificio);
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
        public List<UsuarioModel> GetDirectorioUsuarios(string nombre = "", string apellido = "", string puesto = "", string profesion = "", string habilidades = "",
                                                        bool disponibilidad = true, string pais = "", string estado = "", string municipio = "")
        {
            List<UsuarioModel> usuarios = new List<UsuarioModel>();

            command = CreateCommand("select * from vw_pro_Directorio_Usuarios WHERE Usuario_Nombre IS NOT NULL AND Usuario_Estatus = 1 ORDER BY Usuario_Nombre, Usuario_Apellidos");
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
                    if (!usuarios.Exists(usuario => usuario.Usuario_Id == reader["Usuario_Id"].ToString() && usuario.Usuario_Tipo == reader["Usuario_Tipo"].ToString()))
                        usuarios.Add(new UsuarioModel
                        {
                            Usuario_Id = reader["Usuario_Id"].ToString(),
                            Usuario_Tipo = reader["Usuario_Tipo"].ToString(),
                            Usuario_Nombre = reader["Usuario_Nombre"].ToString(),
                            Usuario_Apellidos = reader["Usuario_Apellidos"].ToString(),
                            Usuario_Profesion = reader["Usuario_Profesion"].ToString(),
                            Usuario_Puesto = reader["Usuario_Puesto"].ToString(),
                            Usuario_Fotografia = reader["Usuario_Fotografia"].ToString(),
                            Usuario_Correo_Electronico = reader["Usuario_Correo_Electronico"].ToString(),
                            //Usuario_Fotografia_Perfil = ImageHelper.DownloadFileFTP(reader["Usuario_Fotografia"].ToString(), usuario_imagen_path),
                            Usuario_Telefono = reader["Usuario_Telefono"].ToString(),
                            Usuario_Celular = reader["Usuario_Celular"].ToString(),
                            Usuario_Fecha_Nacimiento = reader["Usuario_Fecha_Nacimiento"].ToString(),
                            Usuario_Fecha_Registro = reader["Usuario_Fecha_Registro"].ToString(),
                            Genero = new GeneroModel
                            {
                                Genero_Id = reader["Genero_Id"].ToString(),
                                Genero_Descripcion = reader["Genero_Descripcion"].ToString()
                            },
                            Usuario_Empresa_Nombre = reader["Usuario_Empresa_Nombre"].ToString()
                        });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                SlackLogs.SendMessage(e.Message);
            }
            finally { conn.Close(); }
            usuarios.ForEach(usuario =>
            {
                usuario.Redes_Sociales = GetUsuarioRedesSociales(usuario.Usuario_Id, usuario.Usuario_Tipo);
                usuario.Etiquetas = GetUsuarioEtiquetas(usuario.Usuario_Id, usuario.Usuario_Tipo);
            });
            return usuarios;
        }

        public List<UsuarioModel> GetMiembrosFavoritos(string usuario_id, string usuario_tipo)
        {
            List<UsuarioModel> usuarios = new List<UsuarioModel>();

            command = CreateCommand("select duf.* from pro_Miembros_Favoritos AS mf " +
                                    "inner join vw_pro_Usuarios_Directorio as duf on mf.Usuario_Favorito_Id = duf.Usuario_Id " +
                                    "AND mf.Usuario_Favorito_Tipo = duf.Usuario_Tipo " +
                                    "WHERE Miembros_Favoritos_Estatus = 1 " +
                                    "AND mf.Usuario_Id = @usuario_id AND mf.Usuario_Tipo = @usuario_tipo " +
                                    "ORDER BY Usuario_Nombre, Usuario_Apellidos");
            command.Parameters.AddWithValue("@usuario_id", usuario_id);
            command.Parameters.AddWithValue("@usuario_tipo", usuario_tipo);
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    usuarios.Add(new UsuarioModel
                    {
                        Usuario_Id = reader["Usuario_Id"].ToString(),
                        Usuario_Nombre = reader["Usuario_Nombre"].ToString(),
                        Usuario_Apellidos = reader["Usuario_Apellidos"].ToString(),
                        Usuario_Profesion = reader["Usuario_Profesion"].ToString(),
                        Usuario_Puesto = reader["Usuario_Puesto"].ToString(),
                        Usuario_Fotografia = reader["Usuario_Fotografia"].ToString(),
                        //Usuario_Fotografia_Perfil = ImageHelper.DownloadFileFTP(reader["Usuario_Fotografia"].ToString(), usuario_imagen_path),
                        Usuario_Correo_Electronico = reader["Usuario_Correo_Electronico"].ToString(),
                        Usuario_Telefono = reader["Usuario_Telefono"].ToString(),
                        Usuario_Celular = reader["Usuario_Celular"].ToString(),
                        Usuario_Fecha_Nacimiento = reader["Usuario_Fecha_Nacimiento"].ToString(),
                        Usuario_Fecha_Registro = reader["Usuario_Fecha_Registro"].ToString(),
                        Genero = new GeneroModel { Genero_Descripcion = reader["Usuario_Genero_Descripcion"].ToString() },
                        Usuario_Empresa_Nombre = reader["Usuario_Empresa_Nombre"].ToString(),
                        Usuario_Tipo = reader["Usuario_Tipo"].ToString()
                    });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                SlackLogs.SendMessage(e.Message);
            }
            finally { conn.Close(); }
            usuarios.ForEach(usuario =>
            {
                List<string> contadores = GetContadoresSocial(usuario.Usuario_Id, usuario.Usuario_Tipo);
                usuario.Red_Social_Publicaciones = contadores[0];
                usuario.Red_Social_Seguidores = contadores[1];
                usuario.Red_Social_Siguiendo = contadores[2];
                usuario.Etiquetas = GetUsuarioEtiquetas(usuario.Usuario_Id, usuario.Usuario_Tipo);
                usuario.Redes_Sociales = GetUsuarioRedesSociales(usuario.Usuario_Id, usuario.Usuario_Tipo);
            });

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
        /// <param name="fechaNacimiento">Fecha nacimiento del usuario</param>
        public bool UpdateDataMiembros(string usuario_id, string nombre, string apellido, string correo, string telefono, string celular, string descripcion, DateTime fechaNacimiento, byte[] fotografia, byte[] foto_fondo)
        {
            string fotoNombre = null, fotoFondoNombre = null;
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                if (fotografia.Length != 0)
                {
                    fotoNombre = Guid.NewGuid().ToString() + ".png";
                    var result = new UploadImages().UploadBitmapAsync(fotoNombre, fotografia, usuario_imagen_path);
                    if (!result)
                    {
                        return false;
                    }

                }
                if (foto_fondo.Length != 0)
                {
                    fotoFondoNombre = Guid.NewGuid().ToString() + ".png";
                    var result = new UploadImages().UploadBitmapAsync(fotoFondoNombre, foto_fondo, usuario_imagen_path);
                    if (!result)
                    {
                        return false;
                    }

                }
                command = CreateCommand();
                command.Connection = conn;
                command.Transaction = transaction;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_cat_Miembros_General";

                command.Parameters.AddWithValue("@Trasaccion", "MODIFICAR");
                command.Parameters.AddWithValue("@Miembro_Id", usuario_id);
                command.Parameters.AddWithValue("@Miembro_Nombre", nombre);
                command.Parameters.AddWithValue("@Miembro_Apellidos", apellido);
                command.Parameters.AddWithValue("@Miembro_Fecha_Nacimiento", fechaNacimiento);
                command.Parameters.AddWithValue("@Miembro_Correo_Electronico", correo);
                command.Parameters.AddWithValue("@Miembro_Telefono", telefono);
                command.Parameters.AddWithValue("@Miembro_Celular", celular);
                command.Parameters.AddWithValue("@Miembro_Fotografia", fotoNombre);
                command.Parameters.AddWithValue("@Miembro_Descripcion", descripcion);
                command.Parameters.AddWithValue("@Miembro_Estatus", DBNull.Value);
                command.Parameters.AddWithValue("@Miembro_Imagen_Fondo", foto_fondo);

                command.Parameters.Add("@Miembro_Id_Salida", SqlDbType.Int).Direction = ParameterDirection.Output;

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
                "Usuario_Id = @miembro_id AND Usuario_Tipo = @miembro_tipo AND Usuario_Favorito_Id = @miembro_favorito_id AND Usuario_Favorito_Tipo = @miembro_favorito_tipo AND Miembros_Favoritos_Estatus = 1");
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

        public List<UsuarioModel> GetColaboradoresCard(string usuario_id)
        {
            List<UsuarioModel> colaboradores = new List<UsuarioModel>();
            try
            {
                conn.Open();
                command = CreateCommand("select Colaborador_Empresa_Nombre, Colaborador_Empresa_Apellidos, Colaborador_Empresa_Id, Colaborador_Empresa_Fotografia from vw_cat_Colaboradores_Directorio WHERE Empresa_Miembro_Id = @Usuario_Id");
                command.Parameters.AddWithValue("@Usuario_Id", usuario_id);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    colaboradores.Add(new UsuarioModel
                    {
                        Usuario_Nombre = reader["Colaborador_Empresa_Nombre"].ToString(),
                        Usuario_Apellidos = reader["Colaborador_Empresa_Apellidos"].ToString(),
                        Usuario_Id = reader["Colaborador_Empresa_Id"].ToString(),
                        Usuario_Fotografia = reader["Colaborador_Empresa_Fotografia"].ToString(),
                        Usuario_Fotografia_Perfil = null, //ImageHelper.DownloadFileFTP(reader["Colaborador_Empresa_Fotografia"].ToString(), usuario_imagen_path),
                    });
                }
            }
            catch (Exception e) { SlackLogs.SendMessage(e.Message); }
            finally { conn.Close(); }
            return colaboradores;
        }

        /// <summary>
        /// Obtiene los colaboradores de un miembro
        /// </summary>
        /// <returns>Colaboradores de un miembro</returns>
        /// <param name="empresa_id">Identificador de la empresa</param>
        public List<UsuarioModel> GetColaboradoresMiembro(string empresa_id, int estatus = 1, string nombre = "", string apellido = "", string puesto = "",
                                                              string profesion = "", string habilidades = "",
                                                              string disponibilidad = "N/A")
        {
            List<UsuarioModel> colaboradores = new List<UsuarioModel>();
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
                    colaboradores.Add(new UsuarioModel
                    {
                        Usuario_Id = reader["Usuario_Id"].ToString(),
                        Usuario_Tipo = reader["Usuario_Tipo"].ToString(),
                        Genero = new GeneroModel
                        {
                            Genero_Id = reader["Genero_Id"].ToString(),
                            Genero_Descripcion = reader["Genero_Descripcion"].ToString()
                        },
                        Usuario_Nombre = reader["Usuario_Nombre"].ToString(),
                        Usuario_Apellidos = reader["Usuario_Apellidos"].ToString(),
                        Usuario_Fecha_Nacimiento = reader["Usuario_Fecha_Nacimiento"].ToString(),
                        Usuario_Correo_Electronico = reader["Usuario_Correo_Electronico"].ToString(),
                        Usuario_Telefono = reader["Usuario_Telefono"].ToString(),
                        Usuario_Celular = reader["Usuario_Celular"].ToString(),
                        Usuario_Profesion = reader["Usuario_Profesion"].ToString(),
                        Usuario_Puesto = reader["Usuario_Puesto"].ToString(),
                        Usuario_Fotografia = reader["Usuario_Fotografia"].ToString(),
                        Usuario_Fecha_Registro = reader["Usuario_Fecha_Registro"].ToString(),
                        Usuario_Estatus = reader["Usuario_Estatus"].ToString()
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
            colaboradores.ForEach(colaborador =>
            {
                colaborador.Etiquetas = GetUsuarioEtiquetas(colaborador.Usuario_Id, colaborador.Usuario_Tipo);
                colaborador.Redes_Sociales = GetUsuarioRedesSociales(colaborador.Usuario_Id, colaborador.Usuario_Tipo);
            });
            return colaboradores;
        }
        /// <summary>
        /// Obtiene los datos de un colaborador
        /// </summary>
        /// <returns>Colaborador</returns>
        /// <param name="usuario_id">Identificador del colaborador</param>
        public UsuarioModel GetColaborador(string usuario_id)
        {
            UsuarioModel colaborador = new UsuarioModel();
            string query = "SELECT * FROM vw_pro_Usuarios_Directorio where Usuario_Id = @usuario_id AND Usuario_Tipo = 2";
            command = CreateCommand(query);
            command.Parameters.AddWithValue("@usuario_id", usuario_id);
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    colaborador = new UsuarioModel
                    {
                        Usuario_Id = reader["Usuario_Id"].ToString(),
                        Usuario_Tipo = reader["Usuario_Tipo"].ToString(),
                        Genero = new GeneroModel
                        {
                            Genero_Id = reader["Genero_Id"].ToString(),
                            Genero_Descripcion = reader["Genero_Descripcion"].ToString()
                        },
                        Usuario_Nombre = reader["Usuario_Nombre"].ToString(),
                        Usuario_Apellidos = reader["Usuario_Apellidos"].ToString(),
                        Usuario_Fecha_Nacimiento = reader["Usuario_Fecha_Nacimiento"].ToString(),
                        Usuario_Correo_Electronico = reader["Usuario_Correo_Electronico"].ToString(),
                        Usuario_Telefono = reader["Usuario_Telefono"].ToString(),
                        Usuario_Celular = reader["Usuario_Celular"].ToString(),
                        Usuario_Profesion = reader["Usuario_Profesion"].ToString(),
                        Usuario_Puesto = reader["Usuario_Puesto"].ToString(),
                        Usuario_Fotografia = reader["Usuario_Fotografia"].ToString(),
                        Usuario_Fecha_Registro = reader["Usuario_Fecha_Registro"].ToString(),
                        Usuario_Estatus = reader["Usuario_Estatus"].ToString()
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
            colaborador.Etiquetas = GetUsuarioEtiquetas(colaborador.Usuario_Id, colaborador.Usuario_Tipo);
            colaborador.Redes_Sociales = GetUsuarioRedesSociales(colaborador.Usuario_Id, colaborador.Usuario_Tipo);
            return colaborador;
        }
        /// <summary>
        /// Cambia el estado del colaborador
        /// </summary>
        /// <returns><c>true</c>, si el estado del colaborador cambió, <c>false</c> existió un error.</returns>
        /// <param name="colaborador_id">Identificador del colaborador.</param>
        /// <param name="estatus">Estado del colaborador.</param>
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
        /// <summary>
        /// Agrega o cambia la información del colaborador
        /// </summary>
        /// <returns><c>true</c>, si se agregño la información, <c>false</c> existió algún error.</returns>
        /// <param name="empresa_id">Identificador de la empresa.</param>
        /// <param name="nombre">Nombre.</param>
        /// <param name="apellidos">Apellidos.</param>
        /// <param name="mail">Mail.</param>
        /// <param name="telefono">Telefono.</param>
        /// <param name="celular">Celular.</param>
        /// <param name="profesion">Profesión.</param>
        /// <param name="puesto">Puesto.</param>
        /// <param name="habilidades">Habilidades.</param>
        /// <param name="fecha_nacimiento">Fecha de nacimiento.</param>
        /// <param name="colaborador_id">Identificador del colaborador.</param>
        public bool AddChangeColaborador(string empresa_id, string nombre, string apellidos, string mail,
                                         string telefono, string celular, string profesion, string puesto,
                                         string habilidades, string fecha_nacimiento, string colaborador_id,
                                         string genero_id, byte[] fotografia)
        {
            PassSecurity password = new PassSecurity();
            string pwd = password.GeneraIdentifier();
            string fotoNombre = null;
            try
            {
                if (fotografia.Length != 0)
                {
                    fotoNombre = Guid.NewGuid().ToString() + ".png";
                    var result = new UploadImages().UploadBitmapAsync(fotoNombre, fotografia, usuario_imagen_path);
                    if (!result)
                    {
                        return false;
                    }

                }
                conn.Open();
                transaction = conn.BeginTransaction();
                command = CreateCommand();
                command.Connection = conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_cat_Miembros_Empresas_Colaboradores";

                command.Parameters.AddWithValue("@Trasaccion", colaborador_id == null ? "ALTA" : "MODIFICAR");

                command.Parameters.AddWithValue("@Colaborador_Empresa_ID", colaborador_id);
                command.Parameters.AddWithValue("@Miembro_Empresa_Id", empresa_id);
                command.Parameters.AddWithValue("@Genero_Id", genero_id);
                command.Parameters.AddWithValue("@Colaborador_Empresa_Nombre", nombre);
                command.Parameters.AddWithValue("@Colaborador_Empresa_Apellidos", apellidos);
                command.Parameters.AddWithValue("@Colaborador_Fecha_Nacimiento", fecha_nacimiento);
                command.Parameters.AddWithValue("@Colaborador_Empresa_Correo_Electronico", mail);
                command.Parameters.AddWithValue("@Colaborador_Empresa_Contrasena", password.EncodePassword(pwd));
                command.Parameters.AddWithValue("@Colaborador_Empresa_Telefono", telefono);
                command.Parameters.AddWithValue("@Colaborador_Empresa_Celular", celular);
                command.Parameters.AddWithValue("@Colaborador_Empresa_Profesion", profesion);
                command.Parameters.AddWithValue("@Colaborador_Empresa_Puesto", puesto);
                command.Parameters.AddWithValue("@Colaborador_Empresa_Habilidades", habilidades);
                command.Parameters.AddWithValue("@Colaborador_Empresa_Llave_Acceso", pwd);
                command.Parameters.AddWithValue("@Colaborador_Empresa_Identificacion", pwd);
                command.Parameters.AddWithValue("@Colaborador_Empresa_Fotografia", fotoNombre);
                command.Parameters.AddWithValue("@Colaborador_Empresa_Estatus", 1);
                command.Parameters.Add("@Colaborador_Empresa_Id_Salida", SqlDbType.Int).Direction = ParameterDirection.Output;

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
            //new Emails().SendMail(mail, nombre + " " + apellidos, pwd);
            return true;
        }

        /*public List<RedSocialModel> GetRedesSocialesUsuario(string usuario_id, string usuario_tipo)
        {
            List<RedSocialModel> rs = new List<RedSocialModel>();

            string query = "SELECT * FROM vw_pro_Usuarios_Redes_Sociales where Usuario_Id = @usuario_id AND Usuario_Tipo = @usuario_tipo";
            command = CreateCommand(query);
            command.Parameters.AddWithValue("@usuario_id", usuario_id);
            command.Parameters.AddWithValue("@usuario_tipo", usuario_tipo);
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    rs.Add(new RedSocialModel
                    {
                        Red_Social_Id = reader["Red_Social_Id"].ToString(),
                        Red_Social_Nombre = reader["Red_Social_Nombre"].ToString(),
                        Usuario_Red_Social_Id = reader["Red_Social_Nombre"].ToString(),
                        Red_Social_Icono_Android = reader["Red_Social_Icono_Android"].ToString(),
                        Red_Social_Icono_iOS = reader["Red_Social_Icono_iOS"].ToString(),
                        Red_Social_Icono_Web = reader["Red_Social_Icono_Web"].ToString(),
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

            return rs;
        }*/

        public List<string> GetContadoresSocial(string usuario_id, string usuario_tipo)
        {
            List<string> contadores = new List<string>();

            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                command = CreateCommand();
                command.Connection = conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_pro_Redes_Sociales_Contadores";

                command.Parameters.AddWithValue("@Usuario_Id", usuario_id);

                command.Parameters.AddWithValue("@Usuario_Tipo", usuario_tipo);
                command.Transaction = transaction;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    contadores.Add(reader.GetInt32(0).ToString());
                    contadores.Add(reader.GetInt32(1).ToString());
                    contadores.Add(reader.GetInt32(2).ToString());
                }

                //command.Transaction = transaction;
                //command.ExecuteNonQuery();
                //transaction.Commit();
            }
            catch (Exception e)
            {
                //transaction.Rollback();
                Console.WriteLine(e.Message);
                SlackLogs.SendMessage(e.Message);
            }
            finally
            {
                conn.Close();
            }

            return contadores;
        }

        public int AddRemoveEtiquetas(string usuario_id, string usuario_tipo, string etiqueta_id, string etiqueta_nombre, TipoEtiquetas etiqueta_tipo, string miembro_etiqueta_id)
        {

            try
            {

                conn.Open();
                transaction = conn.BeginTransaction();
                command = CreateCommand();
                command.Connection = conn;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_pro_Usuarios_Etiquetas";

                command.Parameters.AddWithValue("@Trasaccion", string.IsNullOrEmpty(miembro_etiqueta_id) ? "ALTA" : "BAJA");

                if (((int)TiposUsuarios.Miembro).ToString() == usuario_tipo)
                {
                    command.Parameters.AddWithValue("@Miembro_Id", usuario_id);
                    command.Parameters.AddWithValue("@Colaborador_Id", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@Colaborador_Id", usuario_id);
                    command.Parameters.AddWithValue("@Miembro_Id", DBNull.Value);
                }
                command.Parameters.AddWithValue("@Etiqueta_Nombre", etiqueta_nombre);
                command.Parameters.AddWithValue("@Etiqueta_Tipo", etiqueta_tipo.ToString());
                command.Parameters.AddWithValue("@Etiqueta_Id", etiqueta_id);
                command.Parameters.AddWithValue("@Miembro_Etiqueta_Id", DBNull.Value);
                command.Parameters.Add("@Miembro_Etiqueta_Id_Salida", SqlDbType.Int).Direction = ParameterDirection.Output;

                command.Transaction = transaction;
                command.ExecuteNonQuery();
                transaction.Commit();
                return Convert.ToInt32(command.Parameters["@Miembro_Etiqueta_Id_Salida"].Value);
            }
            catch (Exception e)
            {
                //transaction.Rollback();
                Console.WriteLine(e.Message);
                SlackLogs.SendMessage(e.Message);
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }
        public List<EtiquetaModel> GetUsuarioEtiquetas(string usuario_id, string usuario_tipo)
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

        public List<RedSocialModel> GetUsuarioRedesSociales(string usuario_id, string usuario_tipo)
        {
            List<RedSocialModel> redesSociales = new PickerItemsController().GetRedesSociales();
            try
            {
                command = CreateCommand("select Miembro_Red_Social_Id, Red_Social_Id, Miembro_Red_Social_Enlace " +
                                        "from vw_pro_Usuarios_Redes_Sociales Where Usuario_Id = @Usuario_Id and Usuario_Tipo = @Usuario_Tipo");
                command.Parameters.AddWithValue("@Usuario_Id", usuario_id);
                command.Parameters.AddWithValue("@Usuario_Tipo", usuario_tipo);
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    redesSociales.ForEach(red =>
                    {
                        if (red.Red_Social_Id == reader["Red_Social_Id"].ToString())
                        {
                            red.Red_Social_Enlace = reader["Miembro_Red_Social_Enlace"].ToString();
                            red.Usuario_Red_Social_Id = reader["Miembro_Red_Social_Id"].ToString();
                        }
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
    }
}
