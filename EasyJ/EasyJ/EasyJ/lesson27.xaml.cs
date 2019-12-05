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
	public partial class lesson27 : ContentPage
	{
        private int _index = 0;
        private string[] _quotes27 = new string[]
        {
                 "Hai \n (はい) \n Yes",
                 "Iie \n (いいえ) \n No",
                 "Mada mada \n (まだまだ) \n Not yet",
                 "Kamoshiremasen \n (かもしれません) \n Maybe/I’m not sure",
                 "Tokidoki \n (時々) \n Sometimes",
                 "Zenzen \n (全然) \n Never",
                 "Itsumo \n (いつも) \n Always",
                 "Taitei \n (たいてい) \n Usually",
                 "Watashi wa _____ desu \n (私は＿＿です) \n I’m a _______",
                 "Daijoubu desu \n (大丈夫です) \n That’s okay"

        };
        public lesson27()
        {
            InitializeComponent();
            currentQuote.Text = _quotes27[_index];
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            _index++;
            if (_index >= _quotes27.Length)
                _index = 0;

            currentQuote.Text = _quotes27[_index];
        }
    }
}