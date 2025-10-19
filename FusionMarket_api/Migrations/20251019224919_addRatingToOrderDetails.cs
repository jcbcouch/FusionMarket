﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FusionMarket_api.Migrations
{
    /// <inheritdoc />
    public partial class addRatingToOrderDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "OrderDetails",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "OrderDetails");
        }
    }
}
