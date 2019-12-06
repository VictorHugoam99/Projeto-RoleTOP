using System;
using RoleTOPMVC.Enums;

namespace RoleTOPMVC.Models
{
    public class Evento
    {
        public ulong Id {get;set;}
        public Cliente Cliente {get; set;}
        public Espaço Espaço {get;set;}
        public DateTime DataDoPedido {get; set;}
        public double PrecoTotal {get; set;}
        public uint Status {get;set;}

        public Evento()
        {
            this.Cliente = new Cliente();
            this.Espaço = new Espaço();
            this.Id = 0;
            this.Status = (uint) StatusAluguel.PENDENTE;
        }
    }
}