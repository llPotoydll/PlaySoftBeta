using PlaySoftBeta.Models;
using PlaySoftBeta.DTOs;

namespace PlaySoftBeta.Services;

public interface IPLaylistService
{
    public bool CreatePlaylist(PlaylistDTO playlist);

    public bool DeletePlaylist(int playlistID);
    public bool EditPLaylist(EditPLaylistDTO editPLaylistDTO);

    public List<PlaylistDTO> GetOwnPlaylist(int userUKID);

    public List<SongIdListDTO> GetSongsId(int playlistID);
}
