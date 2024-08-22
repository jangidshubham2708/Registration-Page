using Microsoft.AspNetCore.Mvc;
using StudentRepo.Data;
using StudentRepo.Models;
using StudentRepo.Models.Entities;

namespace StudentRepo.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ApplicationDbContext dbcontext;
        public StudentsController(ApplicationDbContext _dbContext)
        {
            DbContext = _dbContext;
        }

        public ApplicationDbContext DbContext { get; }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddStudentViewModel viewModel)
        {
            var student = new Student
            {
                Name = viewModel.Name,
                Email = viewModel.Email,
                Phone = viewModel.Phone,
                Subscribed = viewModel.Subscribed
            };
            await DbContext.Students.AddAsync(student);
          await DbContext.SaveChangesAsync();

            return View();
        }
    }
}
