﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreProject.DataAccessLayer.Migrations
{
    public partial class updateTestimonialTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Testimonials",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Testimonials");
        }
    }
}
