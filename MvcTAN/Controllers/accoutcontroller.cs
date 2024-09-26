using MvcTAN.Controllers;
using MvcTAN.Models;
using Microsoft.AspNetCore.Mvc;

public class accoutcontroller : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(account ps)
    {
        string str = "Hello" + " " + ps.masinhvien + "-" + ps.hoTen;
        ViewBag.thongbao = str;
        return View();
    }

}