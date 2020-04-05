using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutdownClock
{
    public partial class TopTime : Form
    {
        public static bool pause = false;
        public static bool play = false;
        private static int maximum, hour, min, sec;

        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pause == true)
            {
                timer1.Stop();
            }
            if (play == true)
            {
                pause = false;
                play = false;
                timer1.Start();
            }
        }

        private void TopTime_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void TopTime_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void TopTime_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        public TopTime()
        {
            InitializeComponent();
            this.Opacity = .50;
            timer1.Start();
        }

        public static void InitializeVar(int allseconds, int h, int m, int s)
        {
            maximum = allseconds;
            hour = h;
            min = m;
            sec = s;   
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec--;
            if (sec == -1)
            {
                min = min - 1;
                sec = 59;
            }

            if (min == -1)
            {
                hour = hour - 1;
                min = 59;
            }

            if (hour == 0 && min == 0 && sec == 0)
            {
                timer1.Stop();
                this.Close();
            }

            string hh, mm, ss;

            if (hour < 10)
            {
                hh = "0" + Convert.ToString(hour);
            }
            else
            {
                hh = Convert.ToString(hour);
            }

            if (min < 10)
            {
                mm = "0" + Convert.ToString(min);
            }
            else
            {
                mm = Convert.ToString(min);
            }

            if (sec < 10)
            {
                ss = "0" + Convert.ToString(sec);
            }
            else
            {
                ss = Convert.ToString(sec);
            }

            Hours.Text = hh;
            Mins.Text = mm;
            Secs.Text = ss;
        }
    }
}
