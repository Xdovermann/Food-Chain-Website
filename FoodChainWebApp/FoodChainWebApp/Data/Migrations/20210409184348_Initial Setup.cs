using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodChainWebApp.Data.Migrations
{
    public partial class InitialSetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodChainUserClaims_FoodChainUsers_UserId",
                table: "FoodChainUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodChainUserLogins_FoodChainUsers_UserId",
                table: "FoodChainUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodChainUserRoles_AspNetRoles_RoleId",
                table: "FoodChainUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodChainUserRoles_FoodChainUsers_UserId",
                table: "FoodChainUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodChainUserTokens_FoodChainUsers_UserId",
                table: "FoodChainUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FoodChainUserTokens",
                table: "FoodChainUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FoodChainUsers",
                table: "FoodChainUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FoodChainUserRoles",
                table: "FoodChainUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FoodChainUserLogins",
                table: "FoodChainUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FoodChainUserClaims",
                table: "FoodChainUserClaims");

            migrationBuilder.RenameTable(
                name: "FoodChainUserTokens",
                newName: "AspNetUserTokens");

            migrationBuilder.RenameTable(
                name: "FoodChainUsers",
                newName: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "FoodChainUserRoles",
                newName: "AspNetUserRoles");

            migrationBuilder.RenameTable(
                name: "FoodChainUserLogins",
                newName: "AspNetUserLogins");

            migrationBuilder.RenameTable(
                name: "FoodChainUserClaims",
                newName: "AspNetUserClaims");

            migrationBuilder.RenameIndex(
                name: "IX_FoodChainUserRoles_RoleId",
                table: "AspNetUserRoles",
                newName: "IX_AspNetUserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_FoodChainUserLogins_UserId",
                table: "AspNetUserLogins",
                newName: "IX_AspNetUserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_FoodChainUserClaims_UserId",
                table: "AspNetUserClaims",
                newName: "IX_AspNetUserClaims_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "LeaderBoardEntry",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(nullable: true),
                    Score = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaderBoardEntry", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "LeaderBoardEntry");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                newName: "FoodChainUserTokens");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "FoodChainUsers");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                newName: "FoodChainUserRoles");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                newName: "FoodChainUserLogins");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                newName: "FoodChainUserClaims");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "FoodChainUserRoles",
                newName: "IX_FoodChainUserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "FoodChainUserLogins",
                newName: "IX_FoodChainUserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "FoodChainUserClaims",
                newName: "IX_FoodChainUserClaims_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FoodChainUserTokens",
                table: "FoodChainUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_FoodChainUsers",
                table: "FoodChainUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FoodChainUserRoles",
                table: "FoodChainUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_FoodChainUserLogins",
                table: "FoodChainUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_FoodChainUserClaims",
                table: "FoodChainUserClaims",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodChainUserClaims_FoodChainUsers_UserId",
                table: "FoodChainUserClaims",
                column: "UserId",
                principalTable: "FoodChainUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodChainUserLogins_FoodChainUsers_UserId",
                table: "FoodChainUserLogins",
                column: "UserId",
                principalTable: "FoodChainUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodChainUserRoles_AspNetRoles_RoleId",
                table: "FoodChainUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodChainUserRoles_FoodChainUsers_UserId",
                table: "FoodChainUserRoles",
                column: "UserId",
                principalTable: "FoodChainUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodChainUserTokens_FoodChainUsers_UserId",
                table: "FoodChainUserTokens",
                column: "UserId",
                principalTable: "FoodChainUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
