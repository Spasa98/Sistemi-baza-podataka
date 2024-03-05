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
    public class RadiController : ControllerBase
    {
        [HttpGet]
        [Route("ReadSvaRadi")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ReadSvaRadi()
        {
            try
            {
                return new JsonResult(DTOManager.ReadSvaRadi());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet]
        [Route("ReadRadiJedneEkipe/{idE}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ReadRadiJedneEkipe(int idE)
        {
            try
            {
                return new JsonResult(DTOManager.ReadRadiJedneEkipe(idE));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        [Route("CreateRadi/{idEk}/{idSm}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult CreateRadi(int idEk, int idSm)
        {
            try
            {
                DTOManager.CreateRadi(idEk, idSm);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPut]
        [Route("UpdateRadi/{idEk}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdateRadi([FromBody] Radi_View r, int idEk)
        {
            try
            {
                DTOManager.UpdateRadi(r, idEk);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpDelete]
        [Route("DeleteRadi/{idRadi}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteRadi(int idRadi)
        {
            try
            {
                DTOManager.DeleteRadi(idRadi);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
