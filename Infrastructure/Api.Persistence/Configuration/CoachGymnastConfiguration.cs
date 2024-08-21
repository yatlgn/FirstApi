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
    public class CoachGymnastConfiguration :IEntityTypeConfiguration<CoachGymnast>
    {
        public void Configure(EntityTypeBuilder<CoachGymnast> builder)
        {
            builder.HasKey(cg => cg.Id);
            builder.HasOne(cg => cg.Gymnast)
                .WithMany()
                .HasForeignKey(cg => cg.GymnastId);


            builder.HasOne(cg => cg.Coach)
                .WithMany()
                .HasForeignKey(cg => cg.CoachId);
        }
    }
}
