using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Treinar.Data.ClienteDbContext;
using Treinar.Data.Entidades;
using Treinar.Models;

namespace Treinar.Controllers;

public class ClienteController : Controller
{
    private readonly ClienteDbContext _context;
    private readonly IMapper _mapper;

    public ClienteController(ClienteDbContext context, IMapper mapper)
    {
        _context = context;
        mapper = _mapper;
    }

    public IActionResult Index()
    {
        return View(_context.ClienteModels.ToList());
    }

    public IActionResult CadastroCliente()
    {
        var viewModel = new CadastroCompletoViewModel();
        viewModel.CepClienteViewModel = new CepClienteViewModel()
        {
            CepClienteViewModelId = Guid.NewGuid()
        };

        return View(viewModel);
    }
    

    [HttpPost]
    public async Task<IActionResult> CadastroCliente(CadastroCompletoViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }
        
        var clienteModel = new ClienteViewModel();
        clienteModel = new ClienteViewModel()
        {
            CepClienteId = clienteModel.CepClienteId
        };
        
        
        Cliente cliente = new()
        {
            FirstName = model.ClienteViewModel.FirstName,
            LastName = model.ClienteViewModel.LastName,
            Idade = model.ClienteViewModel.Idade,
        };

        CepCliente cepModels = new()
        {
            cep = model.CepClienteViewModel.Cep,
            state = model.CepClienteViewModel.State,
            city = model.CepClienteViewModel.City,
            neighborhood = model.CepClienteViewModel.Neighborhood,
            street = model.CepClienteViewModel.Street
        };

        
        await _context.CepCliente.AddAsync(cepModels);
        await _context.ClienteModels.AddAsync(cliente);
        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Index), clienteModel);
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