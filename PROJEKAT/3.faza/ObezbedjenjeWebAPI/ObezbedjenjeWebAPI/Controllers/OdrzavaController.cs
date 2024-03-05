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
    public class OdrzavaController : ControllerBase
    {
        [HttpGet]
        [Route("ReadSvaOdrzavanja")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ReadSvaOdrzavanja()
        {
            try
            {
                return new JsonResult(DTOManager.ReadSvaOdrzavanja());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet]
        [Route("ReadOdrzavanjeTehLica/{idTehLica}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ReadOdrzavanjeTehLica(int idTehLica)
        {
            try
            {
                return new JsonResult(DTOManager.ReadOdrzavanjeTehLica(idTehLica));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        [Route("CreateOdrzava/{idAS}/{idTL}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult CreateOdrzava([FromBody] Odrzava_View o, int idAS, int idTL)
        {
            try
            {
                DTOManager.CreateOdrzava(o, idAS, idTL);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPut]
        [Route("UpdateOdrzava")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdateOdrzava([FromBody] Odrzava_View o)
        {
            try
            {
                DTOManager.UpdateOdrzava(o);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpDelete]
        [Route("DeleteOdrzava/{idOdrzavanja}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteOdrzava(int idOdrzavanja)
        {
            try
            {
                DTOManager.DeleteOdrzava(idOdrzavanja);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
