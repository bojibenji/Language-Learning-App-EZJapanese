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
	public partial class lesson8 : ContentPage
	{
        private int _index = 0;
        private string[] _quotes8 = new string[]
        {
             "New \n 新しい \n atarashii",
            " Happy \n 嬉しい \n ureshii",
            "Okay  \n  大丈夫 \n daijoubu",
            "Amazing \n すごい \n sugoi",
            "Expensive, Tall \n 高い \n takai",
            "Big, Large  \n 大きい \n ookii",
            "Small  \n 小さい \n chiisai",
            "Near  \n  近い \n chikai",
            "Far \n 遠い \n tooi",
            "Bad \n 悪い \n warui"

        };
        public lesson8()
        {
            InitializeComponent();
            currentQuote.Text = _quotes8[_index];
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            _index++;
            if (_index >= _quotes8.Length)
                _index = 0;

            currentQuote.Text = _quotes8[_index];
        }
    }
}