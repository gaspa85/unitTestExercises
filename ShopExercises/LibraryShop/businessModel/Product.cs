namespace LibraryShop.businessModel;

public class Product
{
    public Product(ProductState ProductState)
    {
        this.ProductState = ProductState;
    }

    public Guid Id { get; } = Guid.NewGuid();
    public ProductState ProductState { get; }
}
