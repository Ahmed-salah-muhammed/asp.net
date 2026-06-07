using Microsoft.AspNetCore.Mvc;
using WebApplicationGIS46.Models;

namespace WebApplicationGIS46.Controllers
{
    public class productsController : Controller
    {
        ProductsBL pBL = new ProductsBL();
        public IActionResult allProducts()
        {
            List<Products> products = pBL.GetAll();
            //return View("allProducts"); 
            //view  ==> Views/Products/allProducts.cshtml
            return View("allProducts",products);
        }
        public IActionResult productId(int id)
        {
            //return View("productId"); 
            //view  ==> Views/Products/productId.cshtml
            Products product = pBL.GetProductbyId(id);
            return View("productId", product);
        }
    }
}
