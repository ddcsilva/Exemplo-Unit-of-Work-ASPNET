namespace UnitOfShop.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
