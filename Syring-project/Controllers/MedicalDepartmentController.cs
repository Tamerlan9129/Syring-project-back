using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Syring_project.DAL;
using Syring_project.Models;
using Syring_project.ViewModels.MedicalDepartment;

namespace Syring_project.Controllers
{
    public class MedicalDepartmentController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public MedicalDepartmentController(AppDbContext appDbContext )
        {
            _appDbContext = appDbContext;
        }
        public async Task< IActionResult> Index()
        {
            var model = new MedicalDepartmentIndexViewModel
            {
                DepartmentComponents= await _appDbContext.DepartmentComponents.ToListAsync()
            };
            return View(model);
        }
    }
}
