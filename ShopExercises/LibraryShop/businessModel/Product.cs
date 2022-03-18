namespace LibraryShop.businessModel;

public class Product
{
    public string Name { get; set; }
    public DateTime? Expire { get; set; } = null!;

    public List<ProductPrice> Price { get; set; }
    public List<ProductDiscount> Discounts { get; set; }
    public string Ean { get; set; }

}
