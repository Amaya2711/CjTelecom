namespace PryCjTelecom.ENTIDAD
{
    public class MaterialSerie
    {
        public string CodPap { get; set; }
        public Guid CorrelativoInt { get; set; }
        public string Serie { get; set; }
        public string? PedidoSap { get; set; }
        public string? IdSolicitud { get; set; }
        public string? Correlativo { get; set; }
        public int? IdEstado { get; set; }
        public string? Usuario { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? Hora { get; set; }
    }
}
