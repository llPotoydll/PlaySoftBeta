using PlaySoftBeta.Models;
using PlaySoftBeta.Services;
using Microsoft.AspNetCore.Mvc;

namespace PlaySoftBeta.Controllers;

[ApiController]
[Route("[controller]")]
public class SongController : ControllerBase
{
    public SongController()
    {
    }

    [HttpGet]
    public ActionResult<List<Song>> GetAll() =>
    SongSevice.GetAll();

    [HttpGet("{id}")]
    public ActionResult<Song> Get(int id)
    {
        var song = SongSevice.Get(id);

        if (song == null)
            return NotFound();

        return song;
    }
    
    [HttpPost]
    public IActionResult Create(Song song)
    {
        SongSevice.Add(song);
        return CreatedAtAction(nameof(Get), new { id = song.songID }, song);
    }
    

[HttpPut("{id}")]
public IActionResult Update(int id, Song song)
{
    if (id != song.songID)
        return BadRequest();
           
    var existingSong = SongSevice.Get(id);
    if(existingSong is null)
        return NotFound();
   
    SongSevice.Update(song);           
   
    return NoContent();
}

[HttpDelete("{id}")]
public IActionResult Delete(int id)
{
    var song = SongSevice.Get(id);
   
    if (song is null)
        return NotFound();
       
    SongSevice.Delete(id);
   
    return NoContent();
}
}