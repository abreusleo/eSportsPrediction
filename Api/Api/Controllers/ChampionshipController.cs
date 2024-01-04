using System.Collections.Generic;
using Api.Dtos;
using Api.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ChampionshipController : ControllerBase
{
    private readonly ILogger<ChampionshipController> _logger;

    public ChampionshipController(ILogger<ChampionshipController> logger)
    {
        _logger = logger;
    }
    
    [HttpGet]
    public IActionResult GetPossibleChampionships()
    {
        GetPossibleChampionshipsDto dto = new GetPossibleChampionshipsDto { Id = 0, Name = "VCT Americas", Region = ChampionshipRegions.Americas.ToString(), LogoUrl = "https://cdn.thespike.gg/VCT%25202023%2FVCT23-AMERICAS_1678786271315.png" };
        GetPossibleChampionshipsDto secondDto = new GetPossibleChampionshipsDto { Id = 1, Name = "VCT EMEA", Region = ChampionshipRegions.EMEA.ToString(), LogoUrl = "https://cdn.thespike.gg/VCT%25202023%2FVCT23-AMERICAS_1678786271315.png" };
        List<GetPossibleChampionshipsDto> dtoList = new List<GetPossibleChampionshipsDto> { dto, secondDto };

        return Ok(dtoList);
    }
}