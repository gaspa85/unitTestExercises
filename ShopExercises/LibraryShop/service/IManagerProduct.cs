using LibraryShop.businessModel;

namespace LibraryShop;

public interface IManagerProduct
{
    public Task<Guid> createProduct();

    public Task insertProductState(Guid idProduct, ProductState product);

    public Task<OperationResult<ProductState>> getProductState(Guid idProduct, DateTime articleTime);

    public Task<OperationResult<ProductHistory>> getProduct(Guid idProduct);
}
