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
	public partial class lesson2 : ContentPage
	{
        private int _index = 0;
        private string[] _quotes2 = new string[]
        {
            "Peril, Hazard \n	危険	 \n kiken",
            "What Happened? \n  どうした？  \n	doushita?",
            "Why?   \n どうして？ \n	doushite?",
            "What? \n  なに？	\n nani?",
            "Time   \n 時間  \n jikan",
            "Question   \n 質問 \n shitsumon",
            "Who?    \n だれ？	\n dare?",
            "When?   \n いつ？	\n itsu?",
            "Teacher \n 先生  \n sensei",
            "Student \n 学生  \n gakusei"

        };
        public lesson2 ()
		{
			InitializeComponent ();
            currentQuote.Text = _quotes2[_index];
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            _index++;
            if (_index >= _quotes2.Length)
                _index = 0;

            currentQuote.Text = _quotes2[_index];
        }
    }
}