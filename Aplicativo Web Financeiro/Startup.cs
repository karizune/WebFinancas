using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;
using Infra.EntityFramework.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicativo_Web_Financeiro
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddControllers();
            services.AddMvc();

            // services
            services.AddTransient<IAcumuladoService, AcumuladoService>();
            services.AddTransient<IEmpresaService, EmpresaService>();
            services.AddTransient<IGrupoService, GrupoService>();
            services.AddTransient<ILancamentoContabilService, LancamentoContabilService>();
            services.AddTransient<ILancamentoContabilItemService, LancamentoContabilItemService>();
            services.AddTransient<ILancamentoTipoService, LancamentoTipoService>();
            services.AddTransient<IPlanoContaService, PlanoContaService>();
            services.AddTransient<IPlanoContaTipoService, PlanoContaTipoService>();
            services.AddTransient<IUsuarioService, UsuarioService>();

            //repositories
            services.AddTransient<IAcumuladoRepository, AcumuladoRepository>();
            services.AddTransient<IEmpresaRepository, EmpresaRepository>();
            services.AddTransient<IGrupoRepository, GrupoRepository>();
            services.AddTransient<ILancamentoContabilRepository, LancamentoContabilRepository>();
            services.AddTransient<ILancamentoContabilItemRepository, LancamentoContabilItemRepository>();
            services.AddTransient<ILancamentoTipoRepository, LancamentoTipoRepository>();
            services.AddTransient<IPlanoContaRepository, PlanoContaRepository>();
            services.AddTransient<IPlanoContaTipoRepository, PlanoContaTipoRepository>();
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Login}");
            });
        }
    }
}
