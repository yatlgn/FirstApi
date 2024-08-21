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
    public class WorkoutsConfiguration : IEntityTypeConfiguration<Workout>
    {
        public void Configure(EntityTypeBuilder<Workout> builder)
        {
            builder.HasKey(w => w.WorkoutType);

            builder.Property(w => w.WorkoutDays)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(w => w.WorkoutHours);
        }
    }
}
