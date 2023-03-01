using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SalesWebMvc.Data;
using VendasWebMvc.Data;
using VendasWebMvc.Models;
using VendasWebMvc.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<VendasWebMvcContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("VendasWebMvcContext")));

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<SeedingService>();
builder.Services.AddScoped<Seller>();
builder.Services.AddScoped<Department>();
builder.Services.AddScoped<SalesRecord>();
builder.Services.AddScoped<SellerServices>();

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
