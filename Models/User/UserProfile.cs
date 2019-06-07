using AutoMapper;

using Sandbox.Models.User;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<UserModel, UserViewModel>();
    }
}
