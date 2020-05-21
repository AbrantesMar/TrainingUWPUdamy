using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace Info
{
    public class InfoList : NotificationBase
    {
        public ObservableCollection<TruckInfo> Infos { get; set; }
        private TruckInfo _selectedTruck;

        public TruckInfo SelectedTruck
        {
            get { return _selectedTruck; }
            set 
            {
                if (value == _selectedTruck)
                    return;
                _selectedTruck = value;
                NotifyPropertyChanged();
            }
        }
        public object SelectedTruckObject
        {
            get { return _selectedTruck; }
            set
            {
                if (value == _selectedTruck)
                    return;
                _selectedTruck = (TruckInfo)value;
                NotifyPropertyChanged("SelectedTruck");
            }
        }
    }
}
