namespace FastAPI.Entities
{
    public class Product : BaseEntity<Guid>
    {
        public string Name { get; set; } = default!;
        public long Quantity { get; set; } = default!;
        public decimal Amount { get; set; }

    }
}
