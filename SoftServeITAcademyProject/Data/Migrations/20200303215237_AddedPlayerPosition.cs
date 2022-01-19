﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace SoftServeITAcademyProject.Data.Migrations
{
    public partial class AddedPlayerPosition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Position",
                table: "Players",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Position",
                table: "Players");
        }
    }
}
