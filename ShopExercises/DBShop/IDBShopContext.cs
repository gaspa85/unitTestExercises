using dbshop.businessModel;

namespace DBShop;

public interface IDBShopContext
{
    public Task createProductHistory(ProductHistoryDTO productHistoryDTO);

    public Task insertProductState(Guid idProduct, ProductStateDTO productStateDTO);

    public Task<ProductStateDTO> getProductState(Guid idProduct, DateTime articleTime);

    public Task<ProductHistoryDTO> getProductHistory(Guid idProduct);
}
