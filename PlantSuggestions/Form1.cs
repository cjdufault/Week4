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
        public Form1()
        {
            InitializeComponent();
            this.trkTemp.Scroll += new EventHandler(this.btnSuggest_Click);
        }

        private void trkTemp_Scroll(object sender, EventArgs e)
        {
            lblTemp.Text = trkTemp.Value + " °F";
        }

        private void btnSuggest_Click(object sender, EventArgs e)
        {
            int temp = trkTemp.Value;
            bool southFacing = chkSthFacing.Checked;

            string suggestion = GenerateSuggestion(temp, southFacing);
            lblSuggestion.Text = suggestion;
        }

        private string GenerateSuggestion(int temp, bool southFacing)
        {
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
    }
}
