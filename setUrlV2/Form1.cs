using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace setUrlV2
{
    public partial class setUrl : Form
    {
        private string[] args;
        public setUrl(string[] argumentos)
        {
            InitializeComponent();
            args = argumentos;
        }
        private string GetData(string url)
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
        private void Form1_Load(object sender, EventArgs e)
        {
            if (args[0] == "-get")
            {
                string rtn = GetData(args[1]);
                Application.Exit();
            }
            else if (args[0] != "-get")
            {
                MessageBox.Show("error");
                Application.Exit();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
