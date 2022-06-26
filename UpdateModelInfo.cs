using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SketchfabAPI.Models
{
    public class UpdateModelInfo
    {
        public string uid { get; set; }
        public string name { get; set; }
        public List<string> categories { get; set; }
        public List<string> tags { get; set; }
        public string description { get; set; }


    }
}
