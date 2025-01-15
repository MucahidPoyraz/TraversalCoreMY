using Microsoft.EntityFrameworkCore.Migrations;

namespace TraversalCoreMY.DAL.Migrations
{
    public partial class destination_detail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CoverImage",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ManinDetail",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondaryDetail",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondaryImage",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoverImage",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "ManinDetail",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "SecondaryDetail",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "SecondaryImage",
                table: "Destinations");
        }
    }
}
