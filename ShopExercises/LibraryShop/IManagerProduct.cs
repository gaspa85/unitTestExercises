using LibraryShop.businessModel;

namespace LibraryShop;

public interface IManagerProduct
{
    public void insertProduct(Product product);

    public Product getProductByTime(Guid idProduct, DateTime articleTime);

    public List<Product> getProductAll(Guid idProduct);
}
