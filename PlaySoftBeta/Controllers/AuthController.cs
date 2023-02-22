using PlaySoftBeta.DTOs;
using PlaySoftBeta.Models;
using PlaySoftBeta.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace PlaySoftBeta.Controllers;

[Route("[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IAuthService authService;

    public AuthController(IAuthService authService)
    {
        this.authService = authService;
    }

    [HttpPost("login")]

    public async Task<ActionResult<User>> getUser(string email, string password)
    {
        AuthLoginOutDTO a = authService.login(email, password);
        return Ok();
    }

    [HttpPost]
    public async Task<ActionResult<User>> PostUser(String user)
    {
        authService.register(user);
        return null;
    }
}
