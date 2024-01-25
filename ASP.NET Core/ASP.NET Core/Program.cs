using ASP.NET_Core.Models;
using ASP.NET_Core.Models.DBContext;
using ASP.NET_Core.Models.Inicializador;
using ASP.NET_Core.Models.Interfaces;
using ASP.NET_Core.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//Transient Devuelve una instancia nueva y limpia

//Singleton Devuelve la misma instancia para toda la app

//Scoped Devuelve una instancia que dura lo que dura la solicitud que la haya traido
builder.Services.AddScoped<ICategoryRepository,CategoryService>();
builder.Services.AddScoped<IPieRepository, PieService>();

//Servicio para que el proyecto conozca MVC
builder.Services.AddControllersWithViews();
//Agrego el servicio de DbContext y dentro uso la propiedad Confifuration del objeto Builder
//para poder acceder al ConnectionString dentro de mi appsettings.json y asignarle el servidor
//que debe usar a mi DBContext
builder.Services.AddDbContext<BethanysPieShopDBContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration["ConnectionStrings:BethanysPieShopDbContextConnection"]);
});

var app = builder.Build();

//Middleware
app.UseStaticFiles();

if(app.Environment.IsDevelopment())
    app.UseDeveloperExceptionPage();

//Resultado de la ruta ejemplo:
app.MapDefaultControllerRoute();// {controller = Home}/{action = Index}/{ Id? }

DbInitializer.Seed(app);

app.Run();
