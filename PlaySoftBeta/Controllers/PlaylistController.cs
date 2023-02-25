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




    [HttpPost]
    public IActionResult CreatePlaylist(PlaylistDTO pLaylist)
    {
        _pLaylistService.CreatePlaylist(pLaylist);
        return null;
    }

}