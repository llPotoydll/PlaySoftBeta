using PlaySoftBeta.Models;
using PlaySoftBeta.DTOs;
using PlaySoftBeta.Repository;

namespace PlaySoftBeta.Services;

public class SongServiceImpl : ISongService
{
    private readonly ISongRepository _songRepository;
    private readonly IPlaylistLinesRepository _playlistLinesRepository;

    public SongServiceImpl(ISongRepository songRepository,IPlaylistLinesRepository playlistLinesRepository )
    {
        _songRepository = songRepository;
        _playlistLinesRepository = playlistLinesRepository;
    }

    public void AddSongToPlaylist(PlaylistLinesDTO playlistLinesDTO)
    {   
        //comprobar que la cancion no este ya en la playlist
        _playlistLinesRepository.AddSong(playlistLinesDTO);
        _playlistLinesRepository.Save();
    }
    public SongDTO GetSong(int songID)
    {
        try
        {
            return _songRepository.getSong(songID);
        }
        catch (Exception e)
        {
            return null;
        }
    }
}