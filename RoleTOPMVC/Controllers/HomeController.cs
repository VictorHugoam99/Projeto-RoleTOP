using RoleTOPMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace RoleTOPMVC.Controllers 
{
    public class HomeController : AbstractController 
    {
        public IActionResult Index () 
        {            
            return View(new BaseViewModel()
            {
                NomeView = "Home",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        public IActionResult Privacy() 
        {
            return View ();
        }

    }
}