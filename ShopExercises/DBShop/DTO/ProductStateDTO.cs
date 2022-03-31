namespace dbshop.businessModel;

public class ProductStateDTO
{
    public Guid Id { get; set; }

    public string Name { get; set; }
    public DateTime? Expire { get; set; }
    public float Price { get; set; }
    public DiscountEnumDTO Discounts { get; set; }
    public string Ean { get; set; }
}
