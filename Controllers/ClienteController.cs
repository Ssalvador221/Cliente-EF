using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Treinar.Data.ClienteDbContext;
using Treinar.Data.ClienteDbContext.Entidades;
using Treinar.Models;

namespace Treinar.Controllers;

public class ClienteController : Controller
{
    private readonly ClienteDbContext _context;
    
    
    
    public ClienteController(ClienteDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View(_context.ClienteModels.ToList());
    }

    public IActionResult CadastroCliente()
    {
        ClienteViewModel model = new()
        {
            Id = Guid.NewGuid()
        };

        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> CadastroCliente(ClienteViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        Cliente clienteModels = new()
        {
            FirstName = model.FirstName,
            LastName = model.LastName,
            Idade = model.Idade
        };

        await _context.ClienteModels.AddAsync(clienteModels);
        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }

   /* public IActionResult Details()
    {
        var vm = _context.ClienteModels.AsNoTracking().Select(x => new ClienteViewModel
        {
            Id = x.Id,
            FirstName = x.FirstName,
            LastName = x.LastName,
            Idade = x.Idade.Value
        }).ToListAsync();
        return View(vm);
    }*/
    
    
    
}