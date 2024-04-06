using Magic_villa.Data;
using Magic_villa.Models;
using Microsoft.AspNetCore.Mvc;

namespace Magic_villa.Controllers
{
    [Route("api/VillaAPI")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet]

        public ActionResult <IEnumerable<VillaDTO>> GetVillas()
        {
            return Ok(Villastore.villaList);
        }
        [HttpGet("id")]
        public ActionResult<VillaDTO> GetVilla(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var villa = Villastore.villaList.FirstOrDefault(u => u.Id == id);
            if (villa == null)
            {
                return NotFound();//akash
            }
            return Ok(villa);
        }
    }
}
