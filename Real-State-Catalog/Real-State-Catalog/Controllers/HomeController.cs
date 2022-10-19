using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Real_State_Catalog.Data;
using Real_State_Catalog.Models;
using System.Diagnostics;

namespace Real_State_Catalog.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppContextDB _context;

        public HomeController(AppContextDB context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var appContextDB = _context.Offers
                .Include(o => o.Accommodation)
                .Include(o => o.Accommodation.Address)
                .Include(o => o.Accommodation.User)
                .Include(o => o.Accommodation.Pictures);

            return View(await appContextDB.ToListAsync());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}