rotected void Application_Start()
{
    // Configuração de rotas, formatters, etc.

    // Injeção de dependência
    var container = new UnityContainer();
container.RegisterType<IProdutoService, ProdutoService>();
container.RegisterType<IUsuarioService, UsuarioService>();
container.RegisterType<IVendaService, VendaService>();

GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
}