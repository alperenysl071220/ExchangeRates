using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcahngeRates
{

    public class Datum
    {
        public string code { get; set; }
        public string name { get; set; }
        public string rate { get; set; }
        public string calculatedstr { get; set; }
        public double calculated { get; set; }
    }

    public class Result
    {
        public string @base { get; set; }
        public string lastupdate { get; set; }
        public List<Datum> data { get; set; }
    }

    public class RootCalculate
    {
        public bool success { get; set; }
        public Result result { get; set; }
    }


}
