using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Core.Entites;

namespace TodoApp.Infrastructure.Configurations
{
    public class ToDoitemConfig : IEntityTypeConfiguration<ToDoItem>
    {
        public void Configure(EntityTypeBuilder<ToDoItem> builder)
        {
            builder.Property(t=>t.Title)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(t=>t.Description)
                .IsRequired(false)
                .HasMaxLength(500);

            builder.Property(t => t.IsCompleted)
                .HasDefaultValue(false);

            builder.HasIndex(t => t.Title);

        }
    }
}
