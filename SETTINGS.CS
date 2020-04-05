using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ShutdownClock
{
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();

            Title_label.Text = "SHUTDOWN CLOCK " + Current.Ver_label;

            XmlDocument oDoc = new XmlDocument();
            oDoc.Load(Program.Opacity);
            string Opacity = oDoc.SelectSingleNode("Opacity/Bool").InnerText;
            string AOT = oDoc.SelectSingleNode("Opacity/AOT").InnerText;
            if(Opacity == "On")
            {
                Opacity_Box.SelectedIndex = 1;
            }
            else
            {
                Opacity_Box.SelectedIndex = 0;
            }
            if(AOT == "On")
            {
                AlwaysOnTop_Option.Checked = true;
            }
            else
            {
                AlwaysOnTop_Option.Checked = false;
            }
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            if(Opacity_Box.SelectedIndex == 0 && AlwaysOnTop_Option.Checked == false)
            {
                XmlWriter xml = XmlWriter.Create(Program.Opacity);

                xml.WriteStartDocument();
                xml.WriteStartElement("Opacity");

                xml.WriteStartElement("Bool");
                xml.WriteString("Off");
                xml.WriteEndElement();

                xml.WriteStartElement("AOT");
                xml.WriteString("Off");
                xml.WriteEndElement();

                xml.WriteFullEndElement();
                xml.WriteEndDocument();
                xml.Close();

                Application.Restart();
                MessageBox.Show("Changes done!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(Opacity_Box.SelectedIndex == 1 && AlwaysOnTop_Option.Checked == false)
            {
                XmlWriter xml = XmlWriter.Create(Program.Opacity);

                xml.WriteStartDocument();
                xml.WriteStartElement("Opacity");

                xml.WriteStartElement("Bool");
                xml.WriteString("On");
                xml.WriteEndElement();

                xml.WriteStartElement("AOT");
                xml.WriteString("Off");
                xml.WriteEndElement();

                xml.WriteFullEndElement();
                xml.WriteEndDocument();
                xml.Close();

                Application.Restart();

            }
            else if (Opacity_Box.SelectedIndex == 0 && AlwaysOnTop_Option.Checked == true)
            {
                XmlWriter xml = XmlWriter.Create(Program.Opacity);

                xml.WriteStartDocument();
                xml.WriteStartElement("Opacity");

                xml.WriteStartElement("Bool");
                xml.WriteString("Off");
                xml.WriteEndElement();

                xml.WriteStartElement("AOT");
                xml.WriteString("On");
                xml.WriteEndElement();

                xml.WriteFullEndElement();
                xml.WriteEndDocument();
                xml.Close();

                Application.Restart();

            }
            else if (Opacity_Box.SelectedIndex == 1 && AlwaysOnTop_Option.Checked == true)
            {
                XmlWriter xml = XmlWriter.Create(Program.Opacity);

                xml.WriteStartDocument();
                xml.WriteStartElement("Opacity");

                xml.WriteStartElement("Bool");
                xml.WriteString("On");
                xml.WriteEndElement();

                xml.WriteStartElement("AOT");
                xml.WriteString("On");
                xml.WriteEndElement();

                xml.WriteFullEndElement();
                xml.WriteEndDocument();
                xml.Close();

                Application.Restart();

            }
            else
            {
                MessageBox.Show("Incorrect value of opacity option", "Error 0x0001", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Check_Btn_Click(object sender, EventArgs e)
        {
            DialogResult m1 = MessageBox.Show("Now You're getting to check for a new version of the program. If you find actualisation, remember to close this program in order to install new version properly!", "Information!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (m1 == DialogResult.OK)
            {
                System.Diagnostics.Process.Start("http://lambda.c0.pl/updates/sc/update.php?v=" + Current.Version);
            }
            else if (m1 == DialogResult.Cancel)
            {

            }
        }
    }
}
