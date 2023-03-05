using PlaySoftBeta.Models;
using PlaySoftBeta.DTOs;
using AutoMapper;

namespace PlaySoftBeta.Repository
{
    public class PlaylistLinesRepositoryImpl : IPlaylistLinesRepository
    {

        private readonly RepositoryContext _context;
        private readonly IMapper _mapper;

        public PlaylistLinesRepositoryImpl(RepositoryContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public void AddSong(PlaylistLinesDTO playlistLinesDTO)
        {
            _mapper.Map<PlaylistLines>(playlistLinesDTO);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}