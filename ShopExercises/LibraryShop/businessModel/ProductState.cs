namespace LibraryShop.businessModel;

public class ProductState
{
    public ProductState(
        string Name,
        DateTime? Expire,
        float Price,
        string Ean,
        DateTime Start,
        DateTime End,
        DiscountEnum Discounts = DiscountEnum.no_d
        )
    {
        this.Id = Guid.NewGuid();
        this.Name = Name;
        this.Expire = Expire;
        this.Price = Price;
        this.Discounts = Discounts;
        this.Ean = Ean;
    }

    public Guid Id { get; }
    public string Name { get; }
    public DateTime? Expire { get; } = null!;

    public float Price { get; }
    public DiscountEnum Discounts { get; } = DiscountEnum.no_d;
    public string Ean { get; }
}
