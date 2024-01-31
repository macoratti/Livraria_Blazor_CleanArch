using Livraria.Domain.Entities;

namespace Livraria.Domain.Abstractions;

public interface ILivroRepository
{
    Task<IEnumerable<Livro>> ObterLivros();
    Task<Livro?> ObterLivro(int id);
    Task<Livro> AdicionarLivro(Livro livro);
    Task DeletarLivro(int id);
    Task AtualizarLivro(Livro livro);
}
