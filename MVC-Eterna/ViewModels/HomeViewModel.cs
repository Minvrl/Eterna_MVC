using MVC_Eterna.Models;

namespace MVC_Eterna.ViewModels
{
    public class HomeViewModel
    {
        public List<Feature> Features { get; set; }     
        public List<Service> Services { get; set; }
        public List<SliderItem> Sliders { get; set; }

    }
}
