﻿using Business.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ClientsController(ClientService clientService) : ControllerBase
{
    private readonly ClientService _clientService = clientService;

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _clientService.GetClientsAsync());
    }
}
