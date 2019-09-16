using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TitheEnvelopeApi.Migrations
{
    public partial class TitheEnvelopeModelsTitheContextForTitherDetailSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "dbo",
                table: "TitherDetail",
                columns: new[] { "TitherDetailId", "DateInserted", "DateUpdated", "NameOfTither" },
                values: new object[] { 1L, new DateTime(2019, 9, 1, 22, 18, 17, 175, DateTimeKind.Unspecified), new DateTime(2019, 9, 1, 22, 18, 17, 175, DateTimeKind.Unspecified), "Jolaoluwa Adedeji" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "TitherDetail",
                keyColumn: "TitherDetailId",
                keyValue: 1L);
        }
    }
}
