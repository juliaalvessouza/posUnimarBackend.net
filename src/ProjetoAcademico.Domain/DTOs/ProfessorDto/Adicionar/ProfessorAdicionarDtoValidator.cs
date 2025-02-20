using FluentValidation;

namespace ProjetoAcademico.Domain.DTOs.ProfessorDto.Adicionar
{
    public class ProfessorAdicionarDtoValidator : AbstractValidator<ProfessorAdicionarDto>
    {
        public ProfessorAdicionarDtoValidator()
        {
            RuleFor(p => p.Nome)
                .NotEmpty().WithMessage("Nome é obrigatório")
                .MaximumLength(50).WithMessage("Nome deve ter no máximo 50 caracteres");

            RuleFor(p => p.Biogafia)
        }
    }
}
