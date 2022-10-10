using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Syring_project.DAL;
using Syring_project.ViewModels.Sidebar;

namespace Syring_project.Controllers
{
    public class SidebarController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public SidebarController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IActionResult> Index()
        {
            var categories = await _appDbContext.Categories.Include(c => c.CategoryComponents).ToListAsync();
            var model = new SidebarIndexViewModel
            {
                Categories =categories

             
            };
            return View(model);
        }
    }
}
