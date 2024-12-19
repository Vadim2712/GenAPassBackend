using GenAPassBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GenAPassBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InfUser : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public InfUser(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/User/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _context.User
                .Include(u => u.UserServices)
                .FirstOrDefaultAsync(u => u.Id == id);

            if (user == null)
            {
                return NotFound(new { Message = "User not found" });
            }

            return Ok(user);
        }

        // GET: api/User
        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _context.User
                .Include(u => u.UserServices)
                .ToListAsync();

            return Ok(users);
        }
    }
}
