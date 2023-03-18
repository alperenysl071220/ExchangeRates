using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace ExcahngeRates
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExchangeTable exchangeTable = new ExchangeTable();
            exchangeTable.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExchangeCalculator exchangeCalculator = new ExchangeCalculator();
            exchangeCalculator.Show();
        }
    }
}
