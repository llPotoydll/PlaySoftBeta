using PlaySoftBeta.Models;
using PlaySoftBeta.Services;
using Microsoft.AspNetCore.Mvc;

namespace PlaySoftBeta.Controllers;

[ApiController]
[Route("[controller]")]
public class PlayListController : ControllerBase
{
    public PlaylistController()
    {
    }

    [HttpGet]
    public ActionResult<List<Playlist>> GetAll() =>
    PlaylistService.GetAll();

    [HttpGet("{id}")]
    public ActionResult<Playlist> Get(int id)
    {
        var playlilst = PlaylistService.Get(id);

        if (playlist == null)
            return NotFound();

        return playlilst;
    }
    
    [HttpPost]
    public IActionResult Create(PLaylist pLaylist)
    {
        PlaylistService.Add(pLaylist);
        return CreatedAtAction(nameof(Get), new { id = pLaylist.playlistID }, pLaylist);
    }
    

[HttpPut("{id}")]
public IActionResult Update(int id, Playlist playlist)
{
    if (id != playlist.playlistID)
        return BadRequest();
           
    var existingPlaylist = PlaylistService.Get(id);
    if(existingPlaylist is null)
        return NotFound();
   
    PlaylistService.Update(playlist);           
   
    return NoContent();
}

[HttpDelete("{id}")]
public IActionResult Delete(int id)
{
    var playlist = PlaylistService.Get(id);
   
    if (playlist is null)
        return NotFound();
       
    PlaylistService.Delete(id);
   
    return NoContent();
}
}