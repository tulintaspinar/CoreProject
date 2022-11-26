using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreProject.DataAccessLayer.Migrations
{
    public partial class _createAnnouncementTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserMessages_Users_UserID",
                table: "UserMessages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserMessages",
                table: "UserMessages");

            migrationBuilder.RenameTable(
                name: "UserMessages",
                newName: "UserMessage");

            migrationBuilder.RenameIndex(
                name: "IX_UserMessages_UserID",
                table: "UserMessage",
                newName: "IX_UserMessage_UserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserMessage",
                table: "UserMessage",
                column: "MessageID");

            migrationBuilder.AddForeignKey(
                name: "FK_UserMessage_Users_UserID",
                table: "UserMessage",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserMessage_Users_UserID",
                table: "UserMessage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserMessage",
                table: "UserMessage");

            migrationBuilder.RenameTable(
                name: "UserMessage",
                newName: "UserMessages");

            migrationBuilder.RenameIndex(
                name: "IX_UserMessage_UserID",
                table: "UserMessages",
                newName: "IX_UserMessages_UserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserMessages",
                table: "UserMessages",
                column: "MessageID");

            migrationBuilder.AddForeignKey(
                name: "FK_UserMessages_Users_UserID",
                table: "UserMessages",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
