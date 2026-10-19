
using System.ComponentModel.DataAnnotations;

namespace TechnologyResourceCenter.Models
{
    public class Equipment
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del equipo es obligatorio.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "La categoría es obligatoria.")]
        public string Category { get; set; } = string.Empty;

        [Required(ErrorMessage = "La marca es obligatoria.")]
        public string Brand { get; set; } = string.Empty;

        [Range(typeof(decimal), "0.01", "100000",
            ErrorMessage = "La tarifa diaria debe ser mayor que cero.")]
        public decimal DailyRate { get; set; }

        [Range(0, 100000,
            ErrorMessage = "El inventario no puede ser negativo.")]
        public int Stock { get; set; }

        public bool IsOperational { get; set; }

        public string GetStatus()
        {
            if (!IsOperational)
                return "FUERA DE SERVICIO";

            if (Stock == 0)
                return "NO DISPONIBLE";

            if (Stock == 1)
                return "ÚLTIMA UNIDAD";

            return "DISPONIBLE";
        }

        public decimal CalculateRentalCost(int days)
        {
            if (days <= 0)
                throw new ArgumentOutOfRangeException(
                    nameof(days),
                    "Los días de alquiler deben ser mayores que cero.");

            if (DailyRate <= 0)
                throw new InvalidOperationException(
                    "La tarifa diaria debe ser mayor que cero.");

            return DailyRate * days;
        }
    }
}
