
namespace WebApplication_Learning.Repository
{
    public interface IAccountRepository
    {
        List<AccountModel> FindAll();
        AccountModel Add(AccountModel account);
        string? BuscarPorId(int value);
    }
}
