using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DAPI.Models
{
    public class GetMeModels
    {
       public  List<Result> results { get; set; }
    }
        public class Result
        {
            public string uid { get; set; }
          // public List<Tag> tags { get; set; }
            public string viewerUrl { get; set; }
            public bool isProtected { get; set; }
            //public List<Category> categories { get; set; }
            public string publishedAt { get; set; }
            public int likeCount { get; set; }
            public int commentCount { get; set; }
            public int viewCount { get; set; }
            public int vertexCount { get; set; }
            public User user { get; set; }
            public bool isDownloadable { get; set; }
            public int animationCount { get; set; }
            public string name { get; set; }
            public int soundCount { get; set; }
            public bool isAgeRestricted { get; set; }
            public string uri { get; set; }
            public int faceCount { get; set; }
            public string createdAt { get; set; }
       
            public string embedUrl { get; set; }
        // public Archives archives { get; set; }
        public Thumbnails thumbnails { get; set; }
    }
    public class RequestParameters
        {
            public bool archives_flavours { get; set; }
            public bool downloadable { get; set; }
        }
        public class Category
        {
            public string uri { get; set; }
            public string uid { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
        }
    public class User
    {
        public string username { get; set; }
        public string profileUrl { get; set; }
        public string account { get; set; }
        public string displayName { get; set; }
        public string uid { get; set; }
        public string uri { get; set; }
       // public List<Avatar> avatar { get; set; }
    }
    public class Thumbnails
    {
        public List<Image> images { get; set; }
    }
    public class Image
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int size { get; set; }
        public string uid { get; set; }
    }
}
