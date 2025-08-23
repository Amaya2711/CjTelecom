namespace PryCjTelecom.ENTIDAD
{
    public class DetalleMulta
    {
        public decimal? IdMulta { get; set; }
        public int? IdMoneda { get; set; }
        public int? IdSolicitado { get; set; }
        public int? IdAtendido { get; set; }
        public DateTime? FecRec { get; set; }
        public DateTime? FecObj { get; set; }
        public int? IdGerencia { get; set; }
        public int? IdDireccion { get; set; }
        public int? IdContrata { get; set; }
        public int? IdResponsable { get; set; }
        public int? IdEstado { get; set; }
        public string? TxtInfraccion { get; set; }
        public string? TxtMedida { get; set; }
        public string? TxtAfectacion { get; set; }
        public string? TxtConcepto { get; set; }
        public string? TxtLugar { get; set; }
        public string? Usuario { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? HoraCreacion { get; set; }
    }
}
