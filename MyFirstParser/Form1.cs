//Напишите парсер сайта IPWHOIS(или аналога, имеющего API), который выдаст информацию об любом IP(страна, город и т.д)
using System;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstParser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string url = @"http://free.ipwhois.io/xml/" + IP.Text;
            string line = string.Empty;

            using (WebClient wc = new WebClient())
            {
                line = wc.DownloadString(url);
                Match match = Regex.Match(line, "<ip>(.*?)</ip><success>(.*?)</success><type>(.*?)</type><continent>(.*?)" +
                    "</continent><continent_code>(.*?)</continent_code><country>(.*?)</country><country_code>(.*?)</country_code><country_flag>(.*?)</country_flag>" +
                    "<country_capital>(.*?)</country_capital><country_phone>(.*?)</country_phone><country_neighbours>(.*?)</country_neighbours><region>(.*?)</region><city>(.*?)</city><latitude>(.*?)</latitude>", RegexOptions.Singleline); //<success> (.*) </success><type> (.*) </type>
                for (int i = 1; i <= match.Groups.Count; i++)
                    Output.Text += match.Groups[1].Value + "\r\n";
            }
        }
    }
}
