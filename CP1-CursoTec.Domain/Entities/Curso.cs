namespace CP1_CursoTec.Domain.Entities;

public class Curso
{
    public string Nome { get; private set; }
    public int CargaHoraria { get; private set; }
    public string? Descricao { get; private set; }
    
    public ICollection<Turma> Turmas { get; set; } = new List<Turma>();

    public Curso(string nome, int cargaHoraria, string? descricao)
    {
        Nome = nome;
        CargaHoraria = cargaHoraria;
        Descricao = descricao;
    }
}