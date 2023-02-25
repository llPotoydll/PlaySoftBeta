using PlaySoftBeta.Models;
using PlaySoftBeta.Repository;
using PlaySoftBeta.DTOs;

namespace PlaySoftBeta.Services;

public class AuthServiceImpl : IAuthService
{
    private readonly IAuthRepositoy authRepository;


    public AuthServiceImpl(IAuthRepositoy authRepository)
    {
        this.authRepository = authRepository;
    }

    public AuthLoginOutDTO login(AuthLoginInDTO authLoginInDTO)
    {
        AuthLoginOutDTO authLoginOutDTO = authRepository.GetUserByEmail(authLoginInDTO.email);

        if (authLoginOutDTO.password.Equals(authLoginInDTO.password))
        {
            return authLoginOutDTO;
        }
        return null; //error
    }

    public void register(AuhtRegisterUserDTO auhtRegisterUserDTO)
    {
        if (!authRepository.checkEmail(auhtRegisterUserDTO.email))
        {
            if (auhtRegisterUserDTO.password.Equals(auhtRegisterUserDTO.verifyPassword)){
                authRepository.registerUser(auhtRegisterUserDTO);
            }
        }
    }
}
