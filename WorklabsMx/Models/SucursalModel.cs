using System;
namespace WorklabsMx.Models
{
    public class SucursalModel
    {
        public string Sucursal_Id { get; set; }
        public string Sucursal_Descripcion { get; set; }
        public string Sucursal_Domicilio { get; set; }
        public string Sucursal_Telefono { get; set; }
		public string Sucursal_Correo { get; set; }
		public string Sucursal_Imagen { get; set; }
		public string Sucursal_Estatus { get; set; }
        public string Sucursal_No_Exterior { get; set; }
        public string Sucursal_No_Interior { get; set; }
        public TerritorioModel Territorio { get; set; }
    }
}
