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
    public class GymnastParentConfiguration : IEntityTypeConfiguration<GymnastParent>
    {
        public void Configure(EntityTypeBuilder<GymnastParent> builder)
        {
            builder.HasKey(cg => cg.Id);
            builder.HasOne(cg => cg.Gymnast)
                .WithMany()
                .HasForeignKey(cg => cg.GymnastId);


            builder.HasOne(cg => cg.Parent)
                .WithMany()
                .HasForeignKey(cg => cg.ParentId);
        }
    }
}

