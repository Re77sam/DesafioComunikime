[Route("api/usuarios")]
public class UsuarioController : ApiController
{
    private readonly IUsuarioService _usuarioService;

    public UsuarioController(IUsuarioService usuarioService)
    {
        _usuarioService = usuarioService;
    }

    [HttpGet]
    public IHttpActionResult GetAllUsuarios()
    {
        try
        {
            var usuarios = _usuarioService.GetAll();
            return Ok(usuarios);
        }
        catch (Exception ex)
        {
            // Logar o erro
            return InternalServerError(new ApplicationException("Erro ao obter a lista de usu�rios.", ex));
        }
    }

    // Implementar m�todos CRUD para usu�rios com tratamento de erros
}