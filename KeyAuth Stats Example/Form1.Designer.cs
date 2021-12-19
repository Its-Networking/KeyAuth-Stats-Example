namespace KeyAuth_Stats_Example
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
            this.components = new System.ComponentModel.Container();
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.siticoneShadowPanel1 = new Siticone.UI.WinForms.SiticoneShadowPanel();
            this.siticoneShadowPanel2 = new Siticone.UI.WinForms.SiticoneShadowPanel();
            this.siticoneShadowPanel3 = new Siticone.UI.WinForms.SiticoneShadowPanel();
            this.siticoneShadowPanel4 = new Siticone.UI.WinForms.SiticoneShadowPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.accountsLbl = new System.Windows.Forms.Label();
            this.applicationsLbl = new System.Windows.Forms.Label();
            this.licensesLbl = new System.Windows.Forms.Label();
            this.uptimeLbl = new System.Windows.Forms.Label();
            this.getStatsBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneShadowPanel1.SuspendLayout();
            this.siticoneShadowPanel2.SuspendLayout();
            this.siticoneShadowPanel3.SuspendLayout();
            this.siticoneShadowPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "KeyAuth Stats Example";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(805, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // siticoneShadowPanel1
            // 
            this.siticoneShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneShadowPanel1.Controls.Add(this.accountsLbl);
            this.siticoneShadowPanel1.Controls.Add(this.label4);
            this.siticoneShadowPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(51)))), ((int)(((byte)(80)))));
            this.siticoneShadowPanel1.Location = new System.Drawing.Point(17, 84);
            this.siticoneShadowPanel1.Name = "siticoneShadowPanel1";
            this.siticoneShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.siticoneShadowPanel1.ShadowStyle = Siticone.UI.WinForms.SiticoneShadowPanel.ShadowMode.Dropped;
            this.siticoneShadowPanel1.Size = new System.Drawing.Size(195, 162);
            this.siticoneShadowPanel1.TabIndex = 2;
            // 
            // siticoneShadowPanel2
            // 
            this.siticoneShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneShadowPanel2.Controls.Add(this.applicationsLbl);
            this.siticoneShadowPanel2.Controls.Add(this.label3);
            this.siticoneShadowPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(51)))), ((int)(((byte)(80)))));
            this.siticoneShadowPanel2.Location = new System.Drawing.Point(218, 84);
            this.siticoneShadowPanel2.Name = "siticoneShadowPanel2";
            this.siticoneShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.siticoneShadowPanel2.ShadowStyle = Siticone.UI.WinForms.SiticoneShadowPanel.ShadowMode.Dropped;
            this.siticoneShadowPanel2.Size = new System.Drawing.Size(195, 162);
            this.siticoneShadowPanel2.TabIndex = 3;
            // 
            // siticoneShadowPanel3
            // 
            this.siticoneShadowPanel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneShadowPanel3.Controls.Add(this.licensesLbl);
            this.siticoneShadowPanel3.Controls.Add(this.label5);
            this.siticoneShadowPanel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(51)))), ((int)(((byte)(80)))));
            this.siticoneShadowPanel3.Location = new System.Drawing.Point(419, 84);
            this.siticoneShadowPanel3.Name = "siticoneShadowPanel3";
            this.siticoneShadowPanel3.ShadowColor = System.Drawing.Color.Black;
            this.siticoneShadowPanel3.ShadowStyle = Siticone.UI.WinForms.SiticoneShadowPanel.ShadowMode.Dropped;
            this.siticoneShadowPanel3.Size = new System.Drawing.Size(195, 162);
            this.siticoneShadowPanel3.TabIndex = 3;
            // 
            // siticoneShadowPanel4
            // 
            this.siticoneShadowPanel4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneShadowPanel4.Controls.Add(this.uptimeLbl);
            this.siticoneShadowPanel4.Controls.Add(this.label6);
            this.siticoneShadowPanel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(51)))), ((int)(((byte)(80)))));
            this.siticoneShadowPanel4.Location = new System.Drawing.Point(620, 84);
            this.siticoneShadowPanel4.Name = "siticoneShadowPanel4";
            this.siticoneShadowPanel4.ShadowColor = System.Drawing.Color.Black;
            this.siticoneShadowPanel4.ShadowStyle = Siticone.UI.WinForms.SiticoneShadowPanel.ShadowMode.Dropped;
            this.siticoneShadowPanel4.Size = new System.Drawing.Size(195, 162);
            this.siticoneShadowPanel4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Applications";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Accounts";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "Licenses";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 26);
            this.label6.TabIndex = 3;
            this.label6.Text = "Uptime";
            // 
            // accountsLbl
            // 
            this.accountsLbl.AutoSize = true;
            this.accountsLbl.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountsLbl.ForeColor = System.Drawing.Color.White;
            this.accountsLbl.Location = new System.Drawing.Point(3, 72);
            this.accountsLbl.Name = "accountsLbl";
            this.accountsLbl.Size = new System.Drawing.Size(25, 26);
            this.accountsLbl.TabIndex = 3;
            this.accountsLbl.Text = "0";
            // 
            // applicationsLbl
            // 
            this.applicationsLbl.AutoSize = true;
            this.applicationsLbl.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationsLbl.ForeColor = System.Drawing.Color.White;
            this.applicationsLbl.Location = new System.Drawing.Point(3, 72);
            this.applicationsLbl.Name = "applicationsLbl";
            this.applicationsLbl.Size = new System.Drawing.Size(25, 26);
            this.applicationsLbl.TabIndex = 4;
            this.applicationsLbl.Text = "0";
            // 
            // licensesLbl
            // 
            this.licensesLbl.AutoSize = true;
            this.licensesLbl.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licensesLbl.ForeColor = System.Drawing.Color.White;
            this.licensesLbl.Location = new System.Drawing.Point(3, 72);
            this.licensesLbl.Name = "licensesLbl";
            this.licensesLbl.Size = new System.Drawing.Size(25, 26);
            this.licensesLbl.TabIndex = 5;
            this.licensesLbl.Text = "0";
            // 
            // uptimeLbl
            // 
            this.uptimeLbl.AutoSize = true;
            this.uptimeLbl.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uptimeLbl.ForeColor = System.Drawing.Color.White;
            this.uptimeLbl.Location = new System.Drawing.Point(3, 72);
            this.uptimeLbl.Name = "uptimeLbl";
            this.uptimeLbl.Size = new System.Drawing.Size(25, 26);
            this.uptimeLbl.TabIndex = 6;
            this.uptimeLbl.Text = "0";
            // 
            // getStatsBtn
            // 
            this.getStatsBtn.CheckedState.Parent = this.getStatsBtn;
            this.getStatsBtn.CustomBorderColor = System.Drawing.Color.Black;
            this.getStatsBtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.getStatsBtn.CustomImages.Parent = this.getStatsBtn;
            this.getStatsBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(51)))), ((int)(((byte)(80)))));
            this.getStatsBtn.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getStatsBtn.ForeColor = System.Drawing.Color.White;
            this.getStatsBtn.HoveredState.Parent = this.getStatsBtn;
            this.getStatsBtn.Location = new System.Drawing.Point(218, 263);
            this.getStatsBtn.Name = "getStatsBtn";
            this.getStatsBtn.ShadowDecoration.Parent = this.getStatsBtn;
            this.getStatsBtn.Size = new System.Drawing.Size(396, 39);
            this.getStatsBtn.TabIndex = 4;
            this.getStatsBtn.Text = "Get Stats";
            this.getStatsBtn.Click += new System.EventHandler(this.getStatsBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(57)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(841, 349);
            this.Controls.Add(this.getStatsBtn);
            this.Controls.Add(this.siticoneShadowPanel4);
            this.Controls.Add(this.siticoneShadowPanel3);
            this.Controls.Add(this.siticoneShadowPanel2);
            this.Controls.Add(this.siticoneShadowPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.siticoneShadowPanel1.ResumeLayout(false);
            this.siticoneShadowPanel1.PerformLayout();
            this.siticoneShadowPanel2.ResumeLayout(false);
            this.siticoneShadowPanel2.PerformLayout();
            this.siticoneShadowPanel3.ResumeLayout(false);
            this.siticoneShadowPanel3.PerformLayout();
            this.siticoneShadowPanel4.ResumeLayout(false);
            this.siticoneShadowPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Siticone.UI.WinForms.SiticoneButton getStatsBtn;
        private Siticone.UI.WinForms.SiticoneShadowPanel siticoneShadowPanel4;
        private System.Windows.Forms.Label uptimeLbl;
        private System.Windows.Forms.Label label6;
        private Siticone.UI.WinForms.SiticoneShadowPanel siticoneShadowPanel3;
        private System.Windows.Forms.Label licensesLbl;
        private System.Windows.Forms.Label label5;
        private Siticone.UI.WinForms.SiticoneShadowPanel siticoneShadowPanel2;
        private System.Windows.Forms.Label applicationsLbl;
        private System.Windows.Forms.Label label3;
        private Siticone.UI.WinForms.SiticoneShadowPanel siticoneShadowPanel1;
        private System.Windows.Forms.Label accountsLbl;
        private System.Windows.Forms.Label label4;
    }
}

