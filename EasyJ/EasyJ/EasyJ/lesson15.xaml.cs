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
	public partial class lesson15 : ContentPage
	{
        private int _index = 0;
        private string[] _quotes15 = new string[]
        {
            "映画 \n (Eiga) \n “Movie”",
            "テレビ \n (Terebi) \n “TV”",
            "家族 \n (Kazoku) \n “Family”",
            "町 \n (Machi) \n “Town”",
            "他の \n (Hoka no) \n “Other”",
            "出身 \n (Shusshin) \n “Hometown”",
            "トイレ / お手洗い \n (Toire / Otearai) – “Bathroom”",
            "家 \n (Uchi or Ie) \n “Home” or “House”",
            "店 \n (Mise or Ya) \n “Shop”",
            "する \n (Suru) \n “To do”"

        };
        public lesson15()
        {
            InitializeComponent();
            currentQuote.Text = _quotes15[_index];
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            _index++;
            if (_index >= _quotes15.Length)
                _index = 0;

            currentQuote.Text = _quotes15[_index];
        }
    }
}