using Desafio.Lancamento.Application.Operacao.AppServices;
using Desafio.Lancamento.Application.Operacao.Contracts.Interfaces;
using Desafio.Lancamento.Domain.Operacao.Commands.PersistirOperacao;
using Desafio.Lancamento.Domain.Operacao.Handlers.PersistirOperacao;
using Desafio.Lancamento.Infra.Core.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using SimpleInjector;
using Swashbuckle.AspNetCore.SwaggerUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Lancamento.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Container container = new SimpleInjector.Container();


        public Startup(IConfiguration configuration)
        {
            container.Options.ResolveUnregisteredConcreteTypes = false;
            Configuration = configuration;
        }



        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Desafio para Arquiteto - Controle de Lancamentos",
                    Version = "v1",
                });
            });

            //services.AddDbContext<SQLContext>(options => options.UseMySQL(Configuration.GetConnectionString("MySQL")));

            services.AddControllers();
            services.AddSimpleInjector(container, options =>
            {
                options.AddAspNetCore()
                    .AddControllerActivation();

                options.AddLogging();
            });

            InitializeContainer();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSimpleInjector(container);

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Desafio.Lancamento.API");
                c.DocExpansion(DocExpansion.None);
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            container.Verify(); ;
        }

        private void InitializeContainer()
        {
            container.Register<IPersistirOperacaoApp, PersistirOperacaoApp>(Lifestyle.Scoped);

            container.Register<ICommandHandler<PersistirOperacaoCommand>, PersistirOperacaoHandler>(Lifestyle.Scoped);


        }

    }
}




