﻿using FluentValidation;

namespace ProjetoAcademico.Domain.DTOs.ProfessorDto.Atualizar;

public class ProfessorAtualizarDtoValidator : AbstractValidator<ProfessorAtualizarDto>
{
    public ProfessorAtualizarDtoValidator()
    {
        RuleFor(x => x.Nome)
            .NotEmpty().WithMessage("Nome é obrigatório")
            .MaximumLength(50).WithMessage("Nome deve ter no máximo 50 caracteres");

        RuleFor(x => x.Biografia)
    }
}