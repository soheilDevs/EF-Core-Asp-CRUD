using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages.UserProduct
{
    [BindProperties]
    public class AddModel : PageModel
    {
        private ApplicationContext _context;

        public AddModel(ApplicationContext context)
        {
            _context = context;
        }

        public long UserId { get; set; }
        public long ProductId { get; set; }
        public string Color { get; set; }
        public long Price { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            var userProduct = new DomainLayer.UserProduct()
            {
                Color = Color,
                Price = Price,
                SellerId = UserId,
                ProductId = ProductId
            };
            _context.Add(userProduct);
            _context.SaveChanges();

            return RedirectToPage("Index");
        }
    }
}
