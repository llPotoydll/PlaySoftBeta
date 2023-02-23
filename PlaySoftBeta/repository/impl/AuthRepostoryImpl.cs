using PlaySoftBeta.Models;
using PlaySoftBeta.DTOs;

namespace PlaySoftBeta.Repository
{
    public class AuthRepository : IAuthRepositoy, IDisposable
    {
        private RepositoryContext context;

        public AuthRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public User GetUserByEmail(string userEmail)
        {
            return context.Users.Find(userEmail);
        }

        public void registerUser(AuhtRegisterUserDTO user)
        {
             context.Users.Add(user);
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
