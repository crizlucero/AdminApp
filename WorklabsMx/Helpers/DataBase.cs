using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WorklabsMx.Models;

namespace WorklabsMx
{
    public class DataBase
    {

        SqlConnection conn;
        public DataBase()
        {

            this.conn = new SqlConnection("Server=184.168.47.17; Database=Worklabs; User=webmaster; Pwd=W3bM4st3r");
        }
        /// <summary>
        /// Inicia sesión el usuario
        /// </summary>
        /// <returns>Identificador del usuario</returns>
        /// <param name="email">Correo electrónico</param>
        /// <param name="password">Contraseña</param>
        public int Login(string email, string password)
        {
            try
            {
                string query = "SELECT Miembro_Id FROM vw_cat_miembros where Miembro_Correo_Electronico = @email --and Miembro_Contrasena = @password";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", password);
                this.conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    return reader.GetInt32(0);
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return -1;
        }
        /// <summary>
        /// Valida que exista el correo en los miembros inscritos
        /// </summary>
        /// <returns>Nombre e identificador del miembro registrado</returns>
        /// <param name="email">Correo electrónico</param>
        public string ValidateMember(string email)
        {
            string miembro = string.Empty;
            try
            {
                conn.Open();

                String slc_session = "SELECT miembro_id, miembro_nombre FROM VW_CAT_MIEMBROS_EMPRESAS WHERE MIEMBRO_CORREO_ELECTRONICO = @email";
                SqlCommand sessioncmd = new SqlCommand(slc_session, conn);

                SqlDataReader dr = sessioncmd.ExecuteReader();

                if (dr.Read())
                {
                    miembro = dr["Empresa_Miembro_Id"].ToString();
                }
            }
            catch (Exception e) { }
            finally
            {
                conn.Close();
            }
            return miembro;
        }
        /// <summary>
        /// Registra en la base de datos la nueva contraseña del miembro
        /// </summary>
        /// <returns>Si se pudo registrar el usuario</returns>
        /// <param name="email">Correo electrónico</param>
        /// <param name="password">Contraseña nueva</param>
        public bool registrarenbd(string email, string password)
        {

            string newPassword = new PassSecurity().EncodePassword(password);

            SqlTransaction varTransaccion;
            varTransaccion = conn.BeginTransaction();
            try
            {

                SqlCommand varComando = new SqlCommand();
                varComando.Connection = conn;
                varComando.CommandType = CommandType.StoredProcedure;
                varComando.CommandText = "sp_Miembros_Update_Password";

                varComando.Parameters.Add("@Miembro_contrasena", SqlDbType.VarChar, 30).Value = newPassword;
                varComando.Parameters.Add("@Miembro_Correo_Electronico", SqlDbType.VarChar, 50).Value = email;


                varComando.Transaction = varTransaccion;
                varComando.ExecuteNonQuery();
                varTransaccion.Commit();

            }

            catch (Exception ex)
            {
                varTransaccion.Rollback();
                //clsLog.ReportarError("CARPETA: Sign_In" + Environment.NewLine + "PAGINA: login.aspx" + Environment.NewLine + "PROCESO: bttnActualizarUser_Command" + Environment.NewLine + "ERROR: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }
        /// <summary>
        /// Obtiene las configuraciones
        /// </summary>
        /// <returns>Configuraciones</returns>
        /// <param name="parametro">Parametro a elegir</param>
        public Configuraciones GetConfiguraciones(string parametro)
        {

            string query = "SELECT * FROM vw_cat_Parametros_Generales WHERE Parametro_Descripcion = @Parametro";
            Configuraciones configuracion = new Configuraciones();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Parametro", parametro);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    configuracion = new Configuraciones
                    {
                        Parametro_Id = reader["Parametro_Id"].ToString(),
                        Parametro_Descripcion = reader["Parametro_Descripcion"].ToString(),
                        Parametro_Varchar_1 = reader["Parametro_Varchar_1"].ToString(),
                        Parametro_Varchar_2 = reader["Parametro_Varchar_2"].ToString(),
                        Parametro_Varchar_3 = reader["Parametro_Varchar_3"].ToString(),
                        Parametro_Varchar_4 = reader["Parametro_Varchar_4"].ToString(),
                        Parametro_Varchar_5 = reader["Parametro_Varchar_5"].ToString(),
                        Parametro_Int_1 = reader["Parametro_Int_1"].ToString(),
                        Parametro_Int_2 = reader["Parametro_Int_2"].ToString(),
                        Parametro_Int_3 = reader["Parametro_Int_3"].ToString(),
                        Parametro_Int_4 = reader["Parametro_Int_4"].ToString(),
                        Parametro_Int_5 = reader["Parametro_Int_5"].ToString(),
                        Parametro_date_1 = reader["Parametro_date_1"].ToString(),
                        Parametro_date_2 = reader["Parametro_date_2"].ToString(),
                        Parametro_date_3 = reader["Parametro_date_3"].ToString(),
                        Parametro_date_4 = reader["Parametro_date_4"].ToString(),
                        Parametro_date_5 = reader["Parametro_date_5"].ToString(),
                        Parametro_Estatus = reader["Parametro_Estatus"].ToString(),
                        Parametro_Fecha_Alta = reader["Parametro_Fecha_Alta"].ToString(),
                        Parametro_Fecha_Modificacion = reader["Parametro_Fecha_Modificacion"].ToString(),
                        Parametro_Fecha_Baja = reader["Parametro_Fecha_Baja"].ToString()
                    };
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }

            return configuracion;
        }

        public bool RegistraInvitado(string nombre, string asunto, string email, string emailcc, DateTime horaEntrada, DateTime horaSalida, DateTime Fecha, string clave)
        {
            var ent_ampm = horaEntrada.ToString("tt");
            var sal_ampm = horaSalida.ToString("tt");

            char estatus = '0';
            conn.Open();
            SqlTransaction varTransaccion;
            varTransaccion = conn.BeginTransaction();
            try
            {

                SqlCommand varComando = new SqlCommand();
                varComando.Connection = conn;
                varComando.CommandType = CommandType.StoredProcedure;
                varComando.CommandText = "sp_cat_Visitas";

                varComando.Parameters.Add("@Visita_Nombre", SqlDbType.VarChar, 100).Value = nombre;

                varComando.Parameters.Add("@Visita_Entrada", SqlDbType.DateTime).Value = horaEntrada;
                varComando.Parameters.Add("@Visita_Entrada_AMPM", SqlDbType.VarChar, 5).Value = ent_ampm;
                varComando.Parameters.Add("@Visita_Salida", SqlDbType.DateTime).Value = horaSalida;
                varComando.Parameters.Add("@Visita_Salida_AMPM", SqlDbType.VarChar, 5).Value = sal_ampm;
                varComando.Parameters.Add("@Visita_Host", SqlDbType.VarChar, 50).Value = emailcc;
                varComando.Parameters.Add("@Visita_Email", SqlDbType.VarChar, 50).Value = email;
                varComando.Parameters.Add("@Visita_Estatus", SqlDbType.Char).Value = estatus;
                varComando.Parameters.Add("@Visita_Codigo_QR", SqlDbType.VarChar, 50).Value = clave;

                varComando.Parameters.Add("@Visita_Asunto", SqlDbType.VarChar, 100).Value = asunto;

                varComando.Transaction = varTransaccion;
                varComando.ExecuteNonQuery();
                varTransaccion.Commit();
            }

            catch (Exception ex)
            {
                varTransaccion.Rollback();
                return false;
                //clsLog.ReportarError("CARPETA: Dashboard_Cliente" + Environment.NewLine + "PAGINA: registrarinvitados.aspx" + Environment.NewLine + "PROCESO: registrarenbd" + Environment.NewLine + "ERROR: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return true;
        }

        /// <summary>
        /// Obtiene la información del miembro
        /// </summary>
        /// <returns>Información del miembro</returns>
        /// <param name="miembro_id">Identificador del miembro</param>
        public Miembro GetMemberData(string miembro_id)
        {
            Miembro miembro = new Miembro();
            string query = "select * from vw_cat_Miembros where Miembro_Id = @miembro_id";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@miembro_id", miembro_id);
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    miembro = new Miembro
                    {
                        Miembro_Id = reader["Miembro_Id"].ToString(),
                        Miembro_Nombre = reader["Miembro_Nombre"].ToString(),
                        Miembro_Apellidos = reader["Miembro_Apellidos"].ToString(),
                        Miembro_Fecha_Nacimiento = reader["Miembro_Fecha_Nacimiento"].ToString(),
                        Genero_Id = reader["Genero_Id"].ToString(),
                        Genero_Descripcion = reader["Genero_Descripcion"].ToString(),
                        Miembro_Correo_Electronico = reader["Miembro_Correo_Electronico"].ToString(),
                        Miembro_Telefono = reader["Miembro_Telefono"].ToString(),
                        Miembro_Celular = reader["Miembro_Celular"].ToString(),
                        Miembro_Profesion = reader["Miembro_Profesion"].ToString(),
                        Miembro_Puesto = reader["Miembro_Puesto"].ToString(),
                        Miembro_Habilidades = reader["Miembro_Habilidades"].ToString(),
                        Miembro_Identificacion = reader["Miembro_Identificacion"].ToString(),
                        Miembro_Llave_Acceso = reader["Miembro_Llave_Acceso"].ToString(),
                        Miembro_Fotografia = reader["Miembro_Fotografia"].ToString(),
                        Miembro_Fecha_Registro = reader["Miembro_Fecha_Registro"].ToString(),
                        Miembro_Estatus = reader["Miembro_Estatus"].ToString()
                    };
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return miembro;
        }

        public Dictionary<string, string> GetMemberName(string miembro_id)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            string query = "select Concat(Miembro_Nombre, Miembro_Apellidos) as Nombre, Miembro_Fotografia from vw_cat_Miembros where Miembro_Id = @miembro_id";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@miembro_id", miembro_id);
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    data.Add("Nombre", reader["Nombre"].ToString());
                    data.Add("Fotografia", reader["Miembro_Fotografia"].ToString().Replace(@"\", "/"));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return data;
        }

        public Empresa GetEmpresaMiembro(string miembro_id)
        {
            Empresa empresa = new Empresa();
            string query = "SELECT Giro_Descripcion, Empresa_Miembro_Red_Social_3, Empresa_Miembro_Red_Social_2, " +
                "Empresa_Miembro_Red_Social_1, Empresa_Miembro_Pagina_Web, Empresa_Miembro_Telefono, " +
                "Empresa_Miembro_Correo_Electronico, Empresa_Miembro_Numero_Interior, " +
                "Empresa_Miembro_Numero_Exterior, Empresa_Miembro_Calle, Empresa_Miembro_Nombre, " +
                "Empresa_Miembro_Rfc, Empresa_Miembro_Razon_Social, Empresa_Miembro_Id, Territorio_Estado_Descripcion, " +
                "Territorio_Municipio_Descripcion, Territorio_Colonia_Descripcion, Territorio_Cp " +
                "FROM vw_cat_Miembros_Empresas WHERE Miembro_Id = @miembro_id";

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@miembro_id", miembro_id);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    empresa = new Empresa
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
            }
            finally
            {
                conn.Close();
            }

            return empresa;
        }
    }
}
