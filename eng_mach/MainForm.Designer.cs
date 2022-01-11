
namespace eng_mach
{
    partial class MainForm
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
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxOutPut = new System.Windows.Forms.TextBox();
            this.BtnEncryptDecrypt = new System.Windows.Forms.Button();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(12, 12);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(666, 119);
            this.textBoxInput.TabIndex = 0;
            // 
            // textBoxOutPut
            // 
            this.textBoxOutPut.Location = new System.Drawing.Point(12, 199);
            this.textBoxOutPut.Multiline = true;
            this.textBoxOutPut.Name = "textBoxOutPut";
            this.textBoxOutPut.Size = new System.Drawing.Size(666, 119);
            this.textBoxOutPut.TabIndex = 1;
            // 
            // BtnEncryptDecrypt
            // 
            this.BtnEncryptDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEncryptDecrypt.Location = new System.Drawing.Point(245, 137);
            this.BtnEncryptDecrypt.Name = "BtnEncryptDecrypt";
            this.BtnEncryptDecrypt.Size = new System.Drawing.Size(193, 56);
            this.BtnEncryptDecrypt.TabIndex = 2;
            this.BtnEncryptDecrypt.Text = "Encrypt/Decrypt";
            this.BtnEncryptDecrypt.UseVisualStyleBackColor = true;
            // 
            // BtnSettings
            // 
            this.BtnSettings.Location = new System.Drawing.Point(609, 137);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(75, 23);
            this.BtnSettings.TabIndex = 3;
            this.BtnSettings.Text = "Settings";
            this.BtnSettings.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 333);
            this.Controls.Add(this.BtnSettings);
            this.Controls.Add(this.BtnEncryptDecrypt);
            this.Controls.Add(this.textBoxOutPut);
            this.Controls.Add(this.textBoxInput);
            this.Name = "MainForm";
            this.Text = "Eng_Sim";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxOutPut;
        private System.Windows.Forms.Button BtnEncryptDecrypt;
        private System.Windows.Forms.Button BtnSettings;
    }
}

