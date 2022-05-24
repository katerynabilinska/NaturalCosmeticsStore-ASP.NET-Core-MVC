using Xunit;
using System.Linq;
using NaturalCosmeticsStore.Models;
namespace NaturalCosmeticsStore.Tests
{
    public class ProductRepositoryTests
    {
        [Fact]
        public void TestingAddProductFunction()
        {
            IProductRepository repository = new ProductRepository();
            int length = repository.Products.Count();
            Product product = new Product() { Name="Test"};

            repository.SaveProduct(product);

            Assert.Equal(length + 1, repository.Products.Count());
            Assert.Equal(product, repository.Products.First(p => p.Id == product.Id));
        }

        [Fact]
        public void TestingUpdateProductFunction()
        {
            IProductRepository repository = new ProductRepository();
            Product product = new Product() { Id = 8, Name = "Test" };

            repository.SaveProduct(product);
            Assert.Equal(product.Name, 
                repository.Products.First(p => p.Id == product.Id).Name);
        }

        [Fact]
        public void TestingDeleteProductFunction()
        {
            IProductRepository repository = new ProductRepository();
            int length = repository.Products.Count();

            repository.DeleteProduct(7);

            Assert.Equal(length - 1, repository.Products.Count());
        }
    }
}