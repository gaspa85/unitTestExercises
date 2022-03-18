using LibraryShop.businessModel;

namespace LibraryShop;

public class ManagerProduct : IManagerProduct
{
    public void insertProduct(Product product)
    {
        throw new NotImplementedException();
    }

    List<Product> IManagerProduct.getProductAll(Guid idProduct)
    {
        throw new NotImplementedException();
    }

    Product IManagerProduct.getProductByTime(Guid idProduct, DateTime articleTime)
    {
        throw new NotImplementedException();
    }
}
