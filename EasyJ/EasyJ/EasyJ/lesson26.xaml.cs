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
	public partial class lesson26 : ContentPage
	{
        private int _index = 0;
        private string[] _quotes26 = new string[]
        {
                 "Ashita \n (明日) \n Tomorrow",
                 "Mainichi \n (毎日) \n Everyday",
                 "Nansai desu ka? \n (何歳ですか) \n How old are you?",
                 "Doko ni sundeimasu ka? \n (どこに住んでいますか) \n Where do you live?",
                 "Kyoudai ga imasu ka? \n (兄弟がいますか) \n Do you have siblings?",
                 "Ikura desu ka? \n (いくらですか) \n How much does that cost?",
                 "Kore wa nan desu ka? \n (これはなんですか) \n What is this?",
                 "Sore wa nan desu ka? \n (それはなんですか) \n What is that?",
                 "Are we nan desu ka? \n (あれはなんですか) \n What is that? ",
                 "Toire wa doko desu ka? \n (トイレはどこですか) \n Where’s the toilet?"

        };
        public lesson26()
        {
            InitializeComponent();
            currentQuote.Text = _quotes26[_index];
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            _index++;
            if (_index >= _quotes26.Length)
                _index = 0;

            currentQuote.Text = _quotes26[_index];
        }
    }
}