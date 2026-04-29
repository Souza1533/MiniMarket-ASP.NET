using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Add(AccountModel account)
        {
            if (!ModelState.IsValid)
            {
                return View(account);
            }
            _accountRepository.Add(account);

            HttpContext.Session.SetString("IsLoggedIn", "true");

            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        
    }
}
