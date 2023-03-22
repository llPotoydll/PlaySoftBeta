using PlaySoftBeta.Models;
using PlaySoftBeta.DTOs;

namespace PlaySoftBeta.Repository;

    public interface IUserRepository
    {
        List<UserDTO> getUserListByUsername(string username);
        List<PlaylistDTO> getUserPlaylists(int ukid);
        void Save();
    }
