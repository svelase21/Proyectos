using Microsoft.AspNetCore.Mvc.Rendering;

namespace EvaluacionTecnica.Models
{
    public class ProductViewModel
    {

        public int Codigocategoria { get; set; }
        public IEnumerable<SelectListItem> Categorias { get; set; }
        public IEnumerable<Producto> Productos { get; set; } 

    }
}
