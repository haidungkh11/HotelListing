using AutoMapper.Configuration;
using HotelListing.Data;
using HotelListing.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;

namespace HotelListing.Services
{
    public interface IAuthManager 
    {
        Task<string> Login(LoginUserDTO userDTO);
        Task<string> CreateToken();
        Task<bool> Register(UserDTO userDTO);
        Task<string> Logout();
        Task<string> ConfirmedEmail(Guid id, string code);
        Task<string> ForgotPassword(string mail);
        Task<string> ResetPassword(string code, ResetPassword resetPassword);

    }
}
