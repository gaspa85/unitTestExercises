using DBShop;
using LibraryShop.businessModel;

namespace LibraryShop;

public class ManagerProduct : IManagerProduct
{
    private IDBShopContext db;

    public ManagerProduct(IDBShopContext db)
    {
        this.db = db;
    }

    public async Task<Guid> createProduct()
    {
        var p = new Product();

        this.db.createProduct(p.toEntity());

        return p.Id
    }

    public async Task insertProductState(Guid idProduct, ProductState product)
    {
        throw new NotImplementedException();
    }

    public async Task<OperationResult<Product>> getProduct(Guid idProduct)
    {
        throw new NotImplementedException();
    }

    public async Task<OperationResult<ProductState>> getProductState(Guid idProduct, DateTime articleTime)
    {
        throw new NotImplementedException();
    }

}
