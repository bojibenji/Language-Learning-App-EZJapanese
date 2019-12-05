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
	public partial class lesson14 : ContentPage
	{
        private int _index = 0;
        private string[] _quotes14 = new string[]
        {
            "です \n (Desu) \n “To be” or “it is”",
            "なる \n (Naru) \n “To become”",
            "ある \n (Aru) \n “There is” for inanimate objects and plants.",
            "いる \n (Iru) \n “There is” for living things, like humans and animals.",
            "言う \n (Iu) \n “To say”",
            "行く \n (Iku) \n “To go”",
            "出来る \n (Dekiru) \n “To be able to do” or “can do”",
            "見る \n (Miru) \n “To see”",
            "送る \n (Okuru) \n “To send”",
            "持つ \n (Motsu) \n “To have” or “to hold”"

        };
        public lesson14()
        {
            InitializeComponent();
            currentQuote.Text = _quotes14[_index];
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            _index++;
            if (_index >= _quotes14.Length)
                _index = 0;

            currentQuote.Text = _quotes14[_index];
        }
    }
}