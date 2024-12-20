
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GenAPassBackend.Models;

namespace GenAPassBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserServiceController
    {
        private readonly ApplicationDbContext _context;

        public UserServiceController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserService>>> GetUserServices()
        {
            return await _context.UserServices.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserService>> GetUserService(int id)
        {
            var userService = await _context.UserServices.FindAsync(id);

            return userService;
        }

        //[HttpPost]
        //public async Task<ActionResult<UserService>> CreateUserService(UserService userService)
        //{
        //    _context.UserServices.Add(userService);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction(nameof(GetUserService), new { id = userService.Id }, userService);
        //}
    }
}
