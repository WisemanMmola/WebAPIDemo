using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPIDemo.Migrations
{
    /// <inheritdoc />
    public partial class AddFirstTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Learners",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LearnerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LearnerSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LearnerEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LearnerPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LearnerIdNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Learners", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Learners");
        }
    }
}
