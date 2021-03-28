using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectMongoDB
{
    public class ProductCollection
    {
        public IMongoCollection<Product> Products { get; }

        public ProductCollection()
        {
            var client = new MongoClient("mongodb://127.0.0.1:27017");
            var database = client.GetDatabase("GeeksArrayStore");
            Products = database.GetCollection<Product>("Products");

            List<Product> list = Products.Find<Product>
                    (p => true).ToList<Product>();

            foreach(Product product in list)
            {
                Console.WriteLine($"ProductID: {product.Id} - Product Name: {product.Name}" );
            }
        }
    }
}
