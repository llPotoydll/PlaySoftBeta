using PlaySoftBeta.DTOs;
using PlaySoftBeta.Models;
using PlaySoftBeta.Repository;

namespace PlaySoftBeta.Services;

public class PlaylistService : IPLaylistService
{
    private readonly IPLaylistRepository _pLaylistRepository;

    public PlaylistService(IPLaylistRepository pLaylistRepository)
    {
        _pLaylistRepository = pLaylistRepository;
    }

    public void CreatePlaylist(PlaylistDTO playlist) { }
}
