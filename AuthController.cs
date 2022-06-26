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
    public class AuthController : ControllerBase
    {
        private readonly ModelService cl = new ModelService();
        [HttpPost("GetToken")]
        public string GetToken(string _email, string _password)
        {
            return cl.GetAuthToken(_email, _password).Result;
        }
    }
}
