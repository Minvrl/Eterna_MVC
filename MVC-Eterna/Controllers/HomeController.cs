using Microsoft.AspNetCore.Mvc;
using MVC_Eterna.Data;
using MVC_Eterna.Models;
using MVC_Eterna.ViewModels;
using System.Diagnostics;

namespace MVC_Eterna.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
                
        }
        public IActionResult Index()
        {
            HomeViewModel vm = new HomeViewModel()
            {
                Features = _context.Features.ToList(),
                Services = _context.Services.ToList(),
                Sliders = _context.SliderItems.OrderByDescending(x=> x.Order).ToList()    
            };
            return View(vm);
        }

       
    }
}
