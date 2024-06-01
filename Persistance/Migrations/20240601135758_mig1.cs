using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Currents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TaxDepartmentId = table.Column<int>(type: "int", nullable: false),
                    CurrentCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrentName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CardType = table.Column<bool>(type: "bit", nullable: false),
                    CurrentType = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CurrentFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxNumberOrIdentityNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressHeader = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressMainStreet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressNeighbourhood = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressStreet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressBABNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressDistrict = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressPostCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FaxNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Currents_TaxDepartments_TaxDepartmentId",
                        column: x => x.TaxDepartmentId,
                        principalTable: "TaxDepartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Currents_TaxDepartmentId",
                table: "Currents",
                column: "TaxDepartmentId");

            migrationBuilder.CreateIndex(
                name: "UK_Currents_CurrentName",
                table: "Currents",
                column: "CurrentName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Currents");
        }
    }
}
