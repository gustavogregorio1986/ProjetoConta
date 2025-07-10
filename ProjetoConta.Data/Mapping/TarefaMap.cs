using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoConta.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoConta.Data.Mapping
{
    public class TarefaMap : IEntityTypeConfiguration<Tarefa>
    {
        public void Configure(EntityTypeBuilder<Tarefa> builder)
        {
            builder.ToTable("tb_Tarefa");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Titulo)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(t => t.Descricao)
                .IsRequired()
                .HasColumnType("varchar(MAX)");

            builder.Property(t => t.Status)
                .IsRequired()
                .HasColumnType("varchar(40)");

            builder.Property(t => t.DataCriacao)
               .IsRequired()
               .HasColumnType("DATETIME");

            builder.Property(t => t.DataConclusao)
               .HasColumnType("DATETIME");
        }
    }
}
