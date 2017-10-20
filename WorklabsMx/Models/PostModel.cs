namespace WorklabsMx.Models
{
    public class PostModel
    {
        public string Publicacion_Id { get; set; }
        public string Miembro_Id { get; set; }
        public string Colaborador_Empresa_Id { get; set; }
        public string Usuario_Nombre { get; set; }
        public string Usuario_Tipo { get; set; }
        public string Usuario_Fotografia_Ruta { get; set; }
        public string Usuario_Puesto { get; set;}
        public string Publicacion_Contenido { get; set; }
        public string Publicacion_Imagen { get; set; }
        public string Publicacion_Imagen_Ruta { get; set; }
        public string Publicacion_Fecha { get; set; }
        public string Publicacion_Comentarios_Cantidad { get; set; }
        public string Publicacion_Me_Gustan_Cantidad { get; set; }
        public string Publicacion_Estatus { get; set; }
        public string Publicacion_Fecha_Alta { get; set; }
        public string Publicacion_Fecha_Modificacion { get; set; }
        public string Publicacion_Fecha_Baja { get; set; }
        public string Publicacion_Me_Gusta_Usuario { get; set; }
    }
}
