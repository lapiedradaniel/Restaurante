using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Restaurante.Context;
using Restaurante.Services.Copa;
using Restaurante.Services.Cozinha;
using Restaurante.Services.Interface;
using Restaurante.Services.Pedidos;

namespace Restaurante
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var connection = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connection));

            builder.Services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();

            builder.Services.AddScoped<PedidoService>();
            builder.Services.AddScoped<CozinhaService>();
            builder.Services.AddScoped<CopaService>();

            
            builder.Services.AddScoped<ISeedUserRoleInitial, SeedUserRoleInitial>();

            var app = builder.Build();

            
            CriarPerfisUsuarios(app);

            
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }

        private static void CriarPerfisUsuarios(WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var seeder = scope.ServiceProvider.GetRequiredService<ISeedUserRoleInitial>();
                seeder.SeedRoles();
                seeder.SeedUsers();
            }
        }
    }
}

