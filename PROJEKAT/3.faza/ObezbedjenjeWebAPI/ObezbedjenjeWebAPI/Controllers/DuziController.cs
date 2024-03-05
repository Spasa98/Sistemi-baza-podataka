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
    public class DuziController : ControllerBase
    {
        [HttpGet]
        [Route("ReadSveEkipaDuziVozilo")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ReadSveEkipaDuziVozilo()
        {
            try
            {
                return new JsonResult(DTOManager.ReadSveEkipaDuziVozilo());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet]
        [Route("ReadZaduzenjeEkipe/{idE}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ReadZaduzenjeEkipe(int idE)
        {
            try
            {
                return new JsonResult(DTOManager.ReadZaduzenjeEkipe(idE));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        [Route("CreateEkipaDuziVozilo/{idE}/{idV}/{vreme}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult CreateEkipaDuziVozilo(int idE, int idV, int vreme)
        {
            try
            {
                DTOManager.CreateEkipaDuziVozilo(idE, idV, vreme);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPut]
        [Route("UpdateEkipaDuziVozilo")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdateEkipaDuziVozilo([FromBody] Duzi_View d)
        {
            try
            {
                DTOManager.UpdateEkipaDuziVozilo(d);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpDelete]
        [Route("DeleteEkipaDuziVozilo/{idDuzi}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteEkipaDuziVozilo(int idDuzi)
        {
            try
            {
                DTOManager.DeleteEkipaDuziVozilo(idDuzi);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
