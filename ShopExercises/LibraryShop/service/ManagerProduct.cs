using DBShop;
using LibraryShop.businessModel;
using LibraryShop.mapper;

namespace LibraryShop;

public class ManagerProduct : IManagerProduct
{
    private IDBShopContext db;

    public ManagerProduct(IDBShopContext db)
    {
        this.db = db;
    }

    public async Task<OperationResult<Guid>> createProduct(ProductState ps)
    {
        var result = new OperationResult<Guid>();

        try
        {
            var p = new Product(ps);
            var ph = new ProductHistory(p);

            await this.db.createProductHistory(ph.toDTO());

            result.Result = p.Id;
            result.ReturnCode = ReturnCode.Success;
        }
        catch (Exception ex)
        {
            result.Exception = ex;
            result.MessageError = ex.Message;
            result.ReturnCode = ReturnCode.DBError;
        }

        return result;
    }

    public async Task<OperationResult<Boolean>> insertProductState(Guid idProduct, ProductState ps)
    {
        var result = new OperationResult<Boolean>();

        try
        {
            await this.db.insertProductState(idProduct, ps.toDTO());
            result.Result = true;
            result.ReturnCode = ReturnCode.Success;
        }
        catch (Exception ex)
        {
            result.Exception = ex;
            result.MessageError = ex.Message;
            result.ReturnCode = ReturnCode.DBError;
        }

        return result;
    }

    public async Task<OperationResult<ProductHistory>> getProductHistory(Guid idProduct)
    {
        var result = new OperationResult<ProductHistory>();

        try
        {
            var psDTO = await this.db.getProductHistory(idProduct);
            result.Result = psDTO.toModel();
            result.ReturnCode = ReturnCode.Success;
        }
        catch (Exception ex)
        {
            result.Exception = ex;
            result.MessageError = ex.Message;
            result.ReturnCode = ReturnCode.DBError;
        }

        return result;
    }

    public async Task<OperationResult<ProductState>> getProductState(Guid idProduct, DateTime articleTime)
    {
        var result = new OperationResult<ProductState>();

        try
        {
            var psDTO = await this.db.getProductState(idProduct, articleTime);
            result.Result = psDTO.toModel();
            result.ReturnCode = ReturnCode.Success;
        }
        catch (Exception ex)
        {
            result.Exception = ex;
            result.MessageError = ex.Message;
            result.ReturnCode = ReturnCode.DBError;
        }

        return result;
    }
}
