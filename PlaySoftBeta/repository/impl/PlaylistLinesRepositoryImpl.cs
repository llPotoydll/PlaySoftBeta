using PlaySoftBeta.Models;
using PlaySoftBeta.DTOs;
using AutoMapper;

namespace PlaySoftBeta.Repository
{
    public class PlaylistLinesRepositoryImpl : IPlaylistLinesRepository
    {

        private readonly RepositoryContext _context;

        public PlaylistLinesRepositoryImpl(RepositoryContext context)
        {
            _context = context;
        }
        public void addSong(PlaylistLinesDTO playlistLinesDTO)
        {
            throw new NotImplementedException();
        }
    }
}