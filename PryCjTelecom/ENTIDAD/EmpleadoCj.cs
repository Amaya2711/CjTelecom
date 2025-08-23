namespace PryCjTelecom.ENTIDAD
{
    public class EmpleadoCj
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
        public DateTime? FechaIniLaboral { get; set; }
        public DateTime? FechaFinlaboral { get; set; }
        public bool? IdActivo { get; set; }
        public int? IdAptobeneficio { get; set; }
        public int? IdSexo { get; set; }
        public int? IdEmpRel { get; set; }
        public string? NroAlterno { get; set; }
        public int? IdEstable { get; set; }
        public int? IdEmpleadoAnt { get; set; }
        public DateTime? FechaBaja { get; set; }
    }
}
