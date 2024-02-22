using AutoMapper;
using Day6_efcore1.Context;
using Day6_efcore1.Dtos.Requests;
using Day6_efcore1.Models;
using Day6_efcore1.Repositories.Abstract;
using Day6_efcore1.Services.Abstract;
using Day6_efcore1.Services.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Day6_efcore1.Controllers;


[Route("api/[controller]")] // https://localhost:5000/api/players
[ApiController]
public class PlayersController : ControllerBase
{
    private readonly PlayerService _playerService; //İllaki Interface kullanılacak diye bir şart yok

    public PlayersController(PlayerService playerService)
    {
        _playerService = playerService;
    }

    [HttpPost("add")] // https://localhost:5000/api/players/add
    public IActionResult Add([FromBody] CreatePlayerRequestDto requestDto)
    {
        var response = _playerService.Add(requestDto);
        if (response.StatusCode == HttpStatusCode.Created)
        {
            return Created("/", response);
        }

        return BadRequest(response);
    }

    [HttpGet("getbyid")]
    public IActionResult GetById([FromQuery] int id)
    {
        var response = _playerService.GetById(id);
        if (response.StatusCode == HttpStatusCode.OK)
        {
            return Ok(response);
        }
        if(response.StatusCode==HttpStatusCode.NotFound)
        {
            return NotFound(response);
        }
        return BadRequest(response);
    }
}
