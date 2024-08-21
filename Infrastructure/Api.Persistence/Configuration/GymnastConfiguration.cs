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
    public class GymnastConfiguration : IEntityTypeConfiguration<Gymnast>
    {
        public void Configure(EntityTypeBuilder<Gymnast> builder)
        {
            builder.HasKey(g => g.GymnastId);

            builder.Property(g => g.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(g => g.Surname)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(g => g.Birthdate)
                .IsRequired();

            builder.Property(g => g.Height);

            builder.Property(g => g.Weight);

            builder.Property(g => g.BMI);

            builder.Property(g => g.Category)
                .IsRequired();


        }
    }
}
