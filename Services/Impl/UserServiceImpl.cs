using PlaySoftBeta.Models;
using PlaySoftBeta.Repository;
using PlaySoftBeta.DTOs;

namespace PlaySoftBeta.Services;
using PlaySoftBeta.Log;
public class UserServiceImpl : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserServiceImpl(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public List<UserDTO> getUsers(string username)
    {
        try
        {
            return _userRepository.getUserListByUsername(username);
        }
        catch (Exception e)
        {
            LogErrors.Log(e);
            return null;
        }
    }
}
