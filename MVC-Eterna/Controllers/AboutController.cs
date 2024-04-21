using Microsoft.AspNetCore.Mvc;
using MVC_Eterna.Models;
using System.Diagnostics;
namespace MVC_Eterna.Controllers;


public class AboutController:Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
