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
	public partial class lesson7 : ContentPage
	{
        private int _index = 0;
        private string[] _quotes7 = new string[]
        {
            "To Return (home) \n   帰ります \n   kaerimasu",
            "To Eat \n 食べます \n  tabemasu",
            "To Do  \n します \n shimasu",
            "To See \n 見ます \n mimasu",
            " To Buy \n 買います  \n  kaimasu",
            "To Wait \n 待ちます  \n  machimasu",
            "To Write  \n  書きます  \n  kakimasu",
            "To Stop \n 止まります \n  tomarimasu",
            "To Teach  \n  教えます  \n  oshiemasu",
            "To Speak  \n  話します  \n  hanashimasu"

        };
        public lesson7()
        {
            InitializeComponent();
            currentQuote.Text = _quotes7[_index];
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            _index++;
            if (_index >= _quotes7.Length)
                _index = 0;

            currentQuote.Text = _quotes7[_index];
        }
    }
}