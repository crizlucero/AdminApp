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

        public SalaJuntasReservacionModel(string Sala_Junta_Reservacion_Id = "", string Sala_Hora_Inicio = "", string Sala_Hora_Fin = "", string Sala_Fecha = "", string Sala_Reservacion_Estatus = "", string Usuario_Id = "", string Usuario_Tipo = "", string Sala_Descripcion = "", string Sala_Capacidad = "", string Sala_Nivel = "", string Sucursal_Descripcion = "", string Sucursal_Id = "", string Sala_Id = "")
        {
            this.Sala_Junta_Reservacion_Id = Sala_Junta_Reservacion_Id;
            this.Sala_Hora_Inicio = Sala_Hora_Inicio;
            this.Sala_Hora_Fin = Sala_Hora_Fin;
            this.Sala_Fecha = Sala_Fecha;
            this.Sala_Reservacion_Estatus = Sala_Reservacion_Estatus;
            this.Usuario_Id = Usuario_Id;
            this.Usuario_Tipo = Usuario_Tipo;
            this.Sala_Descripcion = Sala_Descripcion;
            this.Sala_Capacidad = Sala_Capacidad;
            this.Sala_Nivel = Sala_Nivel;
            this.Sucursal_Descripcion = Sucursal_Descripcion;
            this.Sucursal_Id = Sucursal_Id;
            this.Sala_Id = Sala_Id;
        }
    }
}
