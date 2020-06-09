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
    public partial class GoroskopForm : Form
    {
        public GoroskopForm()
        {
            InitializeComponent();
        }

        private void goroASK_Click(object sender, EventArgs e)
        {
            Form goroASK = new goroASK();
            goroASK.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void goro_Click(object sender, EventArgs e)
        {
            Form Show_goro = new Show_goro();
            Show_goro.Show();
        }
    }
}
