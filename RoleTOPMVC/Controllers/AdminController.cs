using RoleTOPMVC.Enums;
using RoleTOPMVC.Repositories;
using RoleTOPMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace RoleTOPMVC.Controllers {
    public class AdminController : AbstractController {
        EventoRepository eventoRepository = new EventoRepository ();
        public IActionResult DashBoard () {

            var ninguemLogado = string.IsNullOrEmpty(ObterUsuarioTipoSession());

            if (!ninguemLogado && (uint) TiposUsuario.ADMINISTRADOR == uint.Parse(ObterUsuarioTipoSession())) 
            {

                var eventos = eventoRepository.ObterTodos();
                DashBoardViewModel dashboardViewModel = new DashBoardViewModel ();

                foreach (var evento in eventos) {
                    switch (evento.Status) {
                        case (uint) StatusEvento.APROVADO:
                            dashboardViewModel.PedidosAprovados++;
                            break;
                        case (uint) StatusEvento.REPROVADO:
                            dashboardViewModel.PedidosReprovados++;
                            break;
                        default:
                            dashboardViewModel.PedidosPendentes++;
                            dashboardViewModel. Eventos.Add (evento);
                            break;
                    }
                }
                dashboardViewModel.NomeView = "Dashboard";
                dashboardViewModel.UsuarioEmail = ObterUsuarioSession ();

                return View (dashboardViewModel);
            } 
            else 
            {
                return View ("Erro", new RespostaViewModel(){
                    NomeView = "Dashboard",
                    Mensagem = "Você não tem permissão para isso"
                });

            }
        }
    }
}