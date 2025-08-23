namespace PryCjTelecom.ENTIDAD
{
    public class EmpleadoCjAdministracion
    {
        public int IdEmpleado { get; set; }
        public DateTime InicioContrato { get; set; }
        public int Activo { get; set; }
        public int? CantMeses { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? HoraCreacion { get; set; }
        public string? UsuarioCreacion { get; set; }
        public int? IdEstado { get; set; }
    }
}
