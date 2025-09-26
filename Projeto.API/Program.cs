using Microsoft.EntityFrameworkCore;
using Projeto.Data;
using Projeto.Data.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<UsuarioRepository>();


builder.Services.AddDbContext<ProjetoContext>(options =>
                options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

var serviceScope = app.Services.GetService<IServiceScopeFactory>().CreateScope();
var context = serviceScope.ServiceProvider.GetRequiredService<ProjetoContext>();
context.Database.Migrate();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
