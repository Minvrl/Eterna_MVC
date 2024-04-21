using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Evaluation;
using Microsoft.EntityFrameworkCore;
using MVC_Eterna.Data;
using MVC_Eterna.ViewModels;

namespace MVC_Eterna.Controllers
{
    public class PortfolioController:Controller
    {
        public AppDbContext _context;
        public PortfolioController(AppDbContext context)
        {
            _context = context; 
        }
        public IActionResult Index()
        {
            PortfolioViewModel pvm = new PortfolioViewModel()
            {
                Projects = _context.Projects.Include(x => x.Category).Include(x => x.ProjectImgs).ToList(),  
                Categories = _context.Categories.ToList(),  
            };
            return View(pvm);
        }

        public ActionResult Details(int id)
        {
            var project = _context.Projects
                                  .Include(x => x.Category)
                                  .Include(x => x.ProjectImgs)
                                  .FirstOrDefault(p => p.Id == id);

            PortfolioDetailsViewModel vm = new PortfolioDetailsViewModel()
            {
                Project = project,
                ProjectImgs = project.ProjectImgs.ToList()
            };

            return View(vm);
        }

    }
}
