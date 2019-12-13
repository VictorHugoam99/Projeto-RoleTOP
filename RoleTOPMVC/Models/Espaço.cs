namespace RoleTOPMVC.Models
{
    public class Espaço
    {
        public string Local {get;set;}
        public double Preco {get;set;}
        public Espaço ()
        {

        }

        public Espaço(string local, double preco)
        {
            this.Local = local;
            this.Preco = preco;
        }
    }
}