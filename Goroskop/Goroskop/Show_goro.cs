using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goroskop
{
    public partial class Show_goro : Form
    {
        public Show_goro()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Url = new Uri("https://1001goroskop.ru");
        }

        private void BackMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        

        private void vvod_znaka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (vvod_znaka.SelectedIndex == 0)
            {
                webBrowser1.Url = new
                Uri("https://1001goroskop.ru/?znak=aries");
            }

            if (vvod_znaka.SelectedIndex == 1)
            {
                webBrowser1.Url = new
                Uri("https://1001goroskop.ru/?znak=taurus");
            }

            if (vvod_znaka.SelectedIndex == 2)
            {
                webBrowser1.Url = new
                Uri("https://1001goroskop.ru/?znak=gemini");
            }

            if (vvod_znaka.SelectedIndex == 3)
            {
                webBrowser1.Url = new
                Uri("https://1001goroskop.ru/?znak=cancer");
            }

            if (vvod_znaka.SelectedIndex == 4)
            {
                webBrowser1.Url = new
                Uri("https://1001goroskop.ru/?znak=leo");
            }

            if (vvod_znaka.SelectedIndex == 5)
            {
                webBrowser1.Url = new
                Uri("https://1001goroskop.ru/?znak=virgo");
            }

            if (vvod_znaka.SelectedIndex == 6)
            {
                webBrowser1.Url = new
                Uri("https://1001goroskop.ru/?znak=libra");
            }

            if (vvod_znaka.SelectedIndex == 7)
            {
                webBrowser1.Url = new
                Uri("https://1001goroskop.ru/?znak=scorpio");
            }

            if (vvod_znaka.SelectedIndex == 8)
            {
                webBrowser1.Url = new
                Uri("https://1001goroskop.ru/?znak=sagittarius");
            }

            if (vvod_znaka.SelectedIndex == 9)
            {
                webBrowser1.Url = new
                Uri("https://1001goroskop.ru/?znak=capricorn");
            }

            if (vvod_znaka.SelectedIndex == 10)
            {
                webBrowser1.Url = new
                Uri("https://1001goroskop.ru/?znak=aquarius");
            }

            if (vvod_znaka.SelectedIndex == 11)
            {
                webBrowser1.Url = new
                Uri("https://1001goroskop.ru/?znak=pisces");
            }
        }

        private void авторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Admin = new Admin();
            Admin.Show();
        }
    }
}
