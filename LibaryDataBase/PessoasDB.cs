public class PessoasDB
{
    private List<Pessoa> pessoas;
    private int ultimoId;

    public PessoasDB()
    {
        pessoas = new List<Pessoa>();
        ultimoId = 0; // Para gerar IDs incrementais
    }

    // Adicionar uma pessoa
    public void AdicionarPessoa(string nome, string cpf, string endereco, int quantidadeViagens)
    {
        var novaPessoa = new Pessoa
        {
            Id = ++ultimoId, // Gera um novo ID
            Nome = nome,
            CPF = cpf,
            Endereco = endereco,
            QuantidadeViagens = quantidadeViagens
        };
        pessoas.Add(novaPessoa);
        Console.WriteLine("Pessoa adicionada com sucesso!");
    }

    // Listar todos as pessoas
    public List<Pessoa> ListarPessoas()
    {
        return pessoas;
    }

    // Buscar uma pessoa pelo nome
    public Pessoa BuscarPessoaPeloNome(string Nome)
    {
        return pessoas.FirstOrDefault(l => l.Nome.Equals(Nome, StringComparison.OrdinalIgnoreCase));
    }

    // Remover uma pessoa pelo ID
    public void RemoverPessoa(int id)
    {
        var pessoa = pessoas.FirstOrDefault(l => l.Id == id);
        if (pessoa != null)
        {
            pessoas.Remove(pessoa);
            Console.WriteLine("Pessoa removida com sucesso!");
        }
        else
        {
            Console.WriteLine("Pessoa não encontrada!");
        }
    }

    // Atualizar informações de uma pessoa
    
}