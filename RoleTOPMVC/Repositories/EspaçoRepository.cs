using System.Collections.Generic;
using System.IO;
using RoleTOPMVC.Models;

namespace RoleTOPMVC.Repositories
{
    public class EspaçoRepository : Aluguel
    {
        private const string PATH = "Database/Espaço.csv";

        public double ObterPrecoDe(string nomeEspaço)
        {
            var lista = ObterTodos();
            var preco = 0.0;
            foreach (var item in lista)
            {
                if (item.Local.Equals(nomeEspaço))
                {
                    preco = item.Preco;
                    break;
                }
            }
            return preco;
        }
        public List<Espaço> ObterTodos()
        {
            List<Espaço> espaços = new List<Espaço>();
            string[] locais = File.ReadAllLines(PATH);
            
            foreach (var local in locais)
            {
                Espaço e = new Espaço();
                string [] dados = local.Split(";");
                e.Preco = double.Parse(dados[1]);
                espaços.Add(e);
            }

            return espaços;
        }
    }
}