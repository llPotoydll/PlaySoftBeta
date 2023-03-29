using PlaySoftBeta.DTOs;
using PlaySoftBeta.Models;
using PlaySoftBeta.Repository;
using PlaySoftBeta.Log;

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
            LogErrors.Log(e);
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
        catch (Exception e)
        {
            LogErrors.Log(e);
            return false;
        }
    }

    public bool EditPLaylist(EditPLaylistDTO editPLaylistDTO)
    {
        try
        {
            _pLaylistRepository.EditPLaylist(editPLaylistDTO);
            return true;
        }
        catch (Exception e)
        {
            LogErrors.Log(e);
            return false;
        }
    }

   /* public List<PlaylistDTO> GetOwnPlaylist(int userUKID)
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
            LogErrors.Log(e);
            return null;
        }
    }
    */
    public List<SongIDSongOutDTO> GetSongsId(int playlistID, string orderKey)
    {
        try
        {
            if (playlistID != null)
            {
                return _playlistLinesRepository.GetSongsId(playlistID, orderKey);
            }
            return null;
        }
        catch (Exception e)
        {
            LogErrors.Log(e);
            return null;
        }
    }
}
