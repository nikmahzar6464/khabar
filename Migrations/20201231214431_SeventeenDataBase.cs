using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Khabar.Migrations
{
    public partial class SeventeenDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CommentID",
                table: "News",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_News_CommentID",
                table: "News",
                column: "CommentID");

            migrationBuilder.AddForeignKey(
                name: "FK_News_Comments_CommentID",
                table: "News",
                column: "CommentID",
                principalTable: "Comments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_News_Comments_CommentID",
                table: "News");

            migrationBuilder.DropIndex(
                name: "IX_News_CommentID",
                table: "News");

            migrationBuilder.DropColumn(
                name: "CommentID",
                table: "News");
        }
    }
}
