﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ElVegetarianoFurio.Profile
{
    [INotifyPropertyChanged]
    public partial class ProfileViewModel
    {

        [ObservableProperty]
        private string _fullName;

        [ObservableProperty]
        private string _street;

        [ObservableProperty]
        private string _zip;

        [ObservableProperty]
        private string _city;

        [ObservableProperty]
        private string _phone;

        [ObservableProperty]
        private bool _isBusy;

        private readonly IProfileService _profileService;

        public ProfileViewModel(IProfileService profileService)
        {
            _profileService = profileService;
        }


        public async Task Initialize()
        {
            IsBusy = true;
            var profile = await _profileService.GetAsync();
            FullName = profile.FullName;
            Street = profile.Street;
            Zip = profile.Zip;
            City = profile.City;
            Phone = profile.Phone;
            IsBusy = false;
        }


        [RelayCommand]
        private async Task SaveAsync()
        {
            IsBusy = true;

            await _profileService.SaveAsync(
                new Profile
                {
                    FullName = FullName,
                    Street = Street,
                    Zip = Zip,
                    City = City,
                    Phone = Phone
                }
                );

            IsBusy = false;
        }



    }
}
