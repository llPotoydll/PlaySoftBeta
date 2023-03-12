using PlaySoftBeta.Models;
using PlaySoftBeta.DTOs;
using PlaySoftBeta.Services;
using Microsoft.AspNetCore.Mvc;

namespace PlaySoftBeta.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet("{username}")]
    public ActionResult<User> Get(string username)
    {
        var userList = _userService.getUsers(username);
        if (userList.Any())
        {
            return Ok(userList);
        }
            return BadRequest("User not found");
    }
}
