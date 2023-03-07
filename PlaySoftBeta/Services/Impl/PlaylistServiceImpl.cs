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
    public bool CreatePlaylist(PlaylistDTO playlist)
    {
        try
        {
            _pLaylistRepository.CreatePlaylist(playlist);
            _pLaylistRepository.Save();
            return true;
        }
        catch (Exception e)
        {
            return false;
        }

    }

    public bool DeletePlaylist(PlaylistDTO playlist)
    {
        return true;
    }

    public List<PlaylistDTO> getOwnPlaylist(int userUKID)
    {
        try
        {
            if (userUKID != null && userUKID > -1)
            {
                return _pLaylistRepository.getOwnPlaylist(userUKID);
            }
            return null;
        }
        catch (Exception e)
        {
            e.GetHashCode();
            return null;
        }
    }

}
