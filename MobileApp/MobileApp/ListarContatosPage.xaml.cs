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
    public partial class ListarContatosPage : ContentPage
    {
        public ListarContatosPage()
        {
            InitializeComponent();
            ListarContatos(ServicoContato.ObterContatos());
        }

        private void ListarContatos(IEnumerable<Contato> contatos)
        {
            foreach(var contato in contatos)
            {
                LblContatos.Text += $"Nome: {contato.Nome}\n";
                LblContatos.Text += $"Email: {contato.Email}\n";
                LblContatos.Text += $"Telefone: {contato.Telefone}\n";
                LblContatos.Text += "\n";

                /*
                 * A opção abaixo adiciona componentes na interface
                 * 
                StackLayout stack = new StackLayout()
                {
                    Orientation = StackOrientation.Horizontal
                };

                stack.Children.Add(new Label() { Text = $"Nome: {contato.Nome}" });
                stack.Children.Add(new Label() { Text = $"Email: {contato.Email}" });
                stack.Children.Add(new Label() { Text = $"Telefone: {contato.Telefone}" });
                stack.Children.Add(new Button() { Text = "Editar" });
                stack.Children.Add(new Button() { Text = "Excluir" });

                StackContatos.Children.Add(stack);*/
            }
        }
    }
}