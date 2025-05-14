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

    public IActionResult Index()
    {
        var products = _context.FoodProducts
            .Include(fc=>fc.FoodCategoryId)
            .ToList();
        var categories = _context.FoodCategories.ToList();
        var model = new HomeViewModel
        {
            FoodCategories = categories,
            FoodProducts = products,
        };

        return View(model);
    }

   
}
