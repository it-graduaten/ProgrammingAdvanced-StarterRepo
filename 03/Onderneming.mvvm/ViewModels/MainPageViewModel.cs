using Onderneming.mvvm.ViewModels;
using Onderneming.mvvm.Models;
using Onderneming.mvvm.Data.Repository;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace Onderneming.mvvm.ViewModels
{
    public partial class MainPageViewModel : BaseViewModel
    {
        WerknemerRepository _repo;

        [ObservableProperty]
        private ObservableCollection<Werknemer> werknemers;

        public MainPageViewModel(WerknemerRepository Repo)
        {
            Title = "Werknemers";
            _repo = Repo;
        }

        [RelayCommand]
        public void ToonWerknemers()
        {
            Werknemers = new ObservableCollection<Werknemer>(_repo.GetWerknemers());
        }
    }
}
