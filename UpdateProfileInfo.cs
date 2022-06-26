using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SketchfabAPI.Models
{
    public class UpdateProfileInfo
    {
        public string password { get; set; }
        public string passwordConfirmation { get; set; }
        public string displayName { get; set; }
        public string facebookUsername { get; set; }
        public string biography { get; set; }
        public string tagline { get; set; }
        public string website { get; set; }
        public string city { get; set; }
        public string country { get; set; }

    }
}
