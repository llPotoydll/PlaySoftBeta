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
    }

    [HttpPost]
    public async Task<ActionResult<User>> PostUser(User user)
    {
        _context.Users.Add(user);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(getUser), new { id = user.userID }, user);
    }


    [HttpPut("{id}")]
    public async Task<IActionResult> PutUser(int id, User user)
    {
        if (id != user.userID)
        {
            return BadRequest();
        }

        _context.Entry(user).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!UserExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }
        return NoContent();
    }

    private bool UserExists(long id)
    {
        return (_context.Users?.Any(e => e.userID == id)).GetValueOrDefault();
    }


    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteUser(int id)
    {
        if (_context.Users == null)
        {
            return NotFound();
        }
        var user = await _context.Users.FindAsync(id);
        if(user == null){
            return NotFound();
        }

        _context.Users.Remove(user);
        await _context.SaveChangesAsync();

        return NoContent();
    }

}
