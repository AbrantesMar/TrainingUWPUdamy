using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// O modelo de item de Página em Branco está documentado em https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x416

namespace AppAdaptiveUI
{
    /// <summary>
    /// Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(200, 300));
            ApplicationView.GetForCurrentView().VisibleBoundsChanged += MainPage_VisibleBoundsChanged;
        }

        private void MainPage_VisibleBoundsChanged(ApplicationView sender, object args)
        {
            var width = ApplicationView.GetForCurrentView().VisibleBounds.Width;
            if(width >= 720)
            {
                VisualStateManager.GoToState(this, "Width720", false);
                //TODO: Tamb[em pode ser feito dessa forma
                //SlvPanel.DisplayMode = SplitViewDisplayMode.CompactInline;
                //SlvPanel.IsPaneOpen = true;
            }
            else if(width >= 360)
            {
                VisualStateManager.GoToState(this, "Width360", false);
                //SlvPanel.DisplayMode = SplitViewDisplayMode.CompactOverlay;
                //SlvPanel.IsPaneOpen = false;
            }
            else
            {
                VisualStateManager.GoToState(this, "Width0", false);
                //SlvPanel.DisplayMode = SplitViewDisplayMode.Overlay;
                //SlvPanel.IsPaneOpen = false;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SlvPanel.IsPaneOpen = !SlvPanel.IsPaneOpen;
        }
    }
}
