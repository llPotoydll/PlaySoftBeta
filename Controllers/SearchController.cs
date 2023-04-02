using PlaySoftBeta.DTOs;
using PlaySoftBeta.Models;
using PlaySoftBeta.Services;
using Microsoft.AspNetCore.Mvc;

namespace PlaySoftBeta.Controllers;

[Route("[controller]")]
[ApiController]
public class SearchController : ControllerBase
{

    private readonly ISearchService _searchService;

    public SearchController( ISearchService serarchService)
    {
        _searchService = serarchService;
    }


    [HttpGet("{name}")]
    public async Task<ActionResult> GetSongByName(string name)
    {
        var song = _searchService.SearchByName(name);
        if (song != null)
        {
            return Ok(song);
        }
        else
        {
            return BadRequest("Not found");
        }
    }

}
