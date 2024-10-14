using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projeto_Estudo_dotnet.Models.model;

namespace Projeto_Estudo_dotnet.Controllers;

public class ClienteController : Controller
{
    private readonly ILogger<ClienteController> _logger;
    public Cliente cliente;

    public ClienteController(ILogger<ClienteController> logger)
    {
        _logger = logger;
        this.cliente = new Cliente();
    }

    public IActionResult Index()
    {
        cliente.nomePessoa = "Rodrigo Zenezini Pozzebon";
        cliente.ContatoEmail = "rodrigo.zenezini@hotmail.com";
        return View(this.cliente);
    }

    [HttpPost]
    public IActionResult SalvarClienteAjax([FromBody] Cliente cliente)
    {
        return Json(new { success = true, message = "Cliente salvo com sucesso!" });
    }

}
