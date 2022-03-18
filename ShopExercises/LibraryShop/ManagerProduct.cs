using LibraryShop.businessModel;

namespace LibraryShop;

public class ManagerProduct : IManagerProduct
{
    public void insertProductState(Guid idProduct, ProductState product)
    {
        throw new NotImplementedException();
    }

    public Product getProduct(Guid idProduct)
    {
        throw new NotImplementedException();
    }

    public ProductState getProductState(Guid idProduct, DateTime articleTime)
    {
        throw new NotImplementedException();
    }
}
