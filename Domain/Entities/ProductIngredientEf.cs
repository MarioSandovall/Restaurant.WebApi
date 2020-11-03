namespace Domain.Entities
{
    public class ProductIngredientEf
    {
        public int ProductId { get; set; }
        public ProductEf Product { get; set; }

        public int IngredientId { get; set; }
        public IngredientEf Ingredient { get; set; }
    }
}
