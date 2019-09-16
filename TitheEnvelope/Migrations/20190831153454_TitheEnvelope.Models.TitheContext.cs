using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TitheEnvelopeApi.Migrations
{
    public partial class TitheEnvelopeModelsTitheContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "TitherDetail",
                schema: "dbo",
                columns: table => new
                {
                    TitherDetailId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NameOfTither = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TitherDetail", x => x.TitherDetailId);
                });

            migrationBuilder.CreateTable(
                name: "TithePaymentDetail",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateOfPayment = table.Column<DateTime>(type: "datetime", nullable: false),
                    Amount = table.Column<decimal>(type: "money", nullable: false),
                    PaymentMethod = table.Column<string>(type: "varchar(50)", nullable: false),
                    TitherDetailId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TithePaymentDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TithePaymentDetail_TitherDetail_TitherDetailId",
                        column: x => x.TitherDetailId,
                        principalSchema: "dbo",
                        principalTable: "TitherDetail",
                        principalColumn: "TitherDetailId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TithePaymentDetail_TitherDetailId",
                schema: "dbo",
                table: "TithePaymentDetail",
                column: "TitherDetailId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TithePaymentDetail",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "TitherDetail",
                schema: "dbo");
        } 
    }
}
