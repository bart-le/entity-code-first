using doctors.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace doctors.Configurations
{
	public class PrescriptionConfiguration : IEntityTypeConfiguration<Prescription>
	{
		public void Configure(EntityTypeBuilder<Prescription> builder)
		{
			builder
				.HasKey(prescription => prescription.IdPrescription);
			builder
				.Property(prescription => prescription.Date)
				.IsRequired();
			builder
				.Property(prescription => prescription.DueDate)
				.IsRequired();
			builder
				.HasOne(prescription => prescription.Patient)
				.WithMany(patient => patient.Prescriptions)
				.HasForeignKey(prescription => prescription.IdPatient);
			builder
				.HasOne(prescription => prescription.Doctor)
				.WithMany(doctor => doctor.Prescriptions)
				.HasForeignKey(prescription => prescription.IdDoctor);
		}
	}
}
