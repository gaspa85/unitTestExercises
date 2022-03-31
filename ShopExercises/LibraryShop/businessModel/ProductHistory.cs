namespace LibraryShop.businessModel;

public class ProductHistory
{
    public ProductHistory(Product Product)
    {
        this.Product = Product;
    }
    public Product Product { get; }

    public Dictionary<TimeRange, ProductState> MapProductState { get; set; } = new Dictionary<TimeRange, ProductState>();
}
