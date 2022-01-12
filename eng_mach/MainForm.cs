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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //default settings
            settings.SelectedRotors = new Rotor(settings.Rotors.Rotor1);
            settings.SelectedRotors.Next = new Rotor(settings.Rotors.Rotor2);
            settings.SelectedRotors.Next.Next = new Rotor(settings.Rotors.Rotor3);
            settings.SelectedRotors.Offset = 0;
            settings.SelectedRotors.Next.Offset = 1;
            settings.SelectedRotors.Next.Next.Offset = 2;
            settings.SelectedReflector = settings.Reflectors.Reflector1;
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm();
            sf.Show();
        }
    }
}
