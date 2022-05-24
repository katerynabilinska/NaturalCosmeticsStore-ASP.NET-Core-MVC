namespace NaturalCosmeticsStore.Models
{
    public interface IProductRepository
    {
        public List<Product> Products { get; set; }
        public void SaveProduct(Product other);
        public void DeleteProduct(int id);
    }
    public class ProductRepository : IProductRepository
    {
        public List<Product> Products { get; set; }

        public ProductRepository()
        {
            Products = new List<Product>() 
            {
                new Product(){Id = 1, Name="Lipstick", Description="Pellentesque ut varius sem. Aenean imperdiet vehicula purus, ac posuere lectus hendrerit egestas. ",
                              Price=15},
                new Product(){Id = 2, Name="Shadows", Description="Pellentesque ut varius sem. Aenean imperdiet vehicula purus, ac posuere lectus hendrerit egestas. ",
                              Price=23},
                new Product(){Id = 3, Name="Brush", Description="Pellentesque ut varius sem. Aenean imperdiet vehicula purus, ac posuere lectus hendrerit egestas. ",
                              Price=72},
                new Product(){Id = 4, Name="Toner", Description="Pellentesque ut varius sem. Aenean imperdiet vehicula purus, ac posuere lectus hendrerit egestas. ",
                              Price=50},
                new Product(){Id = 5, Name="Lipstick", Description="Pellentesque ut varius sem. Aenean imperdiet vehicula purus, ac posuere lectus hendrerit egestas. ",
                              Price=15},
                new Product(){Id = 6, Name="Shadows", Description="Pellentesque ut varius sem. Aenean imperdiet vehicula purus, ac posuere lectus hendrerit egestas. ",
                              Price=23},
                new Product(){Id = 7, Name="Brush", Description="Pellentesque ut varius sem. Aenean imperdiet vehicula purus, ac posuere lectus hendrerit egestas. ",
                              Price=72},
                new Product(){Id = 8, Name="Toner", Description="Pellentesque ut varius sem. Aenean imperdiet vehicula purus, ac posuere lectus hendrerit egestas. ",
                              Price=50}
            };
        }
        public void SaveProduct(Product other)
        {                      
            if (other.Id == 0)
            {
                other.Id = Products.Count() + 1;
                Products.Add(other);
            }
            else
            {
                Product product = Products.FirstOrDefault(p => p.Id == other.Id);
                product.Name = other.Name;
                product.Description = other.Description;
                product.Price = other.Price;
            }
            
        }
        public void DeleteProduct(int id)
        {
            Product product = Products.FirstOrDefault(p => p.Id == id);
            Products.Remove(product);
        }
    }
}
