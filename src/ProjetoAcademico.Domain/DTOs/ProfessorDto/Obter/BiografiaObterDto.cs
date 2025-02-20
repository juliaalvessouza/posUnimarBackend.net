using ProjetoAcademico.Domain.Enumerators;

namespace ProjetoAcademico.Domain.DTOs.BiografiaDto.Obter;

public class BiografiaObterDto
{
    public Guid Id { get; set; }
    public required string Nome { get; set; }
    public string Biografia { get; set; }
}