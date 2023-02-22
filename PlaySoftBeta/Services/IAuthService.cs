using PlaySoftBeta.Models;
using PlaySoftBeta.DTOs;

namespace PlaySoftBeta.Services;

public interface IAuthService
{
    public AuthLoginOutDTO login(String email, String password);
    public void register(String user);
}