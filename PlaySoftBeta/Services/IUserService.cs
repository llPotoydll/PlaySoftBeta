using PlaySoftBeta.Models;

namespace PlaySoftBeta.Services;

public interface IUserService
{
    public void getUserByEmail(String email, String password);
    public void createNewUser(String user);
}