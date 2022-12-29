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
            voweldto.Vowels = new List<int>();

            voweldto.YourText = vowelTxt.txt;
            if (vowelTxt.nat == "en")
            {
                voweldto.Txten = VowelChrs.txten;
                voweldto.Lang = "English";
                foreach (var chrs in voweldto.Txten)
                {
                    voweldto.Vowels.Add(vowelTxt.txt.Where(x => x == chrs).Count());
                }
            }
            else
            {
                voweldto.Txttr = VowelChrs.txttr;
                voweldto.Lang = "Türkçe";
                foreach (var chrs in voweldto.Txttr)
                {
                    voweldto.Vowels.Add(vowelTxt.txt.Where(x => x == chrs).Count());
                }
            }
            

            return Ok(voweldto);
        }
    }
}
