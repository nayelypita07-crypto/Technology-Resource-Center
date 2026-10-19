
using Microsoft.AspNetCore.Mvc;
using TechnologyResourceCenter.Models;

namespace TechnologyResourceCenter.Controllers
{
    public class AccessoriesController : Controller
    {
        private static readonly List<Accessory> _accessories = new()
        {
            new() { Id = 1, Name = "Micrófono inalámbrico", Brand = "Shure", Category = "Audio", Price = 120m, Quantity = 4 },
            new() { Id = 2, Name = "Auriculares de estudio", Brand = "Sony", Category = "Audio", Price = 85m, Quantity = 6 },
            new() { Id = 3, Name = "Micrófono USB", Brand = "Blue", Category = "Audio", Price = 70m, Quantity = 3 },
            new() { Id = 4, Name = "Cámara web HD", Brand = "Logitech", Category = "Video", Price = 95m, Quantity = 5 },
            new() { Id = 5, Name = "Trípode para cámara", Brand = "Manfrotto", Category = "Video", Price = 65m, Quantity = 3 },
            new() { Id = 6, Name = "Tarjeta de captura", Brand = "Elgato", Category = "Video", Price = 150m, Quantity = 2 },
            new() { Id = 7, Name = "Conmutador de red", Brand = "TP-Link", Category = "Redes", Price = 55m, Quantity = 4 },
            new() { Id = 8, Name = "Router Gigabit", Brand = "ASUS", Category = "Redes", Price = 110m, Quantity = 2 },
            new() { Id = 9, Name = "Unidad SSD portátil", Brand = "Samsung", Category = "Almacenamiento", Price = 100m, Quantity = 5 },
            new() { Id = 10, Name = "Disco duro externo", Brand = "Seagate", Category = "Almacenamiento", Price = 80m, Quantity = 3 },
            new() { Id = 11, Name = "Concentrador USB-C", Brand = "Anker", Category = "Conectividad", Price = 45m, Quantity = 7 },
            new() { Id = 12, Name = "Adaptador HDMI", Brand = "UGREEN", Category = "Conectividad", Price = 18m, Quantity = 10 },
            new() { Id = 13, Name = "Teclado inalámbrico", Brand = "Logitech", Category = "Informática", Price = 40m, Quantity = 6 },
            new() { Id = 14, Name = "Ratón externo", Brand = "Microsoft", Category = "Informática", Price = 25m, Quantity = 8 },
            new() { Id = 15, Name = "Base refrigerante para portátil", Brand = "Cooler Master", Category = "Informática", Price = 35m, Quantity = 4 }
        };

        public IActionResult Index()
        {
            return View(_accessories);
        }

        public IActionResult Details(int id)
        {
            var accessory = _accessories
                .FirstOrDefault(a => a.Id == id);

            if (accessory == null)
                return NotFound();

            return View(accessory);
        }

        public IActionResult ByCategory()
        {
            var accessoriesByCategory = _accessories
                .OrderBy(a => a.Category)
                .ThenBy(a => a.Name)
                .ToList();

            return View(accessoriesByCategory);
        }
    }
}
