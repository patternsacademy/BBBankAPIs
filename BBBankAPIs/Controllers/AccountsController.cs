using BusinessLogic;
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
        [Route("GetAll")]
        public async Task<List<Account>> GetAll()
        {
            var accountService = new AccountsService();
            return accountService.GetAllAccounts();
        }
    }
}
