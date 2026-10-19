
using Microsoft.AspNetCore.Mvc;
using TechnologyResourceCenter.Models;

namespace TechnologyResourceCenter.Controllers
{
    public class EquipmentController : Controller
    {
        private static readonly List<Equipment> _equipmentList = new()
        {
            new() { Id = 1, Name = "Dell Latitude 5550", Category = "Informática", Brand = "Dell", DailyRate = 25m, Stock = 4, IsOperational = true },
            new() { Id = 2, Name = "HP ProBook 450", Category = "Informática", Brand = "HP", DailyRate = 22m, Stock = 3, IsOperational = true },
            new() { Id = 3, Name = "MacBook Air M3", Category = "Informática", Brand = "Apple", DailyRate = 35m, Stock = 2, IsOperational = true },
            new() { Id = 4, Name = "Epson PowerLite", Category = "Proyección", Brand = "Epson", DailyRate = 18m, Stock = 1, IsOperational = true },
            new() { Id = 5, Name = "Canon EOS R50", Category = "Fotografía", Brand = "Canon", DailyRate = 30m, Stock = 2, IsOperational = true },
            new() { Id = 6, Name = "iPad Air", Category = "Tableta", Brand = "Apple", DailyRate = 16m, Stock = 5, IsOperational = true },
            new() { Id = 7, Name = "Samsung Galaxy Tab S9", Category = "Tableta", Brand = "Samsung", DailyRate = 15m, Stock = 3, IsOperational = true },
            new() { Id = 8, Name = "TP-Link Archer AX55", Category = "Redes", Brand = "TP-Link", DailyRate = 8m, Stock = 4, IsOperational = true },
            new() { Id = 9, Name = "LG UltraWide Monitor", Category = "Pantallas", Brand = "LG", DailyRate = 12m, Stock = 2, IsOperational = true },
            new() { Id = 10, Name = "Shure SM58 Microphone", Category = "Audio", Brand = "Shure", DailyRate = 10m, Stock = 3, IsOperational = true },
            new() { Id = 11, Name = "Logitech Brio Webcam", Category = "Video", Brand = "Logitech", DailyRate = 9m, Stock = 0, IsOperational = true },
            new() { Id = 12, Name = "GoPro HERO12", Category = "Fotografía", Brand = "GoPro", DailyRate = 20m, Stock = 2, IsOperational = true },
            new() { Id = 13, Name = "BenQ Projector", Category = "Proyección", Brand = "BenQ", DailyRate = 21m, Stock = 0, IsOperational = true },
            new() { Id = 14, Name = "Lenovo ThinkPad E14", Category = "Informática", Brand = "Lenovo", DailyRate = 24m, Stock = 3, IsOperational = true },
            new() { Id = 15, Name = "ASUS Zenbook 14", Category = "Informática", Brand = "ASUS", DailyRate = 27m, Stock = 1, IsOperational = true },
            new() { Id = 16, Name = "Cisco Catalyst 2960", Category = "Redes", Brand = "Cisco", DailyRate = 14m, Stock = 2, IsOperational = true },
            new() { Id = 17, Name = "DJI Osmo Pocket 3", Category = "Fotografía", Brand = "DJI", DailyRate = 28m, Stock = 1, IsOperational = false },
            new() { Id = 18, Name = "Acer Aspire 5", Category = "Informática", Brand = "Acer", DailyRate = 19m, Stock = 4, IsOperational = true },
            new() { Id = 19, Name = "Rode VideoMic GO", Category = "Audio", Brand = "Rode", DailyRate = 11m, Stock = 2, IsOperational = true },
            new() { Id = 20, Name = "ViewSonic Monitor", Category = "Pantallas", Brand = "ViewSonic", DailyRate = 13m, Stock = 0, IsOperational = false }
        };

        public IActionResult Index()
        {
            return View(_equipmentList);
        }

        public IActionResult Details(int id)
        {
            var equipment = _equipmentList.FirstOrDefault(e => e.Id == id);

            if (equipment == null)
                return NotFound();

            return View(equipment);
        }

        public IActionResult Available()
        {
            var availableEquipment = _equipmentList
                .Where(e => e.IsOperational && e.Stock > 0)
                .ToList();

            return View(availableEquipment);
        }
    }
}
