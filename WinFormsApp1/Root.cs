using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1
{


    public class Result
    {
        public string name { get; set; }
        public string code { get; set; }
        public double buying { get; set; }
        public string buyingstr { get; set; }
        public double selling { get; set; }
        public string sellingstr { get; set; }
        public double rate { get; set; }
        public string time { get; set; }
        public string date { get; set; }
        public DateTime datetime { get; set; }
        public int calculated { get; set; }

    }

    public class Root
    {
        public bool success { get; set; }
        public List<Result> result { get; set; }
    }
}
