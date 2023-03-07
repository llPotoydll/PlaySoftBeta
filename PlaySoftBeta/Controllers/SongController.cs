using PlaySoftBeta.DTOs;
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
    public async Task<ActionResult> GetSong(int songID)
    {
        _songService.GetSong(songID);
        return Ok();
    }

    [HttpPost("addSong")]
    public async Task<ActionResult> AddSongToPlaylist(PlaylistLinesDTO playlistLinesDTO)
    {
        _songService.AddSongToPlaylist(playlistLinesDTO);
        return Ok();
    }
}