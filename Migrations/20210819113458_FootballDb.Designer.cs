﻿// <auto-generated />
using System;
using AspNetCoreAngularCrudDemo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AspNetCoreAngularCrudDemo.Migrations
{
    [DbContext(typeof(FootballDbContext))]
    [Migration("20210819113458_FootballDb")]
    partial class FootballDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AspNetCoreAngularCrudDemo.Models.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Team1")
                        .HasColumnType("int");

                    b.Property<int?>("Team1Goals")
                        .HasColumnType("int");

                    b.Property<int?>("Team2")
                        .HasColumnType("int");

                    b.Property<int?>("Team2Goals")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Team1");

                    b.HasIndex("Team2");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("AspNetCoreAngularCrudDemo.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Appearances")
                        .HasColumnType("int");

                    b.Property<int?>("Goals")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("PositionId")
                        .HasColumnType("int");

                    b.Property<int?>("ShirtNo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PositionId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("AspNetCoreAngularCrudDemo.Models.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("AspNetCoreAngularCrudDemo.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Logo")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("AspNetCoreAngularCrudDemo.Models.Match", b =>
                {
                    b.HasOne("AspNetCoreAngularCrudDemo.Models.Team", "Team1Navigation")
                        .WithMany("MatchTeam1Navigations")
                        .HasForeignKey("Team1")
                        .HasConstraintName("FK_Matches_Team1_Teams_Id");

                    b.HasOne("AspNetCoreAngularCrudDemo.Models.Team", "Team2Navigation")
                        .WithMany("MatchTeam2Navigations")
                        .HasForeignKey("Team2")
                        .HasConstraintName("FK_Matches_Team2_Teams_Id");

                    b.Navigation("Team1Navigation");

                    b.Navigation("Team2Navigation");
                });

            modelBuilder.Entity("AspNetCoreAngularCrudDemo.Models.Player", b =>
                {
                    b.HasOne("AspNetCoreAngularCrudDemo.Models.Position", "Position")
                        .WithMany("Players")
                        .HasForeignKey("PositionId")
                        .HasConstraintName("FK_Players_Positions");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("AspNetCoreAngularCrudDemo.Models.Position", b =>
                {
                    b.Navigation("Players");
                });

            modelBuilder.Entity("AspNetCoreAngularCrudDemo.Models.Team", b =>
                {
                    b.Navigation("MatchTeam1Navigations");

                    b.Navigation("MatchTeam2Navigations");
                });
#pragma warning restore 612, 618
        }
    }
}
