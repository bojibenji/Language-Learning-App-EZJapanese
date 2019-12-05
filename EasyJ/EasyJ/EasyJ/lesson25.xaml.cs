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
	public partial class lesson25 : ContentPage
	{
        private int _index = 0;
        private string[] _quotes25 = new string[]
        {
                 "Itsu desu ka? \n (いつですか) \n When is it?",
                 "Doushite? \n (どうして) \n Why?",
                 "Dochira desu ka? \n (どちらですか) \n Which one is it?",
                 "Nan desu ka? \n (何ですか) \n What is it?",
                 "Dare desu ka? \n (だれですか) \n Who is it?",
                 "Ima nanji desu ka? \n (今何時ですか) \n What time is it right now?",
                 "Ima \n (今) \n Now",
                 "Ato de \n (後で) \n Later",
                 "Kyou \n (今日) \n Today",
                 "Kinou \n (昨日) \n Yesterday"

        };
        public lesson25()
        {
            InitializeComponent();
            currentQuote.Text = _quotes25[_index];
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            _index++;
            if (_index >= _quotes25.Length)
                _index = 0;

            currentQuote.Text = _quotes25[_index];
        }
    }
}