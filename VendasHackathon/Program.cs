using Microsoft.EntityFrameworkCore;
using VendasHackathon.DataContext;
using VendasHackathon.Middleware;
using VendasHackathon.Repositories.Cliente;
using VendasHackathon.Repositories.Venda;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
// AQUI EU DIGO: TODA VEZ QUE EU CHAMAR O ICLIENTEREPO, NA VERDADE EU ESTOU ME REFERINDO AO CLIENTE REPOSITORY (REGRA DE NEGOCIO)
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<IVendaRepository, VendaRepository>();
// AQUI EU ME CONECTO COM MEU BANCO DE DADOS
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

// Middleware para tratamento de exceções
app.UseMiddleware<ExceptionMiddleware>();

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
