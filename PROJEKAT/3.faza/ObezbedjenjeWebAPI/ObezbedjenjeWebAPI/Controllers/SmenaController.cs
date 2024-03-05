using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ObezbedjenjeClassLibrary;
using ObezbedjenjeClassLibrary.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObezbedjenjeWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SmenaController : ControllerBase
    {
        [HttpGet]
        [Route("ReadSveSmene")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ReadSveSmene()
        {
            try
            {
                return new JsonResult(DTOManager.ReadSveSmene());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        [Route("CreateSmena")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult CreateSmena([FromBody] Smena_View sm)
        {
            try
            {
                DTOManager.CreateSmena(sm);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPut]
        [Route("UpdateSmena")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdateSmena([FromBody] Smena_View sm)
        {
            try
            {
                DTOManager.UpdateSmena(sm);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpDelete]
        [Route("DeleteSmena/{idS}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteSmena(int idS)
        {
            try
            {
                DTOManager.DeleteSmena(idS);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
