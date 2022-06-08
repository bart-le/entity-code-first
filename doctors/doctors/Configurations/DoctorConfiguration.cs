using System.Numerics;
using System.Reflection.Emit;

using doctors.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace doctors.Configurations
{
	public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
	{
		public void Configure(EntityTypeBuilder<Doctor> builder)
		{
			builder
				.HasKey(doctor => doctor.IdDoctor);
			builder
				.Property(doctor => doctor.FirstName)
				.IsRequired()
				.HasMaxLength(100);
			builder
				.Property(doctor => doctor.LastName)
				.IsRequired()
				.HasMaxLength(100);
			builder
				.Property(doctor => doctor.Email)
				.IsRequired()
				.HasMaxLength(100);
		}
	}
}
