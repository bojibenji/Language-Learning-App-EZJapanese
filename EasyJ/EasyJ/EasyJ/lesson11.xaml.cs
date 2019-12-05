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
	public partial class lesson11 : ContentPage
	{
        private int _index = 0;
        private string[] _quotes11 = new string[]
        {
            "Seven \n  七 \n  nana \n shichi",
            "Eight \n  八 \n  hachi",
            "Nine  \n  九 \n  ku / kyuu",
            "Ten \n 十  \n juu",
            "100 \n 百 \n  hyaku",
            "1,000 \n  千 \n  sen",
            "10,000 \n 万 \n  man",
            "Yen \n 円 \n  en",
            "31 \n 三十一 \n San-jû-ichi",
            "32 \n  三十二 \n San-jû-ni"

        };
        public lesson11()
        {
            InitializeComponent();
            currentQuote.Text = _quotes11[_index];
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            _index++;
            if (_index >= _quotes11.Length)
                _index = 0;

            currentQuote.Text = _quotes11[_index];
        }
    }
}