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

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1(string[] args)
        {
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            InitializeComponent();
            this.Form1_Load(args);
        }
        public string GetData(string url)
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
        private void Form1_Load(string[] args)
        {
            this.Hide();
            this.ShowInTaskbar = false;
            try
            {
                if (args[0] == "-get")
                {
                    GetData(args[1]);
                    Application.Exit();
                }
                else if (args[0] != "-get")
                {
                    MessageBox.Show("error");
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }
    }
}
