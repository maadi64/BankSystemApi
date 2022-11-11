using BankSystemApi.Model;
using System.Collections.Generic;

namespace BankSystemApi.Service
{
    public interface IAccountInfoService
    {
        List<AccountInfo> GetAccountDetails();
        string CreateNew(AccountInfo accountInfo);
    }
   
}
