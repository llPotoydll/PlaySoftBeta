using PlaySoftBeta.Models;
using PlaySoftBeta.DTOs;

namespace PlaySoftBeta.Services;

public interface IPLaylistService
{
    public void CreatePlaylist(PlaylistDTO playlist);

}