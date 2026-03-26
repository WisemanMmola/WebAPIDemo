using Microsoft.AspNetCore.Mvc;
using WebAPIDemo.Data;
using WebAPIDemo.Models;

namespace WebAPIDemo.Controllers
{
    [Route("/api/controller")]
    [ApiController]
    public class LearnerController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public LearnerController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var Mylearner = _context.learners.ToList();
            if (Mylearner is null)
            {
                return NotFound("No learners where found");
            }
            return Ok(Mylearner);
        }

        [HttpPost]
        public async Task<IActionResult> AddLearner(Learner learner)
        {
           await _context.Learners.AddAsync(learner);
            await _context.SaveChangesAsync();
            return Ok(learner);
        }

    }
}