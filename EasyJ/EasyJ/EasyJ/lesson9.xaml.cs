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
	public partial class lesson9 : ContentPage
	{
        private int _index = 0;
        private string[] _quotes9 = new string[]
        {
            "Good  \n  いい \n ii",
            "Interesting, Funny \n 面白い \n omoshiroi",
            "Fun \n 楽しい \n tanoshii",
            "Hot \n 熱い  \n atsui",
            "Cold  \n  寒い \n samui",
            "Good At \n 上手 \n jouzu",
            "Bad At \n 下手 \n heta",
            "Red \n 赤  \n aka",
            "Blue  \n  青 \n  ao",
            "Black \n  黒  \n kuro"

        };
        public lesson9()
        {
            InitializeComponent();
            currentQuote.Text = _quotes9[_index];
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            _index++;
            if (_index >= _quotes9.Length)
                _index = 0;

            currentQuote.Text = _quotes9[_index];
        }
    }
}