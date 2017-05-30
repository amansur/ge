using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using georgia;

namespace georgia.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("georgia.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<byte[]>("Binary");

                    b.Property<string>("FileEnding");

                    b.Property<string>("FilePath");

                    b.Property<Guid>("PhotoUid");

                    b.Property<string>("Slug");

                    b.HasKey("Id");

                    b.ToTable("Photo");
                });
        }
    }
}
