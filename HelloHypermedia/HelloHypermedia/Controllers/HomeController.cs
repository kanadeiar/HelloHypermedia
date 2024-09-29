using Microsoft.AspNetCore.Mvc;

namespace HelloHypermedia.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    // «аменить все лишние методы этим новым методом с приветственным сообщением
    public string Message()
    {
        return "ѕривет, гипермедиа!";
    }
}