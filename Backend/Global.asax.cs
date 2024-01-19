rotected void Application_Start()
{
    // Configura��o de rotas, formatters, etc.

    // Inje��o de depend�ncia
    var container = new UnityContainer();
container.RegisterType<IProdutoService, ProdutoService>();
container.RegisterType<IUsuarioService, UsuarioService>();
container.RegisterType<IVendaService, VendaService>();

GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
}