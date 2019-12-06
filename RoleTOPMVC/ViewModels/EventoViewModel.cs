using System;
using System.Collections.Generic;
using RoleTOPMVC.Models;

namespace RoleTOPMVC.ViewModels
{
    public class PedidoViewModel : BaseViewModel
    {

        public Cliente Cliente {get;set;}
        public string NomeCliente {get;set;}
        public List <Espaço> Espaços {get;set;}

        public PedidoViewModel()
        {
            this.Espaços = new List<Espaço>();
            this.Cliente = new Cliente();
            this.NomeCliente = "TOPSTER";
        }
        
    }
}