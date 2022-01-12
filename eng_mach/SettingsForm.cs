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
    }
}
