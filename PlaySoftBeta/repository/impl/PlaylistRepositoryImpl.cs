using PlaySoftBeta.Models;
using PlaySoftBeta.DTOs;
using AutoMapper;

namespace PlaySoftBeta.Repository
{
    public class PlaylistRepository : IPLaylistRepository
    {

        private readonly RepositoryContext _context;

        public PlaylistRepository(RepositoryContext context)
        {
            _context = context;
        }
        public void NewPlaylist(PlaylistDTO playlistDTO)
        {
            //_context.Playlists.Add();
        }
    }
}