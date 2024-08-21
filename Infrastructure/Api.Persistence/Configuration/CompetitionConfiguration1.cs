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
    public class CompetitionConfiguration : IEntityTypeConfiguration<Competition>
    {
        public void Configure(EntityTypeBuilder<Competition> builder)
        {
            builder.HasKey(c => c.CompetitionId);

            builder.Property(c => c.CompetitionName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(c => c.CompetitionHall)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(c => c.CompetitionType)
                .IsRequired();

            builder.Property(c => c.CompetitionDate)
                .IsRequired();
        }
    }
}
