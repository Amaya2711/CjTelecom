namespace PryCjTelecom.ENTIDAD
{
    public class DetplantaDoc
    {
        public int IdCliente { get; set; }
        public int IdProyecto { get; set; }
        public string IdSite { get; set; }
        public decimal CorreSite { get; set; }
        public string TipoTrabajo { get; set; }
        public string PedidoSap { get; set; }
        public string NroSolicitud { get; set; }
        public string Posicion { get; set; }
        public string Correlativo { get; set; }
        public string? Usuario { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? Hora { get; set; }
        public int? IdEstado { get; set; }
        public string? Observacion { get; set; }
        public DateTime? FechaCarga { get; set; }
        public int? IdRespCarga { get; set; }
        public string? ImagenCarga { get; set; }
    }
}
