using System;

namespace PryCjTelecom.ENTIDAD
{
    public class CargaLogistica
    {
        public Guid Correlativo { get; set; }
        public int? IdCliente { get; set; }
        public int? IdProyecto { get; set; }
        public string? IdSite { get; set; }
        public decimal? CorreSite { get; set; }
        public int? IdTipoTrabajo { get; set; }
        public string? CodPro { get; set; }
        public string? PedidoSap { get; set; }
        public string? IdSolicitud { get; set; }
        public string? DescSite { get; set; }
        public string? Solicitante { get; set; }
        public int? IdSolicitante { get; set; }
        public decimal? CantSolicitada { get; set; }
        public decimal? CantSap { get; set; }
        public string? Centro { get; set; }
        public string? Almacen { get; set; }
        public string? Lote { get; set; }
        public string? Obs { get; set; }
        public string? Region { get; set; }
        public string? Oc { get; set; }
        public string? Posicion { get; set; }
        public string? Usuario { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? Hora { get; set; }
        public string? UsuarioTmp { get; set; }
        public string? Descripcion { get; set; }
        public string? NombreCliente { get; set; }
        public string? NombreProyecto { get; set; }
        public string? NombreTrabajo { get; set; }
    }
}
