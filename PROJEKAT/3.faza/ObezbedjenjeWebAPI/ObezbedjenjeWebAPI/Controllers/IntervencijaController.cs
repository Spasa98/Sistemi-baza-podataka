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
    public class IntervencijaController : ControllerBase
    {
        [HttpGet]
        [Route("ReadSveIntervencije")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ReadSveIntervencije()
        {
            try
            {
                return new JsonResult(DTOManager.ReadSveIntervencije());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet]
        [Route("ReadIntervencijeEkipe/{idE}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ReadIntervencijeEkipe(int idE)
        {
            try
            {
                return new JsonResult(DTOManager.ReadIntervencijeEkipe(idE));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        [Route("CreateIntervencija/{idEk}/{idOb}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult CreateIntervencija([FromBody] Intervencija_View i, int idEk, int idOb)
        {
            try
            {
                DTOManager.CreateIntervencija(i, idEk, idOb);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPut]
        [Route("UpdateIntervencija")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdateIntervencija([FromBody] Intervencija_View i)
        {
            try
            {
                DTOManager.UpdateIntervencija(i);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpDelete]
        [Route("DeleteIntervencija/{idInter}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteIntervencija(int idInter)
        {
            try
            {
                DTOManager.DeleteIntervencija(idInter);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
