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
	public partial class lesson5 : ContentPage
	{
        private int _index = 0;
        private string[] _quotes5 = new string[]
        {
            "Drink \n  飲み物 \n nomimono",
            "Food  \n  食べ物  \n  tabemono",
            "Good Tasting, Tasty \n 美味しい  /n  oishii",
            "Bad Tasting \n 不味い \n mazui",
            "Restaurant  \n レストラン  \n resutoran",
            "Convenience Store  \n コンビニ  \n  kombini",
            "Supermarket \n スーパー  \n suupaa",
            "Thank You  \n ありがとうございます \n  arigatougozaimasu",
            "Excuse Me  \n すみません  \n sumimasen",
            "Sorry  \n ごめんなさい \n gomennasai"

        };
        public lesson5()
        {
            InitializeComponent();
            currentQuote.Text = _quotes5[_index];
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            _index++;
            if (_index >= _quotes5.Length)
                _index = 0;

            currentQuote.Text = _quotes5[_index];
        }
    }
}