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
        var song = _songService.GetSong(songID);
        if (song != null)
        {
            return Ok(song);
        }
        else
        {
            return BadRequest("Not found");
        }

    }

    [HttpGet("search/{songName}")]
    public async Task<ActionResult> GetSongByName(string songName)
    {
        var songList = _songService.GetSongByName(songName);
        if (songList != null)
        {
            return Ok(songList);
        }
        else
        {
            return BadRequest("Not found");
        }
    }

    [HttpPost("addSong")]
    public async Task<ActionResult> AddSongToPlaylist(PlaylistLinesDTO playlistLinesDTO)
    {
        _songService.AddSongToPlaylist(playlistLinesDTO);
        return Ok();
    }
}