using PlaySoftBeta.Models;
using PlaySoftBeta.DTOs;
using AutoMapper;

namespace PlaySoftBeta.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly RepositoryContext _context;
        private readonly IMapper _mapper;

        public UserRepository(RepositoryContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<UserDTO> getUserListByUsername(string username)
        {
            var userList = _context.Users.Where(user => user.username.Equals(username)).ToList();
            return _mapper.Map<List<UserDTO>>(userList);
        }

        public List<PlaylistDTO> getUserPlaylists(int ukid)
        {
            var playlistList = _context.Playlists
                .Where(playlist => playlist.UKID.Equals(ukid) && playlist.privacity == true)
                .OrderBy(playlist => playlist.playListName)
                .ToList();
            return _mapper.Map<List<PlaylistDTO>>(playlistList);
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
