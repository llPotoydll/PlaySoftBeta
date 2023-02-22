using PlaySoftBeta.Models;
using PlaySoftBeta.Repository;
using PlaySoftBeta.DTOs;

namespace PlaySoftBeta.Services;

public class AuthServiceImpl : IAuthService
{
    private IAuthRepositoy authRepositoy;

    public AuthLoginOutDTO login(string email, string password)
    {
        AuthLoginInDTO authLoginInDTO = new AuthLoginInDTO();
        authLoginInDTO.email = email;
        authLoginInDTO.password = password;

        try
        {
            User user = authRepositoy.GetUserByEmail(authLoginInDTO.email);
            if (user.password.Equals(authLoginInDTO.password))
            {
                AuthLoginOutDTO authLoginOutDTO = new AuthLoginOutDTO();
                authLoginOutDTO.email = user.email;
                
                authLoginOutDTO.username = user.username;
                return authLoginOutDTO;
            }
            return null;
        }
        catch (Exception e) { 
            return null;
        }
    }

    public void register(String user) { }
}
