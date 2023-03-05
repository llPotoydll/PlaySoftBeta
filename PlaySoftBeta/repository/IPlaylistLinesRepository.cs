using PlaySoftBeta.Models;
using PlaySoftBeta.DTOs;

namespace PlaySoftBeta.Repository;

public interface IPlaylistLinesRepository
{
    void addSong(PlaylistLinesDTO playlistLinesDTO);
}
