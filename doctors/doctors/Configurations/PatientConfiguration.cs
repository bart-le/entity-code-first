using doctors.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace doctors.Configurations
{
	public class PatientConfiguration : IEntityTypeConfiguration<Patient>
	{
		public void Configure(EntityTypeBuilder<Patient> builder)
		{
			builder
				.HasKey(patient => patient.IdPatient);
			builder
				.Property(patient => patient.FirstName)
				.IsRequired()
				.HasMaxLength(100);
			builder
				.Property(patient => patient.LastName)
				.IsRequired()
				.HasMaxLength(100);
			builder
				.Property(patient => patient.Birthdate)
				.IsRequired();
		}
	}
}
