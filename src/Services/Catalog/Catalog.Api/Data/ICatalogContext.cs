using Catalog.Api.Entities;
using MongoDB.Driver;

namespace Catalog.Api.Data
{
    public class ICatalogContext
    {
     public    IMongoCollection<Product> Products { get; }

    }
}
