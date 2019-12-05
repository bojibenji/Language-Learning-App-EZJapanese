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
	public partial class lesson3 : ContentPage
	{
        private int _index = 0;
        private string[] _quotes3 = new string[]
        {
            "Employee  \n  会社員 \n kaishain",
            "Person  \n 人  \n hito",
            "I  \n 私  \n watashi",
            "You \n あなた \n anata",
            " Hotel  \n ホテル \n hoteru",
            "Where?  \n どこ？	\n doko?",
            "Airport \n 空港  \n kuukou",
            "Station \n 駅  \n eki",
            "Japan  /n 日本  \n nihon / nippon",
            "College \n 大学 \n daigaku"

        };
        public lesson3 ()
		{
			InitializeComponent ();
            currentQuote.Text = _quotes3[_index];
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            _index++;
            if (_index >= _quotes3.Length)
                _index = 0;

            currentQuote.Text = _quotes3[_index];
        }
    }
}