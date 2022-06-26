using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SketchfabAPI.Models
{
    public class ProfileModel
    {
      //  public class Avatar
        //{
        //    public List<Image> images { get; set; }
        //    public string uid { get; set; }
        //    public string uri { get; set; }
        //}

        //public class Image
        //{
        //    public string url { get; set; }
        //    public int width { get; set; }
        //    public int height { get; set; }
        //    public int size { get; set; }
        //}

            public int subscriptionCount { get; set; }
            public int followerCount { get; set; }
            public string uid { get; set; }
            public string modelsUrl { get; set; }
            public int likeCount { get; set; }
            public string facebookUsername { get; set; }
            public string biography { get; set; }
            public string city { get; set; }
            public string tagline { get; set; }
            public int modelCount { get; set; }
            public string twitterUsername { get; set; }
            public string email { get; set; }
            public string website { get; set; }
            public string billingCycle { get; set; }
            public string followersUrl { get; set; }
            public int collectionCount { get; set; }
            public string dateJoined { get; set; }
            public string account { get; set; }
            public string displayName { get; set; }
            public string profileUrl { get; set; }
            public string followingsUrl { get; set; }
        //   public List<Skill> skills { get; set; }
            public string country { get; set; }
            public string uri { get; set; }
            public string apiToken { get; set; }
            public string username { get; set; }
            public string linkedinUsername { get; set; }
            public string likesUrl { get; set; }
           // public Avatar avatar { get; set; }
            public bool isLimited { get; set; }
            public int followingCount { get; set; }
            public string collectionsUrl { get; set; }
        

       //// public class Skill
       // {
       //     public string name { get; set; }
       //     public string uri { get; set; }
       // }
    }
}
