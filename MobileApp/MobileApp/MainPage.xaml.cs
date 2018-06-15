using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void BtnAdicionarContato_Clicked(Object sender, EventArgs args)
        {
            Navigation.PushAsync(new AdicionarContatoPage());
        }

        private void BtnListarContatos_Clicked(Object sender, EventArgs args)
        {
            Navigation.PushAsync(new ListarContatosPage());
        }

    }
}
