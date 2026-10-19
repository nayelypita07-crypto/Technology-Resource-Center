
using System.ComponentModel.DataAnnotations;

namespace TechnologyResourceCenter.Models
{
    public class Space
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del espacio es obligatorio.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "La ubicación es obligatoria.")]
        public string Location { get; set; } = string.Empty;

        [Range(1, 1000,
            ErrorMessage = "La capacidad debe ser mayor que cero.")]
        public int Capacity { get; set; }

        [Range(typeof(decimal), "0.01", "100000",
            ErrorMessage = "La tarifa por hora debe ser mayor que cero.")]
        public decimal HourlyRate { get; set; }

        public bool IsAvailable { get; set; }

        public string GetAvailabilityStatus()
        {
            return IsAvailable ? "DISPONIBLE" : "NO DISPONIBLE";
        }

        public decimal CalculateUsageCost(int hours)
        {
            if (hours < 1 || hours > 24)
                throw new ArgumentOutOfRangeException(
                    nameof(hours),
                    "Las horas de uso deben estar entre 1 y 24.");

            if (HourlyRate <= 0)
                throw new InvalidOperationException(
                    "La tarifa por hora debe ser mayor que cero.");

            return HourlyRate * hours;
        }
    }
}
