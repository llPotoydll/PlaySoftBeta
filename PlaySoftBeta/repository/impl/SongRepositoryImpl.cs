using PlaySoftBeta.Models;
using PlaySoftBeta.DTOs;
using AutoMapper;

namespace PlaySoftBeta.Repository
{
    public class SongRepository : ISongRepository
    {
        private readonly RepositoryContext _context;
        private readonly IMapper _mapper;

        public SongRepository(RepositoryContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public SongDTO getSong(int songID)
        {
            return _mapper.Map<SongDTO>(_context.Songs?.Find(songID));
        }
    }
}