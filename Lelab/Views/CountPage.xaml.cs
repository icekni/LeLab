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
    public partial class CountPage : ContentPage
    {
        private int _counter = 0;

        public CountPage()
        {
            InitializeComponent();
        }

        void Handle_ClickedOnTapButton(object sender, EventArgs e)
        {
            // Incrémentation du compteur
            _counter++;
            // MAJ de l'affichage du compteur
            Counter.Text = _counter.ToString();
        }
    }
}