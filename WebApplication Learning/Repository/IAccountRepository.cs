
namespace WebApplication_Learning.Repository
{
    public interface IAccountRepository
    {
        AccountModel Add(AccountModel account);
        bool Delete(int id);
        AccountModel GetId(int id);
        List<AccountModel> GetAll();
    }
}
