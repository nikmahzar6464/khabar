using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Khabar.Migrations
{
    public partial class ThirdDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CommentID",
                table: "News",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CommentName = table.Column<string>(nullable: true),
                    NewsID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Comments_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTypes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTypes", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserTypeID",
                table: "Users",
                column: "UserTypeID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_News_CommentID",
                table: "News",
                column: "CommentID");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserID",
                table: "Comments",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_News_Comments_CommentID",
                table: "News",
                column: "CommentID",
                principalTable: "Comments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserTypes_UserTypeID",
                table: "Users",
                column: "UserTypeID",
                principalTable: "UserTypes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_News_Comments_CommentID",
                table: "News");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserTypes_UserTypeID",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "UserTypes");

            migrationBuilder.DropIndex(
                name: "IX_Users_UserTypeID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_News_CommentID",
                table: "News");

            migrationBuilder.DropColumn(
                name: "CommentID",
                table: "News");
        }
    }
}
