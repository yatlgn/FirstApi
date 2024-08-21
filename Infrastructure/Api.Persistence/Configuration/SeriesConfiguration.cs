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
    public class SeriesConfiguration : IEntityTypeConfiguration<Series>
    {
        public void Configure(EntityTypeBuilder<Series> builder)
        {
            builder.HasKey(s => s.SeriesId);

            builder.Property(s => s.TotalPoint);

            builder.Property(s => s.SeriesReceivingDate)
                .IsRequired();

            builder.Property(s => s.SeriesMinute);

           
        }
    }
}
