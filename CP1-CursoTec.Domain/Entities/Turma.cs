using CP1_CursoTec.Domain.Commom;

namespace CP1_CursoTec.Domain.Entities;

public class Turma : BaseEntity
{
    public Guid Id { get; private set; }
    public DateTime DataInicio { get; private set; }
    public DateTime? DataFim { get; private set; }
    public Guid ProfessorId { get; private set; }
    public Curso? Curso { get; private set; }
    public Professor? Professor { get; private set; }
    
    public ICollection<Aula> Aulas { get; private set; } = new List<Aula>();

    public Turma(Guid id, DateTime dataInicio, DateTime? dataFim, Guid professorId, Curso? curso, Professor? professor)
    {
        Id = id;
        DataInicio = dataInicio;
        DataFim = dataFim;
        ProfessorId = professorId;
        Curso = curso;
        Professor = professor;
    }
}
