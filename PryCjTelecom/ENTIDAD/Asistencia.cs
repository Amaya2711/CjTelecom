namespace PryCjTelecom.ENTIDAD
{
    public class Asistencia
    {
        public int IdEmpleado { get; set; }
        public DateTime FechaAsistencia { get; set; }
        public int IdEstado { get; set; }
        public string? Comentario { get; set; }
        public int? UsuarioCre { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int? UsuarioAct { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public int? Aprobado { get; set; }
        public DateTime? FechaAprobado { get; set; }
        public int? IdAprobador { get; set; }
        public DateTime? Hora { get; set; }
    }
}
