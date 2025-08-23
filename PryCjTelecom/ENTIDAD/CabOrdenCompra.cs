namespace PryCjTelecom.ENTIDAD
{
    public class CabOrdenCompra
    {
        public int IdOc { get; set; }
        public int? IdSolicitante { get; set; }
        public int? IdResponsable { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? Igv { get; set; }
        public decimal? Total { get; set; }
        public string? UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? HoraCreacion { get; set; }
        public int? IdMoneda { get; set; }
        public int? IdAprobador1 { get; set; }
        public DateTime? FechaAprobador1 { get; set; }
        public int? IdAprobador2 { get; set; }
        public DateTime? FechaAprobador2 { get; set; }
        public int? IdAprobador3 { get; set; }
        public DateTime? FechaAprobador3 { get; set; }
        public int? IdComprobante { get; set; }
        public int? IdRechazador { get; set; }
        public DateTime? FechaRechazado { get; set; }
        public int? IdEstado { get; set; }
        public string? Observacion { get; set; }
        public int? IdValidador { get; set; }
        public int? IdGestor { get; set; }
        public DateTime? FechaGestor { get; set; }
        public int? IdFormaPago { get; set; }
        public int? DiasPAgo { get; set; }
        public decimal? Peso { get; set; }
    }
}
