using System;
using System.Collections.Generic;
using RoleTOPMVC.Models;

namespace RoleTOPMVC.ViewModels
{
    public class EventoViewModel : BaseViewModel
    {

        public Cliente Cliente {get;set;}
        public string NomeCliente {get;set;}
        public List<Espaço> Espaços {get;set;}
        public List<Adicional> Adicionais {get;set;}
        public List<Evento> Eventos {get;set;}


        public EventoViewModel()
        {
            this.Espaços = new List<Espaço>();
            this.Cliente = new Cliente();
            this.NomeCliente = "TOPSTER";
            this.Adicionais = new List<Adicional>();
            this.Eventos = new List<Evento>();
        }
        
    }
}