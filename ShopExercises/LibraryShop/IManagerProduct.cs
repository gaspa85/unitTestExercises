using LibraryShop.businessModel;

namespace LibraryShop;

public interface IManagerProduct
{
    public void insertProductState(Guid idProduct, ProductState product);

    public ProductState getProductState(Guid idProduct, DateTime articleTime);

    public Product getProduct(Guid idProduct);
}
