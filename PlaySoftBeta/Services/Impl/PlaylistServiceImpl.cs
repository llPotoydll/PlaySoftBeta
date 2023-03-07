using PlaySoftBeta.DTOs;
using PlaySoftBeta.Models;
using PlaySoftBeta.Repository;

namespace PlaySoftBeta.Services;

public class PlaylistService : IPLaylistService
{
    private readonly IPlaylistLinesRepository _playlistLinesRepository;
    private readonly IPLaylistRepository _pLaylistRepository;

    public PlaylistService(
        IPLaylistRepository pLaylistRepository,
        IPlaylistLinesRepository playlistLinesRepository
    )
    {
        _playlistLinesRepository = playlistLinesRepository;
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

    public bool DeletePlaylist(int playlistID)
    {
        try
        {
            _pLaylistRepository.DeletePlaylist(playlistID);
            _pLaylistRepository.Save();
            return true;
        }
        catch (Exception e) {
            return false;
         }
    }

    public List<PlaylistDTO> GetOwnPlaylist(int userUKID)
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

    public List<int> GetSongsId(int playlistID)
    {
        try
        {
            if (playlistID != null)
            {
                return _playlistLinesRepository.GetSongsId(playlistID);
            }
            return null;
        }
        catch (Exception e)
        {
            return null;
        }
    }
}
