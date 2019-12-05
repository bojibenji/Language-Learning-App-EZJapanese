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
	public partial class lesson6 : ContentPage
	{
        private int _index = 0;
        private string[] _quotes6 = new string[]
        {
            "Bon Apetite \n いただきます \n itadakimasu",
            "Thanks for the food \n ごちそうさまでした \n gochisousama deshita",
            "Good Morning  \n  おはようございます  \n ohayougozaimasu",
            "Good Afternoon \n こんにちは  \n konnichiwa",
            "Good Evening  \n  こんばんは  \n konbanwa",
            "See You Later  \n ではまた  \n  dewamata",
            "See You Tomorrow  \n  また明日  \n  mata ashita",
            "Goodbye さようなら  \n sayounara",
            "Good Night \n おやすみなさい \n oyasuminasai",
            "To Go \n  行きます  \n  ikimasu"

        };
        public lesson6()
        {
            InitializeComponent();
            currentQuote.Text = _quotes6[_index];
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            _index++;
            if (_index >= _quotes6.Length)
                _index = 0;

            currentQuote.Text = _quotes6[_index];
        }
    }
}