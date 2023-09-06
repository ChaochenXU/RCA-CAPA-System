using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace RCAONE.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userid = table.Column<string>(maxLength: 6, nullable: false),
                    userpassword = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Analysiss",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rules = table.Column<string>(nullable: true),
                    lines = table.Column<string>(nullable: true),
                    status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Analysiss", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AppFile",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(nullable: true),
                    probid = table.Column<string>(nullable: true),
                    userid = table.Column<string>(nullable: true),
                    Size = table.Column<long>(nullable: false),
                    UploadDT = table.Column<DateTime>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    Content = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppFile", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Containment",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    repid = table.Column<string>(nullable: true),
                    CTAownerid0 = table.Column<string>(maxLength: 6, nullable: true),
                    CTApa0 = table.Column<string>(nullable: true),
                    CTAstatues0 = table.Column<int>(nullable: false),
                    CTAdue0 = table.Column<DateTime>(nullable: false),
                    CTAownerid1 = table.Column<string>(maxLength: 6, nullable: true),
                    CTApa1 = table.Column<string>(nullable: true),
                    CTAstatues1 = table.Column<int>(nullable: false),
                    CTAdue1 = table.Column<DateTime>(nullable: false),
                    CTAownerid2 = table.Column<string>(maxLength: 6, nullable: true),
                    CTApa2 = table.Column<string>(nullable: true),
                    CTAstatues2 = table.Column<int>(nullable: false),
                    CTAdue2 = table.Column<DateTime>(nullable: false),
                    CTAownerid3 = table.Column<string>(maxLength: 6, nullable: true),
                    CTApa3 = table.Column<string>(nullable: true),
                    CTAstatues3 = table.Column<int>(nullable: false),
                    CTAdue3 = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Containment", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Corrective",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    repid = table.Column<string>(nullable: true),
                    CRAaction0 = table.Column<string>(nullable: true),
                    CRAownerid0 = table.Column<string>(maxLength: 6, nullable: true),
                    CRAstatus0 = table.Column<int>(nullable: false),
                    CRAdue0 = table.Column<DateTime>(nullable: false),
                    CRAaction1 = table.Column<string>(nullable: true),
                    CRAownerid1 = table.Column<string>(maxLength: 6, nullable: true),
                    CRAstatus1 = table.Column<int>(nullable: false),
                    CRAdue1 = table.Column<DateTime>(nullable: false),
                    CRAaction2 = table.Column<string>(nullable: true),
                    CRAownerid2 = table.Column<string>(maxLength: 6, nullable: true),
                    CRAstatus2 = table.Column<int>(nullable: false),
                    CRAdue2 = table.Column<DateTime>(nullable: false),
                    CRAaction3 = table.Column<string>(nullable: true),
                    CRAownerid3 = table.Column<string>(maxLength: 6, nullable: true),
                    CRAstatus3 = table.Column<int>(nullable: false),
                    CRAdue3 = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Corrective", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userid = table.Column<string>(maxLength: 6, nullable: false),
                    userpassword = table.Column<string>(maxLength: 16, nullable: false),
                    username = table.Column<string>(nullable: false),
                    useremail = table.Column<string>(nullable: false),
                    usergender = table.Column<int>(nullable: false),
                    userdepartment = table.Column<int>(nullable: false),
                    ishead = table.Column<int>(nullable: false),
                    isfree = table.Column<int>(nullable: false),
                    onreport = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Fishbone",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    repid = table.Column<string>(nullable: true),
                    fishman1 = table.Column<string>(nullable: true),
                    fishman2 = table.Column<string>(nullable: true),
                    fishman3 = table.Column<string>(nullable: true),
                    fishmethod1 = table.Column<string>(nullable: true),
                    fishmethod2 = table.Column<string>(nullable: true),
                    fishmethod3 = table.Column<string>(nullable: true),
                    fishmeasure1 = table.Column<string>(nullable: true),
                    fishmeasure2 = table.Column<string>(nullable: true),
                    fishmeasure3 = table.Column<string>(nullable: true),
                    fishmachine1 = table.Column<string>(nullable: true),
                    fishmachine2 = table.Column<string>(nullable: true),
                    fishmachine3 = table.Column<string>(nullable: true),
                    fishmaterial1 = table.Column<string>(nullable: true),
                    fishmaterial2 = table.Column<string>(nullable: true),
                    fishmaterial3 = table.Column<string>(nullable: true),
                    fishenvir1 = table.Column<string>(nullable: true),
                    fishenvir2 = table.Column<string>(nullable: true),
                    fishenvir3 = table.Column<string>(nullable: true),
                    fishprob = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fishbone", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Preventive",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    repid = table.Column<string>(nullable: true),
                    PAaction0 = table.Column<string>(nullable: true),
                    PAownerid0 = table.Column<string>(maxLength: 6, nullable: true),
                    PAstatus0 = table.Column<int>(nullable: false),
                    PAdue0 = table.Column<DateTime>(nullable: false),
                    PAaction1 = table.Column<string>(nullable: true),
                    PAownerid1 = table.Column<string>(maxLength: 6, nullable: true),
                    PAstatus1 = table.Column<int>(nullable: false),
                    PAdue1 = table.Column<DateTime>(nullable: false),
                    PAaction2 = table.Column<string>(nullable: true),
                    PAownerid2 = table.Column<string>(maxLength: 6, nullable: true),
                    PAstatus2 = table.Column<int>(nullable: false),
                    PAdue2 = table.Column<DateTime>(nullable: false),
                    PAaction3 = table.Column<string>(nullable: true),
                    PAownerid3 = table.Column<string>(maxLength: 6, nullable: true),
                    PAstatus3 = table.Column<int>(nullable: false),
                    PAdue3 = table.Column<DateTime>(nullable: false),
                    isrepeat = table.Column<int>(nullable: false),
                    isPMAPS = table.Column<int>(nullable: false),
                    isPFMEA = table.Column<int>(nullable: false),
                    isreview = table.Column<int>(nullable: false),
                    PAcoments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Preventive", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Problem",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    probname = table.Column<string>(nullable: true),
                    probwhat = table.Column<string>(nullable: false),
                    probwhen = table.Column<DateTime>(nullable: false),
                    probwhere = table.Column<string>(nullable: false),
                    probwho = table.Column<string>(nullable: false),
                    probwhy = table.Column<string>(nullable: false),
                    probhow = table.Column<string>(nullable: false),
                    probline = table.Column<int>(nullable: false),
                    probrules = table.Column<int>(nullable: false),
                    probdue = table.Column<DateTime>(nullable: false),
                    probheadid = table.Column<string>(maxLength: 6, nullable: false),
                    probid = table.Column<string>(nullable: true),
                    status = table.Column<int>(nullable: false),
                    scorevalue = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Problem", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Score",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    repid = table.Column<string>(nullable: true),
                    score1 = table.Column<int>(nullable: false),
                    score2 = table.Column<int>(nullable: false),
                    score3 = table.Column<int>(nullable: false),
                    score4 = table.Column<int>(nullable: false),
                    score5 = table.Column<int>(nullable: false),
                    userid = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Score", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    repid = table.Column<string>(nullable: true),
                    memid1 = table.Column<string>(maxLength: 6, nullable: true),
                    memid2 = table.Column<string>(maxLength: 6, nullable: true),
                    memid3 = table.Column<string>(maxLength: 6, nullable: true),
                    memid4 = table.Column<string>(maxLength: 6, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Verification",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    repid = table.Column<string>(nullable: true),
                    VAaction0 = table.Column<string>(nullable: true),
                    VAownerid0 = table.Column<string>(maxLength: 6, nullable: true),
                    VAstatus0 = table.Column<int>(nullable: false),
                    VAdue0 = table.Column<DateTime>(nullable: false),
                    VAaction1 = table.Column<string>(nullable: true),
                    VAownerid1 = table.Column<string>(maxLength: 6, nullable: true),
                    VAstatus1 = table.Column<int>(nullable: false),
                    VAdue1 = table.Column<DateTime>(nullable: false),
                    VAaction2 = table.Column<string>(nullable: true),
                    VAownerid2 = table.Column<string>(maxLength: 6, nullable: true),
                    VAstatus2 = table.Column<int>(nullable: false),
                    VAdue2 = table.Column<DateTime>(nullable: false),
                    VAaction3 = table.Column<string>(nullable: true),
                    VAownerid3 = table.Column<string>(maxLength: 6, nullable: true),
                    VAstatus3 = table.Column<int>(nullable: false),
                    VAdue3 = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Verification", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Whys",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    repid = table.Column<string>(nullable: true),
                    why1 = table.Column<string>(nullable: true),
                    why2 = table.Column<string>(nullable: true),
                    why3 = table.Column<string>(nullable: true),
                    why4 = table.Column<string>(nullable: true),
                    why5 = table.Column<string>(nullable: true),
                    rootcause = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Whys", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Analysiss");

            migrationBuilder.DropTable(
                name: "AppFile");

            migrationBuilder.DropTable(
                name: "Containment");

            migrationBuilder.DropTable(
                name: "Corrective");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Fishbone");

            migrationBuilder.DropTable(
                name: "Preventive");

            migrationBuilder.DropTable(
                name: "Problem");

            migrationBuilder.DropTable(
                name: "Score");

            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.DropTable(
                name: "Verification");

            migrationBuilder.DropTable(
                name: "Whys");
        }
    }
}
