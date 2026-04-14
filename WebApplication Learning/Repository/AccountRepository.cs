using WebApplication_Learning.Data;

namespace WebApplication_Learning.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly AppDbContext _appDbContext;
        public AccountRepository(AppDbContext appDbContext) 
        {
            _appDbContext = appDbContext;
        }
        public AccountModel Add(AccountModel account)
        {
            _appDbContext.Add(account);
            _appDbContext.SaveChanges();

            return account;
        }


        public List<AccountModel> FindAll()
        {
            return _appDbContext.Accounts.ToList();
        }
    }
}
