using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoatReservation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cmboBoatType.Items.Add("Canoe");
            cmboBoatType.Items.Add("Kayak");
            cmboBoatType.Items.Add("Paddleboard");

            // I made these combo boxes, because values outside of these will never be valid
            cmboAdults.Items.Add(1);
            cmboAdults.Items.Add(2);
            cmboKids.Items.Add(0);
            cmboKids.Items.Add(1);

            cmboAdults.SelectedItem = 1;
            cmboKids.SelectedItem = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheckRes_Click(object sender, EventArgs e)
        {
            if (cmboBoatType.SelectedItem != null) // ensure a boat type selection has been made
            {
                string boatType = cmboBoatType.SelectedItem.ToString();
                int adults = (int)cmboAdults.SelectedItem;
                int kids = (int)cmboKids.SelectedItem;

                bool validRes = CheckRes(boatType, adults, kids);

                if (validRes)
                {
                    lblCheckRes.Text = "Valid";
                    btnReserve.Enabled = true;
                }
                else
                {
                    lblCheckRes.Text = "Invalid";
                    btnReserve.Enabled = false;
                }
            }
            else
            {
                lblCheckRes.Text = "Select a boat type";
            }
        }

        private bool CheckRes(string boatType, int adults, int kids)
        {
            if (boatType == "Canoe")
            {
                return CheckCanoe(adults, kids);
            }
            else if (boatType == "Kayak")
            {
                return CheckKayak(adults, kids);
            }
            else if (boatType == "Paddleboard")
            {
                return CheckPaddleboard(adults, kids);
            }    
            else // false by default, in case of something weird
            {    
                return false;
            }        
        }

        private bool CheckCanoe(int adults, int kids)
        {
            // valid cases
            if ((adults == 2 && kids == 0) || (adults == 1 && kids == 1)) // 2 people, at least 1 must be adult
            {
                return true;
            }

            // invalid cases
            else if (adults == 1 && kids == 0)
            {
                MessageBox.Show("Canoes require two people, at least one of whom must be an adult.", "Invalid");
                return false;
            }
            else if (adults == 2 && kids == 1)
            {
                MessageBox.Show("Canoes cannot accomodate more than two people.", "Invalid");
                return false;
            }

            else // default
            {
                return false;
            }
        }

        private bool CheckKayak(int adults, int kids)
        {
            if (adults == 1 && kids == 0) // one adult only
            {
                return true;
            }
            else
            {
                MessageBox.Show("Kayaks can only accomodate one adult.", "Invalid");
                return false;
            }
        }

        private bool CheckPaddleboard(int adults, int kids)
        {
            if (adults == 1) // only 1 adult, may include 1 kid
            {
                return true;
            }
            else if (adults == 2)
            {
                MessageBox.Show("Paddleboards can only accomodate one adult.", "Invalid");
                return false;
            }
            else
            {
                return false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmboBoatType.SelectedItem = null;
            cmboAdults.SelectedItem = 1;
            cmboKids.SelectedItem = 0;

            btnReserve.Enabled = false;
        }
    }
}
