using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coach",
                columns: table => new
                {
                    CoachId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    Branch = table.Column<int>(type: "int", nullable: false),
                    Brevet = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coach", x => x.CoachId);
                });

            migrationBuilder.CreateTable(
                name: "Competition",
                columns: table => new
                {
                    CompetitionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompetitionName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CompetitionHall = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CompetitionType = table.Column<int>(type: "int", nullable: false),
                    CompetitionDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competition", x => x.CompetitionId);
                });

            migrationBuilder.CreateTable(
                name: "Difficulty",
                columns: table => new
                {
                    DifficultyName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DifficultyType = table.Column<int>(type: "int", nullable: false),
                    DifficultyPoint = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Difficulty", x => x.DifficultyName);
                });

            migrationBuilder.CreateTable(
                name: "Gymnast",
                columns: table => new
                {
                    GymnastId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    BMI = table.Column<double>(type: "float", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gymnast", x => x.GymnastId);
                });

            migrationBuilder.CreateTable(
                name: "Parent",
                columns: table => new
                {
                    ParentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    Job = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNum = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parent", x => x.ParentId);
                });

            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    SeriesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalPoint = table.Column<double>(type: "float", nullable: false),
                    SeriesReceivingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SeriesMinute = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.SeriesId);
                });

            migrationBuilder.CreateTable(
                name: "Workout",
                columns: table => new
                {
                    WorkoutType = table.Column<int>(type: "int", nullable: false),
                    WorkoutDays = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    WorkoutHours = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workout", x => x.WorkoutType);
                });

            migrationBuilder.CreateTable(
                name: "CoachGymnast",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GymnastId = table.Column<int>(type: "int", nullable: false),
                    CoachId = table.Column<int>(type: "int", nullable: false),
                    CoachId1 = table.Column<int>(type: "int", nullable: true),
                    GymnastId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoachGymnast", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoachGymnast_Coach_CoachId",
                        column: x => x.CoachId,
                        principalTable: "Coach",
                        principalColumn: "CoachId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoachGymnast_Coach_CoachId1",
                        column: x => x.CoachId1,
                        principalTable: "Coach",
                        principalColumn: "CoachId");
                    table.ForeignKey(
                        name: "FK_CoachGymnast_Gymnast_GymnastId",
                        column: x => x.GymnastId,
                        principalTable: "Gymnast",
                        principalColumn: "GymnastId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoachGymnast_Gymnast_GymnastId1",
                        column: x => x.GymnastId1,
                        principalTable: "Gymnast",
                        principalColumn: "GymnastId");
                });

            migrationBuilder.CreateTable(
                name: "CompetitionGymnast",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GymnastId = table.Column<int>(type: "int", nullable: false),
                    CompetitionId = table.Column<int>(type: "int", nullable: false),
                    CompetitionId1 = table.Column<int>(type: "int", nullable: true),
                    GymnastId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetitionGymnast", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompetitionGymnast_Competition_CompetitionId",
                        column: x => x.CompetitionId,
                        principalTable: "Competition",
                        principalColumn: "CompetitionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompetitionGymnast_Competition_CompetitionId1",
                        column: x => x.CompetitionId1,
                        principalTable: "Competition",
                        principalColumn: "CompetitionId");
                    table.ForeignKey(
                        name: "FK_CompetitionGymnast_Gymnast_GymnastId",
                        column: x => x.GymnastId,
                        principalTable: "Gymnast",
                        principalColumn: "GymnastId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompetitionGymnast_Gymnast_GymnastId1",
                        column: x => x.GymnastId1,
                        principalTable: "Gymnast",
                        principalColumn: "GymnastId");
                });

            migrationBuilder.CreateTable(
                name: "GymnastParent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GymnastId = table.Column<int>(type: "int", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    GymnastId1 = table.Column<int>(type: "int", nullable: true),
                    ParentId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GymnastParent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GymnastParent_Gymnast_GymnastId",
                        column: x => x.GymnastId,
                        principalTable: "Gymnast",
                        principalColumn: "GymnastId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GymnastParent_Gymnast_GymnastId1",
                        column: x => x.GymnastId1,
                        principalTable: "Gymnast",
                        principalColumn: "GymnastId");
                    table.ForeignKey(
                        name: "FK_GymnastParent_Parent_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Parent",
                        principalColumn: "ParentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GymnastParent_Parent_ParentId1",
                        column: x => x.ParentId1,
                        principalTable: "Parent",
                        principalColumn: "ParentId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CoachGymnast_CoachId",
                table: "CoachGymnast",
                column: "CoachId");

            migrationBuilder.CreateIndex(
                name: "IX_CoachGymnast_CoachId1",
                table: "CoachGymnast",
                column: "CoachId1");

            migrationBuilder.CreateIndex(
                name: "IX_CoachGymnast_GymnastId",
                table: "CoachGymnast",
                column: "GymnastId");

            migrationBuilder.CreateIndex(
                name: "IX_CoachGymnast_GymnastId1",
                table: "CoachGymnast",
                column: "GymnastId1");

            migrationBuilder.CreateIndex(
                name: "IX_CompetitionGymnast_CompetitionId",
                table: "CompetitionGymnast",
                column: "CompetitionId");

            migrationBuilder.CreateIndex(
                name: "IX_CompetitionGymnast_CompetitionId1",
                table: "CompetitionGymnast",
                column: "CompetitionId1");

            migrationBuilder.CreateIndex(
                name: "IX_CompetitionGymnast_GymnastId",
                table: "CompetitionGymnast",
                column: "GymnastId");

            migrationBuilder.CreateIndex(
                name: "IX_CompetitionGymnast_GymnastId1",
                table: "CompetitionGymnast",
                column: "GymnastId1");

            migrationBuilder.CreateIndex(
                name: "IX_GymnastParent_GymnastId",
                table: "GymnastParent",
                column: "GymnastId");

            migrationBuilder.CreateIndex(
                name: "IX_GymnastParent_GymnastId1",
                table: "GymnastParent",
                column: "GymnastId1");

            migrationBuilder.CreateIndex(
                name: "IX_GymnastParent_ParentId",
                table: "GymnastParent",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_GymnastParent_ParentId1",
                table: "GymnastParent",
                column: "ParentId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoachGymnast");

            migrationBuilder.DropTable(
                name: "CompetitionGymnast");

            migrationBuilder.DropTable(
                name: "Difficulty");

            migrationBuilder.DropTable(
                name: "GymnastParent");

            migrationBuilder.DropTable(
                name: "Series");

            migrationBuilder.DropTable(
                name: "Workout");

            migrationBuilder.DropTable(
                name: "Coach");

            migrationBuilder.DropTable(
                name: "Competition");

            migrationBuilder.DropTable(
                name: "Gymnast");

            migrationBuilder.DropTable(
                name: "Parent");
        }
    }
}
