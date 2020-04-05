namespace ShutdownClock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TitleBar_Panel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Version_label = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Exit_Btn = new System.Windows.Forms.PictureBox();
            this.Minimize_Btn = new System.Windows.Forms.PictureBox();
            this.Content_Panel = new System.Windows.Forms.Panel();
            this.mainForm1 = new ShutdownClock.MainForm();
            this.TitleBar_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_Btn)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBar_Panel
            // 
            this.TitleBar_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleBar_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(86)))), ((int)(((byte)(75)))));
            this.TitleBar_Panel.Controls.Add(this.pictureBox2);
            this.TitleBar_Panel.Controls.Add(this.Version_label);
            this.TitleBar_Panel.Controls.Add(this.pictureBox4);
            this.TitleBar_Panel.Controls.Add(this.label6);
            this.TitleBar_Panel.Controls.Add(this.pictureBox1);
            this.TitleBar_Panel.Controls.Add(this.Exit_Btn);
            this.TitleBar_Panel.Controls.Add(this.Minimize_Btn);
            this.TitleBar_Panel.Location = new System.Drawing.Point(0, 0);
            this.TitleBar_Panel.Name = "TitleBar_Panel";
            this.TitleBar_Panel.Size = new System.Drawing.Size(610, 52);
            this.TitleBar_Panel.TabIndex = 34;
            this.TitleBar_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_Panel_MouseDown);
            this.TitleBar_Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_Panel_MouseMove);
            this.TitleBar_Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_Panel_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(86)))), ((int)(((byte)(75)))));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::ShutdownClock.Properties.Resources.back;
            this.pictureBox2.Location = new System.Drawing.Point(448, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Version_label
            // 
            this.Version_label.AutoSize = true;
            this.Version_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(86)))), ((int)(((byte)(75)))));
            this.Version_label.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Version_label.ForeColor = System.Drawing.SystemColors.Control;
            this.Version_label.Location = new System.Drawing.Point(268, 25);
            this.Version_label.Name = "Version_label";
            this.Version_label.Size = new System.Drawing.Size(41, 13);
            this.Version_label.TabIndex = 42;
            this.Version_label.Text = "v. 1.3.0";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(86)))), ((int)(((byte)(75)))));
            this.pictureBox4.Image = global::ShutdownClock.Properties.Resources.LOGO_WHITE;
            this.pictureBox4.Location = new System.Drawing.Point(12, 7);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(43, 39);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 41;
            this.pictureBox4.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(86)))), ((int)(((byte)(75)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(61, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 30);
            this.label6.TabIndex = 40;
            this.label6.Text = "SHUTDOWN CLOCK";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(86)))), ((int)(((byte)(75)))));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ShutdownClock.Properties.Resources.ustawienia_w;
            this.pictureBox1.Location = new System.Drawing.Point(487, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Exit_Btn
            // 
            this.Exit_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(86)))), ((int)(((byte)(75)))));
            this.Exit_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_Btn.Image = global::ShutdownClock.Properties.Resources.exit;
            this.Exit_Btn.Location = new System.Drawing.Point(565, 12);
            this.Exit_Btn.Name = "Exit_Btn";
            this.Exit_Btn.Size = new System.Drawing.Size(33, 30);
            this.Exit_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit_Btn.TabIndex = 37;
            this.Exit_Btn.TabStop = false;
            this.Exit_Btn.Click += new System.EventHandler(this.Exit_Btn_Click);
            // 
            // Minimize_Btn
            // 
            this.Minimize_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(86)))), ((int)(((byte)(75)))));
            this.Minimize_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize_Btn.Image = global::ShutdownClock.Properties.Resources.minimize;
            this.Minimize_Btn.Location = new System.Drawing.Point(526, 12);
            this.Minimize_Btn.Name = "Minimize_Btn";
            this.Minimize_Btn.Size = new System.Drawing.Size(33, 30);
            this.Minimize_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimize_Btn.TabIndex = 36;
            this.Minimize_Btn.TabStop = false;
            this.Minimize_Btn.Click += new System.EventHandler(this.Minimize_Btn_Click);
            // 
            // Content_Panel
            // 
            this.Content_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Content_Panel.Location = new System.Drawing.Point(11, 58);
            this.Content_Panel.Name = "Content_Panel";
            this.Content_Panel.Size = new System.Drawing.Size(587, 155);
            this.Content_Panel.TabIndex = 33;
            // 
            // mainForm1
            // 
            this.mainForm1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mainForm1.Location = new System.Drawing.Point(0, 0);
            this.mainForm1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainForm1.Name = "mainForm1";
            this.mainForm1.Size = new System.Drawing.Size(587, 155);
            this.mainForm1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 225);
            this.Controls.Add(this.TitleBar_Panel);
            this.Controls.Add(this.Content_Panel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TitleBar_Panel.ResumeLayout(false);
            this.TitleBar_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_Btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar_Panel;
        private System.Windows.Forms.Panel Content_Panel;
        private System.Windows.Forms.PictureBox Minimize_Btn;
        private MainForm mainForm1;
        private System.Windows.Forms.PictureBox Exit_Btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Version_label;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

