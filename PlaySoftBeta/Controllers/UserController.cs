using PlaySoftBeta.Models;
using PlaySoftBeta.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace PlaySoftBeta.Controllers;


[Route("[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly RepositoryContext _context;
    public UserController(RepositoryContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<User>>> getUsers()
    {
        if (_context.Users == null)
        {
            return NotFound();
        }
        return await _context.Users.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<User>> getUser(int id)
    {
        {
            // var user = UserService.Get(id);

            // if (user == null)
            //     return NotFound();

            // return user;

            if (_context.Users == null)
            {
                return NotFound();
            }
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

      /*  [HttpPost]
        public IActionResult Create(User user)
        {
            UserService.Add(user);
            return CreatedAtAction(nameof(Get), new { id = user.userID }, user);
        }


        [HttpPut("{id}")]
        public IActionResult Update(int id, User user)
        {
            if (id != user.userID)
                return BadRequest();

            var existingUser = UserService.Get(id);
            if (existingUser is null)
                return NotFound();

            UserService.Update(user);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var user = UserService.Get(id);

            if (user is null)
                return NotFound();

            UserService.Delete(id);

            return NoContent();
        }
        */
    }
}