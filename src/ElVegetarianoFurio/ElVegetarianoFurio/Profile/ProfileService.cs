namespace ElVegetarianoFurio.Profile;

public class ProfileService : IProfileService
{
    private readonly IPreferences _preferences;

    public ProfileService(IPreferences preferences)
    {
        _preferences = preferences;
    }

    public async Task<Profile> GetAsync()
    {

        var profile = new Profile
        {
            FullName = _preferences.Get(nameof(Profile.FullName), ""),
            Street = _preferences.Get(nameof(Profile.Street), ""),
            Zip = _preferences.Get(nameof(Profile.Zip), ""),
            City = _preferences.Get(nameof(Profile.City), ""),
            Phone = _preferences.Get(nameof(Profile.Phone), "")
        };
        await Task.Delay(3000);
        return profile;
    }

    public async Task<bool> SaveAsync(Profile profile)
    {
        _preferences.Set(nameof(Profile.FullName), profile.FullName);
        _preferences.Set(nameof(Profile.Street), profile.Street);
        _preferences.Set(nameof(Profile.Zip), profile.Zip);
        _preferences.Set(nameof(Profile.City), profile.City);
        _preferences.Set(nameof(Profile.Phone), profile.Phone);

        await Task.Delay(3000);
        return true;


    }

}
