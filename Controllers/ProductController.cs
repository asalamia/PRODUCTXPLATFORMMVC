using Microsoft.AspNetCore.Mvc;
using PRODUCTXPLATFORMMVC.Data;
using PRODUCTXPLATFORMMVC.Models;

namespace PRODUCTXPLATFORMMVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDBContext _db;

        public ProductController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<ProductList> objProductList = _db.Products.ToList();
            return View(objProductList);
        }
    }
}
