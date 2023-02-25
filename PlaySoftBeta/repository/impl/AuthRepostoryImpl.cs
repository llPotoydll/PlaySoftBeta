using PlaySoftBeta.Models;
using PlaySoftBeta.DTOs;
using AutoMapper;

namespace PlaySoftBeta.Repository
{
    public class AuthRepository : IAuthRepositoy, IDisposable
    {
        private RepositoryContext context;
        private readonly IMapper mapper;
        public AuthRepository(RepositoryContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public AuthLoginOutDTO GetUserByEmail(string userEmail)
        {
            User user = context.Users.Find(userEmail);
            return mapper.Map<AuthLoginOutDTO>(user);
        }

        public void registerUser(AuhtRegisterUserDTO authDTO)
        {
             context.Users.Add(mapper.Map<User>(authDTO));
        }

        public Boolean checkEmail(string userEmail)
        {
            if (context.Users.Any(user => user.email == userEmail))
            {
                return true;
            }
            return false;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
