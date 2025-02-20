using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoAcademico.Domain.Entities;

namespace ProjetoAcademico.Infra.Data.Configurations
{
    public class ProfessorConfiguration : IEntityTypeConfiguration<Professor>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.Biografia)
                .IsRequired(false)
                .HasMaxLength(500);

            builder.ToTable("TB_Professor");
        }
    }
}
