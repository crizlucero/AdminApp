using System;
namespace WorklabsMx.Models
{
    public class VisitaModel
    {
        public string Visita_Id { get; set; }
        public string Visita_Nombre { get; set; }
        public string Visita_Apellidos { get; set; }
        public string Visita_Email { get; set; }
        public string Visita_Fecha_Entrada { get; set; }
        public string Visita_Fecha_Salida { get; set; }
        public string Visita_Codigo_Acceso { get; set; }
        public string Visita_Asunto { get; set; }
        public SucursalModel Sucursal { get; set; }
        public UsuarioModel Miembro { get; set; }
        public UsuarioModel Colaborador { get; set; }
        public string Visita_Estatus { get; set; }

    }
}
