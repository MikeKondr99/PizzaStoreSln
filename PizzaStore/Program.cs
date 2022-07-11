using Microsoft.EntityFrameworkCore;
using PizzaStore.Database;
using PizzaStore.Services;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;
var services = builder.Services;

// Add services to the container.
services.AddControllersWithViews();
services.AddDbContext<DatabaseContext>();
if (config["UseDatabase"] == "true")
{
    services.AddScoped<IProductService, ProductDBService>();
}
else
{
    services.AddSingleton<IProductService, ProductListService>();
}




var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
