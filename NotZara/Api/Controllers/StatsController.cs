using Microsoft.AspNetCore.Mvc;

namespace NotZara.Controllers;

[Route("/")]
public class StatsController : Controller
{
    [HttpGet]
    public string Index()
    {
        return "Not zara";
    }
    
    [HttpGet("baileys")]
    public string Baileys()
    {
        return "Not Baileys";
    }
}