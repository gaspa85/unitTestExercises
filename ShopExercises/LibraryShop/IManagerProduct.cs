using LibraryShop.businessModel;

namespace LibraryShop;

public interface IManagerProduct
{
    public Guid createProduct();

    public void insertProductState(Guid idProduct, ProductState product);

    public OperationResult<ProductState> getProductState(Guid idProduct, DateTime articleTime);

    public OperationResult<Product> getProduct(Guid idProduct);
}
