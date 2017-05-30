using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using georgia;

namespace georgia.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20170528195204_PhotoEntity")]
    partial class PhotoEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("georgia.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FilePath");

                    b.Property<Guid>("PhotoUid");

                    b.Property<string>("Slug");

                    b.HasKey("Id");

                    b.ToTable("Photo");
                });
        }
    }
}
