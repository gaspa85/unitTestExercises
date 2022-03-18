using LibraryShop;
using LibraryShop.businessModel;
using System;
using Xunit;

namespace TestLibraryShop;

public class ProductGet
{
    /// <summary>
    /// try to return product for specific time
    /// </summary>
    [Fact]
    public void getProductState()
    {
        //setup
        var p = new Product();
        var sd = new DateTime(2022, 01, 15);
        var ed = new DateTime(2022, 01, 20);
        //TODO insert product and productstate to low level

        var mp = new ManagerProduct();


        //act
        var ps = mp.getProductState(p.Id, sd);


        //assert

    }

    /// <summary>
    /// if not find product state for particolar date return null
    /// </summary>
    [Fact]
    public void getProductState_NoFindReturnNULL()
    {
        //setup
        var p = new Product();
        var sd = new DateTime(2022, 01, 15);
        var ed = new DateTime(2022, 01, 20);

        var errord = new DateTime(2022, 02, 23);
        //TODO insert product and productstate to low level

        var mp = new ManagerProduct();


        //act
        var ps = mp.getProductState(p.Id, errord);


        //assert
        Assert.Null(ps);
    }

    /// <summary>
    /// if not find product not exist return null
    /// </summary>
    [Fact]
    public void getProductState_ProductNotExistReturnNULL()
    {
        //setup
        var p = new Product();

        var mp = new ManagerProduct();

        //act
        var ps = mp.getProductState(p.Id, new DateTime());

        //assert
        Assert.Null(ps);
    }



    /// <summary>
    /// try to return list of product for specific
    /// </summary>
    [Fact]
    public void getProduct()
    {
        //TODO
    }
}
