using AutoMapper.Configuration;
using HotelListing.Data;
using HotelListing.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace HotelListing.Services
{
    public interface IAuthManager 
    {
        Task<string> Login(LoginUserDTO userDTO);
        Task<string> CreateToken();


    }
}
