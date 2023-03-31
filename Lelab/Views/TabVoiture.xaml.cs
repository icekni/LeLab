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
    public partial class TabVoiture : ContentPage
    {
        public TabVoiture()
        {
            InitializeComponent();

            this.reset();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            this.reset();

            voitureImage.FadeTo(1, 2000);
            voitureImage.TranslateTo(0, 0, 1000);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            this.reset();
        }

        private void reset()
        {
            voitureImage.Opacity = 0;
            voitureImage.TranslationX = -500;
        }
    }
}