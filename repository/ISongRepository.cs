using PlaySoftBeta.Models;
using PlaySoftBeta.DTOs;

namespace PlaySoftBeta.Repository;

public interface ISongRepository
{
    SongDTO getSong(int songID);
    SongDTO getSongByName(string songName);
 }
