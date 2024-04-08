using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StaffType",
                columns: table => new
                {
                    StaffTypeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffType", x => x.StaffTypeId);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeMaster",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    MiddleInitial = table.Column<string>(type: "TEXT", nullable: true),
                    HomePhone = table.Column<string>(type: "TEXT", nullable: true),
                    CellPhone = table.Column<string>(type: "TEXT", nullable: true),
                    OfficeExt = table.Column<string>(type: "TEXT", nullable: true),
                    TaxNumber = table.Column<string>(type: "TEXT", nullable: true),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    ManagerId = table.Column<int>(type: "INTEGER", nullable: true),
                    StaffTypeId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeMaster", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_EmployeeMaster_EmployeeMaster_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "EmployeeMaster",
                        principalColumn: "EmployeeId");
                    table.ForeignKey(
                        name: "FK_EmployeeMaster_StaffType_StaffTypeId",
                        column: x => x.StaffTypeId,
                        principalTable: "StaffType",
                        principalColumn: "StaffTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "StaffType",
                columns: new[] { "StaffTypeId", "Name" },
                values: new object[] { 1, "Manager" });

            migrationBuilder.InsertData(
                table: "StaffType",
                columns: new[] { "StaffTypeId", "Name" },
                values: new object[] { 2, "Employee" });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeMaster_ManagerId",
                table: "EmployeeMaster",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeMaster_StaffTypeId",
                table: "EmployeeMaster",
                column: "StaffTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeMaster");

            migrationBuilder.DropTable(
                name: "StaffType");
        }
    }
}
