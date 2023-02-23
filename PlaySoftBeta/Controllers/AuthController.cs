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

    public async Task<ActionResult<User>> getUser(AuthLoginInDTO user)
    {
        AuthLoginOutDTO a = authService.login(user);
        return null;
    }

    [HttpPost]
    public async Task<ActionResult<User>> PostUser(AuhtRegisterUserDTO user)
    {
        authService.register(user);
        return null;
    }
}
