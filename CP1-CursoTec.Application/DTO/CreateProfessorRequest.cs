using CP1_CursoTec.Domain.Entities;

namespace CP1_CursoTec.Application.DTO;

public class CreateProfessorRequest(string nome, string email, string? especialidade, Turma turma)
{
    public Professor ToDomain()
    {
        return new Professor(nome, email, especialidade, turma);
    }
}