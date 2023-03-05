using PlaySoftBeta.Models;
using PlaySoftBeta.DTOs;
using PlaySoftBeta.Repository;

namespace PlaySoftBeta.Services;

public class SongServiceImpl : ISongService
{
    private readonly ISongRepository _songRepository;

    public SongServiceImpl(ISongRepository songRepository)
    {
        _songRepository = songRepository;
    }

    public SongDTO getSong(int songID)
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