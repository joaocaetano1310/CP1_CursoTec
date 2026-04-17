using CP1_CursoTec.Domain.Entities;

namespace CP1_CursoTec.Domain.Interfaces;

public interface IProfessorService
{
    Professor CreateProfessor(string nome, string email, string especialidade);

    Professor GetProfessorByEmail(string email);
}