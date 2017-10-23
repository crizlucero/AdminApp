namespace WorklabsMx.Models
{
    public class RenovacionPagosModel
    {
        public string Empresa_Id { get; set; }
        public string Num_Tarjeta { get; set; }
        public string Fecha_Vencimiento { get; set; }
        public string Monto_Pagar { get; set; }
        public string Titular { get; set; }
    }
}