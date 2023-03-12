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

    [HttpDelete("delete")]
    public async Task<ActionResult> DeletePlaylist(int pLaylistID)
    {
        if (_pLaylistService.DeletePlaylist(pLaylistID))
        {
            return Ok("Deleted");
        }
        return BadRequest("Playlist not found");
    }

    [HttpPut("EditPlaylist")]
    public async Task<ActionResult> EditPLaylist(EditPLaylistDTO editPLaylistDTO)
    {
      if (_pLaylistService.EditPLaylist(editPLaylistDTO))
        {
            return Ok("Playlist Updated");
        }
        return BadRequest("Error updating playlist");
    }

    [HttpGet("{userUKID}")]
    public async Task<ActionResult> GetOwnPlaylist(int userUKID)
    {
        var playlists = _pLaylistService.GetOwnPlaylist(userUKID);

        if (playlists != null && playlists.Any())
        {
            return Ok(playlists);
        }
        else
        {
            return Ok("You don't have playlists yet");
        }
    }

    [HttpGet("songs/{playlistID}")]
    public async Task<ActionResult> GetSongsId(int playlistID)
    {
        var songsID = _pLaylistService.GetSongsId(playlistID);

        if (songsID != null && songsID.Any())
        {
            return Ok(songsID);
        }
        else
        {
            return Ok("You don't have songs yet");
        }
    }
}
