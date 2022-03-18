using Xunit;

namespace TestLibraryShop;

public class ProductInsert_Discount
{
    /// <summary>
    /// discount is optional, possible to insert product without discount
    /// </summary>
    [Fact]
    public void InsertNewProduct_NODiscount()
    {
        //TODO
    }

    /// <summary>
    /// product with discount MUST have rande date
    /// </summary>
    [Fact]
    public void InsertNewProduct_DiscountNORangeDate()
    {
        //TODO 
    }
}
