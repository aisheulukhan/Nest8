using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskNest.DAL;
using TaskNest.Models;

namespace TaskNest.ViewComponents
{
    public class ProductViewComponent:ViewComponent
    {
        private AppDbContext _context { get;}
        public ProductViewComponent(AppDbContext context)
        {
            _context = context;  
        }
        public async Task<IViewComponentResult> InvokeAsync(int take = 5, int skip = 0)
        {
            List<Product> products = await _context.Products.Where(p => p.IsDeleted == false)
                                   .OrderByDescending(p => p.Id)
                                   .Skip(skip)
                                   .Take(take)
                                   .Include(p => p.ProductImages)
                                   .Include(p => p.Category).ToListAsync();
            return View(await Task.FromResult(products));
        }
    }
}
