using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TitheEnvelopeApi.Migrations
{
    public partial class TitheEnvelopeModelsTitheContextForBaseObject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateInserted",
                schema: "dbo",
                table: "TitherDetail",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                schema: "dbo",
                table: "TitherDetail",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<long>(
                name: "TitherDetailId",
                schema: "dbo",
                table: "TithePaymentDetail",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateInserted",
                schema: "dbo",
                table: "TithePaymentDetail",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                schema: "dbo",
                table: "TithePaymentDetail",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateInserted",
                schema: "dbo",
                table: "TitherDetail");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
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
