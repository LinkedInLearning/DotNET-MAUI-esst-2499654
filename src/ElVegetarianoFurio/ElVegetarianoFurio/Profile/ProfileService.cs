using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElVegetarianoFurio.Profile
{
    public class ProfileService
    {

        public async Task<Profile> GetAsync()
        {

            var profile = new Profile
            {
                FullName = Preferences.Get(nameof(Profile.FullName), ""),
                Street = Preferences.Get(nameof(Profile.Street), ""),
                Zip = Preferences.Get(nameof(Profile.Zip), ""),
                City = Preferences.Get(nameof(Profile.City), ""),
                Phone = Preferences.Get(nameof(Profile.Phone), "")
            };
            await Task.Delay(3000);
            return profile;
        }

        public async Task<bool> SaveAsync(Profile profile)
        {
            Preferences.Set(nameof(Profile.FullName), profile.FullName);
            Preferences.Set(nameof(Profile.Street), profile.Street);
            Preferences.Set(nameof(Profile.Zip), profile.Zip);
            Preferences.Set(nameof(Profile.City), profile.City);
            Preferences.Set(nameof(Profile.Phone), profile.Phone);

            await Task.Delay(3000);
            return true;


        }

    }
}
