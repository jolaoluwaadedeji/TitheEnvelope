using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TitheEnvelopeApi.Migrations
{
    public partial class TitherPaymentDetailSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "dbo",
                table: "TitherDetail",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "dbo",
                table: "TithePaymentDetail",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
               name: "DateUpdated",
               schema: "dbo",
               table: "TithePaymentDetail",
               type: "datetime",
               nullable: true,
               oldClrType: typeof(DateTime),
               oldType: "datetime");

            migrationBuilder.AlterColumn<DateTime>(
              name: "DateUpdated",
              schema: "dbo",
              table: "TitherDetail",
              type: "datetime",
              nullable: true,
              oldClrType: typeof(DateTime),
              oldType: "datetime");

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "TithePaymentDetail",
                columns: new[] { "Id", "Amount", "DateInserted", "DateOfPayment", "DateUpdated", "PaymentMethod", "TitherDetailId" },
                values: new object[] { 1L, 100m, new DateTime(2019, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cash", 1L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "TithePaymentDetail",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DropColumn(
                name: "DateInserted",
                schema: "dbo",
                table: "TitherDetail");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                schema: "dbo",
                table: "TitherDetail");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "dbo",
                table: "TitherDetail");

            migrationBuilder.DropColumn(
                name: "DateInserted",
                schema: "dbo",
                table: "TithePaymentDetail");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                schema: "dbo",
                table: "TithePaymentDetail");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "dbo",
                table: "TithePaymentDetail");

            migrationBuilder.AlterColumn<long>(
                name: "TitherDetailId",
                schema: "dbo",
                table: "TithePaymentDetail",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);
        }
    }
}
