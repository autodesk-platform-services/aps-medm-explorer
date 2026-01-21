using aps_medm_explorer.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace aps_medm_explorer.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HubsController : ControllerBase
{
	private readonly ILogger<HubsController> _logger;
	private readonly APSService _apsService;

	public HubsController(ILogger<HubsController> logger, APSService forgeService)
	{
		_logger = logger;
		_apsService = forgeService;
	}

}