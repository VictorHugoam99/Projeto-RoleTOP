using System;

namespace RoleTOPMVC.Models
{
    public class Cliente
    {
        public string Nome {get; set;}
        public string CPF {get; set;}
        public string Telefone {get; set;}
        public string Senha {get; set;}
        public string Email {get; set;}
        public DateTime DataNascimento {get; set;}

        public uint TipoUsuario {get;set;}
        public Cliente ()
        {

        }
        public Cliente(string Nome, string CPF, string Telefone, string Senha, string Email, DateTime DataNascimento)
        
        {
            this.Nome = Nome;
            this.CPF = CPF;
            this.Telefone = Telefone;
            this.Senha = Senha;
            this.Email = Email;
            this.DataNascimento = DataNascimento;
        }
    }
}