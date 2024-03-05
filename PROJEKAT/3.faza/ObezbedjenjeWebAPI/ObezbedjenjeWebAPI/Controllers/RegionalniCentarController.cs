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
    public class RegionalniCentarController : ControllerBase
    {
        [HttpGet]
        [Route("ReadSveRegCentre")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ReadSveRegCentre()
        {
            try
            {
                return new JsonResult(DTOManager.ReadSveRegCentre());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        [Route("CreateRegionalniCentar")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult CreateRegionalniCentar([FromBody] Regionalni_Centar_View rc)
        {
            try
            {
                DTOManager.CreateRegionalniCentar(rc);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPut]
        [Route("UpdateRegionalniCentar/{adr}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdateRegionalniCentar([FromBody] Regionalni_Centar_View rc, string adr)
        {
            try
            {
                DTOManager.UpdateRegionalniCentar(rc, adr);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpDelete]
        [Route("DeleteRegionalniCentar/{idRC}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteRegionalniCentar(int idRC)
        {
            try
            {
                DTOManager.DeleteRegionalniCentar(idRC);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
