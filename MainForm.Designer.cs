namespace ShutdownClock
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ForceBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Start_Btn = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Secs = new System.Windows.Forms.Label();
            this.Mins = new System.Windows.Forms.Label();
            this.Hours = new System.Windows.Forms.Label();
            this.SNum = new System.Windows.Forms.NumericUpDown();
            this.HNum = new System.Windows.Forms.NumericUpDown();
            this.MNum = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Abort_Btn = new System.Windows.Forms.Button();
            this.Play_Btn = new System.Windows.Forms.PictureBox();
            this.Pause_Btn = new System.Windows.Forms.PictureBox();
            this.picboxPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play_Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pause_Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPB)).BeginInit();
            this.SuspendLayout();
            // 
            // ForceBox
            // 
            this.ForceBox.AutoSize = true;
            this.ForceBox.BackColor = System.Drawing.SystemColors.Control;
            this.ForceBox.Location = new System.Drawing.Point(369, 76);
            this.ForceBox.Name = "ForceBox";
            this.ForceBox.Size = new System.Drawing.Size(59, 21);
            this.ForceBox.TabIndex = 66;
            this.ForceBox.Text = "Force";
            this.ForceBox.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(501, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 64;
            this.label3.Text = "Seconds:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 63;
            this.label2.Text = "Minutes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 62;
            this.label1.Text = "Hours:";
            // 
            // Start_Btn
            // 
            this.Start_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Start_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(86)))), ((int)(((byte)(75)))));
            this.Start_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start_Btn.FlatAppearance.BorderSize = 0;
            this.Start_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(120)))), ((int)(((byte)(111)))));
            this.Start_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start_Btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Start_Btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Start_Btn.Location = new System.Drawing.Point(481, 120);
            this.Start_Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Start_Btn.Name = "Start_Btn";
            this.Start_Btn.Size = new System.Drawing.Size(80, 29);
            this.Start_Btn.TabIndex = 56;
            this.Start_Btn.Text = "START";
            this.Start_Btn.UseVisualStyleBackColor = false;
            this.Start_Btn.Click += new System.EventHandler(this.Start_Click);
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Shutdown",
            "Sleep",
            "Hibernate",
            "Reboot",
            "Log off",
            "Lock"});
            this.comboBox.Location = new System.Drawing.Point(434, 72);
            this.comboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 28);
            this.comboBox.TabIndex = 54;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(202, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 47);
            this.label5.TabIndex = 61;
            this.label5.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(93, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 47);
            this.label4.TabIndex = 60;
            this.label4.Text = ":";
            // 
            // Secs
            // 
            this.Secs.AutoSize = true;
            this.Secs.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Secs.Location = new System.Drawing.Point(233, 17);
            this.Secs.Name = "Secs";
            this.Secs.Size = new System.Drawing.Size(76, 56);
            this.Secs.TabIndex = 59;
            this.Secs.Text = "00";
            // 
            // Mins
            // 
            this.Mins.AutoSize = true;
            this.Mins.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Mins.Location = new System.Drawing.Point(133, 17);
            this.Mins.Name = "Mins";
            this.Mins.Size = new System.Drawing.Size(76, 56);
            this.Mins.TabIndex = 57;
            this.Mins.Text = "00";
            // 
            // Hours
            // 
            this.Hours.AutoSize = true;
            this.Hours.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Hours.Location = new System.Drawing.Point(29, 17);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(76, 56);
            this.Hours.TabIndex = 55;
            this.Hours.Text = "00";
            // 
            // SNum
            // 
            this.SNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SNum.Location = new System.Drawing.Point(503, 26);
            this.SNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SNum.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.SNum.Name = "SNum";
            this.SNum.Size = new System.Drawing.Size(56, 29);
            this.SNum.TabIndex = 53;
            this.SNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HNum_KeyPress);
            // 
            // HNum
            // 
            this.HNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HNum.Location = new System.Drawing.Point(379, 26);
            this.HNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HNum.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.HNum.Name = "HNum";
            this.HNum.Size = new System.Drawing.Size(56, 29);
            this.HNum.TabIndex = 51;
            this.HNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HNum_KeyPress);
            // 
            // MNum
            // 
            this.MNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MNum.Location = new System.Drawing.Point(441, 26);
            this.MNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MNum.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.MNum.Name = "MNum";
            this.MNum.Size = new System.Drawing.Size(56, 29);
            this.MNum.TabIndex = 52;
            this.MNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HNum_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Abort_Btn
            // 
            this.Abort_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Abort_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(86)))), ((int)(((byte)(75)))));
            this.Abort_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Abort_Btn.FlatAppearance.BorderSize = 0;
            this.Abort_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(120)))), ((int)(((byte)(111)))));
            this.Abort_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Abort_Btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Abort_Btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Abort_Btn.Location = new System.Drawing.Point(395, 120);
            this.Abort_Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Abort_Btn.Name = "Abort_Btn";
            this.Abort_Btn.Size = new System.Drawing.Size(80, 29);
            this.Abort_Btn.TabIndex = 70;
            this.Abort_Btn.Text = "ABORT";
            this.Abort_Btn.UseVisualStyleBackColor = false;
            this.Abort_Btn.Click += new System.EventHandler(this.Abort_Btn_Click);
            // 
            // Play_Btn
            // 
            this.Play_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Play_Btn.Enabled = false;
            this.Play_Btn.Image = global::ShutdownClock.Properties.Resources.play;
            this.Play_Btn.Location = new System.Drawing.Point(315, 111);
            this.Play_Btn.Name = "Play_Btn";
            this.Play_Btn.Size = new System.Drawing.Size(44, 38);
            this.Play_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Play_Btn.TabIndex = 68;
            this.Play_Btn.TabStop = false;
            this.Play_Btn.Visible = false;
            this.Play_Btn.Click += new System.EventHandler(this.Play_Btn_Click);
            // 
            // Pause_Btn
            // 
            this.Pause_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pause_Btn.Enabled = false;
            this.Pause_Btn.Image = global::ShutdownClock.Properties.Resources.pause;
            this.Pause_Btn.Location = new System.Drawing.Point(315, 111);
            this.Pause_Btn.Name = "Pause_Btn";
            this.Pause_Btn.Size = new System.Drawing.Size(44, 38);
            this.Pause_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pause_Btn.TabIndex = 67;
            this.Pause_Btn.TabStop = false;
            this.Pause_Btn.Visible = false;
            this.Pause_Btn.Click += new System.EventHandler(this.Pause_Btn_Click);
            // 
            // picboxPB
            // 
            this.picboxPB.Location = new System.Drawing.Point(33, 72);
            this.picboxPB.Name = "picboxPB";
            this.picboxPB.Size = new System.Drawing.Size(270, 20);
            this.picboxPB.TabIndex = 72;
            this.picboxPB.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picboxPB);
            this.Controls.Add(this.Abort_Btn);
            this.Controls.Add(this.Play_Btn);
            this.Controls.Add(this.Pause_Btn);
            this.Controls.Add(this.ForceBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Start_Btn);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Secs);
            this.Controls.Add(this.Mins);
            this.Controls.Add(this.Hours);
            this.Controls.Add(this.SNum);
            this.Controls.Add(this.HNum);
            this.Controls.Add(this.MNum);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Size = new System.Drawing.Size(587, 155);
            ((System.ComponentModel.ISupportInitialize)(this.SNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play_Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pause_Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Play_Btn;
        private System.Windows.Forms.PictureBox Pause_Btn;
        private System.Windows.Forms.CheckBox ForceBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Start_Btn;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Secs;
        private System.Windows.Forms.Label Mins;
        private System.Windows.Forms.Label Hours;
        private System.Windows.Forms.NumericUpDown SNum;
        private System.Windows.Forms.NumericUpDown HNum;
        private System.Windows.Forms.NumericUpDown MNum;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Abort_Btn;
        private System.Windows.Forms.PictureBox picboxPB;
    }
}
