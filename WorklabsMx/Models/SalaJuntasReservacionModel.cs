using System;
namespace WorklabsMx.Models
{
    public class SalaJuntasReservacionModel : SalaJuntasModel
    {
        public string Sala_Junta_Reservacion_Id { get; set; }
        public string Sala_Hora_Inicio { get; set; }
        public string Sala_Hora_Fin { get; set; }
        public string Sala_Fecha { get; set; }
        public string Sala_Reservacion_Estatus { get; set; }
        public string Usuario_Id { get; set; }
        public string Usuario_Tipo { get; set; }
    }
}
