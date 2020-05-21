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

// O modelo de item de Controle de Usuário está documentado em https://go.microsoft.com/fwlink/?LinkId=234236

namespace AppAdaptiveUI.Controls
{
    public sealed partial class FavorityUC : UserControl
    {
        public FavorityUC()
        {
            this.InitializeComponent();
            ApplicationView.GetForCurrentView().VisibleBoundsChanged += FavorityUC_VisibleBoundsChanged;
        }

        private void FavorityUC_VisibleBoundsChanged(ApplicationView sender, object args)
        {
            var width = ApplicationView.GetForCurrentView().VisibleBounds.Width;
            if(width >= 360)
            {
                //VisualStateManager.GoToState(this, "Width360", false);
                RelativePanel.SetBelow(FavText, null);
                RelativePanel.SetRightOf(FavText, Stars);
                RelativePanel.SetAlignVerticalCenterWith(FavText, Stars);
            }
            else
            {
                //VisualStateManager.GoToState(this, "Width0", false);
                RelativePanel.SetRightOf(FavText, null);
                RelativePanel.SetBelow(FavText, Stars);

                RelativePanel.SetAlignVerticalCenterWith(FavText, null);
                RelativePanel.SetAlignVerticalCenterWithPanel(Stars, false);
            }

        }
    }
}
