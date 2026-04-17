using WebApplication_Learning.Data;
using WebApplication_Learning.Repository;

namespace WebApplication_Learning.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly AppDbContext _appDbContext;
        public AccountRepository(AppDbContext AppDbContext)
        {
            _appDbContext = AppDbContext;
        }

        public AccountModel Add(AccountModel account)
        {
            _appDbContext.Add(account);
            _appDbContext.SaveChanges();
            return account;
        }

        public List<AccountModel> ShowAll()
        {
            return _appDbContext.Accounts.ToList();
        }



    }
}



