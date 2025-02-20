using ProjetoAcademico.Domain.Enumerators;

namespace ProjetoAcademico.Domain.DTOs.ProfessorDto.Atualizar;

public class ProfessorAtualizarDto
{
    public Guid Id { get; set; }
    public required string Nome { get; set; }
    public string Biografia { get; set; }
}