namespace NaturalCosmeticsStore.Models
{
    public interface IProductRepository
    {
        public IEnumerable<Product> Products { get; set; }
    }
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<Product> Products { get; set; }

        public ProductRepository()
        {
            Products = new List<Product>() 
            {
                new Product(){Name="Lipstick", Description="Pellentesque ut varius sem. Aenean imperdiet vehicula purus, ac posuere lectus hendrerit egestas. ",
                              Price=15},
                new Product(){Name="Shadows", Description="Pellentesque ut varius sem. Aenean imperdiet vehicula purus, ac posuere lectus hendrerit egestas. ",
                              Price=23},
                new Product(){Name="Brush", Description="Pellentesque ut varius sem. Aenean imperdiet vehicula purus, ac posuere lectus hendrerit egestas. ",
                              Price=72},
                new Product(){Name="Toner", Description="Pellentesque ut varius sem. Aenean imperdiet vehicula purus, ac posuere lectus hendrerit egestas. ",
                              Price=50},
                new Product(){Name="Lipstick", Description="Pellentesque ut varius sem. Aenean imperdiet vehicula purus, ac posuere lectus hendrerit egestas. ",
                              Price=15},
                new Product(){Name="Shadows", Description="Pellentesque ut varius sem. Aenean imperdiet vehicula purus, ac posuere lectus hendrerit egestas. ",
                              Price=23},
                new Product(){Name="Brush", Description="Pellentesque ut varius sem. Aenean imperdiet vehicula purus, ac posuere lectus hendrerit egestas. ",
                              Price=72},
                new Product(){Name="Toner", Description="Pellentesque ut varius sem. Aenean imperdiet vehicula purus, ac posuere lectus hendrerit egestas. ",
                              Price=50}
            };
        }
    }
}
