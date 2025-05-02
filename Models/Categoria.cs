namespace EvaluacionTecnica.Models
{
    public class Categoria
    {
        public int Codigocategoria { get; set; }
        public string Nombre { get; set; }
        public ICollection<Producto> Productos { get; set; }

    }
}
