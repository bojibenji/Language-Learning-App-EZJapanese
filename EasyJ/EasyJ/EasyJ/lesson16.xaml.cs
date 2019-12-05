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
	public partial class lesson16 : ContentPage
	{
        private int _index = 0;
        private string[] _quotes16 = new string[]
        {
            "電車 \n (Densha) \n “Train”",
            "車 \n (Kuruma) \n “Car”",
            "部屋 \n (Heya) \n “Room”",
            "名前 \n (Namae) \n “Name”",
            "所 / 場所 \n (Tokoro / Basho) \n “Place”",
            "地下鉄 \n (Chikatetsu) \n “Subway”",
            "中 \n (Naka or Chuu) \n “Middle,” “Inside,” or “During”",
            "外 \n (Soto or Gai) \n “Outside”",
            "学校 \n (Gakkou) \n “School”",
            "水 \n (Mizu) \n “Water”"

        };
        public lesson16()
        {
            InitializeComponent();
            currentQuote.Text = _quotes16[_index];
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            _index++;
            if (_index >= _quotes16.Length)
                _index = 0;

            currentQuote.Text = _quotes16[_index];
        }
    }
}