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
    public partial class ListPage : ContentPage
    {
        public List<Article> Articles { get; set; }

        public ListPage()
        {
            InitializeComponent();

            var articles = new List<Article>();
            articles.Add(new Article { Nom = "Lait", Prix = "4€" });
            articles.Add(new Article { Nom = "Pain", Prix = "2€" });
            articles.Add(new Article { Nom = "Chocolat", Prix = "2.4€" });
            articles.Add(new Article { Nom = "Beurre", Prix = "1.25€" });

            ArticlesListView.ItemsSource = articles;

            ArticlesListView.ItemSelected += (sender, e) =>
            {
                if (ArticlesListView.SelectedItem != null)
                {
                    DisplayAlert("Article", $"{(ArticlesListView.SelectedItem as Article).Nom} => {(ArticlesListView.SelectedItem as Article).Prix}", "Fermer");
                    ArticlesListView.SelectedItem = null;
                }
            };
        }
    }

    public class Article
    {
        public string Nom { get; set; }
        public string Prix { get; set; }
    }
}