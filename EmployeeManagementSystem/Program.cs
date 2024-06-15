using EmployeeManagementSystem.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EmployeeManagementSystem.Data;
using Microsoft.AspNetCore.Identity;
using EmployeeManagementSystem.Repository;

namespace EmployeeManagementSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<EmployeeManagementSystemContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("EmployeeManagementSystemContext") ?? throw new InvalidOperationException("Connection string 'EmployeeManagementSystemContext' not found.")));

            builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

           builder.Services.AddQuickGridEntityFrameworkAdapter();;
            builder.Services.AddScoped<IFlightRepository, FlightRepository>();

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.MapRazorComponents<App>().AddInteractiveServerRenderMode();

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
