﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using PIM.Desktop.MVVM.Model;
using PIM.Desktop.MVVM.View;

namespace PIM.Desktop.MVVM.View
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        private string Url = "http://localhost:5000/";
        HttpClient client = new HttpClient();
        public Home()
        {
            InitializeComponent();
            client.BaseAddress = new Uri(Url);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
            new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json")
                );
            InitializeComponent();
            GetQuartos();
            GetPessoas();
        }


        private void GetQuartos()
        {
            var response = client.GetStringAsync(Url + "quartos").Result;
            var quartos = JsonConvert.DeserializeObject<List<QuartosModel>>(response);

            listBoxQuartos.ItemsSource = quartos;

        }

        private void GetPessoas()
        {
            var response = client.GetStringAsync(Url + "pessoas").Result;
            var pessoas = JsonConvert.DeserializeObject<List<PessoaModel>>(response);

            listBoxPessoa.ItemsSource = pessoas;

        }

        private void mnuCadastrarQuartos_Click(object sender, RoutedEventArgs e)
        {
            CadastroQuarto telaCadastroQuarto = new CadastroQuarto();
            telaCadastroQuarto.Show();
        }
        
        private void mnuReservas_Click(object sender, RoutedEventArgs e)
        {
            DescricaoReserva telaDescricaoReserva = new DescricaoReserva();
            telaDescricaoReserva.Show();
        }
        private void mnuInfoQuartos_Click(object sender, RoutedEventArgs e)
        {
            InfoQuarto telaInfoQuarto = new InfoQuarto();
            telaInfoQuarto.Show();
        }
        private void mnuListaHospedes_Click(object sender, RoutedEventArgs e)
        {
            ListaHospedes telaListaHospedes = new ListaHospedes();
            telaListaHospedes.Show();
        }
        private void mnuDescricoesHospede_Click(object sender, RoutedEventArgs e)
        {
            DescricaoHospede telaDescricaoHospede = new DescricaoHospede();
            telaDescricaoHospede.Show();
        }
        
        private void mnuCadastrarBeneficio_Click(object sender, RoutedEventArgs e)
        {
            Beneficios telaBeneficios = new Beneficios();
            telaBeneficios.Show();
        }
        private void mnuCadastrarFuncionario_Click(object sender, RoutedEventArgs e)
        {
            CadastroFuncionarios telaCadastroFuncionarios = new CadastroFuncionarios();
            telaCadastroFuncionarios.Show();
        }

        private void mnuCadastrarReservas_Click(object sender, RoutedEventArgs e)
        {
            CadastroReserva telaCadastroReserva = new CadastroReserva();
            telaCadastroReserva.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.GetPessoas();
            this.GetQuartos();
        }
    }
}
