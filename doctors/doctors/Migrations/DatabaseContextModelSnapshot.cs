﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using doctors.Models;

namespace doctors.Migrations
{
	[DbContext(typeof(DatabaseContext))]
	partial class DatabaseContextModelSnapshot : ModelSnapshot
	{
		protected override void BuildModel(ModelBuilder modelBuilder)
		{
#pragma warning disable 612, 618
			modelBuilder
				.HasAnnotation("Relational:MaxIdentifierLength", 128)
				.HasAnnotation("ProductVersion", "5.0.17")
				.HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

			modelBuilder.Entity("doctors.Models.Doctor", b =>
				{
					b.Property<int>("IdDoctor")
						.ValueGeneratedOnAdd()
						.HasColumnType("int")
						.HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

					b.Property<string>("Email")
						.IsRequired()
						.HasMaxLength(100)
						.HasColumnType("nvarchar(100)");

					b.Property<string>("FirstName")
						.IsRequired()
						.HasMaxLength(100)
						.HasColumnType("nvarchar(100)");

					b.Property<string>("LastName")
						.IsRequired()
						.HasMaxLength(100)
						.HasColumnType("nvarchar(100)");

					b.HasKey("IdDoctor");

					b.ToTable("Doctors");

					b.HasData(
						new
						{
							IdDoctor = 1,
							Email = "doctor@strange.com",
							FirstName = "Stephen",
							LastName = "Strange"
						},
						new
						{
							IdDoctor = 2,
							Email = "lizard@doc.com",
							FirstName = "Curtis",
							LastName = "Connors"
						},
						new
						{
							IdDoctor = 3,
							Email = "doc@ock.com",
							FirstName = "Otto",
							LastName = "Octavius"
						},
						new
						{
							IdDoctor = 4,
							Email = "hulk@smash.com",
							FirstName = "Bruce",
							LastName = "Banner"
						},
						new
						{
							IdDoctor = 5,
							Email = "doctor@doom.com",
							FirstName = "Victor",
							LastName = "von Doom"
						});
				});

			modelBuilder.Entity("doctors.Models.Medicament", b =>
				{
					b.Property<int>("IdMedicament")
						.ValueGeneratedOnAdd()
						.HasColumnType("int")
						.HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

					b.Property<string>("Description")
						.IsRequired()
						.HasMaxLength(100)
						.HasColumnType("nvarchar(100)");

					b.Property<string>("Name")
						.IsRequired()
						.HasMaxLength(100)
						.HasColumnType("nvarchar(100)");

					b.Property<string>("Type")
						.IsRequired()
						.HasMaxLength(100)
						.HasColumnType("nvarchar(100)");

					b.HasKey("IdMedicament");

					b.ToTable("Medicaments");

					b.HasData(
						new
						{
							IdMedicament = 1,
							Description = "Sleep deprivation",
							Name = "Hydroxyzine",
							Type = "Antihistamine"
						},
						new
						{
							IdMedicament = 2,
							Description = "Multi-purpose",
							Name = "Mephedrone",
							Type = "Stimulant"
						},
						new
						{
							IdMedicament = 3,
							Description = "Depression",
							Name = "Prozac",
							Type = "Antidepressant"
						},
						new
						{
							IdMedicament = 4,
							Description = "ADHD",
							Name = "Vyvanse",
							Type = "Stimulant"
						},
						new
						{
							IdMedicament = 5,
							Description = "Depression",
							Name = "Xanax",
							Type = "Antidepressant"
						});
				});

			modelBuilder.Entity("doctors.Models.Patient", b =>
				{
					b.Property<int>("IdPatient")
						.ValueGeneratedOnAdd()
						.HasColumnType("int")
						.HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

					b.Property<DateTime>("Birthdate")
						.HasColumnType("datetime2");

					b.Property<string>("FirstName")
						.IsRequired()
						.HasMaxLength(100)
						.HasColumnType("nvarchar(100)");

					b.Property<string>("LastName")
						.IsRequired()
						.HasMaxLength(100)
						.HasColumnType("nvarchar(100)");

					b.HasKey("IdPatient");

					b.ToTable("Patients");

					b.HasData(
						new
						{
							IdPatient = 1,
							Birthdate = new DateTime(191, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
							FirstName = "Alan",
							LastName = "Turing"
						},
						new
						{
							IdPatient = 2,
							Birthdate = new DateTime(1950, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
							FirstName = "Bjarne",
							LastName = "Stroustrup"
						},
						new
						{
							IdPatient = 3,
							Birthdate = new DateTime(1815, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
							FirstName = "Ada",
							LastName = "Lovelace"
						},
						new
						{
							IdPatient = 4,
							Birthdate = new DateTime(1914, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
							FirstName = "Dennis",
							LastName = "Ritchie"
						},
						new
						{
							IdPatient = 5,
							Birthdate = new DateTime(1943, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
							FirstName = "Ken",
							LastName = "Thompson"
						});
				});

			modelBuilder.Entity("doctors.Models.Prescription", b =>
				{
					b.Property<int>("IdPrescription")
						.ValueGeneratedOnAdd()
						.HasColumnType("int")
						.HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

					b.Property<DateTime>("Date")
						.HasColumnType("datetime2");

					b.Property<DateTime>("DueDate")
						.HasColumnType("datetime2");

					b.Property<int>("IdDoctor")
						.HasColumnType("int");

					b.Property<int>("IdPatient")
						.HasColumnType("int");

					b.HasKey("IdPrescription");

					b.HasIndex("IdDoctor");

					b.HasIndex("IdPatient");

					b.ToTable("Prescriptions");

					b.HasData(
						new
						{
							IdPrescription = 1,
							Date = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
							DueDate = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
							IdDoctor = 1,
							IdPatient = 1
						},
						new
						{
							IdPrescription = 2,
							Date = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
							DueDate = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
							IdDoctor = 2,
							IdPatient = 2
						},
						new
						{
							IdPrescription = 3,
							Date = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
							DueDate = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
							IdDoctor = 3,
							IdPatient = 3
						},
						new
						{
							IdPrescription = 4,
							Date = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
							DueDate = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
							IdDoctor = 4,
							IdPatient = 4
						},
						new
						{
							IdPrescription = 5,
							Date = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
							DueDate = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
							IdDoctor = 5,
							IdPatient = 5
						},
						new
						{
							IdPrescription = 6,
							Date = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
							DueDate = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
							IdDoctor = 1,
							IdPatient = 1
						},
						new
						{
							IdPrescription = 7,
							Date = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
							DueDate = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
							IdDoctor = 2,
							IdPatient = 2
						},
						new
						{
							IdPrescription = 8,
							Date = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
							DueDate = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
							IdDoctor = 3,
							IdPatient = 3
						},
						new
						{
							IdPrescription = 9,
							Date = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
							DueDate = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
							IdDoctor = 4,
							IdPatient = 4
						},
						new
						{
							IdPrescription = 10,
							Date = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
							DueDate = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
							IdDoctor = 5,
							IdPatient = 5
						});
				});

			modelBuilder.Entity("doctors.Models.PrescriptionMedicament", b =>
				{
					b.Property<int>("IdMedicament")
						.HasColumnType("int");

					b.Property<int>("IdPrescription")
						.HasColumnType("int");

					b.Property<string>("Details")
						.HasColumnType("nvarchar(max)");

					b.Property<int?>("Dose")
						.HasColumnType("int");

					b.HasKey("IdMedicament", "IdPrescription");

					b.HasIndex("IdPrescription");

					b.ToTable("PrescriptionMedicaments");

					b.HasData(
						new
						{
							IdMedicament = 1,
							IdPrescription = 2,
							Details = "0-0-1",
							Dose = 1
						},
						new
						{
							IdMedicament = 4,
							IdPrescription = 3,
							Details = "0-0-1",
							Dose = 1
						},
						new
						{
							IdMedicament = 5,
							IdPrescription = 1,
							Details = "1-1-1",
							Dose = 10
						},
						new
						{
							IdMedicament = 3,
							IdPrescription = 2,
							Details = "1-1-1",
							Dose = 10
						},
						new
						{
							IdMedicament = 4,
							IdPrescription = 5,
							Details = "1-0-0",
							Dose = 1
						},
						new
						{
							IdMedicament = 2,
							IdPrescription = 1,
							Details = "1-0-0",
							Dose = 1
						},
						new
						{
							IdMedicament = 3,
							IdPrescription = 4,
							Details = "1-0-0",
							Dose = 1
						},
						new
						{
							IdMedicament = 1,
							IdPrescription = 5,
							Details = "1-0-0",
							Dose = 1
						},
						new
						{
							IdMedicament = 2,
							IdPrescription = 3,
							Details = "0-1-1",
							Dose = 2
						},
						new
						{
							IdMedicament = 5,
							IdPrescription = 4,
							Details = "0-1-1",
							Dose = 2
						});
				});

			modelBuilder.Entity("doctors.Models.Prescription", b =>
				{
					b.HasOne("doctors.Models.Doctor", "Doctor")
						.WithMany("Prescriptions")
						.HasForeignKey("IdDoctor")
						.OnDelete(DeleteBehavior.Cascade)
						.IsRequired();

					b.HasOne("doctors.Models.Patient", "Patient")
						.WithMany("Prescriptions")
						.HasForeignKey("IdPatient")
						.OnDelete(DeleteBehavior.Cascade)
						.IsRequired();

					b.Navigation("Doctor");

					b.Navigation("Patient");
				});

			modelBuilder.Entity("doctors.Models.PrescriptionMedicament", b =>
				{
					b.HasOne("doctors.Models.Medicament", "Medicament")
						.WithMany("PrescriptionMedicaments")
						.HasForeignKey("IdMedicament")
						.OnDelete(DeleteBehavior.Cascade)
						.IsRequired();

					b.HasOne("doctors.Models.Prescription", "Prescription")
						.WithMany("PrescriptionMedicaments")
						.HasForeignKey("IdPrescription")
						.OnDelete(DeleteBehavior.Cascade)
						.IsRequired();

					b.Navigation("Medicament");

					b.Navigation("Prescription");
				});

			modelBuilder.Entity("doctors.Models.Doctor", b =>
				{
					b.Navigation("Prescriptions");
				});

			modelBuilder.Entity("doctors.Models.Medicament", b =>
				{
					b.Navigation("PrescriptionMedicaments");
				});

			modelBuilder.Entity("doctors.Models.Patient", b =>
				{
					b.Navigation("Prescriptions");
				});

			modelBuilder.Entity("doctors.Models.Prescription", b =>
				{
					b.Navigation("PrescriptionMedicaments");
				});
#pragma warning restore 612, 618
		}
	}
}
