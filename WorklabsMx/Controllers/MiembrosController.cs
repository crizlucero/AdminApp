using System;
using System.Collections.Generic;
using WorklabsMx.Models;

namespace WorklabsMx.Controllers
{
    public class MiembrosController : DataBaseModel
    {
        public MiembrosController() : base()
        {
        }

        /// <summary>
        /// Obtiene la información del miembro
        /// </summary>
        /// <returns>Información del miembro</returns>
        /// <param name="miembro_id">Identificador del miembro</param>
        public MiembroModel GetMemberData(string miembro_id)
        {
            MiembroModel miembro = new MiembroModel();
            string query = "select * from vw_cat_Miembros where Miembro_Id = @miembro_id";
            command = CreateCommand(query);
            command.Parameters.AddWithValue("@miembro_id", miembro_id);
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    miembro = new MiembroModel
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

        /// <summary>
        /// Obtener el nombre del miembro
        /// </summary>
        /// <returns>Nombre del miembro</returns>
        /// <param name="miembro_id">Identificador del miembro</param>
        public Dictionary<string, string> GetMemberName(string miembro_id)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            string query = "select Concat(Miembro_Nombre, ' ', Miembro_Apellidos) as Nombre, Miembro_Fotografia from vw_cat_Miembros where Miembro_Id = @miembro_id";
            command = CreateCommand(query);
            command.Parameters.AddWithValue("@miembro_id", miembro_id);
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
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

        public string GetLlaveAcceso(string miembro_id){
            string query = "SELECT Miembro_Llave_Acceso FROM vw_cat_Miembros WHERE Miembro_Id = @miembro_id";
            command = CreateCommand(query);
            command.Parameters.AddWithValue("@miembro_id",miembro_id);
            try{
                conn.Open();
                reader = command.ExecuteReader();
                while(reader.Read()){
                    return reader["Miembro_Llave_Acceso"].ToString();
                }
            }catch(Exception e){
                Console.WriteLine(e.Message);
            }
            finally{
                conn.Close();
            }
            return "";
        }

    }
}
