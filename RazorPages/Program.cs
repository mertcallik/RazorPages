using Microsoft.EntityFrameworkCore;
using RazorPages.Data.Abstract;
using RazorPages.Data.Concreate;
using RazorPages.Data.Concreate.EfCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddScoped<IEmployeeRepository, EfEmployeeRepository>();
builder.Services.AddDbContext<DataContext>(options=>options.UseMySql(builder.Configuration.GetConnectionString("mysql_connection"),ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("mysql_connection"))));
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
