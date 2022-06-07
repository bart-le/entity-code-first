using doctors.Services;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace doctors.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DoctorsController : ControllerBase
	{
		private readonly IDatabaseService _databaseService;

		public DoctorsController(IDatabaseService databaseService)
		{
			_databaseService = databaseService;
		}
	}
}
