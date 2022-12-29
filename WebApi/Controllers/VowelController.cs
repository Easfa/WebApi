using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Models.Dto;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class VowelController : ControllerBase
    {

        [HttpPost("text")]
        public async Task<ActionResult<VowelDTO>> GetString(VowelTxt vowelTxt)
        {
            VowelDTO voweldto = new VowelDTO();

            voweldto.YourText = vowelTxt.txt;
            if (vowelTxt.nat == "tr")
            {
                voweldto.Txttr = VowelChrs.txttr;
                voweldto.Lang = "Türkçe";
                voweldto.Vowels = vowelTxt.txt.Where(x => VowelChrs.txttr.Contains(x)).ToList();
            }
            else if (vowelTxt.nat == "en")
            {
                voweldto.Txten = VowelChrs.txten;
                voweldto.Lang = "English";
                voweldto.Vowels = vowelTxt.txt.Where(x => VowelChrs.txten.Contains(x)).ToList();
            }

            return Ok(voweldto);
        }
    }
}
