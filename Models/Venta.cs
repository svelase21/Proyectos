namespace EvaluacionTecnica.Models
{
    public class Venta
    {
        public int Codigoventa { get; set; }
        public DateTime Fecha { get; set; }
        public int Codigoproducto { get; set; }
        public Producto Producto { get; set; }

    }
}
