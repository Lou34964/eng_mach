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
            settings.PlugBoardColors.avc.Add(Color.White);
            settings.PlugBoardColors.avc.Add(Color.Red);
            settings.PlugBoardColors.avc.Add(Color.Blue);
            settings.PlugBoardColors.avc.Add(Color.Green);
            settings.PlugBoardColors.avc.Add(Color.Aqua);
            settings.PlugBoardColors.avc.Add(Color.Gold);
            settings.PlugBoardColors.avc.Add(Color.Yellow);
            settings.PlugBoardColors.avc.Add(Color.Brown);
            settings.PlugBoardColors.avc.Add(Color.Orange);
            settings.PlugBoardColors.avc.Add(Color.Pink);
            settings.PlugBoardColors.avc.Add(Color.DarkCyan);
            settings.PlugBoardColors.avc.Add(Color.Gray);
            settings.PlugBoardColors.avc.Add(Color.Lime);
            for(int i = 0; i < settings.PlugBoard.Colors.Length; i++)
            {
                settings.PlugBoard.Colors[i] = Color.Transparent;
            }
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm();
            sf.Show();
        }
        Dictionary<char, string> cToS = new Dictionary<char, string>()
        {
            { 'A', "A"},{ 'B', "B"},{ 'C', "C"},{ 'D', "D"},{ 'E', "E"},{ 'F', "F"},{ 'G', "G"},
            { 'H', "H"},{ 'I', "I"},{ 'J', "J"},{ 'K', "K"},{ 'L', "L"},{ 'M', "M"},{ 'N', "N"},
            { 'O', "O"},{ 'P', "P"},{ 'Q', "Q"},{ 'R', "R"},{ 'S', "S"},{ 'T', "T"},{ 'U', "U"},
            { 'V', "V"},{ 'W', "W"},{ 'X', "X"},{ 'Y', "Y"},{ 'Z', "Z"},
        };
        private void BtnEncryptDecrypt_Click(object sender, EventArgs e)
        {
            textBoxOutPut.Text = string.Empty;
            string imp = textBoxInput.Text.ToUpper();
            foreach(char c in imp.ToCharArray())
            {
                int plugb1Result = settings.PlugBoard.Plugs[settings.int_to_string.IndexOf(cToS[c])];
                int R1Res = settings.SelectedRotors.GetConvertion(plugb1Result);
                int R2Res = settings.SelectedRotors.Next.GetConvertion(R1Res);
                int R3Res = settings.SelectedRotors.Next.Next.GetConvertion(R2Res);
                int refRes = settings.SelectedReflector.GetConvertion(R3Res);
                int R3Res2 = settings.SelectedRotors.Next.Next.GetConvertion(refRes);
                int R2Res2 = settings.SelectedRotors.Next.GetConvertion(R3Res2);
                int R1Res2 = settings.SelectedRotors.GetConvertion(R2Res2);
                int plugb2Result = settings.PlugBoard.Plugs[R1Res2];
                textBoxOutPut.Text += settings.int_to_string[plugb2Result];
                MessageBox.Show($"{R1Res}+{R2Res}+{R3Res}+{refRes}+{R3Res2}+{R2Res2}+{R1Res2}");
                settings.SelectedRotors.Rotate();
            }
        }
    }
}
