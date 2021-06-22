using LojaIO.Catalogo.Application.Services;
using LojaIO.Catalogo.Data;
using LojaIO.Catalogo.Data.Repository;
using LojaIO.Catalogo.Domain;
using LojaIO.Catalogo.Domain.Events;
using LojaIO.Core.Bus;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace LojaIO.WebApp.MVC.Setup
{
    public static class DependencyInjection
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            // Domain Bus (Mediator)
            services.AddScoped<IMediatrHandler, MediatrHandler>();

            // Catalogo
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IProdutoAppService, ProdutoAppService>();
            services.AddScoped<IEstoqueService, EstoqueService>();
            services.AddScoped<CatalogoContext>();

            services.AddScoped<INotificationHandler<ProdutoAbaixoEstoqueEvent>, ProdutoEventHandler>();
        }
    }
}
