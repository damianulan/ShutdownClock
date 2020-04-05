using System;

using System.Windows.Forms;
using System.IO;
using System.Net;

namespace ShutdownClock
{
    public partial class Update : UserControl
    {
        string address;
        public Update()
        {
            InitializeComponent();



            for(int i = 0; i < 3; i++)
            {
                if(i == 0)
                {
                    WebClient client = new WebClient();
                    Stream stream = client.OpenRead("http://zonesoftwares.com/updates/sc/columns/descr.cse");
                    StreamReader reader = new StreamReader(stream);
                    Descr.Text = reader.ReadToEnd();
                }
                if(i == 1)
                {
                    WebClient client = new WebClient();
                    Stream stream = client.OpenRead("http://zonesoftwares.com/updates/sc/columns/ver.cse");
                    StreamReader reader = new StreamReader(stream);
                    Ver.Text = reader.ReadToEnd();
                }
                if(i == 2)
                {
                    WebClient client = new WebClient();
                    Stream stream = client.OpenRead("http://zonesoftwares.com/updates/sc/columns/address.cse");
                    StreamReader reader = new StreamReader(stream);
                    address = reader.ReadToEnd();
                }
            }
        }

        private void Check_Btn_Click(object sender, EventArgs e)
        {
                System.Diagnostics.Process.Start(address);
                Application.Exit();
        }



        private void Abort_Btn_Click(object sender, EventArgs e)
        {
            ((Form1)this.TopLevelControl).Reload_Form_Content(sender, e);
        }
    }
}
