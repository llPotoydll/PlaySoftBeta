using PlaySoftBeta.Models;
using PlaySoftBeta.DTOs;

namespace PlaySoftBeta.Services;

public interface ISongService
{
    public SongDTO GetSong(int songID);
    public SongDTO GetSongByName(string songName);
    public void AddSongToPlaylist(PlaylistLinesDTO playlistLinesDTO);
}