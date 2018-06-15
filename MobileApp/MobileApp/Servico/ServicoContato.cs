using MobileApp.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MobileApp.Servico
{
    public class ServicoContato
    {
        //Pseudo banco de dados
        private static List<Contato> contatos = new List<Contato>();

        public static void AdicionarContato(Contato contato)
        {
            contatos.Add(contato);
        }

        public static IEnumerable<Contato> ObterContatos()
        {
            return contatos;
        }
    }
}
