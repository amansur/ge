using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace georgia.Migrations
{
    public partial class AddFileEnding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FileEnding",
                table: "Photo",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileEnding",
                table: "Photo");
        }
    }
}
