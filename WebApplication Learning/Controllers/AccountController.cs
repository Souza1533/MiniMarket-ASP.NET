using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication_Learning.Repository;

namespace WebApplication_Learning.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountRepository _accountRepository;
        public AccountController(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        [HttpPost]
        public IActionResult Register(AccountModel account)
        {
            _accountRepository.Add(account);

            HttpContext.Session.SetString("IsLoggedIn", "true");

            return RedirectToAction("Index", "Perfil");
        }


    }
}
