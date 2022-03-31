using dbshop.businessModel;
using MongoDB.Driver;

namespace DBShop;

public class DBShopContext : IDBShopContext
{
    private readonly MongoClient mongoClient;
    private readonly IMongoDatabase mongoDatabase;

    private String collectionName = "ProductHistoryDTO";

    public DBShopContext(MongoClient mongoClient, IMongoDatabase mongoDatabase)
    {
        this.mongoClient = mongoClient;
        this.mongoDatabase = mongoDatabase;
        //create collection if not exist
        var collection = this.mongoDatabase.GetCollection<ProductHistoryDTO>(collectionName);
        if (collection == null)
        {
            this.mongoDatabase.CreateCollection(collectionName);
            collection = this.mongoDatabase.GetCollection<ProductHistoryDTO>(collectionName);
        }
    }



    public async Task createProductHistory(ProductHistoryDTO productHistoryDTO)
    {

        var collection = this.mongoDatabase.GetCollection<ProductHistoryDTO>(collectionName);
        await collection.InsertOneAsync(productHistoryDTO);
    }

    public async Task<ProductHistoryDTO> getProductHistory(Guid idProduct)
    {
        var collection = this.mongoDatabase.GetCollection<ProductHistoryDTO>(collectionName);
        var task = await collection.FindAsync(p => p.Product.Id == idProduct);
        return task.FirstOrDefault();
    }

    public async Task<ProductStateDTO> getProductState(Guid idProduct, DateTime articleTime)
    {
        var collection = this.mongoDatabase.GetCollection<ProductHistoryDTO>(collectionName);
        var task = await collection.FindAsync(p => p.Product.Id == idProduct);
        return task.FirstOrDefault().Product.ProductState;
    }

    public async Task insertProductState(Guid idProduct, ProductStateDTO productStateDTO)
    {
        //TODO filter between
        //var collection = this.mongoDatabase.GetCollection<ProductHistoryDTO>(collectionName);
        //var task = await collection.FindAsync(p => p.Product.Id == idProduct && p.MapProductState.);
        //return task.FirstOrDefault().Product.ProductState;
    }
}
