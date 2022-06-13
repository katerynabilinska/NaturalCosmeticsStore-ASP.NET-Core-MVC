using Microsoft.EntityFrameworkCore;
using NaturalCosmeticsStore.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddTransient<IEmailSender, EmailSender>();
builder.Services.AddDbContext<DataContext>( options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("Context")));

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
