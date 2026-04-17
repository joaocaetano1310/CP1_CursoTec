using CP1_CursoTec.Domain.Entities;

namespace CP1_CursoTec.Domain.Interfaces;

public interface ICursoService
{
    Curso CreateCurso(string nome, int cargaHoraria, string? descricao);

    Curso GetCursoByNome(string nome);
}