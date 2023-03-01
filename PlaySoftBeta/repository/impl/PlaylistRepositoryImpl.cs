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
        public bool CreatePlaylist(PlaylistDTO playlist)
        {
            try
            {
                _context.Playlists.Add(_mapper.Map<Playlist>(playlist));
                return true;
            }
            catch (Exception e)
            {
                //Sacar error
                return false;
            }

        }

        public bool DeletePlaylist (PlaylistDTO playlist){
            
            return true;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}