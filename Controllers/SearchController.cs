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
    public async Task<ActionResult> SearchSongsAndUsers(string name)
    {
        var songsAndUsers = _searchService.SearchByName(name);
        if (songsAndUsers != null)
        {
            return Ok(songsAndUsers);
        }
        else
        {
            return BadRequest("Not found");
        }
    }

}
