﻿using AutoMapper;
using HotelListing.Data;
using HotelListing.Models;
using HotelListing.Properties;
using HotelListing.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace HotelListing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        
        private readonly IAuthManager _authManager; 
        public AccountController(IAuthManager authManager)
        {
            
            _authManager = authManager;
        }
        [HttpPost]
        [Route("register")]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Register([FromBody] UserDTO userDTO)
        {
            var result = await _authManager.Register(userDTO);
            return Ok(new Response(Resource.REGISTER_SUCCESS));

        }
        [HttpPost]
        [Route("Login")]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<IActionResult> Login([FromBody] LoginUserDTO userDTO)
        {
            var result = await _authManager.Login(userDTO);
            return Ok(new Response(Resource.LOGIN_SUCCESS, null, new { Token = result }));


        }
        [HttpGet("logout")]
        public async Task<IActionResult> Logout()
        {
            var result = await _authManager.Logout();
            return Ok(new Response(result));
        }
        [HttpGet]
        [Route("ConfirmedEmail")]
        public async Task<IActionResult> ConfirmedEmail(Guid id, string code)
        {
            var result = await _authManager.ConfirmedEmail(id, code);
            return Ok(new Response(result));
        }

        [HttpPost]
        [Route("forgotPassword")]
        public async Task<IActionResult> ForgotPassword(string mail)
        {
            var result = await _authManager.ForgotPassword(mail);
            return Ok(new Response(result));
        }

        [HttpPost]
        [Route("resetPassword")]
        public async Task<IActionResult> ResetPassword([FromQuery] string code, [FromBody] ResetPassword resetPassword)
        {
            var result = await _authManager.ResetPassword(code, resetPassword);
            return Ok(new Response(result));
        }
    }

}
