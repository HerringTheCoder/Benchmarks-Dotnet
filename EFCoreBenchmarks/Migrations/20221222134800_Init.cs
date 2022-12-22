using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreBenchmarks.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aggregates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aggregates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entity1",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AggregateId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entity1", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entity1_Aggregates_AggregateId",
                        column: x => x.AggregateId,
                        principalTable: "Aggregates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Entity2",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AggregateId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entity2", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entity2_Aggregates_AggregateId",
                        column: x => x.AggregateId,
                        principalTable: "Aggregates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Entity3",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AggregateId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entity3", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entity3_Aggregates_AggregateId",
                        column: x => x.AggregateId,
                        principalTable: "Aggregates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Entity4",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AggregateId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entity4", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entity4_Aggregates_AggregateId",
                        column: x => x.AggregateId,
                        principalTable: "Aggregates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Entity5",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AggregateId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entity5", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entity5_Aggregates_AggregateId",
                        column: x => x.AggregateId,
                        principalTable: "Aggregates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Entity1_AggregateId",
                table: "Entity1",
                column: "AggregateId");

            migrationBuilder.CreateIndex(
                name: "IX_Entity2_AggregateId",
                table: "Entity2",
                column: "AggregateId");

            migrationBuilder.CreateIndex(
                name: "IX_Entity3_AggregateId",
                table: "Entity3",
                column: "AggregateId");

            migrationBuilder.CreateIndex(
                name: "IX_Entity4_AggregateId",
                table: "Entity4",
                column: "AggregateId");

            migrationBuilder.CreateIndex(
                name: "IX_Entity5_AggregateId",
                table: "Entity5",
                column: "AggregateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Entity1");

            migrationBuilder.DropTable(
                name: "Entity2");

            migrationBuilder.DropTable(
                name: "Entity3");

            migrationBuilder.DropTable(
                name: "Entity4");

            migrationBuilder.DropTable(
                name: "Entity5");

            migrationBuilder.DropTable(
                name: "Aggregates");
        }
    }
}
