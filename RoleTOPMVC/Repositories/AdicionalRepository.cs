using System.Collections.Generic;
using System.IO;
using RoleTOPMVC.Models;

namespace RoleTOPMVC.Repositories
{
    public class AdicionalRepository
    {
        private const string PATH = "Database/Adicionais.csv";

        public double ObterPrecoDe(string nomeAdicional)
        {
            var lista = ObterTodos();
            var preco = 0.0;
            foreach (var item in lista)
            {
                if (item.Nome.Equals(nomeAdicional))
                {
                    preco = item.Preco;
                    break;
                }
            }
            return preco;
        }
        public List<Adicional> ObterTodos()
        {
            List<Adicional> adicionais = new List<Adicional>();
            string[] locais = File.ReadAllLines(PATH);
            
            foreach (var local in locais)
            {
                Adicional e = new Adicional();
                string [] dados = local.Split(";");
                e.Nome = dados[0];
                e.Preco = double.Parse(dados[1]);
                adicionais.Add(e);
            }

            return adicionais;
        }
    }
}