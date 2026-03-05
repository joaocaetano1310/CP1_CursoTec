using CP1_CursoTec.Domain.Commom;

namespace CP1_CursoTec.Domain.Entities;

public class Turma : BaseEntity
{
    public Guid Id { get; private set; }
    
    public string Nome_turma { get; private set; }
    public DateTime DataInicio { get; private set; }
    public DateTime? DataFim { get; private set; }
    public Guid ProfessorId { get; private set; }
    public Curso? Curso { get; private set; }
    public Professor? Professor { get; private set; }
    
    public ICollection<Aula> Aulas { get; private set; } = new List<Aula>();
    public ICollection<Aluno> Alunos { get; private set; } = new List<Aluno>();
    
    public Turma(Guid id, string NomeTurma, DateTime dataInicio, DateTime? dataFim, Guid professorId, Curso? curso, Professor? professor)
    {
        Id = id;
        Nome_turma = NomeTurma;
        DataInicio = dataInicio;
        DataFim = dataFim;
        ProfessorId = professorId;
        Curso = curso;
        Professor = professor;
    }
    
    public Turma(string nomeTurma, DateTime dataInicio, DateTime dataFim)
    {
        UpdateNome(nomeTurma);
        UpdateDataInicio(dataInicio);
        UpdateDataFim(dataFim);
    }
    
    public void UpdateNome(string newName)
    {
        if (string.IsNullOrWhiteSpace(newName))
            throw new Exception("Nome não pode ser vazio.");
        
        Nome_turma = newName;
    }

    public void UpdateDataInicio(DateTime newData)
    {
        DataInicio = newData;
    }

    public void UpdateDataFim(DateTime newData)
    {
        DataFim = newData;
    }
}
