namespace BankSystemApi.Model
{
    public enum AccountType
    {
        suspended,
        Active,
        InActive,
        TemporaryBlock
    }
    public class AccountInfo
    { 
      public int ClientId { get; set; }
      public string AccountTitle { get; set; }
      public string BranchAdress { get; set; }
      public int ContactDetails { get; set; }
      public int BranchCode { get; set; }
      public AccountType Status { get; set; }
        
    }
}
