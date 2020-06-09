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
    public partial class goroASK : Form
    {
        public goroASK()
        {
            InitializeComponent();
        }

        private void goroASK_Load(object sender, EventArgs e)
        {

        }

        int year1 = 365;
        String goro1 = "";
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void day_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void mounth_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void noves_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void day_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void showZnak_Click(object sender, EventArgs e)
        {
            if((mounth.SelectedIndex == 0) && (Convert.ToInt32(day.Text) <= 31) && (Convert.ToInt32(day.Text) != 0))
            {
                if (Convert.ToInt32(day.Text) <= 20)
                    goro1 = "Козерог";
                else
                    goro1 = "Водолей";
            }

            if ((mounth.SelectedIndex == 0) && (Convert.ToInt32(day.Text) > 31) || (Convert.ToInt32(day.Text) == 0)) 
            {
                thatUrGoro.Text = "Данные введены не корректно";
            }

            if ((mounth.SelectedIndex == 1) && (Convert.ToInt32(day.Text) <= 29) && (Convert.ToInt32(day.Text) != 0))
            {
                if (Convert.ToInt32(day.Text) <= 19)
                    goro1 = "Водолей";
                else
                    goro1 = "Рыбы";
            }

            if ((mounth.SelectedIndex == 1) && (Convert.ToInt32(day.Text) > 29) || (Convert.ToInt32(day.Text) == 0))
            {
                thatUrGoro.Text = "Данные введены не корректно";
            }

            if ((mounth.SelectedIndex == 2) && (Convert.ToInt32(day.Text) <= 31) && (Convert.ToInt32(day.Text) != 0))
            {
                if (Convert.ToInt32(day.Text) <= 20)
                    goro1 = "Рыбы";
                else
                    goro1 = "Овен";
            }

            if ((mounth.SelectedIndex == 2) && (Convert.ToInt32(day.Text) > 31) || (Convert.ToInt32(day.Text) == 0))
            {
                thatUrGoro.Text = "Данные введены не корректно";
            }

            if ((mounth.SelectedIndex == 3) && (Convert.ToInt32(day.Text) <= 30) && (Convert.ToInt32(day.Text) != 0))
            {
                if (Convert.ToInt32(day.Text) <= 20)
                    goro1 = "Овен";
                else
                    goro1 = "Телец";
            }

            if ((mounth.SelectedIndex == 3) && (Convert.ToInt32(day.Text) > 30) || (Convert.ToInt32(day.Text) == 0))
            {
                thatUrGoro.Text = "Данные введены не корректно";
            }

            if ((mounth.SelectedIndex == 4) && (Convert.ToInt32(day.Text) <= 31) && (Convert.ToInt32(day.Text) != 0))
            {
                if (Convert.ToInt32(day.Text) <= 21)
                    goro1 = "Телец";
                else
                    goro1 = "Близнецы";
            }

            if ((mounth.SelectedIndex == 4) && (Convert.ToInt32(day.Text) > 31) || (Convert.ToInt32(day.Text) == 0))
            {
                thatUrGoro.Text = "Данные введены не корректно";
            }


            if ((mounth.SelectedIndex == 5) && (Convert.ToInt32(day.Text) <= 30) && (Convert.ToInt32(day.Text) != 0))
            {
                if (Convert.ToInt32(day.Text) <= 21)
                    goro1 = "Близнецы";
                else
                    goro1 = "Рак";
            }

            if ((mounth.SelectedIndex == 5) && (Convert.ToInt32(day.Text) > 30) || (Convert.ToInt32(day.Text) == 0))
            {
                thatUrGoro.Text = "Данные введены не корректно";
            }

            if ((mounth.SelectedIndex == 6) && (Convert.ToInt32(day.Text) <= 31) && (Convert.ToInt32(day.Text) != 0))
            {
                if (Convert.ToInt32(day.Text) <= 22)
                    goro1 = "Рак";
                else
                    goro1 = "Лев";
            }

            if ((mounth.SelectedIndex == 6) && (Convert.ToInt32(day.Text) > 31) || (Convert.ToInt32(day.Text) == 0))
            {
                thatUrGoro.Text = "Данные введены не корректно";
            }

            if ((mounth.SelectedIndex == 7) && (Convert.ToInt32(day.Text) <= 31) && (Convert.ToInt32(day.Text) != 0))
            {
                if (Convert.ToInt32(day.Text) <= 21)
                    goro1 = "Лев";
                else
                    goro1 = "Дева";
            }

            if ((mounth.SelectedIndex == 7) && (Convert.ToInt32(day.Text) > 31) || (Convert.ToInt32(day.Text) == 0))
            {
                thatUrGoro.Text = "Данные введены не корректно";
            }

            if ((mounth.SelectedIndex == 8) && (Convert.ToInt32(day.Text) <= 30) && (Convert.ToInt32(day.Text) != 0))
            {
                if (Convert.ToInt32(day.Text) <= 23)
                    goro1 = "Дева";
                else
                    goro1 = "Весы";
            }

            if ((mounth.SelectedIndex == 8) && (Convert.ToInt32(day.Text) > 30) || (Convert.ToInt32(day.Text) == 0))
            {
                thatUrGoro.Text = "Данные введены не корректно";
            }

            if ((mounth.SelectedIndex == 9) && (Convert.ToInt32(day.Text) <= 31) && (Convert.ToInt32(day.Text) != 0))
            {
                if (Convert.ToInt32(day.Text) <= 23)
                    goro1 = "Весы";
                else
                    goro1 = "Скорпион";
            }

            if ((mounth.SelectedIndex == 9) && (Convert.ToInt32(day.Text) > 31) || (Convert.ToInt32(day.Text) == 0))
            {
                thatUrGoro.Text = "Данные введены не корректно";
            }

            if ((mounth.SelectedIndex == 10) && (Convert.ToInt32(day.Text) <= 30) && (Convert.ToInt32(day.Text) != 0))
            {
                if (Convert.ToInt32(day.Text) <= 22)
                    goro1 = "Скорпион";
                else
                    goro1 = "Стрелец";
            }

            if ((mounth.SelectedIndex == 10) && (Convert.ToInt32(day.Text) > 30) || (Convert.ToInt32(day.Text) == 0))
            {
                thatUrGoro.Text = "Данные введены не корректно";
            }

            if ((mounth.SelectedIndex == 11) && (Convert.ToInt32(day.Text) <= 31) && (Convert.ToInt32(day.Text) != 0))
            {
                if (Convert.ToInt32(day.Text) <= 22)
                    goro1 = "Стрелец";
                else
                    goro1 = "Козерог";
            }

            if ((mounth.SelectedIndex == 11) && (Convert.ToInt32(day.Text) > 31) || (Convert.ToInt32(day.Text) == 0))
            {
                thatUrGoro.Text = "Данные введены не корректно";
            }

            thatUrGoro.Text = goro1;
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
