using System;

namespace PryCjTelecom.ENTIDAD
{
    public class DetLogistica
    {
        public int IdCliente { get; set; }
        public int IdProyecto { get; set; }
        public string IdSite { get; set; }
        public decimal CorreSite { get; set; }
        public string TipoTrabajo { get; set; }
        public string PedidoSap { get; set; }
        public string Posicion { get; set; }
        public Guid Correlativo { get; set; }
        public string? Serie { get; set; }
        public string? CodPap { get; set; }
        public decimal? CantSap { get; set; }
        public string? Centro { get; set; }
        public string? Almacen { get; set; }
        public string? Lote { get; set; }
        public string? Usuario { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? Hora { get; set; }
        public int? IdEstado { get; set; }
        public string? Observacion { get; set; }
        public string? Comentario { get; set; }
        public int? LinReg { get; set; }
        public int? NroEnvio { get; set; }
        public int? IdClienteOrigen { get; set; }
        public int? IdProyectoOrigen { get; set; }
        public string? IdSiteOrigen { get; set; }
        public decimal? CorreSiteOrigen { get; set; }
        public string? TipoTrabajoOrigen { get; set; }
        public string? RutaImagen { get; set; }
        public bool? IdDespacho { get; set; }
        public decimal? CantRecepcion { get; set; }
        public DateTime? FecIngreso { get; set; }
        public string? Guia { get; set; }
        public string? Guia2 { get; set; }
        public int? IdUbicacion { get; set; }
        public int? IdZonaAlmacen { get; set; }
        public DateTime? FecIngreso2 { get; set; }
        public decimal? CantSolNew { get; set; }
        public DateTime? FechaRecepcion { get; set; }
        public DateTime? FechaSerie { get; set; }
        public DateTime? FechaValidacion { get; set; }
        public DateTime? FechaSolicitud { get; set; }
        public DateTime? FechaAprobar { get; set; }
        public DateTime? FechaDespacho { get; set; }
        public DateTime? FechaEnvio { get; set; }
        public string? UsuarioMod { get; set; }
        public bool? Alm2025 { get; set; }
        public int? IdActivar { get; set; }
        public DateTime? FechaActivar { get; set; }
        public decimal? CantBloqueada { get; set; }
        public decimal? CantDisponible { get; set; }
        public string? Region { get; set; }
        public string? OC { get; set; }
    }
}
