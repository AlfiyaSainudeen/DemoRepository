using APIAssignmentOnEcomerce.Models;

namespace APIAssignmentOnEcomerce.Repository
{
    public class ProductRepository : IProductRepository
    {
        List<Product> products = new List<Product>();
        public void AddProduct(Product product)
        {
            try
            {
                
                    products.Add(product);
                
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
           
        }

     

        public void DeleteProduct(string ProductName)
        {
            try
            {
                foreach (var product in products)
                {
                    if (product.ProductName == ProductName)
                    {
                        products.Remove(product);
                        break;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Product> GetAllProduct()
        {

            try
            {
                return products;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Product> GetProductByCategory(string Category)
        {

            List<Product> pro = new List<Product>();
            try
            {
                foreach (var product in products)
                {
                    if (product.Category ==  Category)
                    {
                        pro.Add(product);
                    }
                }
                return pro;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Product> GetProductByName(string ProductName)
        {
            List<Product> pro = new List<Product>();
            try
            {
                foreach (var product in products)
                {
                    if (product.ProductName == ProductName)
                    {
                        pro.Add(product);
                    }
                }
                return pro;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateProduct(Product product)
        {                                                                                                                                                                
            try
            {
                foreach (var pro in products)
                {
                    if (pro.ProductName == product.ProductName) 
                    {
                        pro.ProductName = product.ProductName;
                        pro.Category = product.Category;
                        pro.Price = product.Price;
                        pro.Stock = product.Stock;

                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
