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
	public partial class lesson12 : ContentPage
	{
        private int _index = 0;
        private string[] _quotes12 = new string[]
        {
            "飲む \n (Nomu) \n “To drink”",
            "帰る \n (Kaeru) \n “To return home”",
            "多い \n (Ooi) \n “Many”",
            "たくさん \n (Takusan) \n “Lots of”",
            "少し \n (Sukoshi) \n “Few”",
            "遠い \n (Tooi) \n “Far”",
            "近い \n (Chikai) \n “Near”",
            "小さい \n (Chiisai) \n “Small”",
            "大きい \n (Ookii) \n “Big”",
            "良い \n (Yoi) \n “Good”"

        };
        public lesson12()
        {
            InitializeComponent();
            currentQuote.Text = _quotes12[_index];
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            _index++;
            if (_index >= _quotes12.Length)
                _index = 0;

            currentQuote.Text = _quotes12[_index];
        }
    }
}