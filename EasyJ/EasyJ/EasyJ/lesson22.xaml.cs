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
	public partial class lesson22 : ContentPage
	{
        private int _index = 0;
        private string[] _quotes22 = new string[]
        {
             "Konnichiwa \n (こんにちは) \n Hello",
             "Ohayou gozaimasu \n (おはようございます) \n Good morning",
             "Konbanwa \n (こんにちは) \n Good evening",
             "Moshi moshi \n (もしもし) \n Hello (but only if you’re on the phone or something like Skype)",
             "Ogenki desu ka? \n (お元気ですか) \n How are you?",
             "Genki desu \n (元気です) \n I’m good/I’ve been doing well, thanks",
             "Ohisashiburi desu ne \n (お久しぶりですね) \n Long time no see",
             "–san mo? \n (-さんも？) \n And you?",
             "Namae wa nan desu ka? \n (名前は何ですか) \n What’s your name?",
             "Watashi no namae wa _____ desu \n (私の名前は＿＿です) \n My name is ______"

        };
        public lesson22()
        {
            InitializeComponent();
            currentQuote.Text = _quotes22[_index];
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            _index++;
            if (_index >= _quotes22.Length)
                _index = 0;

            currentQuote.Text = _quotes22[_index];
        }
    }
}