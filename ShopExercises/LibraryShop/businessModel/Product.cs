namespace LibraryShop.businessModel;

public class Product : TimeRange
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime? Expire { get; set; } = null!;

    public float Price { get; set; }
    public DiscountEnum Discounts { get; set; } = DiscountEnum.no_d;
    public string Ean { get; set; }
}
