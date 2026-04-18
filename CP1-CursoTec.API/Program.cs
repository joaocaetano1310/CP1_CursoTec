using Microsoft.EntityFrameworkCore;
using CP1_CursoTec.Infrastructure.Data;

// 👇 IMPORTANTE (adiciona esses)
using CP1_CursoTec.Application.Interfaces;
using CP1_CursoTec.Infrastructure.Repositories;

namespace CP1_CursoTec;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // 1. Configuração do Banco de Dados
        builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

        // 👇 AQUI você adiciona os repositories
        builder.Services.AddScoped<IAlunoRepository, AlunoRepository>();
        builder.Services.AddScoped<IAulaRepository, AulaRepository>();
        builder.Services.AddScoped<ICursoRepository, CursoRepository>();
        builder.Services.AddScoped<IProfessorRepository, ProfessorRepository>();
        builder.Services.AddScoped<ITurmaRepository, TurmaRepository>();

        // Add services to the container.
        builder.Services.AddControllers();
        builder.Services.AddOpenApi();

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
        }

        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();

        app.Run();
    }
}