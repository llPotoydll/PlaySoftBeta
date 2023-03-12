using AutoMapper;
using PlaySoftBeta.Models;
using PlaySoftBeta.DTOs;
public class PlaysoftProfile : Profile
{
    public PlaysoftProfile()
    {
        CreateMap<AuhtRegisterUserDTO, User>();
        CreateMap<User, AuthLoginOutDTO>();

        CreateMap<User, UserDTO>();
        CreateMap<Playlist, PlaylistDTO>();
        CreateMap<PlaylistDTO, Playlist>();
        CreateMap<Song, SongDTO>();
        CreateMap<PlaylistLinesDTO, PlaylistLines>();
        CreateMap<PlaylistLines, SongIdListDTO>();
        CreateMap<EditPLaylistDTO, Playlist>();
        // Use CreateMap... Etc.. here (Profile methods are the same as configuration methods)
    }
}

