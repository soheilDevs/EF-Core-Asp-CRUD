using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages.Product
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private ApplicationContext _context;

        public EditModel(ApplicationContext context)
        {
            _context = context;
        }


        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }
        public IActionResult OnGet(int id)
        {
            var product = _context.Products.FirstOrDefault(f=>f.Id==id);
            if (product==null)
            {
                RedirectToPage("Index");
            }

            ProductName = product.ProductName;
            Description = product.Description;
            ImageName = product.ImageName;


            return Page();
        }

        public IActionResult OnPost(int id)
        {
            var product = _context.Products.First(f => f.Id == id);

            product.Description = Description;
            product.ImageName = ImageName;
            product.ProductName = ProductName;
            _context.Products.Update(product);
            _context.SaveChanges();

            return RedirectToPage("index");
        }

    }
}
