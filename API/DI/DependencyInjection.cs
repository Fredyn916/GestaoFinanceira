using DAO;
using DAO.Interface;
using Services;
using Services.Interface;

namespace API.DI;

public static class DependencyInjection
{
    public static void Inject(WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();

       builder.Services.AddScoped<IUsuarioService, UsuarioService>();
    }
}