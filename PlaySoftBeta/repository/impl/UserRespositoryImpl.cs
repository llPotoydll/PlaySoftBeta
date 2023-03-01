using PlaySoftBeta.Models;
using PlaySoftBeta.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace PlaySoftBeta.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly RepositoryContext _context;

        public UserRepository(RepositoryContext context)
        {
            _context = context;
        }

        public List<UserDTO> getUserListByUsername(string username)
        {
            IEnumerable<User> userDTOList = _context.Users.Where(user => user.username.Equals(username));
            return userDTOList;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
