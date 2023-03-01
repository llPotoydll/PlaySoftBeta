using PlaySoftBeta.DTOs;
using PlaySoftBeta.Models;
using PlaySoftBeta.Repository;

namespace PlaySoftBeta.Services;

public class PlaylistService : IPLaylistService
{
    private readonly IPLaylistRepository _pLaylistRepository;

    public PlaylistService(IPLaylistRepository pLaylistRepository)
    {
        _pLaylistRepository = pLaylistRepository;
    }
    public bool CreatePlaylist(PlaylistDTO playlist)
    {
        if (playlist != null)
        {
            if (_pLaylistRepository.CreatePlaylist(playlist))
            {
                _pLaylistRepository.Save();
                return true;
            }
            else
            {
                return false;
            }

        }
        else
        {
            return false;
        }
    }

    public bool DeletePlaylist(PlaylistDTO playlist)
    {
        return true;
    }

    public List<PlaylistDTO> getOwnPlaylist(int userUKID){
        try{
            if(userUKID != null && userUKID > -1){
                if(_pLaylistRepository.getOwnPlaylist(userUKID) != null){
                    return _pLaylistRepository.getOwnPlaylist(userUKID);
                }else{
                    return null;
                }
            }
            return null;
        }catch(Exception e){
            e.GetHashCode();
            return null;
        }
    }

}
