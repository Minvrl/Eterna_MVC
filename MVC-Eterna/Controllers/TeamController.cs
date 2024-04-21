using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Eterna.Data;
using MVC_Eterna.Models;
using MVC_Eterna.ViewModels;
using System.Diagnostics;
namespace MVC_Eterna.Controllers


{
    public class TeamController:Controller
    {
        private AppDbContext _context;

        public TeamController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            TeamViewModel tvm = new TeamViewModel()
            {
                Members = _context.Members.Include(x=> x.SocialMedia).ToList()
            };
            return View(tvm);


        }
    }
}
