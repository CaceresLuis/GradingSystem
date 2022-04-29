using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classrooms",
                columns: table => new
                {
                    IdClassroom = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classrooms", x => x.IdClassroom);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    IdSubject = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.IdSubject);
                });

            migrationBuilder.CreateTable(
                name: "UserDetails",
                columns: table => new
                {
                    IdUserDetail = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetails", x => x.IdUserDetail);
                });

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    IdAdmin = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserDetailIdUserDetail = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.IdAdmin);
                    table.ForeignKey(
                        name: "FK_Admins_UserDetails_UserDetailIdUserDetail",
                        column: x => x.UserDetailIdUserDetail,
                        principalTable: "UserDetails",
                        principalColumn: "IdUserDetail");
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    IdStudent = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserDetailIdUserDetail = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.IdStudent);
                    table.ForeignKey(
                        name: "FK_Students_UserDetails_UserDetailIdUserDetail",
                        column: x => x.UserDetailIdUserDetail,
                        principalTable: "UserDetails",
                        principalColumn: "IdUserDetail");
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    IdTeacher = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserDetailIdUserDetail = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.IdTeacher);
                    table.ForeignKey(
                        name: "FK_Teachers_UserDetails_UserDetailIdUserDetail",
                        column: x => x.UserDetailIdUserDetail,
                        principalTable: "UserDetails",
                        principalColumn: "IdUserDetail");
                });

            migrationBuilder.CreateTable(
                name: "TeacherInscriptions",
                columns: table => new
                {
                    IdTeacherInscription = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TeacherIdTeacher = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClassroomIdClassroom = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SubjectIdSubject = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherInscriptions", x => x.IdTeacherInscription);
                    table.ForeignKey(
                        name: "FK_TeacherInscriptions_Classrooms_ClassroomIdClassroom",
                        column: x => x.ClassroomIdClassroom,
                        principalTable: "Classrooms",
                        principalColumn: "IdClassroom");
                    table.ForeignKey(
                        name: "FK_TeacherInscriptions_Subjects_SubjectIdSubject",
                        column: x => x.SubjectIdSubject,
                        principalTable: "Subjects",
                        principalColumn: "IdSubject");
                    table.ForeignKey(
                        name: "FK_TeacherInscriptions_Teachers_TeacherIdTeacher",
                        column: x => x.TeacherIdTeacher,
                        principalTable: "Teachers",
                        principalColumn: "IdTeacher");
                });

            migrationBuilder.CreateTable(
                name: "StudentInscriptions",
                columns: table => new
                {
                    IdStudentInscription = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TeacherInscriptionIdTeacherInscription = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StudentIdStudent = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentInscriptions", x => x.IdStudentInscription);
                    table.ForeignKey(
                        name: "FK_StudentInscriptions_Students_StudentIdStudent",
                        column: x => x.StudentIdStudent,
                        principalTable: "Students",
                        principalColumn: "IdStudent");
                    table.ForeignKey(
                        name: "FK_StudentInscriptions_TeacherInscriptions_TeacherInscriptionIdTeacherInscription",
                        column: x => x.TeacherInscriptionIdTeacherInscription,
                        principalTable: "TeacherInscriptions",
                        principalColumn: "IdTeacherInscription");
                });

            migrationBuilder.CreateTable(
                name: "Homeworks",
                columns: table => new
                {
                    IdHomework = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(160)", maxLength: 160, nullable: false),
                    Point = table.Column<decimal>(type: "decimal(4,2)", nullable: false),
                    StudentInscriptionIdStudentInscription = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Homeworks", x => x.IdHomework);
                    table.ForeignKey(
                        name: "FK_Homeworks_StudentInscriptions_StudentInscriptionIdStudentInscription",
                        column: x => x.StudentInscriptionIdStudentInscription,
                        principalTable: "StudentInscriptions",
                        principalColumn: "IdStudentInscription");
                });

            migrationBuilder.CreateTable(
                name: "Semesters",
                columns: table => new
                {
                    IdSemester = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(160)", maxLength: 160, nullable: false),
                    Point = table.Column<decimal>(type: "decimal(4,2)", nullable: false),
                    StudentInscriptionIdStudentInscription = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semesters", x => x.IdSemester);
                    table.ForeignKey(
                        name: "FK_Semesters_StudentInscriptions_StudentInscriptionIdStudentInscription",
                        column: x => x.StudentInscriptionIdStudentInscription,
                        principalTable: "StudentInscriptions",
                        principalColumn: "IdStudentInscription");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Admins_UserDetailIdUserDetail",
                table: "Admins",
                column: "UserDetailIdUserDetail");

            migrationBuilder.CreateIndex(
                name: "IX_Homeworks_StudentInscriptionIdStudentInscription",
                table: "Homeworks",
                column: "StudentInscriptionIdStudentInscription");

            migrationBuilder.CreateIndex(
                name: "IX_Semesters_StudentInscriptionIdStudentInscription",
                table: "Semesters",
                column: "StudentInscriptionIdStudentInscription");

            migrationBuilder.CreateIndex(
                name: "IX_StudentInscriptions_StudentIdStudent",
                table: "StudentInscriptions",
                column: "StudentIdStudent");

            migrationBuilder.CreateIndex(
                name: "IX_StudentInscriptions_TeacherInscriptionIdTeacherInscription",
                table: "StudentInscriptions",
                column: "TeacherInscriptionIdTeacherInscription");

            migrationBuilder.CreateIndex(
                name: "IX_Students_UserDetailIdUserDetail",
                table: "Students",
                column: "UserDetailIdUserDetail");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherInscriptions_ClassroomIdClassroom",
                table: "TeacherInscriptions",
                column: "ClassroomIdClassroom");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherInscriptions_SubjectIdSubject",
                table: "TeacherInscriptions",
                column: "SubjectIdSubject");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherInscriptions_TeacherIdTeacher",
                table: "TeacherInscriptions",
                column: "TeacherIdTeacher");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_UserDetailIdUserDetail",
                table: "Teachers",
                column: "UserDetailIdUserDetail");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Homeworks");

            migrationBuilder.DropTable(
                name: "Semesters");

            migrationBuilder.DropTable(
                name: "StudentInscriptions");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "TeacherInscriptions");

            migrationBuilder.DropTable(
                name: "Classrooms");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "UserDetails");
        }
    }
}
