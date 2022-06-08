using doctors.Models;
using doctors.Models.DTO;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Numerics;
using System.Threading.Tasks;

namespace doctors.Services
{
	public class DoctorsDatabaseService : IDatabaseService
	{
		private readonly DatabaseContext _databaseContext;

		public DoctorsDatabaseService(DatabaseContext databaseContext)
		{
			_databaseContext = databaseContext;
		}

		public async Task<IEnumerable<DoctorDto>> GetDoctorsAsync()
		{
			return await _databaseContext.Doctors
				.Select(doctor => new DoctorDto
				{
					FirstName = doctor.FirstName,
					LastName = doctor.LastName,
					Email = doctor.Email
				}).ToListAsync();
		}

		public async Task<DoctorDto> GetDoctorAsync(int idDoctor)
		{
			return await _databaseContext.Doctors
				.Where(doctor => doctor.IdDoctor == idDoctor)
				.Select(doctor => new DoctorDto
				{
					FirstName = doctor.FirstName,
					LastName = doctor.LastName,
					Email = doctor.Email
				}).FirstOrDefaultAsync();
		}
	}
}
