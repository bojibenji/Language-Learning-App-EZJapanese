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
	public partial class lesson20 : ContentPage
	{
        private int _index = 0;
        private string[] _quotes20 = new string[]
        {
            "悪い \n (Warui) \n “Bad”",
            "きれいな \n (Kirei na) \n “Clean” and “Pretty”",
            "醜い \n (Minikui) \n “Ugly”",
            "難しい \n (Muzukashii) \n “Difficult”",
            "簡単な \n (Kantan na) \n “Easy”",
            "うまい \n (Umai) \n “Nice”",
            "美味しい \n (Oishii) \n “Delicious”",
            "まずい \n (Mazui) \n “Disgusting”",
            "大丈夫 \n (Daijoubu) \n “All right”",
            "すごい \n (Sugoi) \n “Amazing”"

        };
        public lesson20()
        {
            InitializeComponent();
            currentQuote.Text = _quotes20[_index];
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            _index++;
            if (_index >= _quotes20.Length)
                _index = 0;

            currentQuote.Text = _quotes20[_index];
        }
    }
}