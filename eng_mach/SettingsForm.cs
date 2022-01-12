using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eng_mach
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void BtnMoveRight_Click(object sender, EventArgs e)
        {
            if(LBRotorList.SelectedIndex > -1)
            {
                if(LBSelectedRotorList.Items.Count < 3)
                {
                    LBSelectedRotorList.Items.Add(LBRotorList.SelectedItem);
                    LBRotorList.Items.RemoveAt(LBRotorList.SelectedIndex);
                }
                else
                {

                }
            }
            else
            {

            }
        }

        private void BtnMoveLeft_Click(object sender, EventArgs e)
        {
            if(LBSelectedRotorList.SelectedIndex > -1)
            {
                LBRotorList.Items.Add(LBSelectedRotorList.SelectedItem);
                LBSelectedRotorList.Items.RemoveAt(LBSelectedRotorList.SelectedIndex);
            }
        }

        private void LBRotorList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((sender as ListBox).SelectedIndex > -1)
            {
                LBSelectedRotorList.SelectedIndex = -1;
                SetPatternTextBox((sender as ListBox).SelectedItem.ToString());
            }
        }

        private void LBSelectedRotorList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ListBox).SelectedIndex > -1)
            {
                LBRotorList.SelectedIndex = -1;
                SetPatternTextBox((sender as ListBox).SelectedItem.ToString());
            }
        }



        private void SetPatternTextBox(string rotor)
        {
            if(rotor == "Rotor 1")
            {
                textBoxRotorPattern.Text = settings.Rotors.Rotor1.Pattern;
            }
            else if (rotor == "Rotor 2")
            {
                textBoxRotorPattern.Text = settings.Rotors.Rotor2.Pattern;
            }
            else if (rotor == "Rotor 3")
            {
                textBoxRotorPattern.Text = settings.Rotors.Rotor3.Pattern;
            }
            else if (rotor == "Rotor 4")
            {
                textBoxRotorPattern.Text = settings.Rotors.Rotor4.Pattern;
            }
            else if (rotor == "Rotor 5")
            {
                textBoxRotorPattern.Text = settings.Rotors.Rotor5.Pattern;
            }
            else
            {
                throw new Exception("Error Setting Rotor Pattern");
            }
        }

        private void BtnUp_Click(object sender, EventArgs e)
        {
            int seli = LBSelectedRotorList.SelectedIndex;
            if (seli > -1)
            {
                if(seli == 0)
                {

                }
                else
                {
                    string temp = LBSelectedRotorList.Items[seli - 1].ToString();
                    LBSelectedRotorList.Items[seli - 1] = LBSelectedRotorList.Items[seli];
                    LBSelectedRotorList.Items[seli] = temp;
                    LBSelectedRotorList.SelectedIndex -= 1;
                }
            }
        }

        private void BtnDown_Click(object sender, EventArgs e)
        {
            int seli = LBSelectedRotorList.SelectedIndex;
            if(seli > -1)
            {
                if (seli < LBSelectedRotorList.Items.Count - 1)
                {
                    string temp = LBSelectedRotorList.Items[seli + 1].ToString();
                    LBSelectedRotorList.Items[seli + 1] = LBSelectedRotorList.Items[seli];
                    LBSelectedRotorList.Items[seli] = temp;
                    LBSelectedRotorList.SelectedIndex ++;
                }
            }
        }
    }
}
