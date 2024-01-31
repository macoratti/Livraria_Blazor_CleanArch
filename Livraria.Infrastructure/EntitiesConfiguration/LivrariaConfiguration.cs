using Livraria.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Infrastructure.EntitiesConfiguration;

public class LivrariaConfiguration : IEntityTypeConfiguration<Livro>
{
    public void Configure(EntityTypeBuilder<Livro> builder)
    {
        builder.HasKey(t => t.LivroId);
        builder.Property(p => p.Titulo).HasMaxLength(150).IsRequired();
        builder.Property(p => p.Autor).HasMaxLength(200).IsRequired();
        builder.Property(p => p.Lancamento).IsRequired();
        builder.Property(p => p.Capa).HasMaxLength(200);
    }
}
