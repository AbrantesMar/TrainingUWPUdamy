using Info;
using System;
using System.Collections.ObjectModel;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

// O modelo de item de Página em Branco está documentado em https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x416

namespace TrainingUWP
{
    /// <summary>
    /// Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            var info = MainInfo.GetInfo();
            var infos = MainInfo.GetInfos();
            //TruckID.Text = info.ID;
            //TruckName.Text = info.Name;
            //TruckStyle.Text = info.Style;
            
            var data = new InfoList()
            {
                Infos = new ObservableCollection<Info.TruckInfo>(infos.Infos)
            };
            //DataContext = data;
            Data = data;

        }
        public InfoList Data { get; set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Data.Infos.Add(new Info.TruckInfo()
            { 
                ID = "4",
                Name = "Fancy Fish",
                Style = "Fish"
            });
        }
    }
    public class StyleToBrushConverter : IValueConverter
    {
        public StyleToBrushConverter()
        {

        }

        private SolidColorBrush _Default = new SolidColorBrush(Colors.White);
        private SolidColorBrush _Mexican = new SolidColorBrush(Colors.LightPink);
        private SolidColorBrush _Desserts = new SolidColorBrush(Colors.Chocolate);

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            switch (value as string)
            {
                case null:
                default:
                    return _Default;
                case "Mexican":
                    return _Mexican;
                case "Desserts":
                    return _Desserts;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
