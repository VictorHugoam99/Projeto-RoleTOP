namespace RoleTOPMVC.Repositories
{
    public class RepositoryBase
    {
        protected string ExtrairValorDoCampo(string nome, string linha)
        {
            var chave = nome;

            var indiceChave = linha.IndexOf(chave);
            var indiceTerminal = linha.IndexOf(";", indiceChave);

            var valor = "";
            if (indiceTerminal != -1)
            {
                valor = linha.Substring(indiceChave, indiceTerminal - indiceChave);
            }else
            {
                valor = linha.Substring(indiceChave);
            }
            System.Console.WriteLine($"Campo: {nome} e valor {valor}");
            return valor.Replace(nome + "=","");
        }
    }
}