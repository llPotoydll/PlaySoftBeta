using PlaySoftBeta.Models;
using PlaySoftBeta.DTOs;

namespace PlaySoftBeta.Repository;

public interface IPLaylistRepository
{
    bool CreatePlaylist (PlaylistDTO playlist);
    bool DeletePlaylist (PlaylistDTO playlist);
    void Save();
}
