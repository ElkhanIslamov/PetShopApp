using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetShopApp.DataContext;
using PetShopApp.ViewModels;

namespace PetShopApp.Controllers
{
    public class CartItemController : Controller
    {
        private readonly AppDbContext _context;

        public CartItemController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var products =await _context.Products.ToListAsync();
            var cartItems = await _context.CartItems.ToListAsync();
            var model = new CartItemViewModel
            {
                Products = products,
                CartItems = cartItems,
            };
            return View(model);
        }
    }
}
