using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetShopApp.DataContext;
using PetShopApp.Models;
using PetShopApp.ViewModels;

namespace PetShopApp.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var products =await _context.FoodProducts.ToListAsync();
        var categories =await _context.FoodCategories.ToListAsync();
        var model = new HomeViewModel
        {
            FoodCategories = categories,
            FoodProducts = products,
        };

        return View(model);
    }

   
}
