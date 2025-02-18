﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using models;

namespace Projekat1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AerodromController : ControllerBase
    {
        public ContextKlasa Context { get; set; }

        public AerodromController(ContextKlasa context)
        {
            Context = context;
        }

        [Route("PronadjiAerodrome")]
        [HttpGet]
        public async Task<ActionResult> PronadjiAerodrome()
        {
            try
            {
                var aerodrom = await Context.Aerodromi.ToListAsync();

                return Ok(aerodrom);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
            

        }
    }
}