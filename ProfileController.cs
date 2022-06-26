using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SketchfabAPI.Models;
using SketchfabAPI.Client;
using _3DAPI.Models;
using SketchfabAPI.Services;

namespace SketchfabAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfileController : ControllerBase
    {
        private readonly ProfileService cl = new ProfileService();
            
        [HttpPost("LikeTheModel")]
        [ApiExplorerSettings(IgnoreApi = false)]
        public IActionResult LikeTheModel(string uid)
        {
            cl.LikeModelsByAsync(uid);
            return Ok(); // 6c82db5da59548348042d740e46f186b
        }


        [HttpGet("GetMyProfile")]      
        public ProfileModel GetMyProfile()
        {
            return cl.GetProfileByAsync().Result;
        }

        
        [HttpPatch("UpdateProfileByAsync")]
        public IActionResult UpdateProfile(string _password, string _passwordConfirmation,
           string _displayName, string _facebookUsername,
           string _biography, string _tagline,
           string _website, string _city, string _country)
        {
            cl.UpdateProfile(_password, _passwordConfirmation,
                 _displayName, _facebookUsername,
                 _biography, _tagline,
                  _website, _city,
                   _country);
            return Ok();
        }

    }
}
