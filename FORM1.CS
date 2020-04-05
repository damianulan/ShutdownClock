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
    public partial class Form1 : Form
    {
    //    [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

    //    private static extern IntPtr CreateRoundRectRgn
    //(
    //    int nLeftRect,
    //    int nTopRect,
    //    int nRightRect,
    //    int nBottomRect,
    //    int nWidthEllipse,
    //    int nHeightEllipse
    //);

        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);


        public Form1()
        {
            InitializeComponent();

            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 5, 5));

            Version_label.Text = "v. " + Current.Ver_label;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(Current.Update_available == true)
            {
                Control con = new Update();
                Content_Panel.Controls.Add(con);
            }
            else
            {
                Control con = new MainForm();
                Content_Panel.Controls.Add(con);
            }
        }

        private void TitleBar_Panel_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void TitleBar_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void TitleBar_Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void Minimize_Btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Content_Panel.Controls.Clear();
            Control con = new Settings();
            Content_Panel.Controls.Add(con);
            pictureBox2.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Content_Panel.Controls.Clear();
            Control con = new MainForm();
            Content_Panel.Controls.Add(con);
            pictureBox2.Visible = false;
        }

        public void Reload_Form_Content(object sender, EventArgs e)
        {
            Content_Panel.Controls.Clear();
            Control con = new MainForm();
            Content_Panel.Controls.Add(con);
        }
    }
}
