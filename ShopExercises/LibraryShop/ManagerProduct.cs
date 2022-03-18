using LibraryShop.businessModel;

namespace LibraryShop;

public class ManagerProduct : IManagerProduct
{
    public Guid createProduct()
    {
        throw new NotImplementedException();
    }

    public void insertProductState(Guid idProduct, ProductState product)
    {
        throw new NotImplementedException();
    }

    public OperationResult<Product> getProduct(Guid idProduct)
    {
        throw new NotImplementedException();
    }

    public OperationResult<ProductState> getProductState(Guid idProduct, DateTime articleTime)
    {
        throw new NotImplementedException();
    }

}
