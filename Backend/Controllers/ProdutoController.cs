[Route("api/produtos")]
public class ProdutoController : ApiController
{
    private readonly IProdutoService _produtoService;

    public ProdutoController(IProdutoService produtoService)
    {
        _produtoService = produtoService;
    }

    [HttpGet]
    public IHttpActionResult GetAllProdutos()
    {
        try
        {
            var produtos = _produtoService.GetAll();
            return Ok(produtos);
        }
        catch (Exception ex)
        {
            // Logar o erro
            return InternalServerError(new ApplicationException("Erro ao obter a lista de produtos.", ex));
        }
    }

    // Implementar métodos CRUD para produtos com tratamento de erros
}