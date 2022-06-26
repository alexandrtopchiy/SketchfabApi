using _3DAPI.Models;
using SketchfabAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SketchfabAPI.Services
{
    public interface IModelService
    {
        public Task<Models3D> GetModelsByAsync(string uid);
        public void DeleteModel(string uid);
        public  Task<GetMeModels> GetMyModelsByAsync(bool _downlodable, bool _archives_flavours);
        public Task<string> GetAuthToken(string _email, string _password);
        public  void UpdateModelInfoByAsync(string _uid, string _name, List<string> _categories, List<string> _tags, string _description);

        public Task<SearchModels> SearchModelsByAsync(string searchRequest);

    }
}
