namespace PryCjTelecom.ENTIDAD
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string NombreEmpleado { get; set; }
        public string InicialesEmpleado { get; set; }
        public int IdCargo { get; set; }
        public int? IdDocumento { get; set; }
        public string? NroDocumento { get; set; }
        public string? Telefono { get; set; }
        public string? Correo { get; set; }
        public string? UsuarioCre { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int? IdEstado { get; set; }
        public string? UsuarioDel { get; set; }
        public DateTime? FechaEliminar { get; set; }
        public string? Direccion { get; set; }
        public int? IdTipoEmpleado { get; set; }
        public int? IdEmpleadoCj { get; set; }
        public int? IdCheque { get; set; }
    }
}
