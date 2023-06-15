using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using VascoVasconcellos.DAO.AppDbContext;
using VascoVasconcellos.DAO.Interface.IRepository;
using VascoVasconcellos.DAO.Interface.IService;
using VascoVasconcellos.DAO.Models;
using VascoVasconcellos.DAO.Repository;
using VascoVasconcellos.DAO.Service;

namespace VascoVasconcellos.API
{
    public class Program
    {

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var services = builder.Services;


            #region Service
            services.AddScoped<IServiceEtiqueta, ServiceEtiqueta>();
            services.AddScoped<IServiceLogAcesso, ServiceLogAcesso>();
            services.AddScoped<IServiceLogErro, ServiceLogErro>();
            services.AddScoped<IServiceLogOperacao, ServiceLogOperacao>();
            services.AddScoped<IServiceUsuario, ServiceUsuario>();
            services.AddScoped<IServiceVendas, ServiceVendas>();
            services.AddScoped<IServiceBoleta, ServiceBoleta>();
            services.AddScoped<IServiceClientes, ServiceClientes>();
            services.AddScoped<IServiceOrcamentos, ServiceOrcamentos>();
            services.AddScoped<IServiceProdutos, ServiceProdutos>();
            services.AddScoped<IServiceProdutosColunas, ServiceProdutosColunas>();
            #endregion

            #region Repository
            services.AddScoped<IRepositoryEtiqueta, RepositoryEtiqueta>();
            services.AddScoped<IRepositoryLogAcesso,  RepositoryLogAcesso>();
            services.AddScoped<IRepositoryLogErro, RepositoryLogErro>();
            services.AddScoped<IRepositoryLogOperacao, RepositoryLogOperacao>();
            services.AddScoped<IRepositoryLogOperacao, RepositoryLogOperacao>();
            services.AddScoped<IRepositoryUsuario, RepositoryUsuario>();
            services.AddScoped<IRepositoryVendas, RepositoryVendas>();
            services.AddScoped<IRepositoryBoleta, RepositoryBoleta>();
            services.AddScoped<IRepositoryClientes, RepositoryClientes>();
            services.AddScoped<IRepositoryOrcamentos, RepositoryOrcamentos>();
            services.AddScoped<IRepositoryProdutos, RepositoryProdutos>();
            services.AddScoped<IRepositoryProdutosColunas,  RepositoryProdutosColunas>();
            #endregion


            var config = builder.Configuration;
            var env = builder.Environment;

            var connectionString = config.GetConnectionString(env.EnvironmentName);

            services.Configure<DataProtectionTokenProviderOptions>(o =>
                o.TokenLifespan = TimeSpan.FromMinutes(10));

            services.AddDbContext<MySqlDbContext>(options =>
            {
                options.UseMySql(
                    connectionString,
                    ServerVersion.AutoDetect(connectionString)
                    );
            });

            services.AddDefaultIdentity<AspNetUsers>(options =>
                options.SignIn.RequireConfirmedAccount = false
            ).AddRoles<IdentityRole>().AddEntityFrameworkStores<MySqlDbContext>();

            services.ConfigureApplicationCookie(config =>
            {
                config.LoginPath = "/Account/Login";
            });

			services.AddControllers()
				.AddNewtonsoftJson(options =>
				options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
			);

			services.AddMvc(options => options.EnableEndpointRouting = false);
			services.AddRazorPages();
			services.AddControllersWithViews()
				.AddRazorRuntimeCompilation()
				.AddNewtonsoftJson(options =>
				options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
			);

			// Add services to the container.
			builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Dashboard/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Dashboard}/{action=Index}/{id?}");

            app.MapRazorPages();

            app.Run();
        }
    }
}