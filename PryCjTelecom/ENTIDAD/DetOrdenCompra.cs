namespace PryCjTelecom.ENTIDAD
{
    public class DetOrdenCompra
    {
        public int? IdOc { get; set; }
        public int? IdCliente { get; set; }
        public int? IdProyecto { get; set; }
        public string? IdSite { get; set; }
        public decimal? Correlativo { get; set; }
        public int? IdTipoTrabajo { get; set; }
        public int? IdTarea { get; set; }
        public string? TipoTrabajo { get; set; }
        public string? Detalle { get; set; }
        public int? Cantidad { get; set; }
        public decimal? PrecioUnitario { get; set; }
        public string? UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? HoraCreacion { get; set; }
        public string? Ot { get; set; }
        public int? IdAprobador1 { get; set; }
        public DateTime? FechaAprobador1 { get; set; }
        public int? IdAprobador2 { get; set; }
        public DateTime? FechaAprobador2 { get; set; }
        public int? IdAprobador3 { get; set; }
        public DateTime? FechaAprobador3 { get; set; }
        public int? IdComprobante { get; set; }
        public int? Fila { get; set; }
        public decimal? MontoAdela { get; set; }
        public int? IdEstado { get; set; }
        public int? IdGestor { get; set; }
        public DateTime? FechaGestor { get; set; }
        public string? ImgOc { get; set; }
        public string? ImgPresupuesto { get; set; }
    }
}
