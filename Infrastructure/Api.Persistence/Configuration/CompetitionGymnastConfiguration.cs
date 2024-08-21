using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Persistence.Configuration
{
    public class CompetitionGymnastConfiguration : IEntityTypeConfiguration<CompetitionGymnast>
    {
        public void Configure(EntityTypeBuilder<CompetitionGymnast> builder)
        {
            builder.HasKey(cg => cg.Id);

            builder.HasOne(cg => cg.Gymnast)
                .WithMany()
                .HasForeignKey(cg => cg.GymnastId);


            builder.HasOne(cg => cg.Competition)
                .WithMany()
                .HasForeignKey(cg => cg.CompetitionId);

        }
    }
}
