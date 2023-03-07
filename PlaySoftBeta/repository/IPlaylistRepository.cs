using PlaySoftBeta.Models;
using PlaySoftBeta.DTOs;

namespace PlaySoftBeta.Repository;

public interface IPLaylistRepository
{
    void CreatePlaylist (PlaylistDTO playlist);
    bool DeletePlaylist (PlaylistDTO playlist);
    List<PlaylistDTO> getOwnPlaylist(int userUKID);
    void Save();
}
