﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Treinar.Data.ClienteDbContext;
using Treinar.Data.ClienteDbContext.Entidades;
using Treinar.Models;

namespace Treinar.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    


    public HomeController(ILogger<HomeController> logger, ClienteDbContext context)
    {
        _logger = logger;
    }

    public async Task<IActionResult> Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}