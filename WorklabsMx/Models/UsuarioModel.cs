using System;
using System.Collections.Generic;

namespace WorklabsMx.Models
{
    public class UsuarioModel
    {
        public string Usuario_Id { get; set; }
        public string Usuario_Tipo{ get; set; }
        public string Usuario_Nombre{ get; set; }
        public string Usuario_Apellidos{ get; set; }
        public string Usuario_Fecha_Nacimiento{ get; set; }
        public string Usuario_Correo_Electronico{ get; set; }
        public string Usuario_Telefono{ get; set; }
        public string Usuario_Celular{ get; set; }
        public string Usuario_Profesion{ get; set; }
        public string Usuario_Puesto{ get; set; }
        public string Usuario_Identificacion{ get; set; }
        public string Usuario_Fotografia{ get; set; }
        public string Usuario_Fecha_Registro{ get; set; }
        public string Usuario_Estatus{ get; set; }
        public string Usuario_Descripcion{ get; set; }
        public List<RedSocialModel> Redes_Sociales { get; set; }
        public GeneroModel Genero { get; set; }
        public List<EtiquetaModel> Etiquetas { get; set; }
        public string Disponibilidad_Laboral_Id { get; set; }
        public string Disponibilidad_Laboral_Descripcion { get; set; }
        public string Usuario_Empresa_Nombre { get; set; }
        public byte[] Usuario_Fotografia_Perfil { get; set;}
    }
}
