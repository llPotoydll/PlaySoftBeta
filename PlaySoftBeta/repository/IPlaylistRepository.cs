using PlaySoftBeta.Models;
using PlaySoftBeta.DTOs;

namespace PlaySoftBeta.Repository;

public interface IPLaylistRepository
{
    void NewPlaylist(PlaylistDTO playlistDTO);
}
