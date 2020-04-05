using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Security.Permissions;

namespace ShutdownClock
{
    static class Program
    {
        public static string Opacity = (System.IO.Directory.GetCurrentDirectory() + "/data/profiles/opacity.xml");

        public static string DateTime = (Directory.GetCurrentDirectory() + "/data/profiles/DateTime.xml");

        public static string Config = (System.IO.Directory.GetCurrentDirectory() + "/data/profiles/config.xml");
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Current.GrantSourceAccess(Directory.GetCurrentDirectory());
            if (Current.GrantSourceAccess(Directory.GetCurrentDirectory()) == true)
            {
                System.IO.File.WriteAllText(System.IO.Directory.GetCurrentDirectory() + "/ver.txt", "ver: " + Current.Ver_label + " z ");
                Current.Update_Check(Current.Update_nr);

                if (!Directory.Exists(Directory.GetCurrentDirectory() + "/data/profiles/"))
                {
                    Directory.CreateDirectory(Directory.GetCurrentDirectory() + "/data/profiles/");
                    Current.GrantSourceAccess(Directory.GetCurrentDirectory() + "/data/");
                    Current.GrantSourceAccess(Directory.GetCurrentDirectory() + "/data/profiles/");
                    Current.ReadmeCreateFile();
                }

                if (File.Exists(Opacity))
                {
                    try
                    {
                        XmlDocument oDoc = new XmlDocument();
                        oDoc.Load(Program.Opacity);
                        string Opacity = oDoc.SelectSingleNode("Opacity/Bool").InnerText;
                        string AOT = oDoc.SelectSingleNode("Opacity/AOT").InnerText;
                        if (Opacity == "On" && AOT == "Off")
                        {
                            Form st = new Form1();
                            st.Opacity = .80;
                            st.TopMost = false;
                            Application.Run(st);
                        }
                        else if (Opacity == "Off" && AOT == "Off")
                        {
                            Form st = new Form1();
                            st.TopMost = false;
                            Application.Run(st);
                        }
                        else if (Opacity == "On" && AOT == "On")
                        {
                            Form st = new Form1();
                            st.Opacity = .80;
                            st.TopMost = true;
                            Application.Run(st);
                        }
                        else if (Opacity == "Off" && AOT == "On")
                        {
                            Form st = new Form1();
                            st.TopMost = true;
                            Application.Run(st);
                        }
                    }
                    catch (DirectoryNotFoundException ex)
                    {
                        DialogResult dr = MessageBox.Show("Some reason your program haven't appeard. Please contact to the administrator or go on http://lambda.c0.pl/support.", "Cannot run the program - Fatal Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        if (dr == DialogResult.Cancel)
                            Application.Exit();
                        else
                            System.Diagnostics.Process.Start("http://zonesoftware.com");
                    }
                    catch (XmlException ex2)
                    {
                        DialogResult dr = MessageBox.Show("Some reason your program haven't appeard. Please contact to the administrator or go on http://lambda.c0.pl/support.", "Cannot run the program - Fatal Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        if (dr == DialogResult.Cancel)
                            Application.Exit();
                        else
                            System.Diagnostics.Process.Start("http://zonesoftware.com");
                    }
                }
                else
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

                    Application.Run(new Form1());
                }
            }
            else
            {
                MessageBox.Show("Cannot assign security settings, please contact to the administrator/author", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
