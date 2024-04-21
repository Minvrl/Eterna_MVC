using MVC_Eterna.Models;

namespace MVC_Eterna.ViewModels
{
    public class PortfolioDetailsViewModel
    {
        public Project Project { get; set; }
        public List<ProjectImg> ProjectImgs { get; set; }
    }
}
