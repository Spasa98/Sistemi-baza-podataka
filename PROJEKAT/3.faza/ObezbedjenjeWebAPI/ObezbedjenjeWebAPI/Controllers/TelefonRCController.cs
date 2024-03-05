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
    public class TelefonRCController : ControllerBase
    {
        [HttpGet]
        [Route("ReadSveTelefoneRC")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ReadSveTelefoneRC()
        {
            try
            {
                return new JsonResult(DTOManager.ReadSveTelefoneRC());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet]
        [Route("ReadSveTelefoneJednogRC/{idRC}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ReadSveTelefoneJednogRC(int idRC)
        {
            try
            {
                return new JsonResult(DTOManager.ReadSveTelefoneJednogRC(idRC));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        [Route("CreateTelefonRC/{idRC}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult CreateTelefonRC([FromBody] Telefon_RC_View t, int idRC)
        {
            try
            {
                DTOManager.CreateTelefonRC(t, idRC);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPut]
        [Route("UpdateTelefonRC")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdateTelefonRC([FromBody] Telefon_RC_View t)
        {
            try
            {
                DTOManager.UpdateTelefonRC(t);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpDelete]
        [Route("DeleteTelefonRC/{idTel}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteTelefonRC(int idTel)
        {
            try
            {
                DTOManager.DeleteTelefonRC(idTel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
