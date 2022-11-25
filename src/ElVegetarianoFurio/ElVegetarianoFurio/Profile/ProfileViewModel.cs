using CommunityToolkit.Mvvm.ComponentModel;
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



        [RelayCommand]
        private async Task SaveAsync()
        {
            IsBusy = true;
            Task.Delay(3000); // simuliertes Speichern
            IsBusy = false;
        }



    }
}
