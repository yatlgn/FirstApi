using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Persistence.Configuration
{
    public class DifficultyConfiguration : IEntityTypeConfiguration<Difficulty>
    {
        public void Configure(EntityTypeBuilder<Difficulty> builder)
        {
            builder.HasKey(d => d.DifficultyName);

            builder.Property(d => d.DifficultyType)
                .IsRequired();

            builder.Property(d => d.DifficultyPoint);
        }
    }
}
