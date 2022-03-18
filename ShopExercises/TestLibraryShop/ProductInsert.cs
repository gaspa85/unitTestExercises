using Xunit;

namespace TestLibraryShop;

public class ProductInsert
{
    /// <summary>
    /// not possible insert null product
    /// </summary>
    [Fact]
    public void InsertNewProduct_NullInsert()
    {
        //TODO 
        //setup
        var p = new Product();
        var m = new ManagerProduct();

        //act
        m.insertProduct(p);

        //verify / assert
    }
}
