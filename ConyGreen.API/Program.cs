using ConyGreen.DAO.DbContext;
using ConyGreen.DAO.IRepository;
using ConyGreen.DAO.IService;
using ConyGreen.DAO.Models;
using ConyGreen.DAO.Repository;
using ConyGreen.DAO.Service;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ConyGreen.API
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			var services = builder.Services;


			#region Service
			services.AddScoped<IServiceRomaneio, ServiceRomaneio>();
			services.AddScoped<IServiceUsuario, ServiceUsuario>();
			services.AddScoped<IServiceLogAcesso, ServiceLogAcesso>();
			#endregion

			#region Repository
			services.AddScoped<IRepositoryRomaneio, RepositoryRomaneio>();
			services.AddScoped<IRepositoryUsuario, RepositoryUsuario>();
			services.AddScoped<IRepositoryLogAcesso,  RepositoryLogAcesso>();
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

			services.AddDefaultIdentity<AspNetUser>(options =>
				options.SignIn.RequireConfirmedAccount = false
			).AddRoles<IdentityRole>().AddEntityFrameworkStores<MySqlDbContext>();

			services.ConfigureApplicationCookie(config =>
			{
				config.LoginPath = "/Account/Login";
			});

			builder.Services.AddRazorPages()
				.AddRazorRuntimeCompilation();

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

			app.Run();
		}
	}
}