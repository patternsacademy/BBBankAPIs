﻿using BusinessLogic;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BBBankAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly AccountsService _accountService;
        public AccountsController(AccountsService accountService)
        {
            _accountService = accountService;
        }
        [Route("GetAll")]
        public async Task<ICollection<Account>> GetAll()
        {
            return await _accountService.GetAllAccounts();
        }
    }
}
