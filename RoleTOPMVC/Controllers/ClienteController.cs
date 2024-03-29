using RoleTOPMVC.ViewModels;
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using RoleTOPMVC.Enums;
using RoleTOPMVC.Repositories;

namespace RoleTOPMVC.Controllers {
    public class ClienteController : AbstractController {
        private ClienteRepository clienteRepository = new ClienteRepository();
        private EventoRepository eventoRepository = new EventoRepository();

        [HttpGet]
        public IActionResult Login () {
            return View (new BaseViewModel()
            {
                NomeView = "Login",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        [HttpPost]
        public IActionResult Login (IFormCollection form) {

            ViewData["Action"] = "Login";
            try {
                
                System.Console.WriteLine (form["email"]);
                System.Console.WriteLine (form["senha"]);

                var usuario = form["email"];
                var senha = form["senha"];

                var cliente = clienteRepository.ObterPor(usuario);

                if (cliente != null)
                {
                    if (cliente.Senha.Equals(senha))
                    {
                        switch (cliente.TipoUsuario)
                        {
                            case (uint) TiposUsuario.CLIENTE:
                                HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL, usuario);
                                HttpContext.Session.SetString(SESSION_CLIENTE_NOME, cliente.Nome);
                                HttpContext.Session.SetString(SESSION_CLIENTE_TIPO, cliente.TipoUsuario.ToString());
                        
                                return RedirectToAction("Index", "Cliente");
                        
                            default:
                                HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL, usuario);
                                HttpContext.Session.SetString(SESSION_CLIENTE_NOME, cliente.Nome);
                                HttpContext.Session.SetString(SESSION_CLIENTE_TIPO, cliente.TipoUsuario.ToString());
                        
                                return RedirectToAction("DashBoard", "Admin");
                            
                        }
                    }else
                    {
                        return View("Erro", new RespostaViewModel($"Senha incorreta!"));
                    }
                }else
                {
                    
                    return View ("Erro", new RespostaViewModel($"Usuário {usuario} não encontrado"));
                }

            } catch (Exception e) {
                System.Console.WriteLine (e.StackTrace);
                return View ("Erro");
            }
        }
    
        public IActionResult Index ()
        {
            
            return View(new HistoricoViewModel()
            {
                NomeView = "Index",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        public IActionResult Logoff ()
        {
            HttpContext.Session.Remove(SESSION_CLIENTE_EMAIL);
            HttpContext.Session.Remove(SESSION_CLIENTE_NOME);
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}