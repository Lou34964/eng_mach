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
        int selectMode = 0;
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

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            loadSettings();
        }

        private void loadSettings()
        {
            //LOAD CURRENT SETTINGS

            //load rotor settings
            if (settings.SelectedRotors == null)
            {
                foreach (object o in LBSelectedRotorList.Items)
                {
                    LBRotorList.Items.Add(o);
                }
                LBSelectedRotorList.Items.Clear();
            }
            else
            {
                //load selected rotors in order.
                Rotor head = new Rotor(settings.SelectedRotors);
                while (head.Next != null)
                {
                    if (head.Name == "rot1")
                    {
                        LBSelectedRotorList.Items.Add("Rotor 1");
                        LBRotorList.Items.Remove("Rotor 1");
                    }
                    else if (head.Name == "rot2")
                    {
                        LBSelectedRotorList.Items.Add("Rotor 2");
                        LBRotorList.Items.Remove("Rotor 2");
                    }
                    else if (head.Name == "rot3")
                    {
                        LBSelectedRotorList.Items.Add("Rotor 3");
                        LBRotorList.Items.Remove("Rotor 3");
                    }
                    else if (head.Name == "rot4")
                    {
                        LBSelectedRotorList.Items.Add("Rotor 4");
                        LBRotorList.Items.Remove("Rotor 4");
                    }
                    else if (head.Name == "rot5")
                    {
                        LBSelectedRotorList.Items.Add("Rotor 5");
                        LBRotorList.Items.Remove("Rotor 5");
                    }
                    head = head.Next;
                }
                //load rotor offsets.
                NudRotor1.Value = settings.SelectedRotors.Offset;
                NudRotor2.Value = settings.SelectedRotors.Next.Offset;
                NudRotor3.Value = settings.SelectedRotors.Next.Next.Offset;
                //load reflector
                if(settings.SelectedReflector == null)
                {
                    comboBox1.SelectedIndex = -1;
                }
                else if (settings.SelectedReflector.Name == "ref1")
                {
                    comboBox1.SelectedIndex = 0;
                }
                else if (settings.SelectedReflector.Name == "ref2")
                {
                    comboBox1.SelectedIndex = 1;
                }
                else if (settings.SelectedReflector.Name == "ref3")
                {
                    comboBox1.SelectedIndex = 2;
                }
                //set reflector pattern
                comboBox1.Items[0] = $"{comboBox1.Items[0]} --  {settings.Reflectors.Reflector1.Pattern}";
                comboBox1.Items[1] = $"{comboBox1.Items[1]} --  {settings.Reflectors.Reflector2.Pattern}";
                comboBox1.Items[2] = $"{comboBox1.Items[2]} --  {settings.Reflectors.Reflector3.Pattern}";
            }
        }
        private Color selcolor;
        private string first, second;
        private void PlugboardSelect(object sender, EventArgs e)
        {
            if ((sender as Button).BackColor == Color.Transparent)
            {
                Random r = new Random();
                if (selectMode == 0)
                {
                    first = (sender as Button).Text;
                    selectMode = 1;
                    int rc = r.Next(0, settings.PlugBoardColors.avc.Count);
                    selcolor = settings.PlugBoardColors.avc[rc];
                    settings.PlugBoardColors.svc.Add(selcolor);
                    settings.PlugBoardColors.avc.Remove(selcolor);
                    (sender as Button).BackColor = selcolor;
                }
                else
                {
                    selectMode = 0;
                    second = (sender as Button).Text;
                    (sender as Button).BackColor = selcolor;
                    settings.PlugBoard.SetPlug(settings.int_to_string.IndexOf(first),
                        settings.int_to_string.IndexOf(second));
                }
            }
            else
            {
                first = (sender as Button).Text;
                Color c = (sender as Button).BackColor;
                (sender as Button).BackColor = Color.Transparent;
                Button B = Controls.OfType<Button>().Where(b => b.BackColor == c).First();
                second = B.Text;
                B.BackColor = Color.Transparent;
                settings.PlugBoard.SetPlug(settings.int_to_string.IndexOf(first),
                        settings.int_to_string.IndexOf(first));
                settings.PlugBoard.SetPlug(settings.int_to_string.IndexOf(second),
                        settings.int_to_string.IndexOf(second));

            }
        }
    }
}
