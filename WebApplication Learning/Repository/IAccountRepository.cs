
namespace WebApplication_Learning.Repository
{
    public interface IAccountRepository
    {
        List<AccountModel> ShowAll();
        AccountModel Add(AccountModel account);
    }
}
