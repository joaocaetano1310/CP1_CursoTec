using CP1_CursoTec.Domain.Entities;

namespace CP1_CursoTec.Domain.Interfaces;

public interface ITurmaService
{
    Turma CreateTurma(string nomeTurma, DateTime dataInicio, DateTime? dataFim);

    Turma GetTurmaById(Guid id);
}