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
        var p = new ProductHistory();
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
        var p = new ProductHistory();
        var sd = new DateTime(2022, 01, 15);
        var ed = new DateTime(2022, 01, 20);

        var errord = new DateTime(2022, 02, 23);
        //TODO insert product and productstate to low level

        var mp = new ManagerProduct();


        //act
        var ps = mp.getProductState(p.Id, errord);


        //assert
        Assert.Null(ps.Result);
    }

    /// <summary>
    /// if not find product return null
    /// </summary>
    [Fact]
    public void getProductState_ProductNotExistReturnNULL()
    {
        //setup
        var p = new ProductHistory();

        var mp = new ManagerProduct();

        //act
        var ps = mp.getProductState(p.Id, new DateTime());

        //assert
        Assert.Null(ps.Result);
    }

    /// <summary>
    /// if there are backend problem for get date return OperationResult with exception
    /// </summary>
    [Fact]
    public void getProductState_BackendException()
    {
        //setup
        var p = new ProductHistory();

        var mp = new ManagerProduct();

        //act
        var ps = mp.getProductState(p.Id, new DateTime());

        //assert
        Assert.NotNull(ps.Exception);
    }



    /// <summary>
    /// try to return product with list of ProductState
    /// </summary>
    [Fact]
    public void getProduct()
    {
        //TODO
    }

    /// <summary>
    /// if not find product return null
    /// </summary>
    [Fact]
    public void getProduct_ProductNotFindReturnNull()
    {
        //TODO
    }

    /// <summary>
    /// if there are some backend error OperationResult retun exception
    /// </summary>
    [Fact]
    public void getProduct_BackendException()
    {
        //TODO
    }
}
