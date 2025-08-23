namespace PryCjTelecom.ENTIDAD
{
    public class CabLogistica
    {
        public int IdCliente { get; set; }
        public int IdProyecto { get; set; }
        public string IdSite { get; set; }
        public decimal CorreSite { get; set; }
        public string TipoTrabajo { get; set; }
        public string PedidoSap { get; set; }
        public string NroSolicitud { get; set; }
        public string? IdSolicitud { get; set; }
        public string? ObsSolicitud { get; set; }
        public string? Region { get; set; }
        public string? Oc { get; set; }
        public int? IdZona { get; set; }
        public string? NroGuia { get; set; }
        public string? Observacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? HoraCreacion { get; set; }
        public string? Usuario { get; set; }
        public int? IdSolicitante { get; set; }
        public int? IdEstado { get; set; }
        public string? OT { get; set; }
        public string? NombreCliente { get; set; }
        public string? NombreProyecto { get; set; }
        public string? NombreTrabajo { get; set; }
        public int? IdValidador { get; set; }
        public DateTime? FechaIngreso { get; set; }
    }
}
