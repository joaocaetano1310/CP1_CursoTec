using CP1_CursoTec.Domain.Entities;

namespace CP1_CursoTec.Domain.Interfaces;

public interface IAlunoService
{
    Aluno CreateAluno(string nome, string email, string cpf, DateOnly dataNascimento);

    Aluno GetAlunoByEmail(string email);
}