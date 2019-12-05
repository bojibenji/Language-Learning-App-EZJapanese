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
	public partial class lesson29 : ContentPage
	{
        private int _index = 0;
        private string[] _quotes29 = new string[]
        {
                "Tasukete! \n (助けて) \n Help me!",
                "Keisatsu o yonde kudasai! \n (警察を読んで下さい) \n Please call the police!",
                "Kyuu kyuusha o yonde kudasai! \n (救急車を読んで下さい) \n Please call an ambulance!",
                "刺身を食べたことがあります。 \n sashimi wo tabeta koto ga arimasu \n  I have eaten sashimi before.",
                "富士山に登ったことがありません。\n fujisan ni nobotta koto ga arimasen \n  I have not climbed Mount Fuji before.",
                " パチンコをしたことがありません。\n pachinko wo shita koto ga arimasen \n I have not played Pachinko before.",
                " 一度/一回 富士山に登ったことがあります。\n ichido/ikkai fujisan ni nobotta koto ga arimasu \n I have climbed Mount Fuji once.",
                " 何度も/何回も パチンコをしたことがあります。\n nandomo/nankaimo pachinko wo shita koto ga arimasu \n I have played Pachinko many times.",
                " あなたは何 が ほしいですか。\n anata wa nani ga hoshii desu ka \n What do you want?",
                " ジュース を/が 飲みたいです。\n ju-su wo/ga nomitai desu \n I want to drink juice."

        };
        public lesson29()
        {
            InitializeComponent();
            currentQuote.Text = _quotes29[_index];
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            _index++;
            if (_index >= _quotes29.Length)
                _index = 0;

            currentQuote.Text = _quotes29[_index];
        }
    }
}