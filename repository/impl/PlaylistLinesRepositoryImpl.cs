using PlaySoftBeta.Models;
using PlaySoftBeta.DTOs;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Linq;


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

        public List<SongIdListDTO> GetSongsId(int ID)
        {
            //Hacer dinamica la consulta
            var playlistLines = _context.PlaylistLines
                .FromSql($"SELECT s.songID, p.playlistID FROM PlaylistLines p INNER JOIN Songs s ON s.songID = p.songID WHERE playlistID = {ID} ORDER BY s.songName OFFSET 0 ROWS")
                .Include(playlistLines => playlistLines.Song)
                .ToList();
            return _mapper.Map<List<SongIdListDTO>>(playlistLines);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
