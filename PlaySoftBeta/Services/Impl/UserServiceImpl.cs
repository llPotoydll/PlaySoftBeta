using PlaySoftBeta.Models;
using PlaySoftBeta.Repository;
using PlaySoftBeta.DTOs;

namespace PlaySoftBeta.Services;

public class UserServiceImpl : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserServiceImpl(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public List<UserDTO> getUsers(string username)
    {
        return _userRepository.getUserListByUsername(username);
    }
}
