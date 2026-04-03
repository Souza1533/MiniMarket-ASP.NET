using Microsoft.AspNetCore.Mvc;
using WebApplication_Learning.Repository;

namespace WebApplication_Learning.Controllers
{
    public class PerfilController : Controller
    {
        private readonly IAccountRepository _accountRepository;
        public PerfilController(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
