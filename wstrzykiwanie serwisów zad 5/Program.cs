using Microsoft.EntityFrameworkCore;
using wstrzykiwanie_serwisów_zad_5;
using wstrzykiwanie_serwisów_zad_5.Data;
using wstrzykiwanie_serwisów_zad_5.Interfaces;
using wstrzykiwanie_serwisów_zad_5.Repositories;
using wstrzykiwanie_serwisów_zad_5.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<PeopleContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase1")));


builder.Services.AddProjectService();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
