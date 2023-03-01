using PlaySoftBeta.Models;
using PlaySoftBeta.DTOs;

namespace PlaySoftBeta.Services;

public interface IPLaylistService
{
    public bool CreatePlaylist(PlaylistDTO playlist);

    public bool DeletePlaylist(PlaylistDTO playlist);

    public Playlist getOwnPlaylist(int userUKID);

}