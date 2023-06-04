using BackEnd.Relations.DAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); 

builder.Services.AddDbContext<RelationsHome>(opt =>
{
    opt.UseSqlServer("Server=DESKTOP-8R6MOBB\\SQLEXPRESS;Database=ChefRelations; Integrated Security=true");
});

var app = builder.Build();

app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");



app.UseStaticFiles();

app.Run();
