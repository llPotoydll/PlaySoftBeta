using PlaySoftBeta.Models;
using PlaySoftBeta.DTOs;
using PlaySoftBeta.Repository;


namespace PlaySoftBeta.Services;

public class SongServiceImpl : ISongService
{
    private readonly IPLaylistRepository _playlistRepository;
    private readonly ISongRepository _songRepository;
    private readonly IPlaylistLinesRepository _playlistLinesRepository;
    private readonly ILogger<SongServiceImpl> _logger;

    public SongServiceImpl(ISongRepository songRepository, IPlaylistLinesRepository playlistLinesRepository, IPLaylistRepository playlistRepository, ILogger<SongServiceImpl> logger)
    {
        _songRepository = songRepository;
        _playlistLinesRepository = playlistLinesRepository;
        _playlistRepository = playlistRepository;
        _logger = logger;
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
            return _songRepository.GetSong(songID);
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Error get song");
            throw;
        }
    }
}