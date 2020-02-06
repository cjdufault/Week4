using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlantSuggestions
{
    public partial class Form1 : Form
    {
        int MaxTemp = 90;
        int MinTemp = 50;

        // true if the applicable warning has been shown
        bool MinTempWarningShown = false;
        bool MaxTempWarningShown = false;

        public Form1()
        {
            InitializeComponent();
            this.trkTemp.Scroll += new EventHandler(this.HouseConditionsChanged);

            this.trkTemp.Maximum = MaxTemp;
            this.trkTemp.Minimum = MinTemp;
        }

        private void trkTemp_Scroll(object sender, EventArgs e)
        {
            lblTemp.Text = trkTemp.Value + " °F";
        }

        private void HouseConditionsChanged(object sender, EventArgs e) 
        {
            int temp = trkTemp.Value;
            bool southFacing = chkSthFacing.Checked;

            if (temp == MinTemp && !MinTempWarningShown)
            {
                MinTempWarningShown = true;
                MessageBox.Show("Your home may be too cold for houseplants!", "Too Cold!");
            }
            else if (temp == MaxTemp && !MaxTempWarningShown)
            {
                MaxTempWarningShown = true;
                MessageBox.Show("Your home may be too hot for houseplants!", "Too Hot!");
            }

            string suggestion = GenerateSuggestion(temp, southFacing);
            lblSuggestion.Text = suggestion;
        }

        private string GenerateSuggestion(int temp, bool southFacing)
        {
            // determine the suggestion based on available sunlight and temperature
            if (southFacing)
            {
                if (temp > 65)
                {
                    return "Peace Lily";
                }
                else
                {
                    return "Spider Plant";
                }
            }
            else
            {
                if (temp > 65)
                {
                    return "Dragon Tree";
                }
                else
                {
                    return "Ivy";
                }
            }
            
        }

        private void linkHousePlantInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblSuggestion.Text == "Plant suggestion here") // don't give an arguement to ShowWebPage if no suggestion has been made
            {
                ShowWebPage();
            }
            else
            {
                ShowWebPage(lblSuggestion.Text);
            }
        }

        private void ShowWebPage(string plantName = null)
        {
            string url = "https://houseplant411.com/";

            if (plantName != null)
            {
                url = url + "houseplant?hpq=" + plantName; // takes you to the search page for that plant on houseplant411.com
            }

            System.Diagnostics.Process.Start(url);
        }
    }
}
