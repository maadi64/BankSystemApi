using BankSystemApi.Model;
using BankSystemApi.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BankSystemApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountInfoController : ControllerBase
    {
        IAccountInfoService _accountInfoService;
        public AccountInfoController(IAccountInfoService  accountInfoService)
        {
            this._accountInfoService = accountInfoService;
        }
        [HttpGet]
        public IEnumerable<AccountInfo> GetAccounts()
        {
            return this._accountInfoService.GetAccountDetails();
        }
        [HttpPost]
        public string Post(AccountInfo accountInfo)
        {
            return this._accountInfoService.CreateNew(accountInfo);
        }
    }
}
