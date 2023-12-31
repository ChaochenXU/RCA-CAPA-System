﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RCAONE.Data;

namespace RCAONE.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RCAONE.Models.Admin", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("userid")
                        .IsRequired()
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<string>("userpassword")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("RCAONE.Models.Analysiss", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("lines")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("rules")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Analysiss");
                });

            modelBuilder.Entity("RCAONE.Models.AppFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("Content")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Size")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("UploadDT")
                        .HasColumnType("datetime2");

                    b.Property<string>("probid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userid")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppFile");
                });

            modelBuilder.Entity("RCAONE.Models.Containment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CTAdue0")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CTAdue1")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CTAdue2")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CTAdue3")
                        .HasColumnType("datetime2");

                    b.Property<string>("CTAownerid0")
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<string>("CTAownerid1")
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<string>("CTAownerid2")
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<string>("CTAownerid3")
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<string>("CTApa0")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CTApa1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CTApa2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CTApa3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CTAstatues0")
                        .HasColumnType("int");

                    b.Property<int>("CTAstatues1")
                        .HasColumnType("int");

                    b.Property<int>("CTAstatues2")
                        .HasColumnType("int");

                    b.Property<int>("CTAstatues3")
                        .HasColumnType("int");

                    b.Property<string>("repid")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Containment");
                });

            modelBuilder.Entity("RCAONE.Models.Corrective", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CRAaction0")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CRAaction1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CRAaction2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CRAaction3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CRAdue0")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CRAdue1")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CRAdue2")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CRAdue3")
                        .HasColumnType("datetime2");

                    b.Property<string>("CRAownerid0")
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<string>("CRAownerid1")
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<string>("CRAownerid2")
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<string>("CRAownerid3")
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<int>("CRAstatus0")
                        .HasColumnType("int");

                    b.Property<int>("CRAstatus1")
                        .HasColumnType("int");

                    b.Property<int>("CRAstatus2")
                        .HasColumnType("int");

                    b.Property<int>("CRAstatus3")
                        .HasColumnType("int");

                    b.Property<string>("repid")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Corrective");
                });

            modelBuilder.Entity("RCAONE.Models.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("isfree")
                        .HasColumnType("int");

                    b.Property<int>("ishead")
                        .HasColumnType("int");

                    b.Property<string>("onreport")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("userdepartment")
                        .HasColumnType("int");

                    b.Property<string>("useremail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("usergender")
                        .HasColumnType("int");

                    b.Property<string>("userid")
                        .IsRequired()
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userpassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(16)")
                        .HasMaxLength(16);

                    b.HasKey("ID");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("RCAONE.Models.Fishbone", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("fishenvir1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fishenvir2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fishenvir3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fishmachine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fishmachine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fishmachine3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fishman1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fishman2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fishman3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fishmaterial1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fishmaterial2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fishmaterial3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fishmeasure1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fishmeasure2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fishmeasure3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fishmethod1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fishmethod2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fishmethod3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fishprob")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("repid")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Fishbone");
                });

            modelBuilder.Entity("RCAONE.Models.Preventive", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PAaction0")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PAaction1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PAaction2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PAaction3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PAcoments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PAdue0")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PAdue1")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PAdue2")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PAdue3")
                        .HasColumnType("datetime2");

                    b.Property<string>("PAownerid0")
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<string>("PAownerid1")
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<string>("PAownerid2")
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<string>("PAownerid3")
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<int>("PAstatus0")
                        .HasColumnType("int");

                    b.Property<int>("PAstatus1")
                        .HasColumnType("int");

                    b.Property<int>("PAstatus2")
                        .HasColumnType("int");

                    b.Property<int>("PAstatus3")
                        .HasColumnType("int");

                    b.Property<int>("isPFMEA")
                        .HasColumnType("int");

                    b.Property<int>("isPMAPS")
                        .HasColumnType("int");

                    b.Property<int>("isrepeat")
                        .HasColumnType("int");

                    b.Property<int>("isreview")
                        .HasColumnType("int");

                    b.Property<string>("repid")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Preventive");
                });

            modelBuilder.Entity("RCAONE.Models.Problem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("probdue")
                        .HasColumnType("datetime2");

                    b.Property<string>("probheadid")
                        .IsRequired()
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<string>("probhow")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("probid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("probline")
                        .HasColumnType("int");

                    b.Property<string>("probname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("probrules")
                        .HasColumnType("int");

                    b.Property<string>("probwhat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("probwhen")
                        .HasColumnType("datetime2");

                    b.Property<string>("probwhere")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("probwho")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("probwhy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("scorevalue")
                        .HasColumnType("real");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Problem");
                });

            modelBuilder.Entity("RCAONE.Models.Score", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("repid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("score1")
                        .HasColumnType("int");

                    b.Property<int>("score2")
                        .HasColumnType("int");

                    b.Property<int>("score3")
                        .HasColumnType("int");

                    b.Property<int>("score4")
                        .HasColumnType("int");

                    b.Property<int>("score5")
                        .HasColumnType("int");

                    b.Property<string>("userid")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Score");
                });

            modelBuilder.Entity("RCAONE.Models.Team", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("memid1")
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<string>("memid2")
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<string>("memid3")
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<string>("memid4")
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<string>("memid5")
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<string>("repid")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Team");
                });

            modelBuilder.Entity("RCAONE.Models.Verification", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("VAaction0")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VAaction1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VAaction2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VAaction3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("VAdue0")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("VAdue1")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("VAdue2")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("VAdue3")
                        .HasColumnType("datetime2");

                    b.Property<string>("VAownerid0")
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<string>("VAownerid1")
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<string>("VAownerid2")
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<string>("VAownerid3")
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<int>("VAstatus0")
                        .HasColumnType("int");

                    b.Property<int>("VAstatus1")
                        .HasColumnType("int");

                    b.Property<int>("VAstatus2")
                        .HasColumnType("int");

                    b.Property<int>("VAstatus3")
                        .HasColumnType("int");

                    b.Property<string>("repid")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Verification");
                });

            modelBuilder.Entity("RCAONE.Models.Whys", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("repid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("rootcause")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("why1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("why2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("why3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("why4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("why5")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Whys");
                });
#pragma warning restore 612, 618
        }
    }
}
