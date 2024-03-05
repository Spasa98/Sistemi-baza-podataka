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
    public class VoziloController : ControllerBase
    {
        [HttpGet]
        [Route("ReadSvaVozila")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ReadSvaVozila()
        {
            try
            {
                return new JsonResult(DTOManager.ReadSvaVozila());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        [Route("CreateVozilo/{idRC}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult CreateVozilo([FromBody] Vozilo_View g, int idRC)
        {
            try
            {
                DTOManager.CreateVozilo(g, idRC);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPut]
        [Route("UpdateVozilo")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdateVozilo([FromBody] Vozilo_View v)
        {
            try
            {
                DTOManager.UpdateVozilo(v);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpDelete]
        [Route("DeleteVozilo/{idV}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteVozilo(int idV)
        {
            try
            {
                DTOManager.DeleteVozilo(idV);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
