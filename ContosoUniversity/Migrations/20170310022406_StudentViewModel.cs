using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ContosoUniversity.Migrations
{
    public partial class StudentViewModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "StudentViewModels",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        StudentID = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_StudentViewModels", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_StudentViewModels_Person_StudentID",
            //            column: x => x.StudentID,
            //            principalTable: "Person",
            //            principalColumn: "ID",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.AddColumn<int>(
            //    name: "StudentViewModelId",
            //    table: "Enrollment",
            //    nullable: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Enrollment_StudentViewModelId",
            //    table: "Enrollment",
            //    column: "StudentViewModelId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_StudentViewModels_StudentID",
            //    table: "StudentViewModels",
            //    column: "StudentID");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Enrollment_StudentViewModels_StudentViewModelId",
            //    table: "Enrollment",
            //    column: "StudentViewModelId",
            //    principalTable: "StudentViewModels",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Enrollment_StudentViewModels_StudentViewModelId",
            //    table: "Enrollment");

            //migrationBuilder.DropIndex(
            //    name: "IX_Enrollment_StudentViewModelId",
            //    table: "Enrollment");

            //migrationBuilder.DropColumn(
            //    name: "StudentViewModelId",
            //    table: "Enrollment");

            //migrationBuilder.DropTable(
            //    name: "StudentViewModels");
        }
    }
}
