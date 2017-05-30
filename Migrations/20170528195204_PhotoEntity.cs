using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace georgia.Migrations
{
    public partial class PhotoEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FilePath",
                table: "Photo",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PhotoUid",
                table: "Photo",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "Photo",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FilePath",
                table: "Photo");

            migrationBuilder.DropColumn(
                name: "PhotoUid",
                table: "Photo");

            migrationBuilder.DropColumn(
                name: "Slug",
                table: "Photo");
        }
    }
}
