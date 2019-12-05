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
	public partial class lesson13 : ContentPage
	{
        private int _index = 0;
        private string[] _quotes13 = new string[]
        {
            "待つ \n (Matsu) \n “To wait”",
            "会う \n (Au) \n “To meet”",
            "呼ぶ \n (Yobu) \n “To call”",
            "置く \n (Oku) \n “To put”",
            "受ける \n (Ukeru) \n “To receive”",
            "作る \n (Tsukuru) \n “To make”",
            "着く \n (Tsuku) \n “To arrive”",
            "使う \n (Tsukau) \n “To use”",
            "学ぶ \n (Manabu) \n “To learn”",
            "食べる \n (Taberu) \n “To eat”"

        };
        public lesson13()
        {
            InitializeComponent();
            currentQuote.Text = _quotes13[_index];
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            _index++;
            if (_index >= _quotes13.Length)
                _index = 0;

            currentQuote.Text = _quotes13[_index];
        }
    }
}