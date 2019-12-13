using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTOPMVC.Enums;
using RoleTOPMVC.Models;
using RoleTOPMVC.Repositories;
using RoleTOPMVC.ViewModels;
namespace RoleTOPMVC.Controllers {
    public class CadastroController : AbstractController {
        ClienteRepository clienteRepository = new ClienteRepository ();

        [HttpGet]
        public IActionResult Index () {
            return View (new BaseViewModel () {
                NomeView = "Cadastro",
                    UsuarioEmail = ObterUsuarioSession (),
                    UsuarioNome = ObterUsuarioNomeSession ()
            });
        }

        [HttpPost]
        public IActionResult CadastrarCliente (IFormCollection form) {
            ViewData["Action"] = "Cadastro";
            try {
                Cliente cliente = new Cliente (form["nome"], form["CPF"], form["tel"], form["senha"], form["email"], DateTime.Parse (form["data-nascimento"]));
                cliente.TipoUsuario = (uint) TiposUsuario.CLIENTE;
                clienteRepository.Inserir (cliente);

                return View ("Sucesso", new RespostaViewModel () {
                    NomeView = "Cadastro",
                        UsuarioEmail = ObterUsuarioSession (),
                        UsuarioNome = ObterUsuarioNomeSession ()
                });

            } catch (Exception e) {
                System.Console.WriteLine (e.StackTrace);

                return View ("Erro", new RespostaViewModel () {
                    NomeView = "Cadastro",
                        UsuarioEmail = ObterUsuarioSession (),
                        UsuarioNome = ObterUsuarioNomeSession ()
                });
            }

        }
    }
}