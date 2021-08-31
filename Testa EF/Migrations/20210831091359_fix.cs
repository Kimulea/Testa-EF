using Microsoft.EntityFrameworkCore.Migrations;

namespace Testa_EF.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AditionalInfoHobby_AditionalInfos_AditionalInfosId",
                table: "AditionalInfoHobby");

            migrationBuilder.DropForeignKey(
                name: "FK_AditionalInfoHobby_Hobbies_HobbiesId",
                table: "AditionalInfoHobby");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AditionalInfoHobby",
                table: "AditionalInfoHobby");

            migrationBuilder.RenameTable(
                name: "AditionalInfoHobby",
                newName: "HobbiesAditionalInfos");

            migrationBuilder.RenameIndex(
                name: "IX_AditionalInfoHobby_HobbiesId",
                table: "HobbiesAditionalInfos",
                newName: "IX_HobbiesAditionalInfos_HobbiesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HobbiesAditionalInfos",
                table: "HobbiesAditionalInfos",
                columns: new[] { "AditionalInfosId", "HobbiesId" });

            migrationBuilder.AddForeignKey(
                name: "FK_HobbiesAditionalInfos_AditionalInfos_AditionalInfosId",
                table: "HobbiesAditionalInfos",
                column: "AditionalInfosId",
                principalTable: "AditionalInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HobbiesAditionalInfos_Hobbies_HobbiesId",
                table: "HobbiesAditionalInfos",
                column: "HobbiesId",
                principalTable: "Hobbies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HobbiesAditionalInfos_AditionalInfos_AditionalInfosId",
                table: "HobbiesAditionalInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_HobbiesAditionalInfos_Hobbies_HobbiesId",
                table: "HobbiesAditionalInfos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HobbiesAditionalInfos",
                table: "HobbiesAditionalInfos");

            migrationBuilder.RenameTable(
                name: "HobbiesAditionalInfos",
                newName: "AditionalInfoHobby");

            migrationBuilder.RenameIndex(
                name: "IX_HobbiesAditionalInfos_HobbiesId",
                table: "AditionalInfoHobby",
                newName: "IX_AditionalInfoHobby_HobbiesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AditionalInfoHobby",
                table: "AditionalInfoHobby",
                columns: new[] { "AditionalInfosId", "HobbiesId" });

            migrationBuilder.AddForeignKey(
                name: "FK_AditionalInfoHobby_AditionalInfos_AditionalInfosId",
                table: "AditionalInfoHobby",
                column: "AditionalInfosId",
                principalTable: "AditionalInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AditionalInfoHobby_Hobbies_HobbiesId",
                table: "AditionalInfoHobby",
                column: "HobbiesId",
                principalTable: "Hobbies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
