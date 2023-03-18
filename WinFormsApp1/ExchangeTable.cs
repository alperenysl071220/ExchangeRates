using RestSharp;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace WinFormsApp1
{
    public partial class ExchangeTable : Form
    {

        public ExchangeTable()
        {
            InitializeComponent();
            DovizHesap();
        }

        public void DovizHesap()
        {
            String URL = "https://api.collectapi.com/economy/allCurrency";
            var client = new RestClient(URL);
            var request = new RestRequest(URL, Method.Get);
            request.AddHeader("authorization", "apikey 2xd4saQ6GBpkzcHrIM4wLm:7kEsFOSO2sRWx7qhBFf8u5");
            request.AddHeader("Content-Type", "application/json");
            RestResponse response = client.Execute(request);

            Root root = JsonSerializer.Deserialize<Root>(response.Content);

            label49.Text = root.result[0].datetime.ToString();

            label5.Text = root.result[0].buyingstr;
            label6.Text = root.result[0].sellingstr;

            label8.Text = root.result[1].buyingstr;
            label7.Text = root.result[1].sellingstr;

            label11.Text = root.result[2].buyingstr;
            label10.Text = root.result[2].sellingstr;

            label14.Text = root.result[3].buyingstr;
            label13.Text = root.result[3].sellingstr;

            label17.Text = root.result[4].buyingstr;
            label16.Text = root.result[4].sellingstr;

            label20.Text = root.result[5].buyingstr;
            label19.Text = root.result[5].sellingstr;

            label23.Text = root.result[6].buyingstr;
            label22.Text = root.result[6].sellingstr;

            label26.Text = root.result[9].buyingstr;
            label25.Text = root.result[9].sellingstr;

            label29.Text = root.result[10].buyingstr;
            label28.Text = root.result[10].sellingstr;

            label32.Text = root.result[11].buyingstr;
            label31.Text = root.result[11].sellingstr;

            label35.Text = root.result[12].buyingstr;
            label34.Text = root.result[12].sellingstr;

            label38.Text = root.result[26].buyingstr;
            label37.Text = root.result[26].sellingstr;

            label41.Text = root.result[27].buyingstr;
            label40.Text = root.result[27].sellingstr;

            label44.Text = root.result[32].buyingstr;
            label43.Text = root.result[32].sellingstr;

        }


    }


}