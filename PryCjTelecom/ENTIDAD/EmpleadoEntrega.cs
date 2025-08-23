namespace PryCjTelecom.ENTIDAD
{
    public class EmpleadoEntrega
    {
        public int? IdCliente { get; set; }
        public int? IdProyecto { get; set; }
        public string? IdSite { get; set; }
        public decimal? CorreSite { get; set; }
        public string? PedidoSap { get; set; }
        public string? NroSolicitud { get; set; }
        public Guid? Correlativo { get; set; }
        public int? IdEmpleado { get; set; }
    }
}
