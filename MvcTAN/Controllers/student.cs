using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcTAN.Models;

namespace MvcTAN.Controllers;

public class StudentController : Controller
{
       public IActionResult Index()
    {
        return View();
    }
}