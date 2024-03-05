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
    public class AlarmniSistemController : ControllerBase
    {
        [HttpGet]
        [Route("ReadSveAlarmneSisteme")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ReadSveAlarmneSisteme()
        {
            try
            {
                return new JsonResult(DTOManager.ReadSveAlarmneSisteme());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        [Route("CreateAlarmniSistem")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult CreateAlarmniSistem([FromBody] Alarmni_Sistem_View als)
        {
            try
            {
                DTOManager.CreateAlarmniSistem(als);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPut]
        [Route("UpdateAlarmniSistem")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdateAlarmniSistem([FromBody] Alarmni_Sistem_View als)
        {
            try
            {
                DTOManager.UpdateAlarmniSistem(als);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpDelete]
        [Route("DeleteAlarmniSistem/{idALS}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteAlarmniSistem(int idALS)
        {
            try
            {
                DTOManager.DeleteAlarmniSistem(idALS);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
