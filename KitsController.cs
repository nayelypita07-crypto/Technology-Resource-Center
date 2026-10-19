
using Microsoft.AspNetCore.Mvc;
using TechnologyResourceCenter.Models;

namespace TechnologyResourceCenter.Controllers
{
    public class KitsController : Controller
    {
        private static readonly List<Kit> _kits = new()
        {
            new() { Id = 1, Name = "Kit de inicio Arduino", Category = "Electrónica", Level = "BEGINNER", DailyRate = 8m, Quantity = 5, IsOperational = true },
            new() { Id = 2, Name = "Kit de fundamentos de electrónica", Category = "Electrónica", Level = "BEGINNER", DailyRate = 7m, Quantity = 4, IsOperational = true },
            new() { Id = 3, Name = "Kit básico de robótica", Category = "Robótica", Level = "BEGINNER", DailyRate = 12m, Quantity = 3, IsOperational = true },
            new() { Id = 4, Name = "Kit de fotografía", Category = "Fotografía", Level = "INTERMEDIATE", DailyRate = 18m, Quantity = 2, IsOperational = true },
            new() { Id = 5, Name = "Kit de transmisión en vivo", Category = "Medios audiovisuales", Level = "INTERMEDIATE", DailyRate = 20m, Quantity = 2, IsOperational = true },
            new() { Id = 6, Name = "Kit de desarrollo IoT", Category = "IoT", Level = "INTERMEDIATE", DailyRate = 15m, Quantity = 3, IsOperational = true },
            new() { Id = 7, Name = "Kit avanzado de robótica", Category = "Robótica", Level = "ADVANCED", DailyRate = 25m, Quantity = 1, IsOperational = true },
            new() { Id = 8, Name = "Kit de inteligencia artificial", Category = "Inteligencia artificial", Level = "ADVANCED", DailyRate = 30m, Quantity = 2, IsOperational = true },
            new() { Id = 9, Name = "Kit de realidad virtual", Category = "Realidad virtual", Level = "ADVANCED", DailyRate = 28m, Quantity = 0, IsOperational = true },
            new() { Id = 10, Name = "Kit avanzado de redes", Category = "Redes", Level = "ADVANCED", DailyRate = 22m, Quantity = 2, IsOperational = false }
        };

        public IActionResult Index()
        {
            return View(_kits);
        }

        public IActionResult Details(int id)
        {
            var kit = _kits.FirstOrDefault(k => k.Id == id);

            if (kit == null)
                return NotFound();

            return View(kit);
        }

        public IActionResult ByLevel()
        {
            var kitsByLevel = _kits
                .OrderBy(k => k.Level)
                .ThenBy(k => k.Name)
                .ToList();

            return View(kitsByLevel);
        }
    }
}
