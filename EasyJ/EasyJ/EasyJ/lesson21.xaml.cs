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
	public partial class lesson21 : ContentPage
	{
        private int _index = 0;
        private string[] _quotes21 = new string[]
        {
            "楽しい \n (Tanoshii) \n “Enjoyable” or “Pleasant”",
            "とても \n (Totemo) \n “Very”",
            "しかし \n (Shikashi) \n “However”",
            "また \n (Mata) \n “Also”",
            "その後 \n (Sono ato) \n “After that”",
            "その時 \n (Sono toki) \n “At that time”",
            "場合は \n (Baai wa) \n “If you” or “If this happens”",
            "例えば \n (Tatoeba) \n “For example”",
            "それから \n (Sorekara) \n “Then”",
            "だから \n (Dakara) \n “So”"

        };
        public lesson21()
        {
            InitializeComponent();
            currentQuote.Text = _quotes21[_index];
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            _index++;
            if (_index >= _quotes21.Length)
                _index = 0;

            currentQuote.Text = _quotes21[_index];
        }
    }
}