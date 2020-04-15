namespace HomeCareCompany.Data.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class ApplicationUserCustomerConfigurationAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationUserCustomer",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false),
                    ApplicationUserId = table.Column<string>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserCustomer", x => new { x.ApplicationUserId, x.CustomerId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserCustomer_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ApplicationUserCustomer_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserCustomer_CustomerId",
                table: "ApplicationUserCustomer",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserCustomer");
        }
    }
}
