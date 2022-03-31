using LibraryShop.businessModel;

namespace LibraryShop;

public interface IManagerProduct
{
    public Task<OperationResult<Guid>> createProduct(ProductState ps);

    public Task<OperationResult<Boolean>> insertProductState(Guid idProduct, ProductState product);

    public Task<OperationResult<ProductState>> getProductState(Guid idProduct, DateTime articleTime);

    public Task<OperationResult<ProductHistory>> getProductHistory(Guid idProduct);
}
