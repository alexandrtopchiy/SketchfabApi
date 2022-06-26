using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SketchfabAPI.Models
{
    public  class SearchModels
    {
        public Results Results { get; set; }
    }

    public  class Results
    {
        public List<Model> Models { get; set; }
        public List<Collection> Collections { get; set; }
       // public List<UserElement> Users { get; set; }
    }

    public  class Collection
    {
        public string CollectionUrl { get; set; }
        public long ModelCount { get; set; }
        public CollectionUser User { get; set; }
      //  public DateTimeOffset UpdatedAt { get; set; }
        public string Uid { get; set; }
        public string EmbedUrl { get; set; }
        public string Slug { get; set; }
     //   public DateTimeOffset CreatedAt { get; set; }
        public string Name { get; set; }
    }

    public partial class CollectionUser
    {
        public string Username { get; set; }
        public string ProfileUrl { get; set; }
        public string Account { get; set; }
        public string DisplayName { get; set; }
        public string Uid { get; set; }
        public string Uri { get; set; }
       // public List<Avatar> Avatar { get; set; }
    }

    //public partial class Avatar
    //{
    //    public List<Image> Images { get; set; }
    //    public string Uid { get; set; }
    //    public string Uri { get; set; }
    //}

    public partial class Image
    {
        public string Url { get; set; }
        public long Width { get; set; }
        public long Height { get; set; }
        public long? Size { get; set; }
        public string Uid { get; set; }
    }

    public partial class Model
    {
        public long ViewCount { get; set; }
        public string Uid { get; set; }
        public string Name { get; set; }
        public long AnimationCount { get; set; }
        public string ViewerUrl { get; set; }
        public bool IsPublished { get; set; }
       // public DateTimeOffset PublishedAt { get; set; }
        public long LikeCount { get; set; }
        public long CommentCount { get; set; }
     //   public Dictionary<string, Archive> Archives { get; set; }
        public Thumbnails Thumbnails { get; set; }
        public string EmbedUrl { get; set; }
        public bool IsDownloadable { get; set; }
        public CollectionUser User { get; set; }
    }

    //public partial class Archive
    //{
    //    public long FaceCount { get; set; }
    //    public long TextureCount { get; set; }
    //    public long Size { get; set; }
    //    public long VertexCount { get; set; }
    //    public long TextureMaxResolution { get; set; }
    //}

    public partial class Thumbnails
    {
        public List<Image> Images { get; set; }
    }

    //public partial class UserElement
    //{
    //    public List<Result> Results { get; set; }
    //}

    //public partial class Result
    //{
    //    public string Username { get; set; }
    //    public long FollowerCount { get; set; }
    //    public string DisplayName { get; set; }
    //    public string Uid { get; set; }
    //   // public List<Skill> Skills { get; set; }
    //    public string Account { get; set; }
    //    public long ModelCount { get; set; }
    //    public string ProfileUrl { get; set; }
    //    public Avatar Avatar { get; set; }
    //}

}
