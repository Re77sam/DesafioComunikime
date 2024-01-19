[Route("api/vendas")]
public class VendaController : ApiController
{
    private readonly IVendaService _vendaService;

    public VendaController(IVendaService vendaService)
    {
        _vendaService = vendaService;
    }

    [HttpPost]
    public IHttpActionResult RealizarVenda(Venda venda)
    {
        try
        {
            _vendaService.RealizarVenda(venda);
            return Ok("Venda realizada com sucesso!");
        }
        catch (Exception ex)
        {
            // Logar o erro
            return InternalServerError(new ApplicationException("Erro ao realizar a venda.", ex));
        }
    }

    // Implementar outros métodos para vendas com tratamento de erros
}