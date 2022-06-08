﻿using System;
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
		Task<bool> DoctorExistsAsync(string email);
		Task AddDoctorAsync(DoctorDto payload);
		Task EditDoctorAsync(int idDoctor, DoctorDto payload);
	}
}
