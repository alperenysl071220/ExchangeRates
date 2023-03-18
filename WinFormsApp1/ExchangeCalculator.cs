using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace ExcahngeRates
{
    public partial class ExchangeCalculator : Form
    {
        public ExchangeCalculator()
        {
            InitializeComponent();
            currencies();
        }

        public void currencies()
        {
            String URL = "https://api.collectapi.com/economy/symbols";
            var client = new RestClient(URL);
            var request = new RestRequest(URL, Method.Get);
            request.AddHeader("authorization", "apikey 2xd4saQ6GBpkzcHrIM4wLm:7kEsFOSO2sRWx7qhBFf8u5");
            request.AddHeader("Content-Type", "application/json");
            RestResponse response = client.Execute(request);

            Root root = JsonSerializer.Deserialize<Root>(response.Content);

            if (root.success == true)
            {
                for (int i = 0; i < root.result.Count(); i++)
                {
                    comboBox1.Items.Add(root.result[i].code + " - " + root.result[i].name);
                    comboBox2.Items.Add(root.result[i].code + " - " + root.result[i].name);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculateExchange();
        }

        public void calculateExchange()
        {
            if (!String.IsNullOrEmpty(Convert.ToString(comboBox1.SelectedItem)) && !String.IsNullOrEmpty(Convert.ToString(comboBox2.SelectedItem)) && !String.IsNullOrEmpty(textBox1.Text))
            {
                String[] from = Convert.ToString(comboBox1.SelectedItem).Split(" - ");
                String[] to = Convert.ToString(comboBox2.SelectedItem).Split(" - ");

                String URL = "https://api.collectapi.com/economy/exchange?" + "to=" + to[0] + "&base=" + from[0];
                var client = new RestClient(URL);
                var request = new RestRequest(URL, Method.Get);
                request.AddHeader("authorization", "apikey 2xd4saQ6GBpkzcHrIM4wLm:7kEsFOSO2sRWx7qhBFf8u5");
                request.AddHeader("Content-Type", "application/json");
                RestResponse response = client.Execute(request);

                RootCalculate root = JsonSerializer.Deserialize<RootCalculate>(response.Content);

                if (root.success == true)
                {
                    double amount = Convert.ToDouble(textBox1.Text);
                    double result = Math.Round(amount * root.result.data[0].calculated, 2);

                    textBox2.Text = result.ToString() + " " + root.result.data[0].code + " (" + root.result.data[0].name + ")";
                    textBox3.Text = root.result.data[0].calculated.ToString();
                    label49.Text = root.result.lastupdate.ToString();
                }
            }
            else
            {
                MessageBox.Show("Please enter all of values", "Empty Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
