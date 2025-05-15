using System.ComponentModel.DataAnnotations;

namespace organigrama.Server.Data_Entities
{
    public class OrganigramaEntity
    {
        [Key]
        public string UsuarioId { get; set; }
        public int Codigocol { get; set; }
        public string NombreCompleto { get; set; }
        public string Correo { get; set; }
        public string UnidadOrganizativa { get; set; }
        public string UnidadOrganizativaId { get; set; }
        public string CentroCosto { get; set; }
        public string Puesto { get; set; }
        public string PuestoId { get; set; }
        public string TipoPosicion { get; set; }
        public string CodigoJefe { get; set; }
        public string UsuarioIdJefe { get; set; }
        public string NombreCompletoJefe { get; set; }
        public string CorreoJefe { get; set; }
        public string UnidadOrganizativaJefe { get; set; }
        public string UnidadOrganizativaJefeId { get; set; }
        public string PuestoJefe { get; set; }
        public string NivelFirma { get; set; }
        public string AreaPersonal { get; set; }
        public string FechaIngreso { get; set; }
        public string FechaNacimiento { get; set; }
        public string Gerencia { get; set; }
        public string Direccion { get; set; }
        public string FotoAD { get; set; }
        public string key { get; set; }
        public string parent { get; set; }


    }
}
