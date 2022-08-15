using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Pages.UserProduct
{
    public class IndexModel : PageModel
    {
        private ApplicationContext _context;

        public IndexModel(ApplicationContext context)
        {
            _context = context;
        }

        public List<DomainLayer.UserProduct> UserProducts { get; set; }
        public void OnGet()
        {
            UserProducts = _context.UserProducts
                .Include(c=>c.Product)
                .Include(c=>c.User)
                .OrderByDescending(d => d.Id).ToList();
        }

        public IActionResult OnPost(int id)
        {
            var entity = _context.UserProducts.FirstOrDefault(i => i.Id == id);
            if (entity==null)
            {
                return RedirectToPage("Index");
            }

            _context.Remove(entity);
            _context.SaveChanges();

            return RedirectToPage("Index");
        }
    }
}
