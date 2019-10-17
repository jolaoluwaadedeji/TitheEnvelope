using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TitheEnvelopeApi.Migrations
{
    public partial class UpDateOnModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "TithePaymentDetail",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.RenameColumn(
                name: "TitherDetailId",
                schema: "dbo",
                table: "TitherDetail",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "dbo",
                table: "TitherDetail",
                newName: "TitherDetailId");

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "TithePaymentDetail",
                columns: new[] { "Id", "Amount", "DateInserted", "DateOfPayment", "DateUpdated", "IsDeleted", "PaymentMethod", "TitherDetailId" },
                values: new object[] { 1L, 100m, new DateTime(2019, 9, 13, 20, 5, 0, 511, DateTimeKind.Local), new DateTime(2019, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Cash", 1L });
        }
    }
}
