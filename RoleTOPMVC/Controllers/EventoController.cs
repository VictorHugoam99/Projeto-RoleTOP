using System;
using RoleTOPMVC.Enums;
using RoleTOPMVC.Models;
using RoleTOPMVC.Repositories;
using RoleTOPMVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RoleTOPMVC.Controllers
{
    public class EventoController : AbstractController
    {
        ClienteRepository clienteRepository = new ClienteRepository();
        EspaçoRepository espaçoRepository = new EspaçoRepository();
        EventoRepository eventoRepository = new EventoRepository();
        AdicionalRepository adicionalRepository = new AdicionalRepository();

        [HttpGet]
        public IActionResult Index()
        {
            var espaço = espaçoRepository.ObterTodos();
            var emailCliente = ObterUsuarioSession();

            EventoViewModel pvm = new EventoViewModel(); 
            pvm.Espaços = espaçoRepository.ObterTodos();
            pvm.Adicionais = adicionalRepository.ObterTodos();
            pvm.Eventos = eventoRepository.ObterTodosPorCliente(emailCliente);

            if (!string.IsNullOrEmpty(emailCliente))
            {
                pvm.Cliente = clienteRepository.ObterPor(emailCliente);
            }
            var UsuarioNome = ObterUsuarioNomeSession();
            if (!string.IsNullOrEmpty(UsuarioNome))
            {
                pvm.NomeCliente = UsuarioNome;
            }

            pvm.NomeView = "Evento";
            pvm.UsuarioEmail = emailCliente;
            pvm.UsuarioNome = UsuarioNome;
            return View(pvm);
        }
        [HttpPost]
        public IActionResult Registrar(IFormCollection form)
        {
            Evento evento = new Evento ();

            var nomeEspaço = form["Espaço"];
            Espaço espaço = new Espaço (nomeEspaço, espaçoRepository.ObterPrecoDe(nomeEspaço));
            evento.Espaço = espaço;

            var nomeAdicional = form["Adicional"];
            Adicional adicional = new Adicional (nomeAdicional, adicionalRepository.ObterPrecoDe(nomeAdicional));
            evento.Adicional = adicional;

            Cliente cliente = new Cliente();
            cliente.Nome = form["nome"];
            cliente.CPF = form["endereco"];
            cliente.Telefone = form["CPF"];
            cliente.Email = form["email"];
            cliente.Telefone = form["telefone"];

            evento.Cliente = cliente;
            evento.DataDoPedido =DateTime.Parse(form["data_evento"]);
            evento.PrecoTotal = espaçoRepository.ObterPrecoDe(nomeEspaço) + adicionalRepository.ObterPrecoDe(nomeAdicional);

            if (eventoRepository.Inserir(evento))
            {
                return View ("Sucesso", new BaseViewModel()
                {
                    NomeView = "Evento",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }else{
                return View ("Erro", new BaseViewModel()
                {
                    NomeView = "Evento",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }
    
        public IActionResult Aprovar(ulong id)
        {
            var evento = eventoRepository.ObterPor(id);
            evento.Status = (uint) StatusEvento.APROVADO;
            
            if (eventoRepository.Atualizar(evento))
            {
                return RedirectToAction("DashBoard", "Admin");
            }
            else
            {
                return View ("Erro", new RespostaViewModel("Não foi possivel aprovar este evento")
                {
                    NomeView = "DashBoard",
                    UsuarioEmail = ObterUsuarioSession (), 
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }

        public IActionResult Reprovar (ulong id)
        {
            var evento = eventoRepository.ObterPor(id);
            evento.Status = (uint) StatusEvento.REPROVADO;
            
            if (eventoRepository.Atualizar(evento))
            {
                return RedirectToAction("Dashboard", "Admin");
            }
            else
            {
                return View ("Erro", new RespostaViewModel("Não foi possivel reprovar este evento")
                {
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession (), 
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }
        public IActionResult Historico ()
        {
            var emailCliente = ObterUsuarioSession();
            var pedidoCliente = eventoRepository.ObterTodosPorCliente(emailCliente);

            return View(new EventoViewModel()
            {
                Eventos = pedidoCliente,
                NomeView = "Dashboard",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
    }
}
