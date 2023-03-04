using PlaySoftBeta.Models;
using PlaySoftBeta.DTOs;
using AutoMapper;

namespace PlaySoftBeta.Repository
{
    public class PlaylistRepository : IPLaylistRepository
    {

        private readonly RepositoryContext _context;

        private readonly IMapper _mapper;

        public PlaylistRepository(RepositoryContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public void CreatePlaylist(PlaylistDTO playlist)
        {
            _context.Playlists.Add(_mapper.Map<Playlist>(playlist));
        }

        public bool DeletePlaylist(PlaylistDTO playlist)
        {

            return true;
        }

        public List<PlaylistDTO> getOwnPlaylist(int userUKID)
        {
            var playlistlist = _context.Playlists.Where(playlist => playlist.playlistUKID.Equals(userUKID)).ToList();
            return _mapper.Map<List<PlaylistDTO>>(playlistlist);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}