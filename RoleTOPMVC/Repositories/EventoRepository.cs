using System;
using System.Collections.Generic;
using System.IO;
using RoleTOPMVC.Models;

namespace RoleTOPMVC.Repositories
{
    public class EventoRepository : RepositoryBase
    {
        private const string PATH = "Database/Evento.csv";

        public EventoRepository()
        {
            if (!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public bool Inserir(Evento evento)
        {
            var quantidadeEventos = File.ReadAllLines(PATH).Length;
            evento.Id = (ulong) ++quantidadeEventos;
            var linha = new string[] { PrepararPedidoCSV (evento)};
            File.AppendAllLines(PATH,linha);
            
            return true;
        }

        public List<Evento> ObterTodosPorCliente(string emailCliente)
        {
            var eventos = ObterTodos();
            List<Evento> eventosCliente = new List<Evento>();
            foreach (var evento in eventos)
            {
                if (evento.Cliente.Email.Equals(emailCliente))
                {
                    eventosCliente.Add(evento);
                }
            }
            return eventosCliente;
        }

        public List<Evento> ObterTodos()
        {
            var linhas = File.ReadAllLines(PATH);
            List<Evento> eventos = new List<Evento>();

            foreach (var linha in linhas)
            {
                Evento evento = new Evento();

                evento.Id = ulong.Parse(ExtrairValorDoCampo("id", linha));
                evento.Status = uint.Parse(ExtrairValorDoCampo("status_pedido", linha));
                evento.Cliente.Nome = ExtrairValorDoCampo("cliente_nome", linha);
                evento.Cliente.CPF = ExtrairValorDoCampo("cliente_cpf", linha);
                evento.Cliente.Telefone = ExtrairValorDoCampo("cliente_telefone", linha);
                evento.Cliente.Email = ExtrairValorDoCampo("cliente_email", linha);
                evento.Espaço.Preco = double.Parse(ExtrairValorDoCampo("espaco_preco", linha));
                evento.PrecoTotal = double.Parse(ExtrairValorDoCampo("preco_total", linha));
                evento.DataDoPedido = DateTime.Parse(ExtrairValorDoCampo("data_pedido", linha));

                eventos.Add(evento);
            }
            return eventos;
        }

        public Evento ObterPor(ulong id)
        {
            var EventoTotal = ObterTodos();
            foreach (var evento in EventoTotal)
            {
                if (id.Equals(evento.Id))
                {
                    return evento;
                }
            }
            return null;
        }

        public bool Atualizar(Evento evento)
        {
            var eventoTotal = File.ReadAllLines(PATH);
            var eventoCSV = PrepararPedidoCSV(evento);
            var linhaEvento = -1;
            var resultado = false;

            for (int i = 0; i < eventoTotal.Length; i++)
            {
                var idConvertido = ulong.Parse(ExtrairValorDoCampo("id", eventoTotal[i]));
                if(evento.Id.Equals(idConvertido))
                {
                    linhaEvento = i;
                    resultado = true;
                    break;
                }
            }

            if(resultado)
            {
                eventoTotal[linhaEvento] = eventoCSV;
                File.WriteAllLines(PATH, eventoTotal);
            }

            return resultado;
        }
        private string PrepararPedidoCSV(Evento evento)
        {
            Cliente c = evento.Cliente;
            Espaço e = evento.Espaço;
            
            return $"id={evento.Id};status_pedido={evento.Status};cliente_nome={c.Nome};cliente_endereco={c.CPF};cliente_CPF={c.Telefone};cliente_email={c.Email};espaço_preco={e.Preco};data_evento={evento.DataDoPedido};preco_total={evento.PrecoTotal}";
        }
    }
}