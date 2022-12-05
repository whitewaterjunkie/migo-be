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

            modelBuilder.Entity("Alliance_API.Models.Benefits", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BenefitType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Duration")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Benefits");
                });

            modelBuilder.Entity("Alliance_API.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Birthdate")
                        .HasColumnType("TEXT");

                    b.Property<string>("BloodType")
                        .HasColumnType("TEXT");

                    b.Property<string>("CityAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("CityContactNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("CivicClubAffiliation")
                        .HasColumnType("TEXT");

                    b.Property<string>("CivilStatus")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContractType")
                        .HasColumnType("TEXT");

                    b.Property<string>("DateEvaluated")
                        .HasColumnType("TEXT");

                    b.Property<string>("DateJoined")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmergencyAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmergencyContactNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmergencyName")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmergencyRelationship")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("Evaluated")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("MiddleName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("NumberOfDependents")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PositionApplied")
                        .HasColumnType("TEXT");

                    b.Property<string>("PositionCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("Profession")
                        .HasColumnType("TEXT");

                    b.Property<string>("Religion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sex")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("YearsOfExperience")
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

                    b.Property<string>("Description")
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

            modelBuilder.Entity("EmployeeTraining", b =>
                {
                    b.Property<int>("EmployeesId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TrainingsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("EmployeesId", "TrainingsId");

                    b.HasIndex("TrainingsId");

                    b.ToTable("EmployeeTraining");
                });

            modelBuilder.Entity("migo_be.Models.Agility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("CA_Q1")
                        .HasColumnType("REAL");

                    b.Property<double>("CA_Q2")
                        .HasColumnType("REAL");

                    b.Property<double>("CA_Q3")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Agilities");
                });

            modelBuilder.Entity("migo_be.Models.Assessment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AgilityId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("AgilityRemark")
                        .HasColumnType("TEXT");

                    b.Property<int?>("EfficiencyId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EfficiencyRemark")
                        .HasColumnType("TEXT");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FunctionalComponentsId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FunctionalComponentsRemark")
                        .HasColumnType("TEXT");

                    b.Property<int?>("InnovationId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("InnovationRemark")
                        .HasColumnType("TEXT");

                    b.Property<int?>("IntegrityId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("IntegrityRemark")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PerformanceId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PerformanceRemark")
                        .HasColumnType("TEXT");

                    b.Property<int?>("QualityId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("QualityRemark")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AgilityId");

                    b.HasIndex("EfficiencyId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("FunctionalComponentsId");

                    b.HasIndex("InnovationId");

                    b.HasIndex("IntegrityId");

                    b.HasIndex("PerformanceId");

                    b.HasIndex("QualityId");

                    b.ToTable("Assessments");
                });

            modelBuilder.Entity("migo_be.Models.Efficiency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("CA_Q1")
                        .HasColumnType("REAL");

                    b.Property<double>("CA_Q2")
                        .HasColumnType("REAL");

                    b.Property<double>("CA_Q3")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Efficiencies");
                });

            modelBuilder.Entity("migo_be.Models.EmployeeTimeLogs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Action")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Remark")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Time")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeTimeLogs");
                });

            modelBuilder.Entity("migo_be.Models.FunctionalComponents", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("FC_EC_Q1")
                        .HasColumnType("REAL");

                    b.Property<double>("FC_KS_Q1")
                        .HasColumnType("REAL");

                    b.Property<double>("FC_LTS_Q1")
                        .HasColumnType("REAL");

                    b.Property<double>("FC_PE_Q1")
                        .HasColumnType("REAL");

                    b.Property<double>("FC_TP_Q1")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("FunctionalComponents");
                });

            modelBuilder.Entity("migo_be.Models.Innovation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("CA_Q1")
                        .HasColumnType("REAL");

                    b.Property<double>("CA_Q2")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Innovations");
                });

            modelBuilder.Entity("migo_be.Models.Integrity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("CA_Q1")
                        .HasColumnType("REAL");

                    b.Property<double>("CA_Q2")
                        .HasColumnType("REAL");

                    b.Property<double>("CA_Q3")
                        .HasColumnType("REAL");

                    b.Property<double>("CA_Q4")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Integrities");
                });

            modelBuilder.Entity("migo_be.Models.Performance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("P_A_Q1")
                        .HasColumnType("REAL");

                    b.Property<double>("P_B_Q1")
                        .HasColumnType("REAL");

                    b.Property<double>("P_C_Q1")
                        .HasColumnType("REAL");

                    b.Property<double>("P_D_Q1")
                        .HasColumnType("REAL");

                    b.Property<double>("P_E_Q1")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Performances");
                });

            modelBuilder.Entity("migo_be.Models.Quality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("CA_Q1")
                        .HasColumnType("REAL");

                    b.Property<double>("CA_Q2")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Quality");
                });

            modelBuilder.Entity("migo_be.Models.Training", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Aspects")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Trainings");
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

            modelBuilder.Entity("EmployeeTraining", b =>
                {
                    b.HasOne("Alliance_API.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("migo_be.Models.Training", null)
                        .WithMany()
                        .HasForeignKey("TrainingsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("migo_be.Models.Assessment", b =>
                {
                    b.HasOne("migo_be.Models.Agility", "Agility")
                        .WithMany()
                        .HasForeignKey("AgilityId");

                    b.HasOne("migo_be.Models.Efficiency", "Efficiency")
                        .WithMany()
                        .HasForeignKey("EfficiencyId");

                    b.HasOne("Alliance_API.Models.Employee", "Employee")
                        .WithMany("Assessments")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("migo_be.Models.FunctionalComponents", "FunctionalComponents")
                        .WithMany()
                        .HasForeignKey("FunctionalComponentsId");

                    b.HasOne("migo_be.Models.Innovation", "Innovation")
                        .WithMany()
                        .HasForeignKey("InnovationId");

                    b.HasOne("migo_be.Models.Integrity", "Integrity")
                        .WithMany()
                        .HasForeignKey("IntegrityId");

                    b.HasOne("migo_be.Models.Performance", "Performance")
                        .WithMany()
                        .HasForeignKey("PerformanceId");

                    b.HasOne("migo_be.Models.Quality", "Quality")
                        .WithMany()
                        .HasForeignKey("QualityId");

                    b.Navigation("Agility");

                    b.Navigation("Efficiency");

                    b.Navigation("Employee");

                    b.Navigation("FunctionalComponents");

                    b.Navigation("Innovation");

                    b.Navigation("Integrity");

                    b.Navigation("Performance");

                    b.Navigation("Quality");
                });

            modelBuilder.Entity("migo_be.Models.EmployeeTimeLogs", b =>
                {
                    b.HasOne("Alliance_API.Models.Employee", "Employee")
                        .WithMany("EmployeeTimeLogs")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Alliance_API.Models.Employee", b =>
                {
                    b.Navigation("Assessments");

                    b.Navigation("EmployeeTimeLogs");
                });
#pragma warning restore 612, 618
        }
    }
}
