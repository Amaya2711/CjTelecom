namespace PryCjTelecom.ENTIDAD
{
    public class SolicitudEnvio
    {
        public int IdCliente { get; set; }
        public int IdProyecto { get; set; }
        public string IdSite { get; set; }
        public decimal CorreSite { get; set; }
        public string TipoTrabajo { get; set; }
        public string PedidoSap { get; set; }
        public string NroSolicitud { get; set; }
        public string? Descripcion { get; set; }
        public DateTime? FechaEnvio { get; set; }
        public DateTime? HoraEnvio { get; set; }
        public string? NroGuia { get; set; }
        public int? IdAgencia { get; set; }
        public string? NombreAgencia { get; set; }
        public decimal? Monto { get; set; }
        public int? IdResponsable { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public DateTime? FechaEnviado { get; set; }
        public int? Aplica { get; set; }
        public DateTime? FechaRecojo { get; set; }
        public string? Imagen { get; set; }
        public int? IdEstado { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? HoraCreacion { get; set; }
        public string? Usuario { get; set; }
    }
}
