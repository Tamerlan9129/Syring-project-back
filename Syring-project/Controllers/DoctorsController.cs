using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Syring_project.DAL;
using Syring_project.ViewModels.Doctors;

namespace Syring_project.Controllers
{
    public class DoctorsController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public DoctorsController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task< IActionResult> Index()
        {

            var model = new DoctorsIndexViewModel
            {

                DoctorsComponents = await _appDbContext.DoctorsComponents.ToListAsync()
            };

            return View(model);
        }
    }
}
