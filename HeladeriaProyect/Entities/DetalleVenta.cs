namespace HeladeriaProyect.Entities
{
    public class DetalleVenta
    {
        public int Id { get; set; }

        public int VentaId { get; set; }
        public Venta Venta { get; set; }

        public int SaborHeladoId { get; set; }
        public SaborHelado SaborHelado { get; set; }

        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
    }
}
