namespace NaturalCosmeticsStore.Models
{
    public interface IProductRepository
    {
        public IEnumerable<Product> Products { get; }
        public void SaveProduct(Product other);
        public void DeleteProduct(int id);
    }
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<Product> Products => context.Products;
        private DataContext context;
        public ProductRepository(DataContext context) => this.context = context;

        public void SaveProduct(Product other)
        {                      
            if (other.Id == 0)
            {
                context.Products.Add(other);
            }
            else
            {
                Product product = context.Products.FirstOrDefault(p => p.Id == other.Id);
                product.Name = other.Name;
                product.Description = other.Description;
                product.Price = other.Price;                
            }
            context.SaveChanges();
        }
        public void DeleteProduct(int id)
        {
            Product product = Products.FirstOrDefault(p => p.Id == id);
            context.Products.Remove(product);
            context.SaveChanges();
        }
    }
}
