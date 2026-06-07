namespace WebApplicationGIS46.Models
{
    public class ProductsBL
    {
        List<Products> products;
        public ProductsBL()
        {
            products = new List<Products>()
            {
                new Products(){id = 1, description = "men red shirt clothes", productName = "man T-shirt", price = 599 , imageURL = "man.jpeg"  },
                new Products(){id = 2, description = "women white shirt clothes", productName = "woman T-shirt", price = 599 , imageURL = "child.jpeg"  },
                new Products(){id = 3, description = "children purble shirt clothes", productName = "children T-shirt", price = 599 , imageURL = "child.jpeg"  },
                new Products(){id = 4, description = "uni-sex shirt clothes", productName = "uni-sex T-shirt", price = 599 , imageURL = "uni.jpeg"  },
                new Products(){id = 5, description = "black shoes", productName = "shoes", price = 599 , imageURL = "shoes.jpeg"  }
            };
        }

        public List<Products> GetAll()
        {
            return products;
        }
        public Products GetProductbyId(int id)
        {
            return products.FirstOrDefault(p => p.id == id);
        }
    }
}
