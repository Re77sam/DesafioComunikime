public class ProdutoService : IProdutoService
{
    private readonly IProdutoRepository _produtoRepository;

    public ProdutoService(IProdutoRepository produtoRepository)
    {
        _produtoRepository = produtoRepository;
    }

    public IEnumerable<Produto> GetAll()
    {
        try
        {
            return _produtoRepository.GetAll();
        }
        catch (Exception ex)
        {
            // Logar o erro
            throw new ApplicationException("Erro ao obter a lista de produtos.", ex);
        }
    }

    // Implementar outros métodos de IProdutoService com tratamento de erros semelhante
}