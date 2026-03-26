using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPIDemo.Data;
using WebAPIDemo.Models;

namespace WebAPIDemo.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class LearnerController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public LearnerController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var Mylearners = await _context.Learners.ToListAsync();
            if (!Mylearners.Any())
            {
                return NotFound("No learners where found");
            }
            return Ok(Mylearners);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var MyLearner = await _context.Learners.FindAsync(id);
            if (MyLearner == null)
            {
                return NotFound("Learner Not Found");
            }

            return Ok(MyLearner);
        }

        [HttpPost]
        public async Task<IActionResult> AddLearner(Learner learner)
        {
            learner.Id = Guid.NewGuid();
           await _context.Learners.AddAsync(learner);
            await _context.SaveChangesAsync();
            return Ok(learner);
        }

    }
}