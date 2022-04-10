using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CodeIDBootcampeMVC.Data;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<CodeIDBootcampeMVCContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CodeIDBootcampeMVCContext")));

// Add services to the container.
builder.Services.AddControllersWithViews();

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

/*app.MapControllerRoute(
    name: "default",
    pattern: "{controller=HelloWorld}/{action=addition}/{a?}/{b?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Student}/{action=Class}/{roomNumber?}/{floor?}");*/

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Student}/{action=Exam}/{topics?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Student}/{action=Profile}/{name?}/{age?}/{address?}");

var builders = WebApplication.CreateBuilder(args);
builders.Services.AddDbContext<CodeIDBootcampeMVCContext>(option => option.UseSqlServer(builders.Configuration.GetConnectionString("CodeIDBootcampeMVCContext")));

 app.Run();
