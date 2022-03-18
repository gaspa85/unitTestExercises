namespace LibraryShop.businessModel;

public class ProductDiscount : TimeRange
{
    public DiscountEnum Discount { get; set; }
}

public enum DiscountEnum
{
    d5,
    d10,
    d15,
    d20,
    d25,
    d30,
    d35,
    d40,
    d45,
    d50
}
