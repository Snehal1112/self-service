using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFDataAccessLibrary.DataAccess;
using EFDataAccessLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace self_service.Controllers;

[ApiController]
[Route("[controller]")]
public class PeopleController : ControllerBase
{
    private readonly PeopleContext _context;

    public PeopleController(PeopleContext context)
    {
        _context = context;
    }

    [HttpGet("GetPeopelsList")]
    public async Task<ActionResult<List<Person>>> GetPeopels()
    {
        return Ok(await _context.People.ToListAsync());
    }

}
