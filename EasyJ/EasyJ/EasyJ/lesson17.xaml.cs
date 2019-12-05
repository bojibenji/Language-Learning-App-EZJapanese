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
	public partial class lesson17 : ContentPage
	{
        private int _index = 0;
        private string[] _quotes17 = new string[]
        {
            "ため \n (Tame) \n “For” or “In regards to”",
            "人 \n (Hito or Nin) \n “Person”",
            "物 \n (Mono) \n “Thing”",
            "国 \n (Kuni or Koku) \n “Country”",
            "大学 \n (Daigaku) \n “College”",
            "今 \n (Ima) \n “Now”",
            "前 \n (Mae) \n “Before”",
            "後 \n (Ato) \n “After”",
            "駅 \n (Eki) \n “(Train) Station”",
            "線 \n (Sen) \n “Line”"

        };
        public lesson17()
        {
            InitializeComponent();
            currentQuote.Text = _quotes17[_index];
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            _index++;
            if (_index >= _quotes17.Length)
                _index = 0;

            currentQuote.Text = _quotes17[_index];
        }
    }
}