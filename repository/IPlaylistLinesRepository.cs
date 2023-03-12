using PlaySoftBeta.Models;
using PlaySoftBeta.DTOs;

namespace PlaySoftBeta.Repository;

public interface IPlaylistLinesRepository
{
    void AddSong(PlaylistLinesDTO playlistLinesDTO);
    List<SongIdListDTO> GetSongsId(int playlistID);
    void Save();
}
