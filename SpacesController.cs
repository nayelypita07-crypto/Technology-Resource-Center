
using Microsoft.AspNetCore.Mvc;
using TechnologyResourceCenter.Models;

namespace TechnologyResourceCenter.Controllers
{
    public class SpacesController : Controller
    {
        private static readonly List<Space> _spaces = new()
        {
            new() { Id = 1, Name = "Laboratorio de informática", Location = "Edificio A - Piso 2", Capacity = 30, HourlyRate = 15m, IsAvailable = true },
            new() { Id = 2, Name = "Sala multimedia", Location = "Edificio B - Piso 1", Capacity = 20, HourlyRate = 12m, IsAvailable = true },
            new() { Id = 3, Name = "Sala de transmisión en vivo", Location = "Centro de medios", Capacity = 8, HourlyRate = 20m, IsAvailable = false },
            new() { Id = 4, Name = "Sala de innovación", Location = "Edificio C - Piso 3", Capacity = 15, HourlyRate = 18m, IsAvailable = true },
            new() { Id = 5, Name = "Laboratorio de robótica", Location = "Bloque de ingeniería", Capacity = 25, HourlyRate = 22m, IsAvailable = false }
        };

        public IActionResult Index()
        {
            return View(_spaces);
        }

        public IActionResult Details(int id)
        {
            var space = _spaces.FirstOrDefault(s => s.Id == id);

            if (space == null)
                return NotFound();

            return View(space);
        }

        public IActionResult Available()
        {
            var availableSpaces = _spaces
                .Where(s => s.IsAvailable)
                .ToList();

            return View(availableSpaces);
        }
    }
}
