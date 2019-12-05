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
	public partial class lesson18 : ContentPage
	{
        private int _index = 0;
        private string[] _quotes18 = new string[]
        {
            "日 \n (Nichi or Hi) \n “Day” and “Sun”",
            "週 \n (Shuu) \n “Week”",
            "今日 \n (Kyou) \n “Today”",
            "明日 \n (Ashita) \n “Tomorrow”",
            "昨日 \n (Kinou) \n “Yesterday”",
            "時間 \n (Jikan) \n “Time” (As in, a time frame.)",
            "分 \n (Fun or Bun) \n “Minute”",
            "時 \n (Ji or Toki) \n “Hour” or “Time”",
            "こと \n (Koto) \n “About (this thing)”",
            "日本 \n (Nihon) \n “Japan”"

        };
        public lesson18()
        {
            InitializeComponent();
            currentQuote.Text = _quotes18[_index];
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            _index++;
            if (_index >= _quotes18.Length)
                _index = 0;

            currentQuote.Text = _quotes18[_index];
        }
    }
}