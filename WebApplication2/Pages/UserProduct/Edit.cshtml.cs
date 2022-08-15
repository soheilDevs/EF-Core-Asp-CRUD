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
    public class EditModel : PageModel
    {
        private ApplicationContext _context;

        public EditModel(ApplicationContext context)
        {
            _context = context;
        }

        public long UserId { get; set; }
        public long ProductId { get; set; }
        public string Color { get; set; }
        public long Price { get; set; }

        public IActionResult OnGet(int id)
        {
            var userProducts = _context.UserProducts.FirstOrDefault(u => u.Id == id);
            if (userProducts==null)
            {
                RedirectToPage("Index");
            }

            UserId = userProducts.SellerId;
            ProductId = userProducts.ProductId;
            Color= userProducts.Color;
            Price = userProducts.Price;

            return Page();
        }

        public IActionResult OnPost(int id)
        {
            var userProduct = _context.UserProducts.First(u => u.Id == id);

            userProduct.SellerId = UserId; 
            userProduct.ProductId = ProductId; 
            userProduct.Color = Color; 
            userProduct.Price = Price; 
            _context.Update(userProduct);
            _context.SaveChanges();

            return RedirectToPage("Index");
        }
    }
}
