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
    public class ZaduzenaController : ControllerBase
    {
        [HttpGet]
        [Route("ReadSvaZaduzenja")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ReadSvaZaduzenja()
        {
            try
            {
                return new JsonResult(DTOManager.ReadSvaZaduzenja());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet]
        [Route("ReadZaduzenjaEkipe/{idEk}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ReadZaduzenjaEkipe(int idEk)
        {
            try
            {
                return new JsonResult(DTOManager.ReadZaduzenjaEkipe(idEk));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        [Route("CreateZaduzena/{idEk}/{idObj}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult CreateZaduzena(int idEk, int idObj)
        {
            try
            {
                DTOManager.CreateZaduzena(idEk, idObj);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPut]
        [Route("UpdateZaduzena/{idEk}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdateZaduzena([FromBody] Zaduzena_View z, int idEk)
        {
            try
            {
                DTOManager.UpdateZaduzena(z, idEk);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpDelete]
        [Route("DeleteZaduzena/{idZad}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteZaduzena(int idZad)
        {
            try
            {
                DTOManager.DeleteZaduzena(idZad);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
