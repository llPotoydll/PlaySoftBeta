using PlaySoftBeta.Models;
using PlaySoftBeta.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace PlaySoftBeta.Controllers;


[Route("[controller]")]
[ApiController]
public class UserController : ControllerBase
{

    private IUserService userService;

   /* [HttpGet]
    public async Task<ActionResult<IEnumerable<User>>> getUsers()
    {
        if (_context.Users == null)
        {
            return NotFound();
        }
        return await _context.Users.ToListAsync();
    }*/

    [HttpGet("login")]
    public async Task<ActionResult<User>> getUser(string email, string password)
    {
        userService.getUserByEmail(email, password);
        return null;
    }

    [HttpPost]
    public async Task<ActionResult<User>> PostUser(String user)
    {
        userService.createNewUser(user);
        return null;
    }


    /*[HttpPut("{id}")]
    public async Task<IActionResult> PutUser(int id, User user)
    {

    }*/




   /* [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteUser(int id)
    {

    }*/
}
