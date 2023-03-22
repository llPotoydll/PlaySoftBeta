using PlaySoftBeta.DTOs;

namespace PlaySoftBeta.Services;

public interface IUserService
{
    public List<UserDTO> getUsers(string username);
    public List<PlaylistDTO> getPlaylists(int ukid);
}