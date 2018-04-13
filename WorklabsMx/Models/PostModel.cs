namespace WorklabsMx.Models
{
    public class PostModel
    {
        public string Publicacion_Id { get; set; }
        public UsuarioModel Usuario { get; set; }
        public string Publicacion_Contenido { get; set; }
        public string Publicacion_Imagen { get; set; }
        public string Publicacion_Imagen_Back { get; set; }
        public string Publicacion_Imagen_Ruta { get; set; }
        public string Publicacion_Fecha { get; set; }
        public string Publicacion_Comentarios_Cantidad { get; set; }
        public string Publicacion_Me_Gustan_Cantidad { get; set; }
        public string Publicacion_Estatus { get; set; }
        public string Publicacion_Fecha_Alta { get; set; }
        public string Publicacion_Fecha_Modificacion { get; set; }
        public string Publicacion_Fecha_Baja { get; set; }
        public string Publicacion_Me_Gusta_Usuario { get; set; }
        public byte[] Publicacion_Imagen_Post { get; set; }
        public byte[] Publicacion_Imagen_Post_Back { get; set; }
        public int Publicacion_Tipo { get; set; }
    }
}
