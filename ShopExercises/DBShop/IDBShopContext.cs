using dbshop.businessModel;
using util;

namespace DBShop;

public interface IDBShopContext
{
    public Task createProduct(ProductDTO productEntity);

    public Task insertProductState(ProductStateDTO product);

    public Task<OperationResult<ProductStateDTO>> getProductState(Guid idProduct, DateTime articleTime);

    public Task<OperationResult<ProductDTO>> getProduct(Guid idProduct);
}
