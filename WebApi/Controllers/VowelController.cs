using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Models.Dto;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class VowelController : ControllerBase
    {

        [HttpPost("vowelTxt")]
        public Task<ActionResult<VowelDTO>> PostVowel(VowelTxtDTO vowelTxt)
        {
            if(vowelTxt.txt is null) { return BadRequest(); }
            else 
            {
                var voweldto = VowelCntrl(vowelTxt);
                return Ok(voweldto);
            }
        }

        private VowelDTO VowelCntrl (VowelTxtDTO vowelTxt) 
        {
            VowelDTO voweldto = new VowelDTO();
            voweldto.Vowels = new List<char>();
            voweldto.VowelsCount = new List<int>();

            voweldto.YourText = vowelTxt.txt;
            if (vowelTxt.nat == "en")
            {
                voweldto.Vowels = VowelChrs.txten;
                voweldto.Lang = "English";
            }
            else
            {
                voweldto.Vowels = VowelChrs.txttr;
                voweldto.Lang = "Türkçe";
            }

            foreach (var chrs in voweldto.Vowels)
            {
                voweldto.VowelsCount.Add(vowelTxt.txt.ToLower().Where(x => x == chrs).Count());
            }
            return voweldto;
        }
    }
}
