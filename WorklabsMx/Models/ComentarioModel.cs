namespace WorklabsMx.Models
{
    public class ComentarioModel
    {
        public string Comentario_Id { get; set; }
        public string Publicacion_Id { get; set; }
        public string Miembro_Id { get; set; }
        public string Colaborador_Empresa_Id { get; set; }
        public string Usuario_Nombre { get; set; }
        public string Usuario_Tipo { get; set; }
        public string Usuario_Fotografia_Ruta { get; set; }
        public string Comentario_Contenido { get; set; }
        public string Comentario_Imagen { get; set; }
        public string Comentario_Imagen_Ruta { get; set; }
        public string Comentario_Fecha { get; set; }
        public string Comentario_Me_Gustan_Cantidad { get; set; }
        public string Comentario_Estatus { get; set; }
        public string Comentario_Fecha_Alta { get; set; }
        public string Comentario_Fecha_Modificacion { get; set; }
        public string Comentario_Fecha_Baja { get; set; }
    }
}
