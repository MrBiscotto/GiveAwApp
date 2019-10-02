using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiveAwApp
{
    public class GiveAway
    {
        private String date;
        private String platform;
        private String resume;

        public GiveAway() { }

        public GiveAway(String date, String plat, String res)
        {
            this.Date = date;
            this.Platform = plat;
            this.Resume = res;
        }

        public string Date { get => date; set => date = value; }
        public string Platform { get => platform; set => platform = value; }
        public string Resume { get => resume; set => resume = value; }


        public override string ToString()
        {
            return base.ToString();
        }


    }
}
