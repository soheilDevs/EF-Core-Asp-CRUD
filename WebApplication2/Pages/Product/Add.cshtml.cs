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
    public class AddModel : PageModel
    {
        private ApplicationContext _context;

        public AddModel(ApplicationContext context)
        {
            _context = context;
        }


        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            var product = new DomainLayer.Product()
            {
                ProductName = ProductName,
                Description = Description,
                ImageName = ImageName
            };
            _context.Products.Add(product);
            _context.SaveChanges();

            return RedirectToPage("index");
        }
    }
}
