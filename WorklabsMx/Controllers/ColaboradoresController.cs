using System;
using System.Collections.Generic;
using WorklabsMx.Models;

namespace WorklabsMx.Controllers
{
    public class ColaboradoresController : DataBaseModel
    {
        public ColaboradoresController() : base()
        {
        }

        /// <summary>
        /// Obtiene los colaboradores de un miembro
        /// </summary>
        /// <returns>Colaboradores de un miembro</returns>
        /// <param name="miembro_id">Identificador del miembro</param>
        public List<ColaboradorModel> GetColaboradoresMiembro(string miembro_id)
        {
            List<ColaboradorModel> colaboradores = new List<ColaboradorModel>();
            string query = "SELECT * FROM vw_cat_Miembros_Colaboradores where Miembro_Id = @miembro_id";
            command = CreateCommand(query);
            command.Parameters.AddWithValue("@miembro_id", miembro_id);
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ColaboradorModel colaborador = new ColaboradorModel
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
                    colaboradores.Add(colaborador);
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
            string query = "SELECT * FROM vw_cat_Miembros_Colaboradores where Colaborador_Id = @colaborador_id";
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
            }
            finally
            {
                conn.Close();
            }
            return colaborador;
        }
    }
}
