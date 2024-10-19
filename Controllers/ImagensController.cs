using Microsoft.AspNetCore.Mvc;

namespace Projeto_Estudo_dotnet.Controllers;

public class ImagensController : Controller
{
    private readonly ILogger<ImagensController> _logger;

    public ImagensController(ILogger<ImagensController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}