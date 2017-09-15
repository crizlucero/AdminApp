namespace WorklabsMx.Models
{
    public class MembresiaModel
    {
        public string Membresia_Id { get; set; }
        public string Membresia_Descripcion { get; set; }
        public string Membresia_Espacios_Disponibles { get; set; }
        public double Membresia_Precio_Base { get; set; }
        public string Membresia_Fecha_Inicio {get;set;}
		//Inscripción
        public string Inscripcion_Descripcion { get;}
		public string Inscripcion_Espacios_Disponibles { get; set; }
		public double Inscripcion_Precio_Base { get; set; }
    }
}
