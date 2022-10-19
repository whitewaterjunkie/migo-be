﻿// <auto-generated />
using System;
using Alliance_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Alliance_API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("Alliance_API.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Birthdate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BloodType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CityAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CityContactNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CivicClubAffiliation")
                        .HasColumnType("TEXT");

                    b.Property<string>("CivilStatus")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ContractType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DateJoined")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EmergencyAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EmergencyContactNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EmergencyName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EmergencyRelationship")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("NumberOfDependents")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PositionApplied")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PositionCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Profession")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Religion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("YearsOfExperience")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Alliance_API.Models.HRUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("HRUsers");
                });

            modelBuilder.Entity("Alliance_API.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Deadline")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("EmployeeProject", b =>
                {
                    b.Property<int>("AssignedEmployeesId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AssignedProjectsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AssignedEmployeesId", "AssignedProjectsId");

                    b.HasIndex("AssignedProjectsId");

                    b.ToTable("EmployeeProject");
                });

            modelBuilder.Entity("EmployeeProject", b =>
                {
                    b.HasOne("Alliance_API.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("AssignedEmployeesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Alliance_API.Models.Project", null)
                        .WithMany()
                        .HasForeignKey("AssignedProjectsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
