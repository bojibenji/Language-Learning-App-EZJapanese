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
    public partial class lesson1 : ContentPage
    {
        private int _index = 0;
        private string[] _quotes = new string[]
        {
            "Toilet \n トイレ \n toire",
            "Bathroom \n 手洗い \n tearai",
            "Help! \n 助けて！ \n tasukete!",
            "I don't understand \n わかりません \n wakarimasen",
            "Stop it! \n やめて！ \n yamete!",
            "English \n 英語 \n eigo",
            "Clothes \n 服 \n fuku",
            "Seems Like I'm Going to Die \n 死にそう \n shinisou",
            "Police \n 警察 \n keisatsu",
            "Dangerous \n 危ない \n abunai"
        };
    
		public lesson1 ()
		{
			InitializeComponent ();
            currentQuote.Text = _quotes[_index];
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            _index++;
            if (_index >= _quotes.Length)
                _index = 0;

            currentQuote.Text = _quotes[_index];
        }

    }
}