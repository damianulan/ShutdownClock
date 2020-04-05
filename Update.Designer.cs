namespace ShutdownClock
{
    partial class Update
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
            this.Check_Btn = new System.Windows.Forms.Button();
            this.Abort_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Ver = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Descr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Check_Btn
            // 
            this.Check_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Check_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(86)))), ((int)(((byte)(75)))));
            this.Check_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Check_Btn.FlatAppearance.BorderSize = 0;
            this.Check_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(120)))), ((int)(((byte)(111)))));
            this.Check_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Check_Btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Check_Btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Check_Btn.Location = new System.Drawing.Point(500, 124);
            this.Check_Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Check_Btn.Name = "Check_Btn";
            this.Check_Btn.Size = new System.Drawing.Size(84, 29);
            this.Check_Btn.TabIndex = 58;
            this.Check_Btn.Text = "UPDATE";
            this.Check_Btn.UseVisualStyleBackColor = false;
            this.Check_Btn.Click += new System.EventHandler(this.Check_Btn_Click);
            // 
            // Abort_Btn
            // 
            this.Abort_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Abort_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(86)))), ((int)(((byte)(75)))));
            this.Abort_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Abort_Btn.FlatAppearance.BorderSize = 0;
            this.Abort_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(120)))), ((int)(((byte)(111)))));
            this.Abort_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Abort_Btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Abort_Btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Abort_Btn.Location = new System.Drawing.Point(410, 124);
            this.Abort_Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Abort_Btn.Name = "Abort_Btn";
            this.Abort_Btn.Size = new System.Drawing.Size(84, 29);
            this.Abort_Btn.TabIndex = 59;
            this.Abort_Btn.Text = "LATER";
            this.Abort_Btn.UseVisualStyleBackColor = false;
            this.Abort_Btn.Click += new System.EventHandler(this.Abort_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(86)))), ((int)(((byte)(75)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 25);
            this.label1.TabIndex = 61;
            this.label1.Text = "NEW PROGRAM VERSION";
            // 
            // Ver
            // 
            this.Ver.AutoSize = true;
            this.Ver.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Ver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(86)))), ((int)(((byte)(75)))));
            this.Ver.Location = new System.Drawing.Point(237, 0);
            this.Ver.Name = "Ver";
            this.Ver.Size = new System.Drawing.Size(55, 25);
            this.Ver.TabIndex = 62;
            this.Ver.Text = "0.0.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(86)))), ((int)(((byte)(75)))));
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 63;
            this.label2.Text = "WHAT\'S NEW?";
            // 
            // Descr
            // 
            this.Descr.Location = new System.Drawing.Point(15, 48);
            this.Descr.Multiline = true;
            this.Descr.Name = "Descr";
            this.Descr.ReadOnly = true;
            this.Descr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Descr.Size = new System.Drawing.Size(559, 71);
            this.Descr.TabIndex = 64;
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Descr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Abort_Btn);
            this.Controls.Add(this.Check_Btn);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Update";
            this.Size = new System.Drawing.Size(587, 155);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Check_Btn;
        private System.Windows.Forms.Button Abort_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Ver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Descr;
    }
}
