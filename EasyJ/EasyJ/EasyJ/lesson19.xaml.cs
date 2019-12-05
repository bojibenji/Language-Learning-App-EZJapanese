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
	public partial class lesson19 : ContentPage
	{
        private int _index = 0;
        private string[] _quotes19 = new string[]
        {
            "これ / この \n (Kore / Kono) \n “This” or “This _ (thing/person)”",
            "それ / その \n (Sore / Sono) \n “That / It” or “That _ (thing/person)”",
            "あれ / あの \n (Are / Ano) \n “That over there” or “That _ (thing/person) over there”",
            "私 / 僕  \n (Watashi / Boku) \n “I” (私 is gender neutral, while 僕 is masculine.)",
            "彼 \n (Kare) \n “He”",
            "彼女 \n (Kanojo) \n “She”",
            "私たち \n (Watashitachi) \n “We”",
            "彼ら \n (Karera) \n “They”",
            "年 \n (Toshi or Nen) \n “Year”",
            "月 \n (Getsu or Tsuki) \n “Month” and “Moon”"

        };
        public lesson19()
        {
            InitializeComponent();
            currentQuote.Text = _quotes19[_index];
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            _index++;
            if (_index >= _quotes19.Length)
                _index = 0;

            currentQuote.Text = _quotes19[_index];
        }
    }
}