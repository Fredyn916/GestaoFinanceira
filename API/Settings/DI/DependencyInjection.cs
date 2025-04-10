using DAO;
using DAO.Interface;
using Services;
using Services.Interface;

namespace API.Settings.DI;

public static class DependencyInjection
{
    public static void Inject(WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
        builder.Services.AddScoped<IReceitaRepository, ReceitaRepository>();
        builder.Services.AddScoped<IDespesaRepository, DespesaRepository>();

        builder.Services.AddScoped<IUsuarioService, UsuarioService>();
        builder.Services.AddScoped<IReceitaService, ReceitaService>();
        builder.Services.AddScoped<IDespesaService, DespesaService>();
    }
}