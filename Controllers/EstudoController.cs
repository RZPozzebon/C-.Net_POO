using Microsoft.AspNetCore.Mvc;

namespace Projeto_Estudo_dotnet.Controllers;

public class EstudoController : Controller
{
    private readonly ILogger<EstudoController> _logger;

    public EstudoController(ILogger<EstudoController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}