namespace Muebleria.Server.Data_Entities
{
    public class CatalogoEntity
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        public DateTime FechaRegistro { get; set; }= DateTime.Now;
    }
}
