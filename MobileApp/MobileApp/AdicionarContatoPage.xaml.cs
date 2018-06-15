using MobileApp.Modelo;
using MobileApp.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AdicionarContatoPage : ContentPage
	{
		public AdicionarContatoPage ()
		{
			InitializeComponent ();
		}

        private void BtnAdicionar_Clicked(object sender, EventArgs e)
        {
            Contato contato = new Contato()
            {
                Nome = EntryNome.Text,
                Email = EntryEmail.Text,
                Telefone = EntryTelefone.Text
            };

            ServicoContato.AdicionarContato(contato);

            DisplayAlert("Contato Cadastrado",
                "Contato cadastrado com sucesso", "Ok");

            EntryNome.Text = "";
            EntryEmail.Text = "";
            EntryTelefone.Text = "";
        }
    }
}