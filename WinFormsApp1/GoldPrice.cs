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
    public partial class GoldPrice : Form
    {
        public GoldPrice()
        {
            InitializeComponent();

            goldValues();
        }

        public RootGold goldPrices()
        {
            String URL = "https://api.collectapi.com/economy/goldPrice";
            var client = new RestClient(URL);
            var request = new RestRequest(URL, Method.Get);
            request.AddHeader("authorization", "apikey 2xd4saQ6GBpkzcHrIM4wLm:7kEsFOSO2sRWx7qhBFf8u5");
            request.AddHeader("Content-Type", "application/json");
            RestResponse response = client.Execute(request);

            RootGold root = JsonSerializer.Deserialize<RootGold>(response.Content);

            return root;

        }

        public void goldValues()
        {
            RootGold root = goldPrices();

            if (root.success == true)
            {
                label2.Text = root.result[0].name;
                label3.Text = root.result[0].buyingstr;
                label4.Text = root.result[0].sellingstr;

                label7.Text = root.result[1].name;
                label6.Text = root.result[1].buyingstr;
                label5.Text = root.result[1].sellingstr;

                label10.Text = root.result[2].name;
                label9.Text = root.result[2].buyingstr;
                label8.Text = root.result[2].sellingstr;

                label13.Text = root.result[3].name;
                label12.Text = root.result[3].buyingstr;
                label11.Text = root.result[3].sellingstr;

                label16.Text = root.result[4].name;
                label15.Text = root.result[4].buyingstr;
                label14.Text = root.result[4].sellingstr;

                label19.Text = root.result[5].name;
                label18.Text = root.result[5].buyingstr;
                label17.Text = root.result[5].sellingstr;

                label22.Text = root.result[6].name;
                label21.Text = root.result[6].buyingstr;
                label20.Text = root.result[6].sellingstr;

                label25.Text = root.result[7].name;
                label24.Text = root.result[7].buyingstr;
                label23.Text = root.result[7].sellingstr;

                label28.Text = root.result[8].name;
                label27.Text = root.result[8].buyingstr;
                label26.Text = root.result[8].sellingstr;

                label31.Text = root.result[9].name;
                label30.Text = root.result[9].buyingstr;
                label29.Text = root.result[9].sellingstr;

                label34.Text = root.result[10].name;
                label33.Text = root.result[10].buyingstr;
                label32.Text = root.result[10].sellingstr;

                label37.Text = root.result[11].name;
                label36.Text = root.result[11].buyingstr;
                label35.Text = root.result[11].sellingstr;

                label40.Text = root.result[12].name;
                label39.Text = root.result[12].buyingstr;
                label38.Text = root.result[12].sellingstr;

                label43.Text = root.result[13].name;
                label42.Text = root.result[13].buyingstr;
                label41.Text = root.result[13].sellingstr;

                label46.Text = root.result[14].name;
                label45.Text = root.result[14].buyingstr;
                label44.Text = root.result[14].sellingstr;

                label49.Text = root.result[15].name;
                label48.Text = root.result[15].buyingstr;
                label47.Text = root.result[15].sellingstr;

                label52.Text = root.result[16].name;
                label51.Text = root.result[16].buyingstr;
                label50.Text = root.result[16].sellingstr;

                label55.Text = root.result[18].name;
                label54.Text = root.result[18].buyingstr;
                label53.Text = root.result[18].sellingstr;

                for (int i = 0; i < root.result.Count(); i++)
                {
                    comboBox1.Items.Add(root.result[i].name);
                }
            }
        }

        public void goldCalculate()
        {
            RootGold root = goldPrices();

            if (root.success == true)
            {
                double result = Math.Round(Convert.ToDouble(textBox1.Text) * root.result[comboBox1.SelectedIndex].buying, 2);

                textBox2.Text = result.ToString() + " TL";
                textBox3.Text = root.result[comboBox1.SelectedIndex].buyingstr;

                label67.Text = Convert.ToString(root.result[comboBox1.SelectedIndex].datetime);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            goldCalculate();
        }
    }
}
