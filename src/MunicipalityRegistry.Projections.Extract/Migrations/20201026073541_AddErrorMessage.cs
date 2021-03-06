﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace MunicipalityRegistry.Projections.Extract.Migrations
{
    public partial class AddErrorMessage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ErrorMessage",
                schema: "MunicipalityRegistryExtract",
                table: "ProjectionStates",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ErrorMessage",
                schema: "MunicipalityRegistryExtract",
                table: "ProjectionStates");
        }
    }
}
