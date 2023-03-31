using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lelab.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabAvion : ContentPage
    {
        public TabAvion()
        {
            InitializeComponent();

            this.reset();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            this.reset();

            uint length = 800;

            avionImage.FadeTo(1, length);
            avionImage.TranslateTo(0, 0, length);
            avionImage.RotateTo(0, length);
            avionImage.ScaleTo(1, length);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            this.reset();
        }

        private void reset()
        {
            avionImage.TranslationX = -250;
            avionImage.TranslationY = -150;
            avionImage.Rotation = 45;
            avionImage.Scale = 0.5;
            avionImage.Opacity = 0;
        }
    }
}