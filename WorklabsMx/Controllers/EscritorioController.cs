using System;
using System.Collections.Generic;
using WorklabsMx.Models;

namespace WorklabsMx.Controllers
{
    public class EscritorioController : DataBaseModel
    {
        public EscritorioController() : base()
        {
        }

        public List<PostModel> GetMuroPosts()
        {
            List<PostModel> posts = new List<PostModel>();
            string query = "SELECT * FROM vw_Muro_Posts ORDER BY Post_Fecha DESC";
            command = CreateCommand(query);
            try
            {
                conn.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    PostModel post = new PostModel
                    {
                        POST_ID = reader["POST_ID"].ToString(),
                        Tipo = reader["Tipo"].ToString(),
                        POST_MIEMBRO_COLABORADOR_ID = reader["POST_MIEMBRO_COLABORADOR_ID"].ToString(),
                        MIEMBRO_ID = reader["MIEMBRO_ID"].ToString(),
                        COLABORADOR_ID = reader["COLABORADOR_ID"].ToString(),
                        POST_FECHA = reader["POST_FECHA"].ToString(),
                        POST_FOTO_URL = reader["POST_FOTO_URL"].ToString(),
                        POST_CONTENIDO = reader["POST_CONTENIDO"].ToString(),
                        Miembro_Nombre = reader["Miembro_Nombre"].ToString(),
                        Miembro_Apellidos = reader["Miembro_Apellidos"].ToString(),
                        Miembro_Fotografia = reader["Miembro_Fotografia"].ToString()
                    };
                    posts.Add(post);
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
            return posts;
        }
    }
}
