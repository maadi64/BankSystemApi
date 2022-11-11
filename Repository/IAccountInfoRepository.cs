using BankSystemApi.Model;
using System.Collections.Generic;

namespace BankSystemApi.Repository
{
    public interface IAccountInfoRepository
    {
        List<AccountInfo> GetDetails();
        bool CreateNew(AccountInfo accountInfo);


    }
  
}
