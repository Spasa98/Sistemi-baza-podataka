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
    public class GradController : ControllerBase
    {
        [HttpGet]
        [Route("ReadSveGradove")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ReadSveGradove()
        {
            try
            {
                return new JsonResult(DTOManager.ReadSveGradove());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        [Route("CreateGrad")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult CreateGrad([FromBody] Grad_View g, int idMenadzera, int idRegCen)
        {
            try
            {
                DTOManager.CreateGrad(g, idMenadzera, idRegCen);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPut]
        [Route("UpdateGrad/{naziv}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdateGrad([FromBody] Grad_View g, string naziv)
        {
            try
            {
                DTOManager.UpdateGrad(g, naziv);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpDelete]
        [Route("DeleteGrad/{idG}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteGrad(int idG)
        {
            try
            {
                DTOManager.DeleteGrad(idG);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
