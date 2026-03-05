using CP1_CursoTec.Domain.Entities;

namespace CP1_CursoTec.Application.DTO;

public record CreateAlunoRequest(string Nome, string Email, string Cpf, DateOnly DataNascimento)
{
    public Aluno ToDomain()
    {
        return new Aluno(Nome, Email, Cpf, DataNascimento);
    } 
}