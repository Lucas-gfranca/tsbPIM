using Controle.Data;
using Controle.Repositorio;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddEntityFrameworkSqlServer().AddDbContext<BancoContext>
    (options => options.UseSqlServer("Data Source=DESKTOP-AHRL1NB;Initial Catalog=Pim;Integrated Security=False"));

//builder.Services.AddDbContext<BancoContext>
  //  (options => options.UseSqlServer
   //("Data Source=DESKTOP-AHRL1NB;Initial Catalog=Pim;Integrated Security=False"));

builder.Services.AddScoped<IContatoRepositorio, ContatoRepositorio>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
