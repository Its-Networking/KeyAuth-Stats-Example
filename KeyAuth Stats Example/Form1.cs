using Leaf.xNet;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyAuth_Stats_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void getStatsBtn_Click(object sender, EventArgs e)
        {
            string rapps = returnApplications();
            string raccs = returnAccounts();
            string rlics = returnLicenses();
            string rUpt = returnUptime();

            accountsLbl.Text = raccs;
            applicationsLbl.Text = rapps;
            licensesLbl.Text = rlics;
            uptimeLbl.Text = rUpt;
        }

        static string returnApplications()
        {
            string app = "";
            try
            {
                var request = new HttpRequest();
                var gatherData = request.Get("https://keyauth.com/stats.php");
                string setData = gatherData.ToString();
                dynamic convData = JsonConvert.DeserializeObject(setData);
                app += convData.applications;
              
                return app;
            }
            catch (HttpException ex)
            {
                return $"Error: {ex}";
            }
        }

        static string returnAccounts()
        {
            string acc = "";
            try
            {
                var request = new HttpRequest();
                var gatherData = request.Get("https://keyauth.com/stats.php");
                string setData = gatherData.ToString();
                dynamic convData = JsonConvert.DeserializeObject(setData);
                acc += convData.accounts;

                return acc;
            }
            catch (HttpException ex)
            {
                return $"Error: {ex}";
            }
        }

        static string returnLicenses()
        {
            string lic = "";
            try
            {
                var request = new HttpRequest();
                var gatherData = request.Get("https://keyauth.com/stats.php");
                string setData = gatherData.ToString();
                dynamic convData = JsonConvert.DeserializeObject(setData);
                lic += convData.licenses;

                return lic;
            }
            catch (HttpException ex)
            {
                return $"Error: {ex}";
            }
        }

        static string returnUptime()
        {
            string Upt = "";
            try
            {
                var request = new HttpRequest();
                var gatherData = request.Get("https://keyauth.com/stats.php");
                string setData = gatherData.ToString();
                dynamic convData = JsonConvert.DeserializeObject(setData);
                Upt += convData.uptime;

                return Upt;
            }
            catch (HttpException ex)
            {
                return $"Error: {ex}";
            }
        }
    }
}
