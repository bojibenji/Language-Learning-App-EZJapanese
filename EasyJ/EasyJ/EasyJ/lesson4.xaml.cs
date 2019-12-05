using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyJ
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class lesson4 : ContentPage
	{
        private int _index = 0;
        private string[] _quotes4 = new string[]
        {
            "Bookstore  \n 本屋  \n hon’ya",
            "Manga Cafe \n まんが喫茶 \n manga kissa",
            "Taxi  \n  タクシー  \n  takushii",
            "Home  \n  家  \n ie , uchi",
            "Hungry \n おなかすいた , はらへった  \n onaka suita , hara hetta",
            "To Eat \n 食べます \n tabemasu",
            "To Not Eat \n 食べません \n  tabemasen",
            "To Drink  \n  飲みます  \n  nomimasu",
            "To Not Drink  \n  飲みません \n  nomimasen",
            "Water \n  水 \n  mizu"

        };
        public lesson4 ()
		{
			InitializeComponent ();
            currentQuote.Text = _quotes4[_index];
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            _index++;
            if (_index >= _quotes4.Length)
                _index = 0;

            currentQuote.Text = _quotes4[_index];
        }
    }
}