using System;
using System.Collections.Generic;

namespace WorklabsMx.Models
{
    public class PostModel
    {
        public string POST_ID { get; set; }
        public string Tipo { get; set; }
        public string POST_MIEMBRO_COLABORADOR_ID { get; set; }
        public string MIEMBRO_ID { get; set; }
        public string COLABORADOR_ID { get; set; }
        public string POST_FECHA { get; set; }
        public string POST_FOTO_URL { get; set; }
        public string POST_CONTENIDO { get; set; }
        public string Miembro_Nombre { get; set; }
        public string Miembro_Apellidos { get; set; }
        public string Miembro_Fotografia { get; set; }
        //public List<ComentarioModel> Comentarios { get; set; }

        public PostModel()
        {
        }
    }
}
