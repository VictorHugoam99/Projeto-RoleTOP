namespace RoleTOPMVC.Models
{
    public class Espaço : Aluguel
    {
        public Espaço ()
        {

        }

        public Espaço(string local, double preco)
        {
            this.Local = Local;
            this.Preco = preco;
        }
    }
}