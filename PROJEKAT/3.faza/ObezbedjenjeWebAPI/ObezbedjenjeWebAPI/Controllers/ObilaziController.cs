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
    public class ObilaziController : ControllerBase
    {
        [HttpGet]
        [Route("ReadSvaObilazenja")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ReadSvaObilazenja()
        {
            try
            {
                return new JsonResult(DTOManager.ReadSvaObilazenja());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet]
        [Route("ReadObilazenjaObjekta/{idObj}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ReadObilazenjaObjekta(int idObj)
        {
            try
            {
                return new JsonResult(DTOManager.ReadObilazenjaObjekta(idObj));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        [Route("CreateObilazi/{idOb}/{idSm}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult CreateObilazi(int idOb, int idSm)
        {
            try
            {
                DTOManager.CreateObilazi(idOb, idSm);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPut]
        [Route("UpdateObilazi/{idSm}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdateObilazi([FromBody] Obilazi_View o, int idSm)
        {
            try
            {
                DTOManager.UpdateObilazi(o, idSm);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpDelete]
        [Route("DeleteObilazi/{idOb}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteObilazi(int idOb)
        {
            try
            {
                DTOManager.DeleteObilazi(idOb);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
