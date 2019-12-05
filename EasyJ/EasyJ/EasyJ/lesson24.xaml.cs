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
	public partial class lesson24 : ContentPage
	{
        private int _index = 0;
        private string[] _quotes24 = new string[]
        {
             "Eigo te iu no wa… \n (英語ていうのは) \n And in English, that’s…?",
             "Wakarimasen \n (わかりません) \n I don’t understand",
             "Shirimasen \n (知りません) \n I don’t know",
             "Wasuremashita \n (忘れました) \n I forgot",
             "Motto yukkuri kudasai \n (もっとゆっくり下さい) \n Please go a little slower",
             "Mou ichido kudasai \n (もう一度下さい) \n Could you say that one more time?",
             "Nihongo de perapera de wa nai desu \n (日本語でペラペラではないです) \n I’m not very fluent in Japanese",
             "___ te iu no imi wa nan desu ka? \n (＿＿ていうの意味は何ですか) \n What does _____ mean?",
             "Tetsudatte kuremasen ka? \n (手伝ってくれませんか) \n Can you help me?",
             "Doko desu ka? \n (どこですか) \n Where is it?"

        };
        public lesson24()
        {
            InitializeComponent();
            currentQuote.Text = _quotes24[_index];
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            _index++;
            if (_index >= _quotes24.Length)
                _index = 0;

            currentQuote.Text = _quotes24[_index];
        }
    }
}