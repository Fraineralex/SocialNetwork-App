﻿using SocialNetwork.Core.Application.ViewModels.Auth;
using SocialNetwork.Core.Domain.Entities;

namespace SocialNetwork.Core.Application.Interfaces.Services
{
    public interface IUsersService : IGenericService<SaveUserViewModel, UserViewModel, Users>
    {
        Task<UserViewModel> Login(LoginViewModel loginVm);
        Task<SaveUserViewModel> GetAUserByUsernameAsync(string username);
        Task<UserViewModel> GetUserViewModelById(int id);
        Task<List<UserViewModel>> GetAllViewModelWithInclude();
    }
}
