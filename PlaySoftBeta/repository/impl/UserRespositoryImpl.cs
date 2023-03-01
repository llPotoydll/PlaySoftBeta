

using PlaySoftBeta.Models;

namespace PlaySoftBeta.Repository
{
    public class UserRepository : IUserRepositoy, IDisposable
    {
        private RepositoryContext context;

        public UserRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}