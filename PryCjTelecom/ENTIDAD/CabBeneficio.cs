namespace PryCjTelecom.ENTIDAD
{
    public class CabBeneficio
    {
        public decimal? IdBeneficio { get; set; }
        public int? IdTipoBeneficio { get; set; }
        public int? IdEmpleado { get; set; }
        public decimal? Monto { get; set; }
        public int? Meses { get; set; }
        public DateTime? MesInicio { get; set; }
        public int? IdAprobador { get; set; }
        public DateTime? FechaAprobador { get; set; }
        public int? IdRechazo { get; set; }
        public DateTime? FechaRechazo { get; set; }
        public int? IdCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int? IdEstado { get; set; }
        public bool? IdAprobado { get; set; }
    }
}
