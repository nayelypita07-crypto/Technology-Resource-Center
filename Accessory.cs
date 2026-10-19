using System.ComponentModel.DataAnnotations;

namespace TechnologyResourceCenter.Models
{
    public class Accessory
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del accesorio es obligatorio.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "La marca es obligatoria.")]
        public string Brand { get; set; } = string.Empty;

        [Required]
        [RegularExpression(
            "^(Audio|Video|Networking|Storage|Connectivity|Computing)$",
            ErrorMessage = "Seleccione una categoría de accesorio válida.")]
        public string Category { get; set; } = "Computing";

        [Range(typeof(decimal), "0.01", "100000",
            ErrorMessage = "El precio debe ser mayor que cero.")]
        public decimal Price { get; set; }

        [Range(0, 100000,
            ErrorMessage = "La cantidad no puede ser negativa.")]
        public int Quantity { get; set; }
    }
}
