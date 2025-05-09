namespace Muebleria.Server.Models
{
    public class CatalogoViewModel
    {
        public int Id { get; set; }
        public string NombreArticulo { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaAltaCatalogo { get; set; }
    }
    public class CatalogoCreateModel
    {
        public string NombreArticulo { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaAltaCatalogo { get; set; }
    }
}
