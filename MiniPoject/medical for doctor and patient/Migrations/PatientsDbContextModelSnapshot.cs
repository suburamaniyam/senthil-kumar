﻿// <auto-generated />
using MedicineOfDoctorPatients.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MedicineOfDoctorPatients.Migrations
{
    [DbContext(typeof(PatientsDbContext))]
    partial class PatientsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MedicineOfDoctorPatients.Model.Doctor", b =>
                {
                    b.Property<int>("Docid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Docid"));

                    b.Property<string>("DocName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocSpecialist")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Docid");

                    b.ToTable("Doctor");
                });

            modelBuilder.Entity("MedicineOfDoctorPatients.Model.Patients", b =>
                {
                    b.Property<int>("Patid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Patid"));

                    b.Property<int>("Docid")
                        .HasColumnType("int");

                    b.Property<string>("Patname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Patid");

                    b.HasIndex("Docid");

                    b.ToTable("Patientcs");
                });

            modelBuilder.Entity("MedicineOfDoctorPatients.Model.Patients", b =>
                {
                    b.HasOne("MedicineOfDoctorPatients.Model.Doctor", "Doctors")
                        .WithMany("Patient")
                        .HasForeignKey("Docid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctors");
                });

            modelBuilder.Entity("MedicineOfDoctorPatients.Model.Doctor", b =>
                {
                    b.Navigation("Patient");
                });
#pragma warning restore 612, 618
        }
    }
}
