using BankSystemApi.Model;
using BankSystemApi.Repository;
using System.Collections.Generic;

namespace BankSystemApi.Service
{
    public class AccountInfoService : IAccountInfoService
    {
        IAccountInfoRepository _repositoryAccountInfo;

        public AccountInfoService()
        {
        }

        public AccountInfoService(IAccountInfoRepository repositoryAccountInfo)
        {
            this._repositoryAccountInfo = repositoryAccountInfo;
        }
        public List<AccountInfo> GetAccountDetails()
        {
            var accounts = this._repositoryAccountInfo.GetDetails();
            var transformedaccounts = new List<AccountInfo>();
            foreach (var account in accounts)
            {
                string transformedAccountTile = TransformedAccountsTitle(account.AccountTitle);
                account.AccountTitle = transformedAccountTile;
                transformedaccounts.Add(account);
            }
            return transformedaccounts;
        }
        string TransformedAccountsTitle(string accountTitle)
        {
            return $"{accountTitle}-Transformed";
        }
        public string CreateNew(AccountInfo accountInfo)
        {
            if (accountInfo == null || accountInfo.ClientId == 0)
            {
                return "Validation error";
            }
            var response = this._repositoryAccountInfo.CreateNew(accountInfo);
            if (response)
            {
                return "insert Sucessful";
            }
            return "failed to Insert";
        }


    }
}
