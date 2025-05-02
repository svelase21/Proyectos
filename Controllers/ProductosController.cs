using EvaluacionTecnica.Data;
using EvaluacionTecnica.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using EvaluacionTecnica.Data;
using EvaluacionTecnica.Models;

public class ProductosController : Controller
{
    private readonly VentasContext _context;

    public ProductosController(VentasContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var model = new ProductViewModel
        {
            Categorias = _context.Categorias.Select(c => new SelectListItem
            {
                Value = c.Codigocategoria.ToString(),
                Text = c.Nombre
            }).ToList(),
            Productos = new List<Producto>()  // Inicializar la lista de productos
        };

        return View(model);
    }

    [HttpPost]
    public IActionResult Filtrar(ProductViewModel model)
    {
        model.Productos = _context.Ventas
            .Where(v => v.Fecha.Year == 2019 && v.Producto.Codigocategoria == model.Codigocategoria)
            .Select(v => v.Producto)
            .ToList();

        model.Categorias = _context.Categorias.Select(c => new SelectListItem
        {
            Value = c.Codigocategoria.ToString(),
            Text = c.Nombre
        }).ToList();

        return View("Index", model);
    }
}

