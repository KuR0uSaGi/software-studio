using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ex6.Models;

namespace ex6.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult OnEnter(string Fname, string Lname, string Email, string Height, string Ans)
    {
        ViewBag.Fname = Fname;
        ViewBag.Lname = Lname;
        ViewBag.Email = Email;
        ViewBag.Height = Height;
        ViewBag.Ans = Ans;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}