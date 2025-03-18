
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;

namespace MVC02
{
    static public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();


            app.UseRouting();

            app.UseStaticFiles();

            app.MapGet("/", () => "Hello World!");

            #region Static Routing

            //app.MapGet("/Home", async context =>
            //{
            //    await context.Response.WriteAsync("Hello in Home");
            //});

            #endregion


            #region Dynamic Routing

            //app.MapGet("/{name}", async context =>
            //{
            //    var name = context.GetRouteValue("name");
            //    await context.Response.WriteAsync($"Hello {name} (:");
            //});

            #endregion


            #region Mixed Routing

            //app.MapGet("/XYZ{name}", async context =>
            //{
            //    var name = context.GetRouteValue("name");
            //    await context.Response.WriteAsync($"==> {name} <==");
            //});

            #endregion


            //app.MapControllerRoute(
            //    name:"Default",
            //    pattern:"/{controller}/{action}/{Id?}" ,// Id is optional
            //    defaults: new { action = "Index" , controller ="Cars"},
            //    constraints: new { Id = new IntRouteConstraint()});

            app.MapControllerRoute(
               name: "Default",
               pattern: "/{controller=Cars}/{action=Index}/{Id:int?}");


            app.Run();
        }
    } 
} 