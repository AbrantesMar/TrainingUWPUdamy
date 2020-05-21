using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Info
{
    public class InfoListVM : NotificationBase
    {
        public InfoListVM()
        {
            TruckInfos = new ObservableCollection<TruckInfoVM>();
            RefreshCommand = new Command(LoadAsync);
        }
        public Command RefreshCommand { get; set; }
        private ObservableCollection<TruckInfoVM> _truckInfos;

        public ObservableCollection<TruckInfoVM> TruckInfos 
        { 
            get { return _truckInfos; }
            set 
            {
                if (_truckInfos == value)
                    return;
                _truckInfos = value;
                NotifyPropertyChanged();
            } 
        }

        private TruckInfoVM _selectedTruck;

        public TruckInfoVM SelectedTruck
        {
            get { return _selectedTruck; }
            set
            {
                if (_selectedTruck == value)
                    return;
                _selectedTruck = value;
                NotifyPropertyChanged();
            }
        }

        public async Task LoadAsync()
        {
            var trucks = MainInfo.GetInfosData();
            if(TruckInfos != null)
                TruckInfos.Clear();
            await Task.Delay(2000);
            foreach (var item in trucks)
            {
                TruckInfos.Add(new TruckInfoVM()
                {
                    ID = item.ID,
                    Name = item.Name,
                    Style = item.Style
                });
            }
            await Repository.GetObject<IDialogService>().ShowDialogAsync("Inicialization", "Data loaded", "Ok", null);
        }
        public async void Launch()
        {
            await LoadAsync();
        }
    }
}
