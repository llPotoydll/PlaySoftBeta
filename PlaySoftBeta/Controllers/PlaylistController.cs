using PlaySoftBeta.Models;
using PlaySoftBeta.DTOs;
using PlaySoftBeta.Services;
using Microsoft.AspNetCore.Mvc;

namespace PlaySoftBeta.Controllers;

[ApiController]
[Route("[controller]")]
public class PlaylistController : ControllerBase
{

    private readonly IPLaylistService _pLaylistService;
    public PlaylistController(IPLaylistService pLaylistService)
    {
        _pLaylistService = pLaylistService;
    }

    [HttpPost("NewPlaylist")]
    public async Task<ActionResult> CreatePlaylist(PlaylistDTO pLaylist)
    {
        if (_pLaylistService.CreatePlaylist(pLaylist))
        {
            return Ok("Playlist created");
        }
        return BadRequest("Create playlist error");
    }
    [HttpDelete("DeletePlaylist")]
    public async Task<ActionResult> DeletePlaylist(PlaylistDTO pLaylist)
    {
        return Ok("Deleted");
    }
    
    public async Task<Playlist> getOwnPlaylist(int userUKID)
    {
        var playlists = _pLaylistService.getMyPlaylist(userUKID);
        return Ok(playlists);
    }
    
}