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
            _context.PlaylistLines.Add(_mapper.Map<PlaylistLines>(playlistLinesDTO));
        }

        public List<int> GetSongsId(int ID)
        {
            var playlistLines = _context.PlaylistLines
                .Where(playlistLine => playlistLine.playlistID.Equals(ID))
                .ToList();
            return _mapper.Map<List<int>>(playlistLines);
            
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
