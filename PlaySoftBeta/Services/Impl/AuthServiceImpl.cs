using PlaySoftBeta.Models;
using PlaySoftBeta.Repository;
using PlaySoftBeta.DTOs;

namespace PlaySoftBeta.Services;

public class AuthServiceImpl : IAuthService
{
    private readonly IAuthRepositoy _authRepository;


    public AuthServiceImpl(IAuthRepositoy authRepository)
    {
        _authRepository = authRepository;
    }

    public AuthLoginOutDTO Login(AuthLoginInDTO authLoginInDTO)
    {

        var authLoginOutDTO = _authRepository.GetUserByEmail(authLoginInDTO.email);
        if (authLoginOutDTO != null)
        {
            if (authLoginOutDTO.password.Equals(authLoginInDTO.password))
            {
                return authLoginOutDTO;
            }
        }
        return null;
    }

    public bool Register(AuhtRegisterUserDTO auhtRegisterUserDTO)
    {
        if (!_authRepository.CheckEmail(auhtRegisterUserDTO.email))
        {
            if (auhtRegisterUserDTO.password.Equals(auhtRegisterUserDTO.verifyPassword))
            {
                _authRepository.RegisterUser(auhtRegisterUserDTO);
                _authRepository.Save();
                return true;
            }
        }
        return false;
    }
}
