
namespace Covid_Register
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.registerB = new System.Windows.Forms.Button();
            this.fnameT = new System.Windows.Forms.TextBox();
            this.numberT = new System.Windows.Forms.TextBox();
            this.paddressRtxb = new System.Windows.Forms.RichTextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.idT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tempT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.genderCmb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fullname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phone Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date Of Birth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Physical Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Temperature:";
            // 
            // registerB
            // 
            this.registerB.Location = new System.Drawing.Point(207, 421);
            this.registerB.Name = "registerB";
            this.registerB.Size = new System.Drawing.Size(124, 41);
            this.registerB.TabIndex = 5;
            this.registerB.Text = "Register";
            this.registerB.UseVisualStyleBackColor = true;
            this.registerB.Click += new System.EventHandler(this.registerB_Click);
            // 
            // fnameT
            // 
            this.fnameT.Location = new System.Drawing.Point(159, 20);
            this.fnameT.Name = "fnameT";
            this.fnameT.Size = new System.Drawing.Size(203, 24);
            this.fnameT.TabIndex = 6;
            // 
            // numberT
            // 
            this.numberT.Location = new System.Drawing.Point(159, 72);
            this.numberT.MaxLength = 10;
            this.numberT.Name = "numberT";
            this.numberT.Size = new System.Drawing.Size(203, 24);
            this.numberT.TabIndex = 7;
            // 
            // paddressRtxb
            // 
            this.paddressRtxb.Location = new System.Drawing.Point(159, 304);
            this.paddressRtxb.Name = "paddressRtxb";
            this.paddressRtxb.Size = new System.Drawing.Size(203, 96);
            this.paddressRtxb.TabIndex = 9;
            this.paddressRtxb.Text = "";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(159, 124);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(203, 24);
            this.datePicker.TabIndex = 10;
            // 
            // idT
            // 
            this.idT.Location = new System.Drawing.Point(159, 181);
            this.idT.MaxLength = 13;
            this.idT.Name = "idT";
            this.idT.Size = new System.Drawing.Size(203, 24);
            this.idT.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID Number:";
            // 
            // tempT
            // 
            this.tempT.Location = new System.Drawing.Point(159, 261);
            this.tempT.MaxLength = 4;
            this.tempT.Name = "tempT";
            this.tempT.Size = new System.Drawing.Size(203, 24);
            this.tempT.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Gender:";
            // 
            // genderCmb
            // 
            this.genderCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderCmb.FormattingEnabled = true;
            this.genderCmb.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other",
            "I prefer not to say"});
            this.genderCmb.Location = new System.Drawing.Point(159, 218);
            this.genderCmb.Name = "genderCmb";
            this.genderCmb.Size = new System.Drawing.Size(203, 26);
            this.genderCmb.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(544, 491);
            this.Controls.Add(this.genderCmb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tempT);
            this.Controls.Add(this.idT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.paddressRtxb);
            this.Controls.Add(this.numberT);
            this.Controls.Add(this.fnameT);
            this.Controls.Add(this.registerB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Covid-Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button registerB;
        private System.Windows.Forms.TextBox fnameT;
        private System.Windows.Forms.TextBox numberT;
        private System.Windows.Forms.RichTextBox paddressRtxb;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.TextBox idT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tempT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox genderCmb;
    }
}

