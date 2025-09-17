// Program.cs

using Microsoft.EntityFrameworkCore;
using ST10282092_PROG6212_POE.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.Equals("ClaimsDB")); // 🔹 Use InMemory DB for demo

var app = builder.Build();

// Middleware
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// Default route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Claims}/{action=Lecturer}/{id?}");

app.Run();