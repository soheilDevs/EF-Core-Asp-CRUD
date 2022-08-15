using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages.Product
{
    public class IndexModel : PageModel
    {
        private ApplicationContext _context;

        public IndexModel(ApplicationContext context)
        {
            _context = context;
        }

        public List<DomainLayer.Product> Products { get; set; }
        public void OnGet()
        {
            Products = _context.Products.OrderByDescending(d => d.Id).ToList();
        }

        public IActionResult OnPost(int id)
        {
            var product = _context.Products.FirstOrDefault(f => f.Id == id);
            if (product==null)
            {
                return RedirectToPage("Index");
            }

            _context.Products.Remove(product);
            _context.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
