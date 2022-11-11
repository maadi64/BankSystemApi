using BankSystemApi.Model;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace BankSystemApi.Repository
{
    public class AccountInfoRepository : IAccountInfoRepository
    {
        List<AccountInfo> _accounts;
        public AccountInfoRepository()
        {
            this._accounts = new List<AccountInfo> {
                new AccountInfo()
                {
                    ClientId = 1,
                    AccountTitle = "ABCD",
                    BranchAdress = "Lahore",
                    BranchCode = 123,
                    ContactDetails = 12333,
                    Status = AccountType.Active,
                },
                new AccountInfo()
                {
                    ClientId= 1,
                    AccountTitle="Xyz",
                    BranchAdress="karachi",
                    BranchCode =123,
                    ContactDetails=1233356,
                    Status=AccountType.Active,
                }
            };
        }
        public List<AccountInfo> GetDetails()
        {
            return this._accounts.ToList();
        }
        public bool CreateNew(AccountInfo accountInfo)
        {
            try
            {
                this._accounts.Add(accountInfo);
                return true;

            }
            catch (System.Exception)
            {

                return false;
            }

        }
    }
}
