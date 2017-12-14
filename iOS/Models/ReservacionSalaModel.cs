using Foundation;

namespace WorklabsMx.iOS.Models
{
    public class ReservacionSalaModel: NSObject
    {
        public string Nombre_Sala { get; set; }
        public string Fecha_Reservacion { get; set; }
        public string Hora_Inicio { get; set; }
        public string Hora_Fin { get; set; }
        public string Capacidad { get; set; }
        public string Estatus { get; set; }
    }
}
