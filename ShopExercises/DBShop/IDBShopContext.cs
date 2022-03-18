using dbshop.businessModel;
using util;

namespace DBShop;

public interface IDBShopContext
{
    public Task createProduct(ProductEntity productEntity);

    public Task insertProductState(ProductStateEntity product);

    public Task<OperationResult<ProductStateEntity>> getProductState(Guid idProduct, DateTime articleTime);

    public Task<OperationResult<ProductEntity>> getProduct(Guid idProduct);
}
