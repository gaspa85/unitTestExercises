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
        //var p = new Product();
        //var m = new ManagerProduct();
        //
        ////act
        //m.insertProduct(p);

        //verify / assert
    }

    /// <summary>
    /// possible to insert product without expire date
    /// </summary>
    [Fact]
    public void InsertNewProduct_ExpireDateOptional()
    {
        //TODO 
    }

    /// <summary>
    /// not possible to insert article with rage date equals of precedent insert
    /// </summary>
    [Fact]
    public void InsertNewProduct_RangeDateEquals()
    {
        //TODO 
    }

    /// <summary>
    /// not possible to insert article with rage date inside of precedent insert
    /// </summary>
    [Fact]
    public void InsertNewProduct_RangeDateInside()
    {
        //TODO 
    }

    /// <summary>
    /// not possible to insert article with rage date minus of precedent insert
    /// </summary>
    [Fact]
    public void InsertNewProduct_RangeDateMinus()
    {
        //TODO 
    }
}
