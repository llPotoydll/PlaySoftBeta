using PlaySoftBeta.Models;
using PlaySoftBeta.DTOs;

namespace PlaySoftBeta.Repository;

public interface IAuthRepositoy : IDisposable
{
    AuthLoginOutDTO GetUserByEmail(String userEmail);
    Boolean checkEmail(String userEmail);
    void registerUser(AuhtRegisterUserDTO user);
    void Save();
}
