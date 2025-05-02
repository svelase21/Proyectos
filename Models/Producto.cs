namespace EvaluacionTecnica.Models

{
    public class Producto
    {
        public int Codigoproducto { get; set; }
        public string Nombreproducto { get; set; }
        public int Codigocategoria { get; set; }
        public Categoria Categoria { get; set; }

    }
}
