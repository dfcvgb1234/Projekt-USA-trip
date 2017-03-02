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
        // Array med billeder (Indsæt string)
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

        // Array med Likes (Indsæt Integer)
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

        // Array med Dislikes (Indsæt Integer)
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
        // Byte der holder styr på hvilket billede der skal vises og likes.
        byte i;

        public Page1()
        {
            InitializeComponent();
        }

        // MainImg, knappen som giver dig mere info, når du kliker på det store billede.
        void Handle_moreInfo(object sender, EventArgs args)
        {
            DisplayAlert("Title", "This is the building plan idea(PLACEHOLDER) " + MainImg.Width + " " + MainImg.Height,"ok");
            
        }

        // Like, knappen som der liker det nuværende billede.
        void handle_like(object sender, EventArgs args)
        {
            i++;
            // checker om i er større end der er billeder til rådighed.
            if (i == images.Length)
            {
                i = 0;
            }
            // liker det nuværende billede.
            likes[i]++;
            DisplayAlert("LIKE!","Du kunne godt lide dette forslag, Likes: " + likes[i], "OK");
            // viser det nuværende billede på skærmen.
            MainImg.Image = images[i];
           
        }

        // dislike, knappen som der disliker det nuværende billede.
        void handle_dislike(object sender, EventArgs args)
        {
            i++;
            // checker om i er større end der er billeder til rådighed.
            if(i == images.Length)
            {
                i = 0;
            }
            // disliker det nuværende billede.
            dislikes[i]++;
            DisplayAlert("DISKLIKE!", "Du kunne ikke lide dette forslag, Dislikes: " + dislikes[i],"OK");
            // viser det nuværende billede på skærmen.
            MainImg.Image = images[i];
        }
    }
}
