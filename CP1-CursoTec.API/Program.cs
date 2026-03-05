using CP1_CursoTec.Application.DTO;

namespace CP1_CursoTec;

public class Program
{
    public static void Main(string[] args)
    {
        var alunoRequest = new CreateAlunoRequest("Raul", "", "", new DateOnly(2005, 09, 19));

        alunoRequest.ToDomain();

        var professorRequest = new CreateProfessorRequest("Thiago", "",  "");
        
        professorRequest.ToDomain();
        
        
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
        builder.Services.AddOpenApi();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
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