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
    public class TelefonOController : ControllerBase
    {
        [HttpGet]
        [Route("ReadSveTelefoneO")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ReadSveTelefoneO()
        {
            try
            {
                return new JsonResult(DTOManager.ReadSveTelefoneO());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet]
        [Route("ReadSveTelefoneJednogO/{idO}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ReadSveTelefoneJednogO(int idO)
        {
            try
            {
                return new JsonResult(DTOManager.ReadSveTelefoneJednogO(idO));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        [Route("CreateTelefonO/{idO}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult CreateTelefonO([FromBody] Telefon_O_View t, int idO)
        {
            try
            {
                DTOManager.CreateTelefonO(t, idO);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPut]
        [Route("UpdateTelefonO")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdateTelefonO([FromBody] Telefon_O_View t)
        {
            try
            {
                DTOManager.UpdateTelefonO(t);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpDelete]
        [Route("DeleteTelefonO/{idTel}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteTelefonO(int idTel)
        {
            try
            {
                DTOManager.DeleteTelefonO(idTel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
