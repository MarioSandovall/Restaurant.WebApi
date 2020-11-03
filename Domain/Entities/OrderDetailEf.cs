using Domain.Interfaces;

namespace Domain.Entities
{
    public class OrderDetailEf : IEntity
    {
        public int Id { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public int ProductId { get; set; }
        public ProductEf Product { get; set; }

        public int OrderId { get; set; }
        public OrderEf Order { get; set; }
    }
}
