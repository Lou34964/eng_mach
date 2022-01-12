
namespace eng_mach
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBRotorList = new System.Windows.Forms.ListBox();
            this.LBSelectedRotorList = new System.Windows.Forms.ListBox();
            this.BtnMoveRight = new System.Windows.Forms.Button();
            this.BtnMoveLeft = new System.Windows.Forms.Button();
            this.textBoxRotorPattern = new System.Windows.Forms.TextBox();
            this.lblRotorPattern = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnUp = new System.Windows.Forms.Button();
            this.BtnDown = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NudRotor1 = new System.Windows.Forms.NumericUpDown();
            this.NudRotor2 = new System.Windows.Forms.NumericUpDown();
            this.NudRotor3 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NudRotor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudRotor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudRotor3)).BeginInit();
            this.SuspendLayout();
            // 
            // LBRotorList
            // 
            this.LBRotorList.FormattingEnabled = true;
            this.LBRotorList.Items.AddRange(new object[] {
            "Rotor 4",
            "Rotor 5"});
            this.LBRotorList.Location = new System.Drawing.Point(136, 31);
            this.LBRotorList.Name = "LBRotorList";
            this.LBRotorList.Size = new System.Drawing.Size(120, 277);
            this.LBRotorList.Sorted = true;
            this.LBRotorList.TabIndex = 0;
            this.LBRotorList.SelectedIndexChanged += new System.EventHandler(this.LBRotorList_SelectedIndexChanged);
            // 
            // LBSelectedRotorList
            // 
            this.LBSelectedRotorList.FormattingEnabled = true;
            this.LBSelectedRotorList.Items.AddRange(new object[] {
            "Rotor 1",
            "Rotor 2",
            "Rotor 3"});
            this.LBSelectedRotorList.Location = new System.Drawing.Point(379, 31);
            this.LBSelectedRotorList.Name = "LBSelectedRotorList";
            this.LBSelectedRotorList.Size = new System.Drawing.Size(120, 277);
            this.LBSelectedRotorList.TabIndex = 1;
            this.LBSelectedRotorList.SelectedIndexChanged += new System.EventHandler(this.LBSelectedRotorList_SelectedIndexChanged);
            // 
            // BtnMoveRight
            // 
            this.BtnMoveRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMoveRight.Location = new System.Drawing.Point(288, 113);
            this.BtnMoveRight.Name = "BtnMoveRight";
            this.BtnMoveRight.Size = new System.Drawing.Size(41, 41);
            this.BtnMoveRight.TabIndex = 2;
            this.BtnMoveRight.Text = "►";
            this.BtnMoveRight.UseVisualStyleBackColor = true;
            this.BtnMoveRight.Click += new System.EventHandler(this.BtnMoveRight_Click);
            // 
            // BtnMoveLeft
            // 
            this.BtnMoveLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMoveLeft.Location = new System.Drawing.Point(288, 160);
            this.BtnMoveLeft.Name = "BtnMoveLeft";
            this.BtnMoveLeft.Size = new System.Drawing.Size(41, 41);
            this.BtnMoveLeft.TabIndex = 3;
            this.BtnMoveLeft.Text = "◄";
            this.BtnMoveLeft.UseVisualStyleBackColor = true;
            this.BtnMoveLeft.Click += new System.EventHandler(this.BtnMoveLeft_Click);
            // 
            // textBoxRotorPattern
            // 
            this.textBoxRotorPattern.Location = new System.Drawing.Point(120, 332);
            this.textBoxRotorPattern.Name = "textBoxRotorPattern";
            this.textBoxRotorPattern.Size = new System.Drawing.Size(390, 20);
            this.textBoxRotorPattern.TabIndex = 4;
            // 
            // lblRotorPattern
            // 
            this.lblRotorPattern.AutoSize = true;
            this.lblRotorPattern.Location = new System.Drawing.Point(41, 335);
            this.lblRotorPattern.Name = "lblRotorPattern";
            this.lblRotorPattern.Size = new System.Drawing.Size(73, 13);
            this.lblRotorPattern.TabIndex = 5;
            this.lblRotorPattern.Text = "Rotor Pattern:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Reflector 1",
            "Reflector 2",
            "Reflector 3"});
            this.comboBox1.Location = new System.Drawing.Point(120, 366);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(390, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Available Rotors";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Selected Rotors";
            // 
            // BtnUp
            // 
            this.BtnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUp.Location = new System.Drawing.Point(505, 113);
            this.BtnUp.Name = "BtnUp";
            this.BtnUp.Size = new System.Drawing.Size(41, 41);
            this.BtnUp.TabIndex = 9;
            this.BtnUp.Text = "▲";
            this.BtnUp.UseVisualStyleBackColor = true;
            this.BtnUp.Click += new System.EventHandler(this.BtnUp_Click);
            // 
            // BtnDown
            // 
            this.BtnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDown.Location = new System.Drawing.Point(505, 160);
            this.BtnDown.Name = "BtnDown";
            this.BtnDown.Size = new System.Drawing.Size(41, 41);
            this.BtnDown.TabIndex = 10;
            this.BtnDown.Text = "▼";
            this.BtnDown.UseVisualStyleBackColor = true;
            this.BtnDown.Click += new System.EventHandler(this.BtnDown_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(700, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 23);
            this.button3.TabIndex = 11;
            this.button3.Tag = "plugs";
            this.button3.Text = "A";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.PlugboardSelect);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(700, 84);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(26, 23);
            this.button4.TabIndex = 12;
            this.button4.Tag = "plugs";
            this.button4.Text = "B";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.PlugboardSelect);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(700, 113);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(26, 23);
            this.button5.TabIndex = 13;
            this.button5.Tag = "plugs";
            this.button5.Text = "C";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.PlugboardSelect);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(700, 142);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(26, 23);
            this.button6.TabIndex = 14;
            this.button6.Tag = "plugs";
            this.button6.Text = "D";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.PlugboardSelect);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(700, 171);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(26, 23);
            this.button7.TabIndex = 15;
            this.button7.Tag = "plugs";
            this.button7.Text = "E";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.PlugboardSelect);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(700, 200);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(26, 23);
            this.button8.TabIndex = 16;
            this.button8.Tag = "plugs";
            this.button8.Text = "F";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.PlugboardSelect);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(700, 229);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(26, 23);
            this.button9.TabIndex = 17;
            this.button9.Tag = "plugs";
            this.button9.Text = "G";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.PlugboardSelect);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Transparent;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(700, 258);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(26, 23);
            this.button10.TabIndex = 18;
            this.button10.Tag = "plugs";
            this.button10.Text = "H";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.PlugboardSelect);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Transparent;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(700, 287);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(26, 23);
            this.button11.TabIndex = 19;
            this.button11.Tag = "plugs";
            this.button11.Text = "I";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.PlugboardSelect);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Transparent;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(700, 316);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(26, 23);
            this.button12.TabIndex = 20;
            this.button12.Tag = "plugs";
            this.button12.Text = "J";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.PlugboardSelect);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Transparent;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Location = new System.Drawing.Point(700, 345);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(26, 23);
            this.button13.TabIndex = 21;
            this.button13.Tag = "plugs";
            this.button13.Text = "K";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.PlugboardSelect);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Transparent;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Location = new System.Drawing.Point(700, 374);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(26, 23);
            this.button14.TabIndex = 22;
            this.button14.Tag = "plugs";
            this.button14.Text = "L";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.PlugboardSelect);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Transparent;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Location = new System.Drawing.Point(700, 403);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(26, 23);
            this.button15.TabIndex = 23;
            this.button15.Tag = "plugs";
            this.button15.Text = "M";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.PlugboardSelect);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Transparent;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Location = new System.Drawing.Point(732, 55);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(26, 23);
            this.button16.TabIndex = 24;
            this.button16.Tag = "plugs";
            this.button16.Text = "N";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.PlugboardSelect);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Transparent;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Location = new System.Drawing.Point(732, 84);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(26, 23);
            this.button17.TabIndex = 25;
            this.button17.Tag = "plugs";
            this.button17.Text = "O";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.PlugboardSelect);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Transparent;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Location = new System.Drawing.Point(732, 113);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(26, 23);
            this.button18.TabIndex = 26;
            this.button18.Tag = "plugs";
            this.button18.Text = "P";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.PlugboardSelect);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.Transparent;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Location = new System.Drawing.Point(732, 143);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(26, 23);
            this.button19.TabIndex = 27;
            this.button19.Tag = "plugs";
            this.button19.Text = "Q";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.PlugboardSelect);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.Transparent;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Location = new System.Drawing.Point(732, 172);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(26, 23);
            this.button20.TabIndex = 28;
            this.button20.Tag = "plugs";
            this.button20.Text = "R";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.PlugboardSelect);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.Transparent;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Location = new System.Drawing.Point(732, 201);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(26, 23);
            this.button21.TabIndex = 29;
            this.button21.Tag = "plugs";
            this.button21.Text = "S";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.PlugboardSelect);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.Transparent;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Location = new System.Drawing.Point(732, 230);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(26, 23);
            this.button22.TabIndex = 30;
            this.button22.Tag = "plugs";
            this.button22.Text = "T";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.PlugboardSelect);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.Transparent;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.Location = new System.Drawing.Point(732, 258);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(26, 23);
            this.button23.TabIndex = 31;
            this.button23.Tag = "plugs";
            this.button23.Text = "U";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.PlugboardSelect);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.Transparent;
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button24.Location = new System.Drawing.Point(732, 287);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(26, 23);
            this.button24.TabIndex = 32;
            this.button24.Tag = "plugs";
            this.button24.Text = "V";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.PlugboardSelect);
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.Transparent;
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button25.Location = new System.Drawing.Point(732, 316);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(26, 23);
            this.button25.TabIndex = 33;
            this.button25.Tag = "plugs";
            this.button25.Text = "W";
            this.button25.UseVisualStyleBackColor = false;
            this.button25.Click += new System.EventHandler(this.PlugboardSelect);
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.Transparent;
            this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button26.Location = new System.Drawing.Point(732, 345);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(26, 23);
            this.button26.TabIndex = 34;
            this.button26.Tag = "plugs";
            this.button26.Text = "X";
            this.button26.UseVisualStyleBackColor = false;
            this.button26.Click += new System.EventHandler(this.PlugboardSelect);
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.Color.Transparent;
            this.button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button27.Location = new System.Drawing.Point(732, 374);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(26, 23);
            this.button27.TabIndex = 35;
            this.button27.Tag = "plugs";
            this.button27.Text = "Y";
            this.button27.UseVisualStyleBackColor = false;
            this.button27.Click += new System.EventHandler(this.PlugboardSelect);
            // 
            // button28
            // 
            this.button28.BackColor = System.Drawing.Color.Transparent;
            this.button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button28.Location = new System.Drawing.Point(732, 403);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(26, 23);
            this.button28.TabIndex = 36;
            this.button28.Tag = "plugs";
            this.button28.Text = "Z";
            this.button28.UseVisualStyleBackColor = false;
            this.button28.Click += new System.EventHandler(this.PlugboardSelect);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(702, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "PlugBoard";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Reflector:";
            // 
            // NudRotor1
            // 
            this.NudRotor1.Location = new System.Drawing.Point(569, 31);
            this.NudRotor1.Name = "NudRotor1";
            this.NudRotor1.Size = new System.Drawing.Size(38, 20);
            this.NudRotor1.TabIndex = 39;
            // 
            // NudRotor2
            // 
            this.NudRotor2.Location = new System.Drawing.Point(569, 57);
            this.NudRotor2.Name = "NudRotor2";
            this.NudRotor2.Size = new System.Drawing.Size(38, 20);
            this.NudRotor2.TabIndex = 40;
            // 
            // NudRotor3
            // 
            this.NudRotor3.Location = new System.Drawing.Point(569, 83);
            this.NudRotor3.Name = "NudRotor3";
            this.NudRotor3.Size = new System.Drawing.Size(38, 20);
            this.NudRotor3.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(545, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "rotor offset selection";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(391, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(310, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 44;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NudRotor3);
            this.Controls.Add(this.NudRotor2);
            this.Controls.Add(this.NudRotor1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BtnDown);
            this.Controls.Add(this.BtnUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblRotorPattern);
            this.Controls.Add(this.textBoxRotorPattern);
            this.Controls.Add(this.BtnMoveLeft);
            this.Controls.Add(this.BtnMoveRight);
            this.Controls.Add(this.LBSelectedRotorList);
            this.Controls.Add(this.LBRotorList);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudRotor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudRotor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudRotor3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LBRotorList;
        private System.Windows.Forms.ListBox LBSelectedRotorList;
        private System.Windows.Forms.Button BtnMoveRight;
        private System.Windows.Forms.Button BtnMoveLeft;
        private System.Windows.Forms.TextBox textBoxRotorPattern;
        private System.Windows.Forms.Label lblRotorPattern;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnUp;
        private System.Windows.Forms.Button BtnDown;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NudRotor1;
        private System.Windows.Forms.NumericUpDown NudRotor2;
        private System.Windows.Forms.NumericUpDown NudRotor3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}