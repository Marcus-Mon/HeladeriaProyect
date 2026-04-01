namespace HeladeriaProyect.Entities
{
    public class Inventario
    {
        public int Id { get; set; }

        public int SaborHeladoId { get; set; }
        public SaborHelado SaborHelado { get; set; }

        public int Stock { get; set; }
    }
}
