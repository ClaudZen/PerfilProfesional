using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BaseDeDatos.Contextos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebPerfil.Models;

namespace WebPerfil.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly ILogger<CategoriaController> _logger;
        private readonly InventarioDbContext _context;

        public CategoriaController(ILogger<CategoriaController> logger ,InventarioDbContext context)
        {
            _logger = logger;
            _context=context;
        }

        public IActionResult Index()
        {
            var listaCategorias=_context.Categorias.ToList();
            return View(listaCategorias);
        }
    }
}
