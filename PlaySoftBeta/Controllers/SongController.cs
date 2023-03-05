using PlaySoftBeta.Models;
using PlaySoftBeta.Services;
using Microsoft.AspNetCore.Mvc;

namespace PlaySoftBeta.Controllers;

[ApiController]
[Route("[controller]")]
public class SongController : ControllerBase
{
    private readonly ISongService _songService;
    public SongController(ISongService songService)
    {
        _songService = songService;
    }


    [HttpGet("{songID}")]
    public async Task<ActionResult> GetUser(int songID)
    {
        _songService.getSong(songID);
       return Ok();
    }
}