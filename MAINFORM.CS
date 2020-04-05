using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Timers;
using System.Diagnostics;
using System.IO;
using System.Xml;

namespace ShutdownClock
{
    public partial class MainForm : UserControl
    {
        int h, m, s, AllSeconds, operand;
        string hh, mm, ss;

        //pb = ProgressBar
        double pbUnit;
        int pbWIDTH, pbHEIGHT, pbComplete;

        Bitmap bmp;
        Graphics g;

        Color ShutdownClockColor = Color.FromArgb(237, 86, 75);
        Color ShutdownClockColorLight = Color.FromArgb(245, 162, 155);
        Brush ShutdownClockBrush = new SolidBrush(Color.FromArgb(237, 86, 75));
        public MainForm()
        {
            InitializeComponent();
            comboBox.SelectedIndex = 0;
            ///////////////////////
            this.HNum.Maximum = 24;
            this.MNum.Maximum = 60;
            this.SNum.Maximum = 60;
            ///////////////////////

            //get picboxPB dimension
            pbWIDTH = picboxPB.Width;
            pbHEIGHT = picboxPB.Height;

            //pbComplete - This is equal to work completed in % [min = 0 max = 100]
            pbComplete = 0;

            //create bitmap
            bmp = new Bitmap(pbWIDTH, pbHEIGHT);

            //graphics
            g = Graphics.FromImage(bmp);

            //clear graphics
            g.Clear(ShutdownClockColorLight);

            //load bitmap in picturebox picboxPB
            picboxPB.Image = bmp;
        }

        // Collecting .dll Windows files to shutdown etc.
        [DllImport("user32")]
        public static extern bool ExitWindowsEx(uint uFlags, uint dwReason);

        [DllImport("user32")]
        public static extern void LockWorkStation();

        [DllImport("PowrProf.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool SetSuspendState(bool hiberate, bool forceCritical, bool disableWakeEvent);

        private void HNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            AllSeconds = 0;
            pbUnit = 0;
            pbComplete = 0;
            // Mathematical operations
            // Hours to sec, Mins to sec
            h = Convert.ToInt32(HNum.Value);
            m = Convert.ToInt32(MNum.Value);
            s = Convert.ToInt32(SNum.Value);

            AllSeconds = h * 3600 + m * 60 + s;

            // Null Values Exeption
            if (AllSeconds == 0)
            {
                MessageBox.Show("You cannot select a time valued null!", "Error 501", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            pbUnit = pbWIDTH / AllSeconds;
            
            timer1.Start();
            //TopTime.InitializeVar(AllSeconds, h, m, s);
            //Form fo = new TopTime();
            //fo.ShowDialog();

            Pause_Btn.Visible = true;
        }

        private void Abort_Btn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            operand = (pbComplete * Convert.ToInt32(pbUnit));

            //clear graphics
            g.Clear(ShutdownClockColorLight);

            //draw progressbar
            g.FillRectangle(ShutdownClockBrush, new Rectangle(0, 0, (int)(operand), pbHEIGHT));

            //load bitmap in picturebox picboxPB
            picboxPB.Image = bmp;

            //STOP and PLAY (time)
            Pause_Btn.Enabled = true;
            Play_Btn.Enabled = true;

            int ProgressValue = pbComplete;

            //IF STATEMENTS for timer1 -- secs, mins, hours (visible clock)
            s = s - 1;
            ProgressValue = ProgressValue + 1;
            pbComplete = ProgressValue;

            AllSeconds = AllSeconds - 1;

            if (s == -1)
            {
                m = m - 1;
                s = 59;
            }

            if (m == -1)
            {
                h = h - 1;
                m = 59;
            }

            if (h == 0 && m == 0 && s == 0)
            {
                
                timer1.Stop();
                pbComplete = 0;

                // Force options
                // Force code imposes closing opened applications automatically without a manual permission
                if (comboBox.Text == "Shutdown" && ForceBox.Checked == false)
                {
                    Process.Start("shutdown", "/s /t 0");
                }
                else if (comboBox.Text == "Shutdown" && ForceBox.Checked == true)
                {
                    Process.Start("shutdown", "/f /s /t 0");
                }
                else if (comboBox.Text == "Reboot" && ForceBox.Checked == false)
                {
                    Process.Start("shutdown", "/r /t 0");
                }
                else if (comboBox.Text == "Reboot" && ForceBox.Checked == true)
                {
                    Process.Start("shutdown", "/f /r /t 0");
                }
                // Other options
                else if (comboBox.Text == "Log off")
                {
                    ExitWindowsEx(0, 0);
                }
                else if (comboBox.Text == "Lock")
                {
                    LockWorkStation();
                }
                else if (comboBox.Text == "Hibernate")
                {
                    SetSuspendState(true, true, true);
                }
                else if (comboBox.Text == "Sleep")
                {
                    SetSuspendState(false, false, false);
                }
            }

            if(h < 10)
            {
                hh = "0" + Convert.ToString(h);
            }
            else
            {
                hh = Convert.ToString(h);
            }

            if(m < 10)
            {
                mm = "0" + Convert.ToString(m);
            }
            else
            {
                mm = Convert.ToString(m);
            }

            if(s < 10)
            {
                ss = "0" + Convert.ToString(s);
            }
            else
            {
                ss = Convert.ToString(s);
            }

            Hours.Text = hh;
            Mins.Text = mm;
            Secs.Text = ss;
        }

        private void Pause_Btn_Click(object sender, EventArgs e)
        {

            timer1.Stop();
            //TopTime.pause = true;
            Pause_Btn.Visible = false;
            Play_Btn.Visible = true;
        }

        private void lambda_logo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://lambda.c0.pl/");
        }

        private void Play_Btn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            //TopTime.play = true;
            Play_Btn.Visible = false;
            Pause_Btn.Visible = true;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Force References

            if (comboBox.Text == "Log off")
            {
                ForceBox.Enabled = false;
            }
            else if (comboBox.Text == "Lock")
            {
                ForceBox.Enabled = false;
            }
            else if (comboBox.Text == "Hibernate")
            {
                ForceBox.Enabled = false;
            }
            else if (comboBox.Text == "Sleep")
            {
                ForceBox.Enabled = false;
            }
            else if (comboBox.Text == "Shutdown")
            {
                ForceBox.Enabled = true;
            }
            else if (comboBox.Text == "Reboot")
            {
                ForceBox.Enabled = true;
            }
            else if (comboBox.Text == "")
            {
                if (comboBox.Items.Count > 0)
                {
                    comboBox.SelectedIndex = 0;
                }
                else
                    comboBox.Text = "Shutdown";
            }
        }
    
    }
}
