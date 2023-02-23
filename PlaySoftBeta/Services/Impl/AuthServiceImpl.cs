using PlaySoftBeta.Models;
using PlaySoftBeta.Repository;
using PlaySoftBeta.DTOs;

namespace PlaySoftBeta.Services;

public class AuthServiceImpl : IAuthService
{
    private IAuthRepositoy authRepositoy;

    public AuthLoginOutDTO login(AuthLoginInDTO authLoginInDTO)
    {
        AuthLoginOutDTO authLoginOutDTO = authRepositoy.GetUserByEmail(authLoginInDTO.email);

        if (authLoginOutDTO.password.Equals(authLoginInDTO.password))
        {
            return authLoginOutDTO;
        }
        return null; //error
    }

    public void register(AuhtRegisterUserDTO auhtRegisterUserDTO)
    {
        if (!authRepositoy.checkEmail(auhtRegisterUserDTO.email))
        {
            //registrar nuevo usuario
        }
    }
}
