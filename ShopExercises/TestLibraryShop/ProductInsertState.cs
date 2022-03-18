using Xunit;

namespace TestLibraryShop;

public class ProductInsertState
{
    /// <summary>
    /// not possible insert null productstate
    /// </summary>
    [Fact]
    public void InsertNewProductState_NullInsert()
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
    /// possible to insert productstate without expire date
    /// </summary>
    [Fact]
    public void InsertNewProductState_ExpireDateOptional()
    {
        //TODO 
    }

    /// <summary>
    /// not possible to insert productstate with rage date equals of precedent insert
    /// </summary>
    [Fact]
    public void InsertNewProductState_RangeDateEquals()
    {
        //TODO 
    }

    /// <summary>
    /// not possible to insert productstate with rage date inside of precedent insert
    /// </summary>
    [Fact]
    public void InsertNewProductState_RangeDateInside()
    {
        //TODO 
    }

    /// <summary>
    /// not possible to insert productstate with rage date minus of precedent insert
    /// </summary>
    [Fact]
    public void InsertNewProductState_RangeDateMinus()
    {
        //TODO 
    }

    /// <summary>
    /// not possible to insert productstate with date rage start time over end time
    /// </summary>
    [Fact]
    public void InsertNewProductState_RangeDateStartOverEnd()
    {
        //TODO 
    }
}
