namespace PryCjTelecom.ENTIDAD
{
    public class DetBeneficio
    {
        public decimal? IdBeneficio { get; set; }
        public string? MesPago { get; set; }
        public decimal? Monto { get; set; }
        public int? IdEstado { get; set; }
        public int? IdUsuarioPago { get; set; }
        public DateTime? FechaPago { get; set; }
        public int? IdActualizacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
    }
}
