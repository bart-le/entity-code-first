using doctors.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace doctors.Configurations
{
	public class MedicamentConfiguration : IEntityTypeConfiguration<Medicament>
	{
		public void Configure(EntityTypeBuilder<Medicament> builder)
		{
			builder
				.HasKey(medicament => medicament.IdMedicament);
			builder
				.Property(medicament => medicament.Name)
				.IsRequired()
				.HasMaxLength(100);
			builder
				.Property(medicament => medicament.Description)
				.IsRequired()
				.HasMaxLength(100);
			builder
				.Property(medicament => medicament.Type)
				.IsRequired()
				.HasMaxLength(100);
		}
	}
}
