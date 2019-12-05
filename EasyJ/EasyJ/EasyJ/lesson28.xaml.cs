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
	public partial class lesson28 : ContentPage
	{
        private int _index = 0;
        private string[] _quotes28 = new string[]
        {
            "Ii desu \n (いいです) \n That’s good",
            "Ki o tsukete \n (気を付けて) \n Be careful",
            "Yoku dekimashita \n (よくできました) \n Great job",
            "Omedetou gozaimasu \n (おめでとうございます) \n Congratulations",
            "Tanjoubi omedetou \n (誕生日おめでとう) \n Happy birthday",
            "Kanpai (乾杯) \n Cheers",
            "Ja (じゃ) \n Well",
            "Sayounara \n (さようなら) \n Goodbye",
            "Ja, mata \n (じゃまた) \n Well, see you",
            "Oyasumi nasai \n (おやすみなさい) \n Good night"

        };
        public lesson28()
        {
            InitializeComponent();
            currentQuote.Text = _quotes28[_index];
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            _index++;
            if (_index >= _quotes28.Length)
                _index = 0;

            currentQuote.Text = _quotes28[_index];
        }
    }
}