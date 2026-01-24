using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SendLove.Data;
using SendLove.Models;
using System.Linq;

namespace SendLove.Controllers
{
    public class ProductController : Controller
    {
        private readonly SendLoveContext _context;

        // Inject database
        public ProductController(SendLoveContext context)
        {
            _context = context;
        }

        // PRODUCT LIST PAGE
        public IActionResult Index(string occasion, string gender)
        {
            ViewBag.Occasion = occasion;
            ViewBag.Gender = gender;

            // Start query from SQL Server
            var query = _context.Products.AsQueryable();

            // Filter by Occasion
            if (!string.IsNullOrEmpty(occasion))
            {
                query = query.Where(p => p.Occasion == occasion);
            }

            // Filter by Gender (Her / Him / Any)
            if (!string.IsNullOrEmpty(gender))
            {
                query = query.Where(p => p.Gender == gender || p.Gender == "Any");
            }

            // Convert ProductEntity (DB) → Product (View model)
            var products = query.Select(p => new Product
            {
                Id = p.Id,
                Name = p.Name,
                Occasion = p.Occasion,
                Section = p.Section,
                Gender = p.Gender,
                Price = p.Price,
                ImageUrl = p.ImageUrl
            }).ToList();

            return View(products);
        }
    }
}
