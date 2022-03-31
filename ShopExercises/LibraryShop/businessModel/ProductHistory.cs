namespace LibraryShop.businessModel;

public class ProductHistory
{
    public ProductHistory(Product Product)
    {
        this.Product = Product;
    }
    public Product Product { get; }

    public List<ProductState> ListProductState { get; set; } = new List<ProductState>();
}
