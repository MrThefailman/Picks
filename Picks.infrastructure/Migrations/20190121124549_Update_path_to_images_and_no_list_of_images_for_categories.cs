using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Picks.infrastructure.Migrations
{
    public partial class Update_path_to_images_and_no_list_of_images_for_categories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Guid",
                table: "Images");

            migrationBuilder.AddColumn<string>(
                name: "Path",
                table: "Images",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Path",
                table: "Images");

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "Images",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
