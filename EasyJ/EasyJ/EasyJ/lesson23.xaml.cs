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
	public partial class lesson23 : ContentPage
	{
        private int _index = 0;
        private string[] _quotes23 = new string[]
        {
             "Doko kara kimashita ka? \n (どこから来ましたか) \n Where are you from?",
             "Watashi wa __ kara kimashita \n (私は＿＿から来ました) \n I’m from __________.",
             "Sou desu ka? \n (そうですか) \n Is that so?/Really?/I see",
             "Arigatou gozaimasu \n (ありがとうございます) \n Thank you",
             "Douitashimashite \n (どういたしまして) \n You’re welcome",
             "Sumimasen \n (すみません) \n I’m sorry/excuse me",
             "Gomen nasai \n (ごめんなさい) \n I’m sorry",
             "Yoroshiku onegaishimasu \n (よろしくおねがいします) \n I’m in your debt!",
             "Itadakimasu \n (いただきます) \n Let’s dig in",
             "Gochisousama deshita \n (ごちそうさまでした) \n That was delicious"

        };
        public lesson23()
        {
            InitializeComponent();
            currentQuote.Text = _quotes23[_index];
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            _index++;
            if (_index >= _quotes23.Length)
                _index = 0;

            currentQuote.Text = _quotes23[_index];
        }
    }
}