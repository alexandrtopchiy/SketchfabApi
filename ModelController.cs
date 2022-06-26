using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SketchfabAPI.Models;
using SketchfabAPI.Client;
using _3DAPI.Models;

namespace SketchfabAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ModelController : ControllerBase
    {
        private readonly ModelService cl = new ModelService();

        [HttpGet("ModelInfo")]
        [ApiExplorerSettings(IgnoreApi = false)]
        public Models3D ModelInf(string uid)
        {

            return cl.GetModelsByAsync(uid).Result; // 6c82db5da59548348042d740e46f186b
        }
     

        [HttpGet("GetMyModels")]
        [ApiExplorerSettings(IgnoreApi = false)]
        public GetMeModels GetMyModels(bool _downlodable, bool _archives_flavours)
        {

            return cl.GetMyModelsByAsync(_downlodable, _archives_flavours).Result; // 6c82db5da59548348042d740e46f186b
        }
        
        [HttpPatch("UpdateModelInfoByAsync")]
        public IActionResult UpdateModelInfoByAsync(string _uid, string _name,[FromQuery] List<string> _categories, [FromQuery] List<string> _tags, string _description)
        {
           cl.UpdateModelInfoByAsync(_uid, _name, _categories, _tags, _description);
            return Ok();
        }
        
        [HttpDelete("DeleteModel")]
        public IActionResult DeleteModel(string uid)
        {
            cl.DeleteModel(uid);
            return Ok();
        }


        [HttpGet("SearchModels")]
        public IActionResult SearchTheModel(string searchRequest)
        {
            return Ok(cl.SearchModelsByAsync(searchRequest).Result);
        }
    }

}
