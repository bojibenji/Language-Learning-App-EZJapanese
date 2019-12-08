using Xamarin.Forms;

namespace EasyJ
{
	public partial class Quiz : ContentPage
    {
		public Quiz ()
		{
            InitializeComponent();
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Quiz1());
        }

        private void Button_Clicked_1(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Quiz2());
        }

        private void Button_Clicked_2(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Quiz3());
        }
    }
}