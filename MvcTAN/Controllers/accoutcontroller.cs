using MvcTAN.Controllers;
using MvcTAN.Models;
using Microsoft.AspNetCore.Mvc;

public class accoutcontroller : Controller
{
    public IActionResult Login()
        {
            return View();
        }
}