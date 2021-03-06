﻿
using Account.Services.Interfaces;
using Account.WebApi.DTO;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Account.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginServies loginServies;
        private readonly IAccountInfoServies accountInfoServies;
        private readonly IMapper mapper;

        public LoginController(IMapper mapper, ILoginServies loginServies, IAccountInfoServies accountInfoServies)
        {
            
            this.loginServies = loginServies;
            this.mapper = mapper;
            this.accountInfoServies = accountInfoServies;
        }


        [HttpGet]
        [Route("{action}")]
        public IActionResult GetLogin([FromQuery] string email, [FromQuery] string password)
        {
            if (loginServies.ChackUserLogin(email, password) == null)
                return Unauthorized();
            var a = loginServies.ChackUserLogin(email, password);
            return Ok(new {accountId=a});
        }

        [HttpGet]
        [Route("{action}")]
        public IActionResult GetAccount([FromQuery] string CustomerId)
        {
            if (accountInfoServies.GetAccount(new Guid(CustomerId)) == null)
                return Unauthorized();
            var a = accountInfoServies.GetAccount(new Guid(CustomerId));
            return Ok(mapper.Map<AccountDTO>(a));
        }
    }
}
