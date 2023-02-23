using PlaySoftBeta.Models;
using PlaySoftBeta.DTOs;

namespace PlaySoftBeta.Services;

public interface IAuthService
{
    public AuthLoginOutDTO login(AuthLoginInDTO user);
    public void register(AuhtRegisterUserDTO user);
}