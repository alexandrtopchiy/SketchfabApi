using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SketchfabAPI.Models
{
    public class Models3D
    {
        public string viewerUrl { get; set; }
        public string uid { get; set; }
        public List<Categories> categories { get; set; }
        public string publishedAt { get; set; }
        public string likeCount { get; set; }
        public string commentCount { get; set; }
        public string vertexCount { get; set; }
        public string animationCount { get; set; }
        public string isDownlodable { get; set; }
        public string viewCount { get; set; }
        public string name { get; set; }
        public string faceCount { get; set; }
        public string createdAt { get; set; }




    }

    public class Categories
    {
        public string uri { get; set; }
        public string uid { get; set; }
        public string name { get; set; }
        public string slug { get; set; }

    }
}
//////
///{
//"status": { },
//  "uid": "string",
//  "tags": [
//    {
//      "slug": "string",
//      "uri": "string"
//    }
//  ],
//  "viewerUrl": "string",
//  "categories": [
//    {
//      "uri": "string",
//      "uid": "string",
//      "name": "string",
//      "slug": "string"
//    }
//  ],
//  "publishedAt": "2022-06-02",
//  "likeCount": 0,
//  "commentCount": 0,
//  "vertexCount": 0,
//  "user": {
//    "username": "string",
//    "profileUrl": "string",
//    "account": "string",
//    "displayName": "string",
//    "uid": "string",
//    "uri": "string",
//    "avatar": [
//      {
//        "images": [
//          {
//            "url": "string",
//            "width": 0,
//            "height": 0,
//            "size": 0
//          }
//        ],
//        "uid": "string",
//        "uri": "string"
//      }
//    ]
//  },
//  "animationCount": 0,
//  "isDownloadable": true,
//  "viewCount": 0,
//  "name": "string",
//  "license": { },
//  "editorUrl": "string",
//  "soundCount": 0,
//  "isAgeRestricted": true,
//  "uri": "string",
//  "faceCount": 0,
//  "createdAt": "2022-06-02",
//  "thumbnails": {
//    "images": [
//      {
//        "url": "string",
//        "width": 0,
//        "uid": "string",
//        "height": 0
//      }
//    ]
//  },
//  "downloadCount": 0,
//  "embedUrl": "string",
//  "options": { }
//}