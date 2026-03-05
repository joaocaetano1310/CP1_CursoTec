using CP1_CursoTec.Domain.Entities;

namespace CP1_CursoTec.Application.DTO;

public class CreateAlunoRequest(string nome, string email, string cpf, DateOnly datanascimento, Turma Turma)
{
    public Aluno ToDomain()
    {
        return new Aluno(nome, email, cpf, datanascimento, Turma);
    } 
}