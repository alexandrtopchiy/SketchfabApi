using SketchfabAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SketchfabAPI.IService
{
    public interface IProfileService
    {
        public  void LikeModelsByAsync(string uid);
        public Task<ProfileModel> GetProfileByAsync();
        public void UpdateProfile(string _password, string _passwordConfirmation, string _displayName, string _facebookUsername, string _biography, string _tagline, string _website, string _city, string _country);
    }
}
