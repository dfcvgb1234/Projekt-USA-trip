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
        string[] images =
        {
            "sushi1",
            "sushi2",
            "sushi3",
            "sushi4",
            "sushi5",
            "sushi6",
            "sushi7",
            "sushi8"

        };
        int[] likes =
        {
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0
        };
        int[] dislikes =
        {
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0
        };
        byte i;
        public Page1()
        {
            InitializeComponent();
        }
        void handle_sliding(object sender, ValueChangedEventArgs args)
        {

        }
        void Handle_moreInfo(object sender, EventArgs args)
        {
            DisplayAlert("Title", "This is the building plan idea(PLACEHOLDER) " + MainImg.Width + " " + MainImg.Height,"ok");
            
        }
        void handle_like(object sender, EventArgs args)
        {
            i++;
            if (i == images.Length)
            {
                i = 0;
            }
            likes[i]++;
            DisplayAlert("title","Du kunne godt lide dette forslag",""+likes[i]);
            MainImg.Image = images[i];
           
        }
        void handle_dislike(object sender, EventArgs args)
        {
            i++;
            if(i==images.Length)
            {
                i = 0;
            }
            dislikes[i]++;
            DisplayAlert("title", "Du kunne ikke lide dette forslag", "" + dislikes[i]);
            MainImg.Image = images[i];
        }
    }
}
