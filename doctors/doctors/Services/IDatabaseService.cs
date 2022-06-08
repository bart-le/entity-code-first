using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using doctors.Models;
using doctors.Models.DTO;

namespace doctors.Services
{
	public interface IDatabaseService
	{
		Task<IEnumerable<DoctorDto>> GetDoctorsAsync();
		Task<DoctorDto> GetDoctorAsync(int idDoctor);
	}
}
