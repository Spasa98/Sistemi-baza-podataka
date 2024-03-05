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
    public class EkipaController : ControllerBase
    {
        [HttpGet]
        [Route("ReadSveEkipe")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ReadSveEkipe()
        {
            try
            {
                return new JsonResult(DTOManager.ReadSveEkipe());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        [Route("CreateEkipa")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult CreateEkipa([FromBody] Ekipa_View ek)
        {
            try
            {
                DTOManager.CreateEkipa(ek);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPut]
        [Route("UpdateEkipa")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdateEkipa([FromBody] Ekipa_View ek)
        {
            try
            {
                DTOManager.UpdateEkipa(ek);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpDelete]
        [Route("DeleteEkipa/{idE}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteEkipa(int idE)
        {
            try
            {
                DTOManager.DeleteEkipa(idE);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
