namespace WorklabsMx.Models
{
    public class MembresiaModel
    {
        public string Membresia_Id {get;set;}
        public string Membresia_Descripcion { get; set; }
        public string Membresia_Espacios_Disponibles { get; set; }
        public string Membresia_Precio_Base { get; set; }
		//Inscripción
        public string Inscripcion_Descripcion { get;}
		public string Inscripcion_Espacios_Disponibles { get; set; }
		public string Inscripcion_Precio_Base { get; set; }
    }
}
