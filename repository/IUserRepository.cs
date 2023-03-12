using PlaySoftBeta.Models;
using PlaySoftBeta.DTOs;

namespace PlaySoftBeta.Repository;

    public interface IUserRepository
    {
        List<UserDTO> getUserListByUsername(string username);
        void Save();
    }
