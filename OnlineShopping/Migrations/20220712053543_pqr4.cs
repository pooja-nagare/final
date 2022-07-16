using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineShopping.Migrations
{
    public partial class pqr4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    CTId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SSId = table.Column<int>(nullable: false),
                    ProdId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.CTId);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fname = table.Column<string>(type: "varchar(20)", nullable: true),
                    Lname = table.Column<string>(type: "varchar(20)", nullable: true),
                    Address = table.Column<string>(type: "varchar(200)", nullable: true),
                    Landmark = table.Column<string>(type: "varchar(150)", nullable: true),
                    City = table.Column<string>(type: "varchar(20)", nullable: true),
                    Pincode = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDetailId = table.Column<int>(nullable: false),
                    ProdId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "PaymentDetails",
                columns: table => new
                {
                    PaymentDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardOwnerName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    CardNumber = table.Column<string>(type: "nvarchar(16)", nullable: true),
                    ExpirationDate = table.Column<string>(type: "nvarchar(5)", nullable: true),
                    SecurityCode = table.Column<string>(type: "nvarchar(3)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentDetails", x => x.PaymentDetailId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProdId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdName = table.Column<string>(type: "varchar(100)", nullable: true),
                    ProdDescription = table.Column<string>(type: "varchar(100)", nullable: true),
                    ProdCategory = table.Column<string>(type: "varchar(100)", nullable: true),
                    ProdImage = table.Column<string>(type: "varchar(40)", nullable: true),
                    ProdPrice = table.Column<decimal>(type: "decimal", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProdId);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingSessions",
                columns: table => new
                {
                    SSId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    ShoppingSessionTotal = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingSessions", x => x.SSId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(40)", nullable: true),
                    LastName = table.Column<string>(type: "varchar(40)", nullable: true),
                    Password = table.Column<string>(type: "varchar(40)", nullable: true),
                    UserEmail = table.Column<string>(type: "varchar(100)", nullable: true),
                    PhoneNumber = table.Column<decimal>(type: "decimal(18,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "PaymentDetails");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ShoppingSessions");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
