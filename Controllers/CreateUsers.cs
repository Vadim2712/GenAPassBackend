using GenAPassBackend.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace GenAPassBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CreateUsers : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CreateUsers(ApplicationDbContext context)
        {
            _context = context;
        }

        // POST: api/User
        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = new User
            {
                Email = request.Email,
                IconUrl = request.IconUrl,
                Hash = request.Hash,
                CreatedAt = DateTime.UtcNow,
                IsActive = request.IsActive
            };

            try
            {
                _context.User.Add(user);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "An error occurred while creating the user.", Error = ex.Message });
            }
        }

        // GET: api/User/{id} (для возврата созданного пользователя)
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _context.User.FindAsync(id);

            if (user == null)
            {
                return NotFound(new { Message = "User not found" });
            }

            return Ok(user);
        }
    }
}
