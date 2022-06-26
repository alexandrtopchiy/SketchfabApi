using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SketchfabAPI.Constans;
using SketchfabAPI.Models;
using System.Net.Http;
using _3DAPI.Models;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using SketchfabAPI.Services;

namespace SketchfabAPI.Client
{
    public class ModelService : IModelService
    {
        private HttpClient _httpClient;
        private static string _address;
        private static string _apikey;
        public ModelService()
        {
            _address = Constants.address;
            _apikey = Constants.apikey;
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(_address);
        }

        public  async Task<Models3D> GetModelsByAsync(string uid)
        {
           // _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", "67f6c65ab3a64177bb7906afe0efebf0");
            var responce = await _httpClient.GetAsync($"/v3/models/{uid}");
            var content = responce.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<Models3D>(content);
            Console.WriteLine(result.name);
            return result;
        }
      

        public  async void UpdateModelInfoByAsync(string _uid, string _name, List<string> _categories, List<string> _tags, string _description)
        {
            UpdateModelInfo up = new UpdateModelInfo()
            {
                name= _name,
                uid=_uid,
                categories=_categories,
               tags=_tags,
                description = _description
            };
            var json = JsonConvert.SerializeObject(up);

            var param = new StringContent(json, Encoding.UTF8, "application/json");
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Token", "67f6c65ab3a64177bb7906afe0efebf0");

            HttpResponseMessage responce = await _httpClient.PatchAsync($"/v3/models/{_uid}", param);
            Console.WriteLine(responce.StatusCode);
            
        }
      
        public async Task<GetMeModels> GetMyModelsByAsync(bool _downlodable, bool _archives_flavours)
        {

            //  var param = new StringContent(json, Encoding.UTF8, "application/json");

            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Token", "67f6c65ab3a64177bb7906afe0efebf0");
            var responce = await _httpClient.GetAsync($"/v3/me/models?downloadable={_downlodable}&archives_flavours={_archives_flavours}");

            Console.WriteLine(responce.StatusCode);

            if (responce.IsSuccessStatusCode)
            {
                var content = responce.Content.ReadAsStringAsync().Result;
                var result = JsonConvert.DeserializeObject<GetMeModels>(content);

                //Result mod1 = result.results[0];
                //Result mod2 = result.results[1];

                Console.WriteLine(result.results[0].name);
                Console.WriteLine(result.results[1].name);
                Console.WriteLine(result.results[1].thumbnails.images[0].url);
                Console.WriteLine(result.results[0].user.username);
                return result;
            }

            return null;
        }
   
        public void DeleteModel(string uid)
            {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Token", "67f6c65ab3a64177bb7906afe0efebf0");
            var responce =   _httpClient.DeleteAsync($"/v3/models/{uid}");
            //var content = responce.ToString();
            //var result = JsonConvert.DeserializeObject<Models3D>(content);            
             }

      
        public async Task<string> GetAuthToken(string _email, string _password)
        {
            AuthModel user = new AuthModel()
            {
                grant_type = "password",
                username = _email,
                password = _password
            };
            var json = JsonConvert.SerializeObject(user);

            var param = new StringContent(json, Encoding.UTF8, "application/json");

            _httpClient.BaseAddress = new Uri("https://sketchfab.com/oauth2/token/");
            _httpClient.DefaultRequestHeaders.Authorization =
         new AuthenticationHeaderValue(
             "Basic", Convert.ToBase64String(
                 System.Text.ASCIIEncoding.ASCII.GetBytes(
                    $"{OAuthConst.client_id}:{OAuthConst.client_secret}")));

            var responce = await _httpClient.PostAsync(_httpClient.BaseAddress, param);
            _httpClient.BaseAddress = new Uri(_address);
            Console.WriteLine(responce.StatusCode);

            string content = responce.Content.ReadAsStringAsync().Result;
            //var result = JsonConvert.DeserializeObject<LikeModel>(content);
            Console.WriteLine(content);

            return content;
        }

        public async Task<SearchModels> SearchModelsByAsync(string searchRequest)
        {
            // _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Token", "67f6c65ab3a64177bb7906afe0efebf0");
            var responce = await _httpClient.GetAsync($"/v3/search?q={searchRequest}");
            var content = responce.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<SearchModels>(content);
            return result;
        }
    }
}
