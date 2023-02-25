using AutoMapper;
using PlaySoftBeta.Models;
using PlaySoftBeta.DTOs;
public class PlaysoftProfile : Profile
{
	public PlaysoftProfile()
	{
		CreateMap<AuhtRegisterUserDTO, User>();
		CreateMap<AuthLoginOutDTO, User>();
		// Use CreateMap... Etc.. here (Profile methods are the same as configuration methods)
	}
}

