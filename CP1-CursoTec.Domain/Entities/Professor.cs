using CP1_CursoTec.Domain.Commom;

namespace CP1_CursoTec.Domain.Entities;

public class Professor : BaseEntity
{
    public Guid ProfessorId { get; private set; }
    public string Nome { get; private set; } 
    public string Email { get; private set; } 
    public string? Especialidade { get; private set; }

    public Professor(string nome, string email, string? especialidade)
    {
        Nome = nome;
        Email = email;
        Especialidade = especialidade;
    }
}