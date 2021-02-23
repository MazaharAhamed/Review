using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Review.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SecretKey = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewerEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Technical_EmployeeRating = table.Column<int>(type: "int", nullable: false),
                    Technical_EmployeeExplanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Technical_ReviewerRating = table.Column<int>(type: "int", nullable: false),
                    Technical_ReviewerExplanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Communication_EmployeeRating = table.Column<int>(type: "int", nullable: false),
                    Communication_EmployeeExplanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Communication_ReviewerRating = table.Column<int>(type: "int", nullable: false),
                    Communication_ReviewerExplanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InternationalLeadership_EmployeeRating = table.Column<int>(type: "int", nullable: false),
                    InternationalLeadership_EmployeeExplanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InternationalLeadership_ReviewerRating = table.Column<int>(type: "int", nullable: false),
                    InternationalLeadership_ReviewerExplanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrganizationalProcedures_EmployeeRating = table.Column<int>(type: "int", nullable: false),
                    OrganizationalProcedures_EmployeeExplanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrganizationalProcedures_ReviewerRating = table.Column<int>(type: "int", nullable: false),
                    OrganizationalProcedures_ReviewerExplanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommitmentObjectives_EmployeeRating = table.Column<int>(type: "int", nullable: false),
                    CommitmentObjectives_EmployeeExplanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommitmentObjectives_ReviewerRating = table.Column<int>(type: "int", nullable: false),
                    CommitmentObjectives_ReviewerExplanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AchievementsOnGoalsLastYear_EmployeeExplanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AchievementsOnGoalsLastYear_ReviewerExplanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeStrengths_EmployeeExplanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeStrengths_ReviewerExplanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreasImprovement_EmployeeExplanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreasImprovement_ReviewerExplanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JIRAReportLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThisYearGoals_EmployeeExplanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThisYearGoals_ReviewerExplanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalComments_EmployeeExplanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalComments_ReviewerExplanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConsiderForPromotion = table.Column<bool>(type: "bit", nullable: false),
                    Promotion_EmployeeExplanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Promotion_ReviewerExplanation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewsId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");
        }
    }
}
