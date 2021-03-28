using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectMongoDB
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool IsExists = productCollection.Find<Product>(p => true).Any<Product>();

            if (!IsExists)
            {
                productCollection.InsertManyAsync(GetConfiguredProducts());
            }
        }
        private static IEnumerable<Product> GetConfiguredProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                     Name = "Milton Thermosteel Flip Lid Flask",
                     Category = "Kitchen & Dining",
                     Description = "Double walled Vacuum insulated technology keeps beverages hot or cold for 24 hours, Inner copper coating for better temperature retention.",
                     Image= "product001.png", 
                     Discount="Yes",
                     Price = 10.30M                     
                },
                new Product()
                {
                     Name = "Jabra Elite Active 75t True Wireless Active Noise Cancelling (ANC) Bluetooth Earbuds",
                     Category = "Headphone",
                     Description = "Designed for secure fit and amazing durability: Ergonomic shape makes eargels exceptionally comfortable and the ideal fit for every type of ear – IP57 rating means fully waterproof and sweat proof.",
                     Image= "product002.png",
                     Discount="Yes",
                     Price = 999.00M
                },
                new Product()
                {
                     Name = "Canon EOS 1500D 24.1 Digital SLR Camera (Black) with EF S18-55 is II Lens, 16GB Card and Carry Case",
                     Category = "Camera",
                     Description = "Sensor: APS-C CMOS Sensor with 24.1 MP (high resolution for large prints and image cropping.",
                     Image= "product003.png",
                     Discount="No",
                     Price = 550.00M
                },
                new Product()
                {
                     Name = "Fitbit Charge 3 Fitness Activity Tracker",
                     Category = "Sport Gadget",
                     Description = "Better measure calorie burn, understand resting heart rate and more with 24/7 heart rate tracking.",
                     Discount="No",
                     Image= "product004.png",
                     Price = 1230.00M
                },
                new Product()
                {
                     Name = "Urban Tribe Fitpack Pro Multipurpose 15.6 Inch| Water Repellent",
                     Category = "Laptop Backpacks",
                     Description = "The Quick Access Pocket is a feature that reduces life’s niggling burdens. Stowaway the things that you will need at a moment’s notice. Your glasses, your headphones, your keys, the works.",
                     Image= "product005.png",
                     Discount="Yes",
                     Price = 130.00M
                }
            };
        }
    }
}
