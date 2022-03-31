namespace LibraryShop.businessModel;

public class ProductState
{
    public ProductState(
        string Name,
        DateTime? Expire,
        float Price,
        string Ean,
        TimeRange TimeRange,
        DiscountEnum Discounts = DiscountEnum.no_d
        )
    {
        this.Name = Name;
        this.Expire = Expire;
        this.Price = Price;
        this.Discounts = Discounts;
        this.Ean = Ean;
        this.TimeRange = TimeRange;
    }

    public Guid Id { get; } = Guid.NewGuid();

    public string Name { get; }
    public DateTime? Expire { get; } = null;
    public float Price { get; }
    public DiscountEnum Discounts { get; } = DiscountEnum.no_d;
    public string Ean { get; }
    public TimeRange TimeRange { get; }
}
