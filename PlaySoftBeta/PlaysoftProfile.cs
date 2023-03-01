using AutoMapper;
using PlaySoftBeta.Models;
using PlaySoftBeta.DTOs;
public class PlaysoftProfile : Profile
{
	public PlaysoftProfile()
	{
		CreateMap<AuhtRegisterUserDTO, User>();
		CreateMap<User, AuthLoginOutDTO>();
		CreateMap<PlaylistDTO, Playlist>();
		// Use CreateMap... Etc.. here (Profile methods are the same as configuration methods)
	}
}

