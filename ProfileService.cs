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
using SketchfabAPI.IService;

namespace SketchfabAPI.Services
{
    public class ProfileService :IProfileService
    {
        private HttpClient _httpClient;
        private static string _address;
        private static string _apikey;
        public ProfileService()
        {
            _address = Constants.address;
            _apikey = Constants.apikey;
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(_address);
        }

        public  async void  LikeModelsByAsync(string uid)
        {
            LikeModel mod = new LikeModel();
            mod.model = uid;

            var json = JsonConvert.SerializeObject(mod);

            var param = new StringContent(json, Encoding.UTF8, "application/json");

            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Token", "67f6c65ab3a64177bb7906afe0efebf0");

            HttpResponseMessage responce =  await _httpClient.PostAsync($"/v3/me/likes", param);
            Console.WriteLine(responce.StatusCode);

            if (responce.IsSuccessStatusCode)
            {
                Console.WriteLine("You liked this model");
                var content = responce.Content.ReadAsStringAsync().Result;
                //var result = JsonConvert.DeserializeObject<LikeModel>(content);
                //Console.WriteLine(content);
            }
            
        }

        public async Task<ProfileModel> GetProfileByAsync()
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Token", "67f6c65ab3a64177bb7906afe0efebf0");
            var responce = await _httpClient.GetAsync($"/v3/me");
            var content = responce.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<ProfileModel>(content);
            return result;
        }
   
        public async void UpdateProfile(string _password, string _passwordConfirmation, string _displayName, string _facebookUsername, string _biography, string _tagline, string _website, string _city, string _country)
        {
            UpdateProfileInfo upd = new UpdateProfileInfo()
            {
                password = _password,
                passwordConfirmation = _passwordConfirmation,
                displayName = _displayName,
                facebookUsername = _facebookUsername,
                biography = _biography,
                tagline = _tagline,
                website = _website,
                city = _city,
                country = _country

            };
            var json = JsonConvert.SerializeObject(upd);

            var param = new StringContent(json, Encoding.UTF8, "application/json");
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Token", "67f6c65ab3a64177bb7906afe0efebf0");

            HttpResponseMessage responce = await _httpClient.PatchAsync($"/v3/me", param);
            Console.WriteLine(responce.StatusCode);
            
        }


    }
}
