namespace EmpleadosApp.Server.Entities
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Activo { get; set; } = true;
        public int PuestoId { get; set; }
        public virtual Puesto Puesto { get; set; }
        public int DepartamentoId { get; set; }
        public virtual Departamento Departamento{ get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public List<Proyectos> Proyectos { get; set; }
    }
}
