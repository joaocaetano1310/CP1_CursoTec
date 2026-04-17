using CP1_CursoTec.Domain.Entities;

namespace CP1_CursoTec.Application.Interfaces;

/// <summary>
/// Interface do serviço de alunos.
/// Define as operações CRUD e consultas disponíveis para a entidade Aluno.
/// </summary>
public interface IAlunoService
{
    /// <summary>
    /// Cria um novo aluno no sistema.
    /// </summary>
    Aluno CreateAluno(Aluno aluno);

    /// <summary>
    /// Busca um aluno pelo Id.
    /// </summary>
    Aluno? GetById(Guid id);

    /// <summary>
    /// Busca um aluno pelo e-mail.
    /// </summary>
    Aluno? GetByEmail(string email);

    /// <summary>
    /// Retorna todos os alunos ativos.
    /// </summary>
    IReadOnlyList<Aluno> GetAll();

    /// <summary>
    /// Atualiza os dados de um aluno.
    /// </summary>
    Aluno UpdateAluno(Guid id, string? nome, string? email, DateOnly? dataNascimento);

    /// <summary>
    /// Desativa um aluno (soft delete).
    /// </summary>
    bool DeactivateAluno(Guid id);

    /// <summary>
    /// Reativa um aluno.
    /// </summary>
    bool ActivateAluno(Guid id);

    /// <summary>
    /// Verifica se email já existe.
    /// </summary>
    bool EmailExists(string email, Guid? excludeId = null);
}