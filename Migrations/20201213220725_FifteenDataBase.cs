using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Khabar.Migrations
{
    public partial class FifteenDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_UserTypeID",
                table: "Users");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserTypeID",
                table: "Users",
                column: "UserTypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_UserTypeID",
                table: "Users");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserTypeID",
                table: "Users",
                column: "UserTypeID",
                unique: true);
        }
    }
}
