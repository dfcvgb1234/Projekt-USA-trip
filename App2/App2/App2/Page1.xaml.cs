using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App2
{
    public partial class Page1 : ContentPage
    {
        int likes;
        int dislikes;
        public Page1()
        {
            InitializeComponent();
        }
        void handle_sliding(object sender, ValueChangedEventArgs args)
        {

        }
        void handle_like(object sender, EventArgs args)
        {
            likes++;
            DisplayAlert("title","Du kunne godt lide dette forslag",""+likes);
        }
        void handle_dislike(object sender, EventArgs args)
        {
            dislikes++;
            DisplayAlert("title", "Du kunne ikke lide dette forslag", "" + dislikes);
        }
    }
}
