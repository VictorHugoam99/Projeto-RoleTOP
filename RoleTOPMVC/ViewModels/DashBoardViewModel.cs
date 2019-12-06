using System.Collections.Generic;
using RoleTOPMVC.Models;

namespace RoleTOPMVC.ViewModels
{
    public class DashBoardViewModel : BaseViewModel
    {
        public List<Evento> Eventos {get;set;}
        public uint PedidosAprovados {get;set;}
        public uint PedidosReprovados {get;set;}
        public uint PedidosPendentes {get;set;}
        public DashBoardViewModel ()
        {
            this.Eventos = new List<Evento> ();
        }
    }
}