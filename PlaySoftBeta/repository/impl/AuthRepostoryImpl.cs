using PlaySoftBeta.Models;

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

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
