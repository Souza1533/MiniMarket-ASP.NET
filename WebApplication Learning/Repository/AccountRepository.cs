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

        public bool Delete(int id)
        {
            AccountModel account = GetId(id);

            if (account == null) throw new Exception($"Account not found.");

            _appDbContext.Accounts.Remove(account);
            _appDbContext.SaveChanges();

            return true;
        }
        
        public AccountModel GetId(int id)
        {
            var account = _appDbContext.Accounts.Find(id);

            if (account == null) throw new Exception($"Account not found.");
            return account;
        }

        public List<AccountModel> GetAll()
        {
            return _appDbContext.Accounts.ToList();
        }



    }
}



