using CP1_CursoTec.Domain.Commom;

namespace CP1_CursoTec.Domain.Entities;

public class Professor : BaseEntity
{
    public Guid ProfessorId { get; private set; }
    public string Nome { get; private set; } 
    public string Email { get; private set; } 
    public string? Especialidade { get; private set; }
    
    public Turma? Turma { get; private set; }
    
    protected Professor() { }

    public Professor(string nome, string email, string? especialidade, Turma turma)
        // ...
    {
        Nome = nome;
        Email = email;
        Especialidade = especialidade;
        Turma = turma;
    }
    public Professor(string name, string email, string especialidade)
    {
        UpdateNome(name);
        UpdateEmail(email);
        UpdateEspecialidade(especialidade);
    }
    
    public void UpdateNome(string newName)
    {
        if (string.IsNullOrWhiteSpace(newName))
            throw new Exception("Nome não pode ser vazio.");
        
        Nome = newName;
    }

    public void UpdateEmail(string newEmail)
    {
        if (string.IsNullOrWhiteSpace(newEmail) || !newEmail.Contains("@"))
            throw new Exception("E-mail inválido.");
            
        Email = newEmail;
    }

    public void UpdateEspecialidade(string newEspecialidade)
    {
        if (string.IsNullOrWhiteSpace(newEspecialidade))
            throw new Exception("Especialidade requerida.");
        
        Especialidade = newEspecialidade;
    } 
}