using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace setUrl
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            if (args[0] == "-get")
            {
                GetData(args[1]);
            }
            else if (args[0] != "-get")
            {
                Console.WriteLine("error");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Sin argumentos");
            }
        }
        static string GetData(string url)
        {
            try
            {
                WebClient client = new WebClient();
                return client.DownloadString(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
                return "";
            }

        }
    }
}
