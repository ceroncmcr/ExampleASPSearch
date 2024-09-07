using Example.Models;
using Example.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Example.Controllers
{
    public class ProductController : Controller
    {
        private ProductRepository _repository = new ProductRepository();
        // GET: Product
        public ActionResult Index(string search)
        {
            var products = new List<Product>();
            if (String.IsNullOrEmpty(search))
            {
                products = _repository.ObtenerProductos();
            }
            else {
                products = _repository.SearchProduct(search);
            }
            
            return View(products);
        }
    }
}