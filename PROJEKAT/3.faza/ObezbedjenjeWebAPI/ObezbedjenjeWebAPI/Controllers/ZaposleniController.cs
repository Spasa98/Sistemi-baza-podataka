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
    public class ZaposleniController : ControllerBase
    {
        [HttpGet]
        [Route("ReadSveZaposlene")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ReadSveZaposlene()
        {
            try
            {
                return new JsonResult(DTOManager.ReadSveZaposlene());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet]
        [Route("ReadSveMenadzere")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ReadSveMenadzere()
        {
            try
            {
                return new JsonResult(DTOManager.ReadSveMenadzere());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        [Route("CreateMenadzer/{idRC}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult CreateMenadzer(int idRC, [FromBody] Menadzer_View menadzer)
        {
            try
            {
                DTOManager.CreateMenadzer(idRC, menadzer);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPut]
        [Route("UpdateMenadzer/{idRCNovi}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdateMenadzer(int idRCNovi, [FromBody] Menadzer_View menadzer)
        {
            try
            {
                DTOManager.UpdateMenadzer(idRCNovi, menadzer);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpDelete]
        [Route("DeleteMenadzer/{idM}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteMenadzer(int idM)
        {
            try
            {
                DTOManager.DeleteMenadzer(idM);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet]
        [Route("ReadSvaTehnickaLica")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ReadSvaTehnickaLica()
        {
            try
            {
                return new JsonResult(DTOManager.ReadSvaTehnickaLica());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        [Route("CreateTehnickoLice")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult CreateTehnickoLice([FromBody] Tehnicko_Lice_View tl)
        {
            try
            {
                DTOManager.CreateTehnickoLice(tl);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPut]
        [Route("UpdateTehnickoLice/{oblast}/{struka}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdateTehnickoLice([FromBody] Tehnicko_Lice_View tl, string oblast, string struka)
        {
            try
            {
                DTOManager.UpdateTehnickoLice(tl, oblast, struka);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpDelete]
        [Route("DeleteTehnickoLice/{idTL}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteTehnickoLice(int idTL)
        {
            try
            {
                DTOManager.DeleteTehnickoLice(idTL);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet]
        [Route("ReadSvaFizickaObezbedjenja")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ReadSvaFizickaObezbedjenja()
        {
            try
            {
                return new JsonResult(DTOManager.ReadSvaFizickaObezbedjenja());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        [Route("CreateFizickoObezbedjenje/{idE}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult CreateFizickoObezbedjenje([FromBody] Fizicko_Obezbedjenje_View fo, int idE)
        {
            try
            {
                DTOManager.CreateFizickoObezbedjenje(fo, idE);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPut]
        [Route("UpdateFizickoObezbedjenje/{vestina}/{vodja}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdateFizickoObezbedjenje([FromBody] Fizicko_Obezbedjenje_View tl, string vestina, bool vodja)
        {
            try
            {
                DTOManager.UpdateFizickoObezbedjenje(tl, vestina, vodja);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpDelete]
        [Route("DeleteFizickoObezbedjenje/{idFO}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteFizickoObezbedjenje(int idFO)
        {
            try
            {
                DTOManager.DeleteFizickoObezbedjenje(idFO);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
