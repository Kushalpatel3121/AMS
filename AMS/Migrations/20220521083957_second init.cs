using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AMS.Migrations
{
    public partial class secondinit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SabhaAttendance_StudenYuvakts_YuvakId",
                table: "SabhaAttendance");

            migrationBuilder.DropForeignKey(
                name: "FK_StudenYuvakts_Mandal_MandalId",
                table: "StudenYuvakts");

            migrationBuilder.DropForeignKey(
                name: "FK_StudenYuvakts_SamparkKaryakar_SamparkKaryakarId",
                table: "StudenYuvakts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudenYuvakts",
                table: "StudenYuvakts");

            migrationBuilder.RenameTable(
                name: "StudenYuvakts",
                newName: "Yuvak");

            migrationBuilder.RenameIndex(
                name: "IX_StudenYuvakts_SamparkKaryakarId",
                table: "Yuvak",
                newName: "IX_Yuvak_SamparkKaryakarId");

            migrationBuilder.RenameIndex(
                name: "IX_StudenYuvakts_MandalId",
                table: "Yuvak",
                newName: "IX_Yuvak_MandalId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Yuvak",
                table: "Yuvak",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SabhaAttendance_Yuvak_YuvakId",
                table: "SabhaAttendance",
                column: "YuvakId",
                principalTable: "Yuvak",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Yuvak_Mandal_MandalId",
                table: "Yuvak",
                column: "MandalId",
                principalTable: "Mandal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Yuvak_SamparkKaryakar_SamparkKaryakarId",
                table: "Yuvak",
                column: "SamparkKaryakarId",
                principalTable: "SamparkKaryakar",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SabhaAttendance_Yuvak_YuvakId",
                table: "SabhaAttendance");

            migrationBuilder.DropForeignKey(
                name: "FK_Yuvak_Mandal_MandalId",
                table: "Yuvak");

            migrationBuilder.DropForeignKey(
                name: "FK_Yuvak_SamparkKaryakar_SamparkKaryakarId",
                table: "Yuvak");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Yuvak",
                table: "Yuvak");

            migrationBuilder.RenameTable(
                name: "Yuvak",
                newName: "StudenYuvakts");

            migrationBuilder.RenameIndex(
                name: "IX_Yuvak_SamparkKaryakarId",
                table: "StudenYuvakts",
                newName: "IX_StudenYuvakts_SamparkKaryakarId");

            migrationBuilder.RenameIndex(
                name: "IX_Yuvak_MandalId",
                table: "StudenYuvakts",
                newName: "IX_StudenYuvakts_MandalId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudenYuvakts",
                table: "StudenYuvakts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SabhaAttendance_StudenYuvakts_YuvakId",
                table: "SabhaAttendance",
                column: "YuvakId",
                principalTable: "StudenYuvakts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudenYuvakts_Mandal_MandalId",
                table: "StudenYuvakts",
                column: "MandalId",
                principalTable: "Mandal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudenYuvakts_SamparkKaryakar_SamparkKaryakarId",
                table: "StudenYuvakts",
                column: "SamparkKaryakarId",
                principalTable: "SamparkKaryakar",
                principalColumn: "Id");
        }
    }
}
