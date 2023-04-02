using PlaySoftBeta.DTOs;
using PlaySoftBeta.Models;
using PlaySoftBeta.Repository;
using PlaySoftBeta.Log;

namespace PlaySoftBeta.Services;

public class SearchService : ISearchService
{
    private readonly IUserRepository _userRepository;
    private readonly ISongRepository _songRpository;


    public SearchService(IUserRepository userRepository, ISongRepository songRepository)
    {
        _userRepository = userRepository;
        _songRpository = songRepository;
    }

    public SearchDTO SearchByName(string name)
    {
        var users = _userRepository.GetUserListByUsername(name);
        var songs = _songRpository.GetSongListByName(name);
        return null;
    }
}
