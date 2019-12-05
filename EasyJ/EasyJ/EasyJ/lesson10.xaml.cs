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
	public partial class lesson10 : ContentPage
	{
        private int _index = 0;
        private string[] _quotes10 = new string[]
        {
            "Green \n  緑  \n midori",
            "Yellow \n 黄色 \n kiiro",
            "White \n  白 \n  shiro",
            "Stupid \n 馬鹿 \n baka",
            "One \n 一  \n ichi",
            "Two \n 二 \n  ni",
            "Three \n  三  \n san",
            "Four  \n  四 \n  shi / yon",
            "Five  \n  五 \n  go",
            "Six \n 六  \n roku"

        };
        public lesson10()
        {
            InitializeComponent();
            currentQuote.Text = _quotes10[_index];
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            _index++;
            if (_index >= _quotes10.Length)
                _index = 0;

            currentQuote.Text = _quotes10[_index];
        }
    }
}