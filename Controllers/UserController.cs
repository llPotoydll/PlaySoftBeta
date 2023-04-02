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

    [HttpGet("{ukid}")]
    public ActionResult<User> Get(int ukid)
    {
        var user = _userService.GetUser(ukid);
        if (user != null)
        {
            return Ok(user);
        }
        return BadRequest("User not found");
    }
/*
    [HttpGet("playlist/{ukid}")]
    public ActionResult<User> getUserPlaylists(int ukid)
    {
        var playlistList = _userService.getPlaylists(ukid);
        if (playlistList.Any())
        {
            return Ok(playlistList);
        }
        return BadRequest("User not found");
    }*/
}
