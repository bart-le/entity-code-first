using doctors.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace doctors.Configurations
{
	public class PrescriptionMedicamentConfiguration : IEntityTypeConfiguration<PrescriptionMedicament>
	{
		public void Configure(EntityTypeBuilder<PrescriptionMedicament> builder)
		{
			builder
				.HasKey(prescriptionMedicament => new
				{
					prescriptionMedicament.IdMedicament,
					prescriptionMedicament.IdPrescription
				});
			builder
				.Property(prescriptionMedicament => prescriptionMedicament.Dose)
				.IsRequired(false);
			builder
				.HasOne(prescriptionMedicament => prescriptionMedicament.Prescription)
				.WithMany(prescription => prescription.PrescriptionMedicaments)
				.HasForeignKey(prescriptionMedicament => prescriptionMedicament.IdPrescription);
			builder
				.HasOne(prescriptionMedicament => prescriptionMedicament.Medicament)
				.WithMany(medicament => medicament.PrescriptionMedicaments)
				.HasForeignKey(prescriptionMedicament => prescriptionMedicament.IdMedicament);
		}
	}
}
