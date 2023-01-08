using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-'))
            {
                if (textBox1.Text.Length > 0 && textBox1.Text[0] == '-')
                {
                    e.Handled = true;
                }
                if (textBox1.Text.Length > 0)
                {
                    e.Handled = true;
                }

            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-'))
            {
                if (textBox2.Text.Length > 0 && textBox2.Text[0] == '-')
                {
                    e.Handled = true;
                }
                if (textBox2.Text.Length > 0)
                {
                    e.Handled = true;
                }

            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-'))
            {
                if (textBox3.Text.Length > 0 && textBox3.Text[0] == '-')
                {
                    e.Handled = true;
                }
                if (textBox3.Text.Length > 0)
                {
                    e.Handled = true;
                }

            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-'))
            {
                if (textBox4.Text.Length > 0 && textBox4.Text[0] == '-')
                {
                    e.Handled = true;
                }
                if (textBox4.Text.Length > 0)
                {
                    e.Handled = true;
                }

            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-'))
            {
                if (textBox5.Text.Length > 0 && textBox5.Text[0] == '-')
                {
                    e.Handled = true;
                }
                if (textBox5.Text.Length > 0)
                {
                    e.Handled = true;
                }

            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-'))
            {
                if (textBox6.Text.Length > 0 && textBox6.Text[0] == '-')
                {
                    e.Handled = true;
                }
                if (textBox6.Text.Length > 0)
                {
                    e.Handled = true;
                }

            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-'))
            {
                if (textBox7.Text.Length > 0 && textBox7.Text[0] == '-')
                {
                    e.Handled = true;
                }
                if (textBox7.Text.Length > 0)
                {
                    e.Handled = true;
                }

            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-'))
            {
                if (textBox8.Text.Length > 0 && textBox8.Text[0] == '-')
                {
                    e.Handled = true;
                }
                if (textBox8.Text.Length > 0)
                {
                    e.Handled = true;
                }

            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-'))
            {
                if (textBox9.Text.Length > 0 && textBox9.Text[0] == '-')
                {
                    e.Handled = true;
                }
                if (textBox9.Text.Length > 0)
                {
                    e.Handled = true;
                }

            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-'))
            {
                if (textBox10.Text.Length > 0 && textBox10.Text[0] == '-')
                {
                    e.Handled = true;
                }
                if (textBox10.Text.Length > 0)
                {
                    e.Handled = true;
                }

            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-'))
            {
                if (textBox11.Text.Length > 0 && textBox11.Text[0] == '-')
                {
                    e.Handled = true;
                }
                if (textBox11.Text.Length > 0)
                {
                    e.Handled = true;
                }

            }
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-'))
            {
                if (textBox12.Text.Length > 0 && textBox12.Text[0] == '-')
                {
                    e.Handled = true;
                }
                if (textBox12.Text.Length > 0)
                {
                    e.Handled = true;
                }

            }
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-'))
            {
                if (textBox13.Text.Length > 0 && textBox13.Text[0] == '-')
                {
                    e.Handled = true;
                }
                if (textBox13.Text.Length > 0)
                {
                    e.Handled = true;
                }

            }
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-'))
            {
                if (textBox14.Text.Length > 0 && textBox14.Text[0] == '-')
                {
                    e.Handled = true;
                }
                if (textBox14.Text.Length > 0)
                {
                    e.Handled = true;
                }

            }
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-'))
            {
                if (textBox15.Text.Length > 0 && textBox15.Text[0] == '-')
                {
                    e.Handled = true;
                }
                if (textBox15.Text.Length > 0)
                {
                    e.Handled = true;
                }

            }
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-'))
            {
                if (textBox16.Text.Length > 0 && textBox16.Text[0] == '-')
                {
                    e.Handled = true;
                }
                if (textBox16.Text.Length > 0)
                {
                    e.Handled = true;
                }

            }
        }

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-'))
            {
                if (textBox17.Text.Length > 0 && textBox17.Text[0] == '-')
                {
                    e.Handled = true;
                }
                if (textBox17.Text.Length > 0)
                {
                    e.Handled = true;
                }

            }
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-'))
            {
                if (textBox18.Text.Length > 0 && textBox18.Text[0] == '-')
                {
                    e.Handled = true;
                }
                if (textBox18.Text.Length > 0)
                {
                    e.Handled = true;
                }

            }
        }

        private void textBox19_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-'))
            {
                if (textBox19.Text.Length > 0 && textBox19.Text[0] == '-')
                {
                    e.Handled = true;
                }
                if (textBox19.Text.Length > 0)
                {
                    e.Handled = true;
                }

            }
        }

        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-'))
            {
                if (textBox20.Text.Length > 0 && textBox20.Text[0] == '-')
                {
                    e.Handled = true;
                }
                if (textBox20.Text.Length > 0)
                {
                    e.Handled = true;
                }

            }
        }

        private void textBox21_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-'))
            {
                if (textBox21.Text.Length > 0 && textBox21.Text[0] == '-')
                {
                    e.Handled = true;
                }
                if (textBox21.Text.Length > 0)
                {
                    e.Handled = true;
                }

            }
        }

        private void textBox22_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-'))
            {
                if (textBox22.Text.Length > 0 && textBox22.Text[0] == '-')
                {
                    e.Handled = true;
                }
                if (textBox22.Text.Length > 0)
                {
                    e.Handled = true;
                }

            }
        }

        private void textBox23_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-'))
            {
                if (textBox23.Text.Length > 0 && textBox23.Text[0] == '-')
                {
                    e.Handled = true;
                }
                if (textBox23.Text.Length > 0)
                {
                    e.Handled = true;
                }

            }
        }

        private void textBox24_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-'))
            {
                if (textBox24.Text.Length > 0 && textBox24.Text[0] == '-')
                {
                    e.Handled = true;
                }
                if (textBox24.Text.Length > 0)
                {
                    e.Handled = true;
                }

            }
        }

        private void textBox25_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-'))
            {
                if (textBox25.Text.Length > 0 && textBox25.Text[0] == '-')
                {
                    e.Handled = true;
                }
                if (textBox25.Text.Length > 0)
                {
                    e.Handled = true;
                }

            }
        }

        private void textBox26_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-'))
            {
                if (textBox26.Text.Length > 0 && textBox26.Text[0] == '-')
                {
                    e.Handled = true;
                }
                if (textBox26.Text.Length > 0)
                {
                    e.Handled = true;
                }

            }
        }

        private void textBox27_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-'))
            {
                if (textBox27.Text.Length > 0 && textBox27.Text[0] == '-')
                {
                    e.Handled = true;
                }
                if (textBox27.Text.Length > 0)
                {
                    e.Handled = true;
                }

            }
        }

        private void textBox28_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-'))
            {
                if (textBox28.Text.Length > 0 && textBox28.Text[0] == '-')
                {
                    e.Handled = true;
                }
                if (textBox28.Text.Length > 0)
                {
                    e.Handled = true;
                }

            }
        }

        private void textBox29_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-'))
            {
                if (textBox29.Text.Length > 0 && textBox29.Text[0] == '-')
                {
                    e.Handled = true;
                }
                if (textBox29.Text.Length > 0)
                {
                    e.Handled = true;
                }

            }
        }

        private void textBox30_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-'))
            {
                if (textBox30.Text.Length > 0 && textBox30.Text[0] == '-')
                {
                    e.Handled = true;
                }
                if (textBox30.Text.Length > 0)
                {
                    e.Handled = true;
                }

            }
        }

        private void textBox31_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-'))
            {
                if (textBox31.Text.Length > 0 && textBox31.Text[0] == '-')
                {
                    e.Handled = true;
                }
                if (textBox31.Text.Length > 0)
                {
                    e.Handled = true;
                }

            }
        }

        private void textBox32_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-'))
            {
                if (textBox32.Text.Length > 0 && textBox32.Text[0] == '-')
                {
                    e.Handled = true;
                }
                if (textBox32.Text.Length > 0)
                {
                    e.Handled = true;
                }

            }
        }

        private void textBox33_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-'))
            {
                if (textBox33.Text.Length > 0 && textBox33.Text[0] == '-')
                {
                    e.Handled = true;
                }
                if (textBox33.Text.Length > 0)
                {
                    e.Handled = true;
                }

            }
        }

        private void textBox34_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-'))
            {
                if (textBox34.Text.Length > 0 && textBox34.Text[0] == '-')
                {
                    e.Handled = true;
                }
                if (textBox34.Text.Length > 0)
                {
                    e.Handled = true;
                }

            }
        }

        private void textBox35_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-'))
            {
                if (textBox35.Text.Length > 0 && textBox35.Text[0] == '-')
                {
                    e.Handled = true;
                }
                if (textBox35.Text.Length > 0)
                {
                    e.Handled = true;
                }

            }
        }

        private void textBox36_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-'))
            {
                if (textBox36.Text.Length > 0 && textBox36.Text[0] == '-')
                {
                    e.Handled = true;
                }
                if (textBox36.Text.Length > 0)
                {
                    e.Handled = true;
                }

            }
        }

        private void textBox37_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-'))
            {
                if (textBox37.Text.Length > 0 && textBox37.Text[0] == '-')
                {
                    e.Handled = true;
                }
                if (textBox37.Text.Length > 0)
                {
                    e.Handled = true;
                }

            }
        }

        private void textBox38_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-'))
            {
                if (textBox38.Text.Length > 0 && textBox38.Text[0] == '-')
                {
                    e.Handled = true;
                }
                if (textBox38.Text.Length > 0)
                {
                    e.Handled = true;
                }

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                panel3.Location = new Point(289, 36);
                panel3.Visible = true;
            }
            else
            {
                panel3.Visible = false;
                panel3.Location = new Point(25, 720);
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                panel6.Location = new Point(273, 34);
                panel6.Visible = true;
            }
            else
            {
                panel6.Visible = false;
                panel6.Location = new Point(595, 720);
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                panel4.Location = new Point(280, 33);
                panel4.Visible = true;
            }
            else
            {
                panel4.Visible = false;
                panel4.Location = new Point(1080, 38);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double a11 = 0;
            double a12 = 0;
            double a13 = 0;
            double a21 = 0;
            double a22 = 0;
            double a23 = 0;
            if (string.IsNullOrEmpty(textBox1.Text) || textBox1.Text == "-" || textBox1.Text == "," || textBox1.Text == "-,")
            {
                a11 = 0;
            }
            else
            {
                a11 = double.Parse(textBox1.Text);
            }
            if (string.IsNullOrEmpty(textBox2.Text) || textBox2.Text == "-" || textBox2.Text == "," || textBox2.Text == "-,")
            {
                a12 = 0;
            }
            else
            {
                a12 = double.Parse(textBox2.Text);
            }
            if (string.IsNullOrEmpty(textBox3.Text) || textBox3.Text == "-" || textBox3.Text == "," || textBox3.Text == "-,")
            {
                a13 = 0;
            }
            else
            {
                a13 = double.Parse(textBox3.Text);
            }
            if (string.IsNullOrEmpty(textBox4.Text) || textBox4.Text == "-" || textBox4.Text == "," || textBox4.Text == "-,")
            {
                a21 = 0;
            }
            else
            {
                a21 = double.Parse(textBox4.Text);
            }
            if (string.IsNullOrEmpty(textBox5.Text) || textBox5.Text == "-" || textBox5.Text == "," || textBox5.Text == "-,")
            {
                a22 = 0;
            }
            else
            {
                a22 = double.Parse(textBox5.Text);
            }
            if (string.IsNullOrEmpty(textBox6.Text) || textBox6.Text == "-" || textBox6.Text == "," || textBox6.Text == "-,")
            {
                a23 = 0;
            }
            else
            {
                a23 = double.Parse(textBox6.Text);
            }
            double det = a11 * a22 - a21 * a12;

            if (radioButton1.Checked == true)
            {
                if (det == 0)
                {
                    label1.Text = "Детермінант матриці:" +
                        "\n\nΔ = a₁₁ × a₂₂ - a₂₁ × a₁₂ = " + a11 + " × " + a22 + " - " + a21 + " × " + a12 + " = " + a11 * a22 + " - " + a21 * a12 + " = " + det +
                        "\n\nТак як детермінант матриці дорівнює нулю, то система не має рішень або має безліч рішень" + "\n\n";
                }
                else
                {
                    double M11, M12, M21, M22, A11, A12, A21, A22, x1, x2;
                    M11 = a22;
                    M12 = a21;
                    M21 = a12;
                    M22 = a11;
                    A11 = M11;
                    A12 = M12 * -1;
                    A21 = M21 * -1;
                    A22 = M22;
                    x1 = A11 / det * a13 + A21 / det * a23;
                    x2 = A12 / det * a13 + A22 / det * a23;
                    label1.Text = "Детермінант матриці:" +
                        "\n\nΔ = a₁₁ × a₂₂ - a₂₁ × a₁₂ = " + a11 + " × " + a22 + " - " + a21 + " × " + a12 + " = " + a11 * a22 + " - " + a21 * a12 + " = " + det +
                        "\n\nМінори матриці A:" +
                        "\n\n• У матриці А викреслюємо рядок 1 та стовпець 1:" +
                        "\n\n  M₁₁ = a₂₂ = " + M11 +
                        "\n  A₁₁ = (-1)¹⁺¹M₁₁ = " + A11 +
                        "\n\n• У матриці А викреслюємо рядок 1 та стовпець 2:" +
                        "\n\n  M₁₂ = a₂₁ = " + M12 +
                        "\n  A₁₂ = (-1)¹⁺²M₁₂ = " + A12 +
                        "\n\n• У матриці А викреслюємо рядок 2 та стовпець 1:" +
                        "\n\n  M₂₁ = a₁₂ = " + M21 +
                        "\n  A₂₁ = (-1)²⁺¹M₂₁ = " + A21 +
                        "\n\n• У матриці А викреслюємо рядок 2 та стовпець 2:" +
                        "\n\n  M₂₂ = a₁₁ = " + M22 +
                        "\n  A₂₂ = (-1)²⁺²M₂₂ = " + A22 +
                        "\n\nКорені рівняння:" +
                        "\n\n•  X₁ = A₁₁ ÷ Δ × a₁₃ + A₂₁ ÷ Δ × a₂₃ = " + A11 + " ÷ " + det + " × " + a13 + " + " + A21 + " ÷ " + det + " × " + a23 + " = " + A11 / det * a13 + " + " + A21 / det * a23 + " = " + x1.ToString("F2") +
                        "\n\n•  X₂ = A₁₂ ÷ Δ × a₁₃ + A₂₂ ÷ Δ × a₂₃ = " + A12 + " ÷ " + det + " × " + a13 + " + " + A22 + " ÷ " + det + " × " + a23 + " = " + A12 / det * a13 + " + " + A22 / det * a23 + " = " + x2.ToString("F2") + "\n\n";
                    // ₁₁  ₁₂  ₁₃
                    // ₂₁  ₂₂  ₂₃
                }
            }
            else
            {
                if (det == 0)
                {
                    label1.Text = "Детермінант матриці:" +
                        "\n\nΔ = a₁₁ × a₂₂ - a₂₁ × a₁₂ = " + a11 + " × " + a22 + " - " + a21 + " × " + a12 + " = " + a11 * a22 + " - " + a21 * a12 + " = " + det +
                        "\n\nТак як детермінант матриці дорівнює нулю, то система не має рішень або має безліч рішень" + "\n\n";
                }
                else
                {
                    double det1 = a13 * a22 - a23 * a12;
                    double det2 = a11 * a23 - a21 * a13;
                    double x1 = det1 / det;
                    double x2 = det2 / det;
                    label1.Text = "Детермінант матриці:" +
                        "\n\nΔ = a₁₁ × a₂₂ - a₂₁ × a₁₂ = " + a11 + " × " + a22 + " - " + a21 + " × " + a12 + " = " + a11 * a22 + " - " + a21 * a12 + " = " + det +
                        "\n\nПерший визначник:" +
                        "\n\nΔ₁ = a₁₃ × a₂₂ - a₂₃ × a₁₂ = " + a13 + " × " + a22 + " - " + a23 + " × " + a12 + " = " + a13 * a22 + " - " + a23 * a12 + " = " + det1 + 
                        "\n\nДругий визначник:" +
                        "\n\nΔ₂ = a₁₁ × a₂₃ - a₂₁ × a₁₃ = " + a11 + " × " + a23 + " - " + a21 + " × " + a13 + " = " + a11 * a23 + " - " + a21 * a13 + " = " + det2 +
                        "\n\nКорені рівняння:" +
                        "\n\n•  X₁ = Δ₁ ÷ Δ = " + det1 + " ÷ " + det + " = " + x1.ToString("F2") +
                        "\n\n•  X₂ = Δ₂ ÷ Δ = " + det2 + " ÷ " + det + " = " + x2.ToString("F2") + "\n\n";
                    // ₁₁  ₁₂  ₁₃
                    // ₂₁  ₂₂  ₂₃
                }

            }

            label1.Visible = true;
            button4.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a11, a12, a13, a14, a21, a22, a23, a24, a31, a32, a33, a34, det;

            if (string.IsNullOrEmpty(textBox7.Text) || textBox7.Text == "-" || textBox7.Text == "," || textBox7.Text == "-,")
            {
                a11 = 0;
            }
            else
            {
                a11 = double.Parse(textBox7.Text);
            }
            if (string.IsNullOrEmpty(textBox8.Text) || textBox8.Text == "-" || textBox8.Text == "," || textBox8.Text == "-,")
            {
                a12 = 0;
            }
            else
            {
                a12 = double.Parse(textBox8.Text);
            }
            if (string.IsNullOrEmpty(textBox9.Text) || textBox9.Text == "-" || textBox9.Text == "," || textBox9.Text == "-,")
            {
                a13 = 0;
            }
            else
            {
                a13 = double.Parse(textBox9.Text);
            }
            if (string.IsNullOrEmpty(textBox10.Text) || textBox10.Text == "-" || textBox10.Text == "," || textBox10.Text == "-,")
            {
                a14 = 0;
            }
            else
            {
                a14 = double.Parse(textBox10.Text);
            }
            if (string.IsNullOrEmpty(textBox11.Text) || textBox11.Text == "-" || textBox11.Text == "," || textBox11.Text == "-,")
            {
                a21 = 0;
            }
            else
            {
                a21 = double.Parse(textBox11.Text);
            }
            if (string.IsNullOrEmpty(textBox12.Text) || textBox12.Text == "-" || textBox12.Text == "," || textBox12.Text == "-,")
            {
                a22 = 0;
            }
            else
            {
                a22 = double.Parse(textBox12.Text);
            }
            if (string.IsNullOrEmpty(textBox13.Text) || textBox13.Text == "-" || textBox13.Text == "," || textBox13.Text == "-,")
            {
                a23 = 0;
            }
            else
            {
                a23 = double.Parse(textBox13.Text);
            }
            if (string.IsNullOrEmpty(textBox14.Text) || textBox14.Text == "-" || textBox14.Text == "," || textBox14.Text == "-,")
            {
                a24 = 0;
            }
            else
            {
                a24 = double.Parse(textBox14.Text);
            }
            if (string.IsNullOrEmpty(textBox15.Text) || textBox15.Text == "-" || textBox15.Text == "," || textBox15.Text == "-,")
            {
                a31 = 0;
            }
            else
            {
                a31 = double.Parse(textBox15.Text);
            }
            if (string.IsNullOrEmpty(textBox16.Text) || textBox16.Text == "-" || textBox16.Text == "," || textBox16.Text == "-,")
            {
                a32 = 0;
            }
            else
            {
                a32 = double.Parse(textBox16.Text);
            }
            if (string.IsNullOrEmpty(textBox17.Text) || textBox17.Text == "-" || textBox17.Text == "," || textBox17.Text == "-,")
            {
                a33 = 0;
            }
            else
            {
                a33 = double.Parse(textBox17.Text);
            }
            if (string.IsNullOrEmpty(textBox18.Text) || textBox18.Text == "-" || textBox18.Text == "," || textBox18.Text == "-,")
            {
                a34 = 0;
            }
            else
            {
                a34 = double.Parse(textBox18.Text);
            }
            det = a11 * a22 * a33 + a12 * a23 * a31 + a13 * a21 * a32 - a13 * a22 * a31 - a11 * a23 * a32 - a12 * a21 * a33;
            if (radioButton1.Checked == true)
            {
                if (det == 0)
                {
                    label1.Text = "Детермінант матриці:" +
                        "\n\nΔ = a₁₁ × a₂₂ × a₃₃ + a₁₂ × a₂₃ × a₃₁ + a₁₃ × a₂₁ × a₃₂ - a₁₃ × a₂₂ × a₃₁ - a₁₁ × a₂₃ × a₃₂ - a₁₂ × a₂₁ × a₃₃ = " +
                        a11 + " × " + a22 + " × " + a33 + " + " + a12 + " × " + a23 + " × " + a31 + " + " + a13 + " × " + a21 + " × " + a32 + " - " + a13 + " × " + a22 + " × " + a31 + " - " + a11 + " × " + a23 + " × " + a32 + " - " + a12 + " × " + a21 + " × " + a33 + " = " +
                        a11 * a22 * a33 + " + " +
                        a12 * a23 * a31 + " + " +
                        a13 * a21 * a32 + " - " +
                        a13 * a22 * a31 + " - " +
                        a11 * a23 * a32 + " - " +
                        a12 * a21 * a33 + " = " + det +
                        "\n\nТак як детермінант матриці дорівнює нулю, то система не має рішень або має безліч рішень" + "\n\n";
                }
                else
                {
                    double M11, M12, M13, M21, M22, M23, M31, M32, M33, A11, A12, A13, A21, A22, A23, A31, A32, A33, x1, x2, x3;
                    M11 = a22 * a33 - a32 * a23;
                    A11 = M11;
                    M12 = a21 * a33 - a31 * a23;
                    A12 = M12 * -1;
                    M13 = a21 * a32 - a31 * a22;
                    A13 = M13;
                    M21 = a12 * a33 - a32 * a13;
                    A21 = M21 * -1;
                    M22 = a11 * a33 - a31 * a13;
                    A22 = M22;
                    M23 = a11 * a32 - a31 * a12;
                    A23 = M23 * -1;
                    M31 = a12 * a23 - a22 * a13;
                    A31 = M31;
                    M32 = a11 * a23 - a21 * a13;
                    A32 = M32 * -1;
                    M33 = a11 * a22 - a21 * a12;
                    A33 = M33;
                    x1 = A11 / det * a14 + A21 / det * a24 + A31 / det * a34;
                    x2 = A12 / det * a14 + A22 / det * a24 + A32 / det * a34;
                    x3 = A13 / det * a14 + A23 / det * a24 + A33 / det * a34;

                    label1.Text = "Детермінант матриці:" +
                        "\n\nΔ = a₁₁ × a₂₂ × a₃₃ + a₁₂ × a₂₃ × a₃₁ + a₁₃ × a₂₁ × a₃₂ - a₁₃ × a₂₂ × a₃₁ - a₁₁ × a₂₃ × a₃₂ - a₁₂ × a₂₁ × a₃₃ = " +
                        a11 + " × " + a22 + " × " + a33 + " + " + a12 + " × " + a23 + " × " + a31 + " + " + a13 + " × " + a21 + " × " + a32 + " - " + a13 + " × " + a22 + " × " + a31 + " - " + a11 + " × " + a23 + " × " + a32 + " - " + a12 + " × " + a21 + " × " + a33 + " = " +
                        a11 * a22 * a33 + " + " +
                        a12 * a23 * a31 + " + " +
                        a13 * a21 * a32 + " - " +
                        a13 * a22 * a31 + " - " +
                        a11 * a23 * a32 + " - " +
                        a12 * a21 * a33 + " = " + det +
                        "\n\nМінори матриці A:" +
                        "\n\n• У матриці А викреслюємо рядок 1 та стовпець 1:" +
                        "\n\n  M₁₁ = a₂₂ × a₃₃ - a₃₂ × a₂₃ = " + 
                        a22 + " × " + a33 + " - " + a32 + " × " + a23 + " = " +
                        a22 * a33 + " - " + a32 * a23 + " = " + M11 +
                        "\n  A₁₁ = (-1)¹⁺¹M₁₁ = " + A11 +
                        "\n\n• У матриці А викреслюємо рядок 1 та стовпець 2:" +
                        "\n\n  M₁₂ = a₂₁ × a₃₃ - a₃₁ × a₂₃ = " +
                        a21 + " × " + a33 + " - " + a31 + " × " + a23 + " = " +
                        a21 * a33 + " - " + a31 * a23 + " = " + M12 +
                        "\n  A₁₂ = (-1)¹⁺²M₁₂ = " + A12 +
                        "\n\n• У матриці А викреслюємо рядок 1 та стовпець 3:" +
                        "\n\n  M₁₃ = a₂₁ × a₃₂ - a₃₁ × a₂₂ = " +
                        a21 + " × " + a32 + " - " + a31 + " × " + a22 + " = " +
                        a21 * a32 + " - " + a31 * a22 + " = " + M13 +
                        "\n  A₁₃ = (-1)¹⁺³M₁₃ = " + A13 +
                        "\n\n• У матриці А викреслюємо рядок 2 та стовпець 1:" +
                        "\n\n  M₂₁ = a₁₂ × a₃₃ - a₃₂ × a₁₃ = " +
                        a12 + " × " + a33 + " - " + a32 + " × " + a13 + " = " +
                        a12 * a33 + " - " + a32 * a13 + " = " + M21 +
                        "\n  A₂₁ = (-1)²⁺¹M₂₁ = " + A21 +
                        "\n\n• У матриці А викреслюємо рядок 2 та стовпець 2:" +
                        "\n\n  M₂₂ = a₁₁ × a₃₃ - a₃₁ × a₁₃ = " +
                        a11 + " × " + a33 + " - " + a31 + " × " + a13 + " = " +
                        a11 * a33 + " - " + a31 * a13 + " = " + M22 +
                        "\n  A₂₂ = (-1)²⁺²M₂₂ = " + A22 +
                        "\n\n• У матриці А викреслюємо рядок 2 та стовпець 3:" +
                        "\n\n  M₂₃ = a₁₁ × a₃₂ - a₃₁ × a₁₂ = " +
                        a11 + " × " + a32 + " - " + a31 + " × " + a12 + " = " +
                        a11 * a32 + " - " + a31 * a12 + " = " + M23 +
                        "\n  A₂₃ = (-1)²⁺³M₂₃ = " + A23 +
                        "\n\n• У матриці А викреслюємо рядок 3 та стовпець 1:" +
                        "\n\n  M₃₁ = a₁₂ × a₂₃ - a₂₂ × a₁₃ = " +
                        a12 + " × " + a23 + " - " + a22 + " × " + a13 + " = " +
                        a12 * a23 + " - " + a22 * a13 + " = " + M31 +
                        "\n  A₃₁ = (-1)³⁺¹M₃₁ = " + A31 +
                        "\n\n• У матриці А викреслюємо рядок 3 та стовпець 2:" +
                        "\n\n  M₃₂ = a₁₁ × a₂₃ - a₂₁ × a₁₃ = " +
                        a11 + " × " + a23 + " - " + a21 + " × " + a13 + " = " +
                        a11 * a23 + " - " + a21 * a13 + " = " + M32 +
                        "\n  A₃₂ = (-1)³⁺²M₃₂ = " + A32 +
                        "\n\n• У матриці А викреслюємо рядок 3 та стовпець 3:" +
                        "\n\n  M₃₃ = a₁₁ × a₂₂ - a₂₁ × a₁₂ = " +
                        a11 + " × " + a22 + " - " + a21 + " × " + a12 + " = " +
                        a11 * a22 + " - " + a21 * a12 + " = " + M33 +
                        "\n  A₃₃ = (-1)³⁺³M₃₃ = " + A33 +
                        "\n\nКорені рівняння:" +
                        "\n\n•  X₁ = A₁₁ ÷ Δ ÷ a₁₄ + A₂₁ ÷ Δ × a₂₄ + A₃₁ ÷ Δ × a₃₄ = " +
                        A11 + " ÷ " + det + " × " + a14 + " + " + A21 + " ÷ " + det + " × " + a24 + " + " + A31 + " ÷ " + det + " × " + a34 + " = " +
                        A11 / det * a14 + " + " + A21 / det * a24 + " + " + A31 / det * a34 + " = " + x1.ToString("F2") +
                        "\n\n•  X₂ = A₁₂ ÷ Δ ÷ a₁₄ + A₂₂ ÷ Δ × a₂₄ + A₃₂ ÷ Δ × a₃₄ = " +
                        A12 + " ÷ " + det + " × " + a14 + " + " + A22 + " ÷ " + det + " × " + a24 + " + " + A32 + " ÷ " + det + " × " + a34 + " = " +
                        A12 / det * a14 + " + " + A22 / det * a24 + " + " + A32 / det * a34 + " = " + x2.ToString("F2") +
                        "\n\n•  X₃ = A₁₃ ÷ Δ ÷ a₁₄ + A₂₃ ÷ Δ × a₂₄ + A₃₃ ÷ Δ × a₃₄ = " +
                        A13 + " ÷ " + det + " × " + a14 + " + " + A23 + " ÷ " + det + " × " + a24 + " + " + A33 + " ÷ " + det + " × " + a34 + " = " +
                        A13 / det * a14 + " + " + A23 / det * a24 + " + " + A33 / det * a34 + " = " + x3.ToString("F2") + "\n\n";

                    //  ₁₁  ₁₂  ₁₃  ₁₄  ×
                    //  ₂₁  ₂₂  ₂₃  ₂₄  ÷
                    //  ₃₁  ₃₂  ₃₃  ₃₄  Δ
                }
            }
            else
            {
                if (det == 0)
                {
                    label1.Text = "Детермінант матриці:" +
                        "\n\nΔ = a₁₁ × a₂₂ × a₃₃ + a₁₂ × a₂₃ × a₃₁ + a₁₃ × a₂₁ × a₃₂ - a₁₃ × a₂₂ × a₃₁ - a₁₁ × a₂₃ × a₃₂ - a₁₂ × a₂₁ × a₃₃ = " +
                        a11 + " × " + a22 + " × " + a33 + " + " + a12 + " × " + a23 + " × " + a31 + " + " + a13 + " × " + a21 + " × " + a32 + " - " + a13 + " × " + a22 + " × " + a31 + " - " + a11 + " × " + a23 + " × " + a32 + " - " + a12 + " × " + a21 + " × " + a33 + " = " +
                        a11 * a22 * a33 + " + " +
                        a12 * a23 * a31 + " + " +
                        a13 * a21 * a32 + " - " +
                        a13 * a22 * a31 + " - " +
                        a11 * a23 * a32 + " - " +
                        a12 * a21 * a33 + " = " + det +
                        "\n\nТак як детермінант матриці дорівнює нулю, то система не має рішень або має безліч рішень" + "\n\n";
                }
                else
                {
                    double det1, det2, det3, x1, x2, x3;
                    det1 = a14 * a22 * a33 + a12 * a23 * a34 + a13 * a24 * a32 - a13 * a22 * a34 - a14 * a23 * a32 - a12 * a24 * a33;
                    det2 = a11 * a24 * a33 + a14 * a23 * a31 + a13 * a21 * a34 - a13 * a24 * a31 - a11 * a23 * a34 - a14 * a21 * a33;
                    det3 = a11 * a22 * a34 + a12 * a24 * a31 + a14 * a21 * a32 - a14 * a22 * a31 - a11 * a24 * a32 - a12 * a21 * a34;
                    x1 = det1 / det;
                    x2 = det2 / det;
                    x3 = det3 / det;
                    label1.Text = "Детермінант матриці:" +
                        "\n\nΔ = a₁₁ × a₂₂ × a₃₃ + a₁₂ × a₂₃ × a₃₁ + a₁₃ × a₂₁ × a₃₂ - a₁₃ × a₂₂ × a₃₁ - a₁₁ × a₂₃ × a₃₂ - a₁₂ × a₂₁ × a₃₃ = " +
                        a11 + " × " + a22 + " × " + a33 + " + " + a12 + " × " + a23 + " × " + a31 + " + " + a13 + " × " + a21 + " × " + a32 + " - " + a13 + " × " + a22 + " × " + a31 + " - " + a11 + " × " + a23 + " × " + a32 + " - " + a12 + " × " + a21 + " × " + a33 + " = " +
                        a11 * a22 * a33 + " + " +
                        a12 * a23 * a31 + " + " +
                        a13 * a21 * a32 + " - " +
                        a13 * a22 * a31 + " - " +
                        a11 * a23 * a32 + " - " +
                        a12 * a21 * a33 + " = " + det +
                        "\n\nПерший визначник:\n\nΔ₁ = " +
                        "a₁₄ × a₂₂ × a₃₃ + " +
                        "a₁₂ × a₂₃ × a₃₄ + " +
                        "a₁₃ × a₂₄ × a₃₂ - " +
                        "a₁₃ × a₂₂ × a₃₄ - " +
                        "a₁₄ × a₂₃ × a₃₂ - " +
                        "a₁₂ × a₂₄ × a₃₃ = " +
                        a14 + " × " + a22 + " × " + a33 + " + " + 
                        a12 + " × " + a23 + " × " + a34 + " + " + 
                        a13 + " × " + a24 + " × " + a32 + " - " + 
                        a13 + " × " + a22 + " × " + a34 + " - " + 
                        a14 + " × " + a23 + " × " + a32 + " - " + 
                        a12 + " × " + a24 + " × " + a33 + " = " +
                        a14 * a22 * a33 + " + " +
                        a12 * a23 * a34 + " + " +
                        a13 * a24 * a32 + " - " +
                        a13 * a22 * a34 + " - " +
                        a14 * a23 * a32 + " - " +
                        a12 * a24 * a33 + " = " + det1 +
                        "\n\nДругий визначник:\n\nΔ₂ = " +
                        "a₁₁ × a₂₄ × a₃₃ + " +
                        "a₁₄ × a₂₃ × a₃₁ + " +
                        "a₁₃ × a₂₁ × a₃₄ - " +
                        "a₁₃ × a₂₄ × a₃₁ - " +
                        "a₁₁ × a₂₃ × a₃₄ - " +
                        "a₁₄ × a₂₁ × a₃₃ = " +
                        a11 + " × " + a24 + " × " + a33 + " + " +
                        a14 + " × " + a23 + " × " + a31 + " + " +
                        a13 + " × " + a21 + " × " + a34 + " - " +
                        a13 + " × " + a24 + " × " + a31 + " - " +
                        a11 + " × " + a23 + " × " + a34 + " - " +
                        a14 + " × " + a21 + " × " + a33 + " = " +
                        a11 * a24 * a33 + " + " +
                        a14 * a23 * a31 + " + " +
                        a13 * a21 * a34 + " - " +
                        a13 * a24 * a31 + " - " +
                        a11 * a23 * a34 + " - " +
                        a14 * a21 * a33 + " = " + det2 +
                        "\n\nТретій визначник:\n\nΔ₃ = " +
                        "a₁₁ × a₂₂ × a₃₄ + " +
                        "a₁₂ × a₂₄ × a₃₁ + " +
                        "a₁₄ × a₂₁ × a₃₂ - " +
                        "a₁₄ × a₂₂ × a₃₁ - " +
                        "a₁₁ × a₂₄ × a₃₂ - " +
                        "a₁₂ × a₂₁ × a₃₄ = " +
                        a11 + " × " + a22 + " × " + a34 + " + " +
                        a12 + " × " + a24 + " × " + a31 + " + " +
                        a14 + " × " + a21 + " × " + a32 + " - " +
                        a14 + " × " + a22 + " × " + a31 + " - " +
                        a11 + " × " + a24 + " × " + a32 + " - " +
                        a12 + " × " + a21 + " × " + a34 + " = " +
                        a11 * a22 * a34 + " + " +
                        a12 * a24 * a31 + " + " +
                        a14 * a21 * a32 + " - " +
                        a14 * a22 * a31 + " - " +
                        a11 * a24 * a32 + " - " +
                        a12 * a21 * a34 + " = " + det3 +
                        "\n\nКорені рівняння:" +
                        "\n\n•  X₁ = Δ₁ ÷ Δ = " + det1 + " ÷ " + det + " = " + x1.ToString("F2") +
                        "\n\n•  X₂ = Δ₂ ÷ Δ = " + det2 + " ÷ " + det + " = " + x2.ToString("F2") +
                        "\n\n•  X₃ = Δ₃ ÷ Δ = " + det3 + " ÷ " + det + " = " + x3.ToString("F2") + "\n\n";
                    //  ₁₁  ₁₂  ₁₃  ₁₄  ×
                    //  ₂₁  ₂₂  ₂₃  ₂₄  ÷
                    //  ₃₁  ₃₂  ₃₃  ₃₄  Δ
                }
            }

            label1.Visible = true;
            button4.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a11, a12, a13, a14, a15,
                a21, a22, a23, a24, a25,
                a31, a32, a33, a34, a35,
                a41, a42, a43, a44, a45,
                det, det1, det2, det3, det4,
                x1, x2, x3, x4,
                minor1det, minor2det, minor3det, minor4det,
                minor1det1, minor2det1, minor3det1, minor4det1,
                minor1det2, minor2det2, minor3det2, minor4det2,
                minor1det3, minor2det3, minor3det3, minor4det3,
                minor1det4, minor2det4, minor3det4, minor4det4;

            if (string.IsNullOrEmpty(textBox19.Text) || textBox19.Text == "-" || textBox19.Text == "," || textBox19.Text == "-,")
            {
                a11 = 0;
            }
            else
            {
                a11 = double.Parse(textBox19.Text);
            }
            if (string.IsNullOrEmpty(textBox20.Text) || textBox20.Text == "-" || textBox20.Text == "," || textBox20.Text == "-,")
            {
                a12 = 0;
            }
            else
            {
                a12 = double.Parse(textBox20.Text);
            }
            if (string.IsNullOrEmpty(textBox21.Text) || textBox21.Text == "-" || textBox21.Text == "," || textBox21.Text == "-,")
            {
                a13 = 0;
            }
            else
            {
                a13 = double.Parse(textBox21.Text);
            }
            if (string.IsNullOrEmpty(textBox22.Text) || textBox22.Text == "-" || textBox22.Text == "," || textBox22.Text == "-,")
            {
                a14 = 0;
            }
            else
            {
                a14 = double.Parse(textBox22.Text);
            }
            if (string.IsNullOrEmpty(textBox23.Text) || textBox23.Text == "-" || textBox23.Text == "," || textBox23.Text == "-,")
            {
                a15 = 0;
            }
            else
            {
                a15 = double.Parse(textBox23.Text);
            }
            if (string.IsNullOrEmpty(textBox24.Text) || textBox24.Text == "-" || textBox24.Text == "," || textBox24.Text == "-,")
            {
                a21 = 0;
            }
            else
            {
                a21 = double.Parse(textBox24.Text);
            }
            if (string.IsNullOrEmpty(textBox25.Text) || textBox25.Text == "-" || textBox25.Text == "," || textBox25.Text == "-,")
            {
                a22 = 0;
            }
            else
            {
                a22 = double.Parse(textBox25.Text);
            }
            if (string.IsNullOrEmpty(textBox26.Text) || textBox26.Text == "-" || textBox26.Text == "," || textBox26.Text == "-,")
            {
                a23 = 0;
            }
            else
            {
                a23 = double.Parse(textBox26.Text);
            }
            if (string.IsNullOrEmpty(textBox27.Text) || textBox27.Text == "-" || textBox27.Text == "," || textBox27.Text == "-,")
            {
                a24 = 0;
            }
            else
            {
                a24 = double.Parse(textBox27.Text);
            }
            if (string.IsNullOrEmpty(textBox28.Text) || textBox28.Text == "-" || textBox28.Text == "," || textBox28.Text == "-,")
            {
                a25 = 0;
            }
            else
            {
                a25 = double.Parse(textBox28.Text);
            }
            if (string.IsNullOrEmpty(textBox29.Text) || textBox29.Text == "-" || textBox29.Text == "," || textBox29.Text == "-,")
            {
                a31 = 0;
            }
            else
            {
                a31 = double.Parse(textBox29.Text);
            }
            if (string.IsNullOrEmpty(textBox30.Text) || textBox30.Text == "-" || textBox30.Text == "," || textBox30.Text == "-,")
            {
                a32 = 0;
            }
            else
            {
                a32 = double.Parse(textBox30.Text);
            }
            if (string.IsNullOrEmpty(textBox31.Text) || textBox31.Text == "-" || textBox31.Text == "," || textBox31.Text == "-,")
            {
                a33 = 0;
            }
            else
            {
                a33 = double.Parse(textBox31.Text);
            }
            if (string.IsNullOrEmpty(textBox32.Text) || textBox32.Text == "-" || textBox32.Text == "," || textBox32.Text == "-,")
            {
                a34 = 0;
            }
            else
            {
                a34 = double.Parse(textBox32.Text);
            }
            if (string.IsNullOrEmpty(textBox33.Text) || textBox33.Text == "-" || textBox33.Text == "," || textBox33.Text == "-,")
            {
                a35 = 0;
            }
            else
            {
                a35 = double.Parse(textBox33.Text);
            }
            if (string.IsNullOrEmpty(textBox34.Text) || textBox34.Text == "-" || textBox34.Text == "," || textBox34.Text == "-,")
            {
                a41 = 0;
            }
            else
            {
                a41 = double.Parse(textBox34.Text);
            }
            if (string.IsNullOrEmpty(textBox35.Text) || textBox35.Text == "-" || textBox35.Text == "," || textBox35.Text == "-,")
            {
                a42 = 0;
            }
            else
            {
                a42 = double.Parse(textBox35.Text);
            }
            if (string.IsNullOrEmpty(textBox36.Text) || textBox36.Text == "-" || textBox36.Text == "," || textBox36.Text == "-,")
            {
                a43 = 0;
            }
            else
            {
                a43 = double.Parse(textBox36.Text);
            }
            if (string.IsNullOrEmpty(textBox37.Text) || textBox37.Text == "-" || textBox37.Text == "," || textBox37.Text == "-,")
            {
                a44 = 0;
            }
            else
            {
                a44 = double.Parse(textBox37.Text);
            }
            if (string.IsNullOrEmpty(textBox38.Text) || textBox38.Text == "-" || textBox38.Text == "," || textBox38.Text == "-,")
            {
                a45 = 0;
            }
            else
            {
                a45 = double.Parse(textBox38.Text);
            }

            minor1det = a22 * a33 * a44 + a23 * a34 * a42 + a32 * a43 * a24 - a24 * a33 * a42 - a22 * a34 * a43 - a44 * a32 * a23;
            minor2det = a21 * a33 * a44 + a23 * a34 * a41 + a31 * a43 * a24 - a24 * a33 * a41 - a21 * a34 * a43 - a23 * a31 * a44;
            minor3det = a21 * a32 * a44 + a22 * a34 * a41 + a31 * a42 * a24 - a24 * a32 * a41 - a21 * a34 * a42 - a22 * a31 * a44;
            minor4det = a21 * a32 * a43 + a22 * a33 * a41 + a31 * a42 * a23 - a23 * a32 * a41 - a21 * a33 * a42 - a22 * a31 * a43;
            det = a11 * minor1det - a12 * minor2det + a13 * minor3det - a14 * minor4det;

            if (radioButton1.Checked == true)
            {
                if (det == 0)
                {
                    label1.Text = "Детермінант матриці:" +
                        "\n\nΔ = a₁₁ × M₁₁ - a₁₂ × M₁₂ + a₁₃ × M₁₃ - a₁₄ × M₁₄" +
                        "\n\nЗнайдемо мінори:" +
                        "\n\n• У матриці А викреслюємо рядок 1 та стовпець 1:" +
                        "\n\n  M₁₁ = " +
                        "a₂₂ × a₃₃ × a₄₄ + " +
                        "a₂₃ × a₃₄ × a₄₂ + " +
                        "a₃₂ × a₄₃ × a₂₄ - " +
                        "a₂₄ × a₃₃ × a₄₂ - " +
                        "a₂₂ × a₃₄ × a₄₃ - " +
                        "a₄₄ × a₃₂ × a₂₃ = " +
                        a22 + " × " + a33 + " × " + a44 + " + " +
                        a23 + " × " + a34 + " × " + a42 + " + " +
                        a32 + " × " + a43 + " × " + a24 + " - " +
                        a24 + " × " + a33 + " × " + a42 + " - " +
                        a22 + " × " + a34 + " × " + a43 + " - " +
                        a44 + " × " + a32 + " × " + a23 + " = " +
                        a22 * a33 * a44 + " + " + 
                        a23 * a34 * a42 + " + " +
                        a32 * a43 * a24 + " - " +
                        a24 * a33 * a42 + " - " +
                        a22 * a34 * a43 + " - " +
                        a44 * a32 * a23 + " = " + minor1det +
                        "\n\n• У матриці А викреслюємо рядок 1 та стовпець 2:" +
                        "\n\n  M₁₂ = " +
                        "a₂₁ × a₃₃ × a₄₄ + " +
                        "a₂₃ × a₃₄ × a₄₁ + " +
                        "a₃₁ × a₄₃ × a₂₄ - " +
                        "a₂₄ × a₃₃ × a₄₁ - " +
                        "a₂₁ × a₃₄ × a₄₃ - " +
                        "a₂₃ × a₃₁ × a₄₄ = " +
                        a21 + " × " + a33 + " × " + a44 + " + " +
                        a23 + " × " + a34 + " × " + a41 + " + " +
                        a31 + " × " + a43 + " × " + a24 + " - " +
                        a24 + " × " + a33 + " × " + a41 + " - " +
                        a21 + " × " + a34 + " × " + a43 + " - " +
                        a23 + " × " + a31 + " × " + a44 + " = " +
                        a21 * a33 * a44 + " + " +
                        a23 * a34 * a41 + " + " +
                        a31 * a43 * a24 + " - " +
                        a24 * a33 * a41 + " - " +
                        a21 * a34 * a43 + " - " +
                        a23 * a31 * a44 + " = " + minor2det +
                        "\n\n• У матриці А викреслюємо рядок 1 та стовпець 3:" +
                        "\n\n  M₁₃ = " +
                        "a₂₁ × a₃₂ × a₄₄ + " +
                        "a₂₂ × a₃₄ × a₄₁ + " +
                        "a₃₁ × a₄₂ × a₂₄ - " +
                        "a₂₄ × a₃₂ × a₄₁ - " +
                        "a₂₁ × a₃₄ × a₄₂ - " +
                        "a₂₂ × a₃₁ × a₄₄ = " +
                        a21 + " × " + a32 + " × " + a44 + " + " +
                        a22 + " × " + a34 + " × " + a41 + " + " +
                        a31 + " × " + a42 + " × " + a24 + " - " +
                        a24 + " × " + a32 + " × " + a41 + " - " +
                        a21 + " × " + a34 + " × " + a42 + " - " +
                        a22 + " × " + a31 + " × " + a44 + " = " +
                        a21 * a32 * a44 + " + " +
                        a22 * a34 * a41 + " + " +
                        a31 * a42 * a24 + " - " +
                        a24 * a32 * a41 + " - " +
                        a21 * a34 * a42 + " - " +
                        a22 * a31 * a44 + " = " + minor3det +
                        "\n\n• У матриці А викреслюємо рядок 1 та стовпець 4:" +
                        "\n\n  M₁₄ = " +
                        "a₂₁ × a₃₂ × a₄₃ + " +
                        "a₂₂ × a₃₃ × a₄₁ + " +
                        "a₃₁ × a₄₂ × a₂₃ - " +
                        "a₂₃ × a₃₂ × a₄₁ - " +
                        "a₂₁ × a₃₃ × a₄₂ - " +
                        "a₂₂ × a₃₁ × a₄₃ = " +
                        a21 + " × " + a32 + " × " + a43 + " + " +
                        a22 + " × " + a33 + " × " + a41 + " + " +
                        a31 + " × " + a42 + " × " + a23 + " - " +
                        a23 + " × " + a32 + " × " + a41 + " - " +
                        a21 + " × " + a33 + " × " + a42 + " - " +
                        a22 + " × " + a31 + " × " + a43 + " = " +
                        a21 * a32 * a43 + " + " +
                        a22 * a33 * a41 + " + " +
                        a31 * a42 * a23 + " - " +
                        a23 * a32 * a41 + " - " +
                        a21 * a33 * a42 + " - " +
                        a22 * a31 * a43 + " = " + minor4det +
                        "\n\nПідставимо знайдені мінори у формулу:\n\nΔ = " + 
                        a11 + " × " + minor1det + " - " +
                        a12 + " × " + minor2det + " + " +
                        a13 + " × " + minor3det + " - " +
                        a14 + " × " + minor4det + " = " + det +
                        "\n\nТак як детермінант матриці дорівнює нулю, то система не має рішень або має безліч рішень" + "\n\n";
                }
                else
                {
                    // matricnii sposob esli det ne 0

                    double M11, M12, M13, M14, 
                        M21, M22, M23, M24,
                        M31, M32, M33, M34,
                        M41, M42, M43, M44,
                        A11, A12, A13, A14,
                        A21, A22, A23, A24,
                        A31, A32, A33, A34,
                        A41, A42, A43, A44;

                    M11 = minor1det;
                    M12 = minor2det;
                    M13 = minor3det;
                    M14 = minor4det;
                    M21 = a12 * a33 * a44 + a13 * a34 * a42 + a14 * a32 * a43 - a14 * a33 * a42 - a12 * a34 * a43 - a13 * a32 * a44;
                    M22 = a11 * a33 * a44 + a13 * a34 * a41 + a14 * a31 * a43 - a14 * a33 * a41 - a11 * a34 * a43 - a13 * a31 * a44;
                    M23 = a11 * a32 * a44 + a12 * a34 * a41 + a14 * a31 * a42 - a14 * a32 * a41 - a11 * a34 * a42 - a12 * a31 * a44;
                    M24 = a11 * a32 * a43 + a12 * a33 * a41 + a13 * a31 * a42 - a13 * a32 * a41 - a11 * a33 * a42 - a12 * a31 * a43;
                    M31 = a12 * a23 * a44 + a13 * a24 * a42 + a14 * a22 * a43 - a14 * a23 * a42 - a12 * a24 * a43 - a13 * a22 * a44;
                    M32 = a11 * a23 * a44 + a13 * a24 * a41 + a14 * a21 * a43 - a14 * a23 * a41 - a11 * a24 * a43 - a13 * a21 * a44;
                    M33 = a11 * a22 * a44 + a12 * a24 * a41 + a14 * a21 * a42 - a14 * a22 * a41 - a11 * a24 * a42 - a12 * a21 * a44;
                    M34 = a11 * a22 * a43 + a12 * a23 * a41 + a13 * a21 * a42 - a13 * a22 * a41 - a11 * a23 * a42 - a12 * a21 * a43;
                    M41 = a12 * a23 * a34 + a13 * a24 * a32 + a14 * a22 * a33 - a14 * a23 * a32 - a12 * a24 * a33 - a13 * a22 * a34;
                    M42 = a11 * a23 * a34 + a13 * a24 * a31 + a14 * a21 * a33 - a14 * a23 * a31 - a11 * a24 * a33 - a13 * a21 * a34;
                    M43 = a11 * a22 * a34 + a12 * a24 * a31 + a14 * a21 * a32 - a14 * a22 * a31 - a11 * a24 * a32 - a12 * a21 * a34;
                    M44 = a11 * a22 * a33 + a12 * a23 * a31 + a13 * a21 * a32 - a13 * a22 * a31 - a11 * a23 * a32 - a12 * a21 * a33;

                    A11 = M11;
                    A12 = M12 * -1;
                    A13 = M13;
                    A14 = M14 * -1;
                    A21 = M21 * -1;
                    A22 = M22;
                    A23 = M23 * -1;
                    A24 = M24;
                    A31 = M31;
                    A32 = M32 * -1;
                    A33 = M33;
                    A34 = M34 * -1;
                    A41 = M41 * -1;
                    A42 = M42;
                    A43 = M43 * -1;
                    A44 = M44;

                    x1 = A11 / det * a15 + A21 / det * a25 + A31 / det * a35 + A41 / det * a45;
                    x2 = A12 / det * a15 + A22 / det * a25 + A32 / det * a35 + A42 / det * a45;
                    x3 = A13 / det * a15 + A23 / det * a25 + A33 / det * a35 + A43 / det * a45;
                    x4 = A14 / det * a15 + A24 / det * a25 + A34 / det * a35 + A44 / det * a45;

                    label1.Text = "Детермінант матриці:" +
                        "\n\nΔ = a₁₁ × M₁₁ - a₁₂ × M₁₂ + a₁₃ × M₁₃ - a₁₄ × M₁₄" +
                        "\n\nЗнайдемо мінори:" +
                        "\n\n• У матриці А викреслюємо рядок 1 та стовпець 1:" +
                        "\n\n  M₁₁ = " +
                        "a₂₂ × a₃₃ × a₄₄ + " +
                        "a₂₃ × a₃₄ × a₄₂ + " +
                        "a₃₂ × a₄₃ × a₂₄ - " +
                        "a₂₄ × a₃₃ × a₄₂ - " +
                        "a₂₂ × a₃₄ × a₄₃ - " +
                        "a₄₄ × a₃₂ × a₂₃ = " +
                        a22 + " × " + a33 + " × " + a44 + " + " +
                        a23 + " × " + a34 + " × " + a42 + " + " +
                        a32 + " × " + a43 + " × " + a24 + " - " +
                        a24 + " × " + a33 + " × " + a42 + " - " +
                        a22 + " × " + a34 + " × " + a43 + " - " +
                        a44 + " × " + a32 + " × " + a23 + " = " +
                        a22 * a33 * a44 + " + " +
                        a23 * a34 * a42 + " + " +
                        a32 * a43 * a24 + " - " +
                        a24 * a33 * a42 + " - " +
                        a22 * a34 * a43 + " - " +
                        a44 * a32 * a23 + " = " + minor1det +
                        "\n\n• У матриці А викреслюємо рядок 1 та стовпець 2:" +
                        "\n\n  M₁₂ = " +
                        "a₂₁ × a₃₃ × a₄₄ + " +
                        "a₂₃ × a₃₄ × a₄₁ + " +
                        "a₃₁ × a₄₃ × a₂₄ - " +
                        "a₂₄ × a₃₃ × a₄₁ - " +
                        "a₂₁ × a₃₄ × a₄₃ - " +
                        "a₂₃ × a₃₁ × a₄₄ = " +
                        a21 + " × " + a33 + " × " + a44 + " + " +
                        a23 + " × " + a34 + " × " + a41 + " + " +
                        a31 + " × " + a43 + " × " + a24 + " - " +
                        a24 + " × " + a33 + " × " + a41 + " - " +
                        a21 + " × " + a34 + " × " + a43 + " - " +
                        a23 + " × " + a31 + " × " + a44 + " = " +
                        a21 * a33 * a44 + " + " +
                        a23 * a34 * a41 + " + " +
                        a31 * a43 * a24 + " - " +
                        a24 * a33 * a41 + " - " +
                        a21 * a34 * a43 + " - " +
                        a23 * a31 * a44 + " = " + minor2det +
                        "\n\n• У матриці А викреслюємо рядок 1 та стовпець 3:" +
                        "\n\n  M₁₃ = " +
                        "a₂₁ × a₃₂ × a₄₄ + " +
                        "a₂₂ × a₃₄ × a₄₁ + " +
                        "a₃₁ × a₄₂ × a₂₄ - " +
                        "a₂₄ × a₃₂ × a₄₁ - " +
                        "a₂₁ × a₃₄ × a₄₂ - " +
                        "a₂₂ × a₃₁ × a₄₄ = " +
                        a21 + " × " + a32 + " × " + a44 + " + " +
                        a22 + " × " + a34 + " × " + a41 + " + " +
                        a31 + " × " + a42 + " × " + a24 + " - " +
                        a24 + " × " + a32 + " × " + a41 + " - " +
                        a21 + " × " + a34 + " × " + a42 + " - " +
                        a22 + " × " + a31 + " × " + a44 + " = " +
                        a21 * a32 * a44 + " + " +
                        a22 * a34 * a41 + " + " +
                        a31 * a42 * a24 + " - " +
                        a24 * a32 * a41 + " - " +
                        a21 * a34 * a42 + " - " +
                        a22 * a31 * a44 + " = " + minor3det +
                        "\n\n• У матриці А викреслюємо рядок 1 та стовпець 4:" +
                        "\n\n  M₁₄ = " +
                        "a₂₁ × a₃₂ × a₄₃ + " +
                        "a₂₂ × a₃₃ × a₄₁ + " +
                        "a₃₁ × a₄₂ × a₂₃ - " +
                        "a₂₃ × a₃₂ × a₄₁ - " +
                        "a₂₁ × a₃₃ × a₄₂ - " +
                        "a₂₂ × a₃₁ × a₄₃ = " +
                        a21 + " × " + a32 + " × " + a43 + " + " +
                        a22 + " × " + a33 + " × " + a41 + " + " +
                        a31 + " × " + a42 + " × " + a23 + " - " +
                        a23 + " × " + a32 + " × " + a41 + " - " +
                        a21 + " × " + a33 + " × " + a42 + " - " +
                        a22 + " × " + a31 + " × " + a43 + " = " +
                        a21 * a32 * a43 + " + " +
                        a22 * a33 * a41 + " + " +
                        a31 * a42 * a23 + " - " +
                        a23 * a32 * a41 + " - " +
                        a21 * a33 * a42 + " - " +
                        a22 * a31 * a43 + " = " + minor4det +
                        "\n\nПідставимо знайдені мінори у формулу:\n\nΔ = " +
                        a11 + " × " + minor1det + " - " +
                        a12 + " × " + minor2det + " + " +
                        a13 + " × " + minor3det + " - " +
                        a14 + " × " + minor4det + " = " + det +
                        "\n\nЗнайдемо інші мінори та їх алгебраїчні доповнення:" +
                        "\n\n  A₁₁ = (-1)¹⁺¹M₁₁ = " + A11 +
                        "\n\n  A₁₂ = (-1)¹⁺²M₁₂ = " + A12 +
                        "\n\n  A₁₃ = (-1)¹⁺³M₁₃ = " + A13 +
                        "\n\n  A₁₄ = (-1)¹⁺⁴M₁₄ = " + A14 +
                        "\n\n• У матриці А викреслюємо рядок 2 та стовпець 1:" +
                        "\n\n  M₂₁ = " +
                        "a₁₂ × a₃₃ × a₄₄ + " +
                        "a₁₃ × a₃₄ × a₄₂ + " +
                        "a₁₄ × a₃₂ × a₄₃ - " +
                        "a₁₄ × a₃₃ × a₄₂ - " +
                        "a₁₂ × a₃₄ × a₄₃ - " +
                        "a₁₃ × a₃₂ × a₄₄ = " +
                        a12 + " × " + a33 + " × " + a44 + " + " +
                        a13 + " × " + a34 + " × " + a42 + " + " +
                        a14 + " × " + a32 + " × " + a43 + " - " +
                        a14 + " × " + a33 + " × " + a42 + " - " +
                        a12 + " × " + a34 + " × " + a43 + " - " +
                        a13 + " × " + a32 + " × " + a44 + " = " +
                        a12 * a33 * a44 + " + " +
                        a13 * a34 * a42 + " + " +
                        a14 * a32 * a43 + " - " +
                        a14 * a33 * a42 + " - " +
                        a12 * a34 * a43 + " - " +
                        a13 * a32 * a44 + " = " + M21 +
                        "\n  A₂₁ = (-1)²⁺¹M₂₁ = " + A21 +
                        "\n\n• У матриці А викреслюємо рядок 2 та стовпець 2:" +
                        "\n\n  M₂₂ = " +
                        "a₁₁ × a₃₃ × a₄₄ + " +
                        "a₁₃ × a₃₄ × a₄₁ + " +
                        "a₁₄ × a₃₁ × a₄₃ - " +
                        "a₁₄ × a₃₃ × a₄₁ - " +
                        "a₁₁ × a₃₄ × a₄₃ - " +
                        "a₁₃ × a₃₁ × a₄₄ = " +
                        a11 + " × " + a33 + " × " + a44 + " + " +
                        a13 + " × " + a34 + " × " + a41 + " + " +
                        a14 + " × " + a31 + " × " + a43 + " - " +
                        a14 + " × " + a33 + " × " + a41 + " - " +
                        a11 + " × " + a34 + " × " + a43 + " - " +
                        a13 + " × " + a31 + " × " + a44 + " = " +
                        a11 * a33 * a44 + " + " +
                        a13 * a34 * a41 + " + " +
                        a14 * a31 * a43 + " - " +
                        a14 * a33 * a41 + " - " +
                        a11 * a34 * a43 + " - " +
                        a13 * a31 * a44 + " = " + M22 +
                        "\n  A₂₂ = (-1)²⁺²M₂₂ = " + A22 +
                        "\n\n• У матриці А викреслюємо рядок 2 та стовпець 3:" +
                        "\n\n  M₂₃ = " +
                        "a₁₁ × a₃₂ × a₄₄ + " +
                        "a₁₂ × a₃₄ × a₄₁ + " +
                        "a₁₄ × a₃₁ × a₄₂ - " +
                        "a₁₄ × a₃₂ × a₄₁ - " +
                        "a₁₁ × a₃₄ × a₄₂ - " +
                        "a₁₂ × a₃₁ × a₄₄ = " +
                        a11 + " × " + a32 + " × " + a44 + " + " +
                        a12 + " × " + a34 + " × " + a41 + " + " +
                        a14 + " × " + a31 + " × " + a42 + " - " +
                        a14 + " × " + a32 + " × " + a41 + " - " +
                        a11 + " × " + a34 + " × " + a42 + " - " +
                        a12 + " × " + a31 + " × " + a44 + " = " +
                        a11 * a32 * a44 + " + " +
                        a12 * a34 * a41 + " + " +
                        a14 * a31 * a42 + " - " +
                        a14 * a32 * a41 + " - " +
                        a11 * a34 * a42 + " - " +
                        a12 * a31 * a44 + " = " + M23 +
                        "\n  A₂₃ = (-1)²⁺³M₂₃ = " + A23 +
                        "\n\n• У матриці А викреслюємо рядок 2 та стовпець 4:" +
                        "\n\n  M₂₄ = " +
                        "a₁₁ × a₃₂ × a₄₃ + " +
                        "a₁₂ × a₃₃ × a₄₁ + " +
                        "a₁₃ × a₃₁ × a₄₂ - " +
                        "a₁₃ × a₃₂ × a₄₁ - " +
                        "a₁₁ × a₃₃ × a₄₂ - " +
                        "a₁₂ × a₃₁ × a₄₃ = " +
                        a11 + " × " + a32 + " × " + a43 + " + " +
                        a12 + " × " + a33 + " × " + a41 + " + " +
                        a13 + " × " + a31 + " × " + a42 + " - " +
                        a13 + " × " + a32 + " × " + a41 + " - " +
                        a11 + " × " + a33 + " × " + a42 + " - " +
                        a12 + " × " + a31 + " × " + a43 + " = " +
                        a11 * a32 * a43 + " + " +
                        a12 * a33 * a41 + " + " +
                        a13 * a31 * a42 + " - " +
                        a13 * a32 * a41 + " - " +
                        a11 * a33 * a42 + " - " +
                        a12 * a31 * a43 + " = " + M24 +
                        "\n  A₂₄ = (-1)²⁺⁴M₂₄ = " + A24 +
                        "\n\n• У матриці А викреслюємо рядок 3 та стовпець 1:" +
                        "\n\n  M₃₁ = " +
                        "a₁₂ × a₂₃ × a₄₄ + " +
                        "a₁₃ × a₂₄ × a₄₂ + " +
                        "a₁₄ × a₂₂ × a₄₃ - " +
                        "a₁₄ × a₂₃ × a₄₂ - " +
                        "a₁₂ × a₂₄ × a₄₃ - " +
                        "a₁₃ × a₂₂ × a₄₄ = " +
                        a12 + " × " + a23 + " × " + a44 + " + " +
                        a13 + " × " + a24 + " × " + a42 + " + " +
                        a14 + " × " + a22 + " × " + a43 + " - " +
                        a14 + " × " + a23 + " × " + a42 + " - " +
                        a12 + " × " + a24 + " × " + a43 + " - " +
                        a13 + " × " + a22 + " × " + a44 + " = " +
                        a12 * a23 * a44 + " + " +
                        a13 * a24 * a42 + " + " +
                        a14 * a22 * a43 + " - " +
                        a14 * a23 * a42 + " - " +
                        a12 * a24 * a43 + " - " +
                        a13 * a22 * a44 + " = " + M31 +
                        "\n  A₃₁ = (-1)³⁺¹M₃₁ = " + A31 +
                        "\n\n• У матриці А викреслюємо рядок 3 та стовпець 2:" +
                        "\n\n  M₃₂ = " +
                        "a₁₁ × a₂₃ × a₄₄ + " +
                        "a₁₃ × a₂₄ × a₄₁ + " +
                        "a₁₄ × a₂₁ × a₄₃ - " +
                        "a₁₄ × a₂₃ × a₄₁ - " +
                        "a₁₁ × a₂₄ × a₄₃ - " +
                        "a₁₃ × a₂₁ × a₄₄ = " +
                        a11 + " × " + a23 + " × " + a44 + " + " +
                        a13 + " × " + a24 + " × " + a41 + " + " +
                        a14 + " × " + a21 + " × " + a43 + " - " +
                        a14 + " × " + a23 + " × " + a41 + " - " +
                        a11 + " × " + a24 + " × " + a43 + " - " +
                        a13 + " × " + a21 + " × " + a44 + " = " +
                        a11 * a23 * a44 + " + " +
                        a13 * a24 * a41 + " + " +
                        a14 * a21 * a43 + " - " +
                        a14 * a23 * a41 + " - " +
                        a11 * a24 * a43 + " - " +
                        a13 * a21 * a44 + " = " + M32 +
                        "\n  A₃₂ = (-1)³⁺²M₃₂ = " + A32 +
                        "\n\n• У матриці А викреслюємо рядок 3 та стовпець 3:" +
                        "\n\n  M₃₃ = " +
                        "a₁₁ × a₂₂ × a₄₄ + " +
                        "a₁₂ × a₂₄ × a₄₁ + " +
                        "a₁₄ × a₂₁ × a₄₂ - " +
                        "a₁₄ × a₂₂ × a₄₁ - " +
                        "a₁₁ × a₂₄ × a₄₂ - " +
                        "a₁₂ × a₂₁ × a₄₄ = " +
                        a11 + " × " + a22 + " × " + a44 + " + " +
                        a12 + " × " + a24 + " × " + a41 + " + " +
                        a14 + " × " + a21 + " × " + a42 + " - " +
                        a14 + " × " + a22 + " × " + a41 + " - " +
                        a11 + " × " + a24 + " × " + a42 + " - " +
                        a12 + " × " + a21 + " × " + a44 + " = " +
                        a11 * a22 * a44 + " + " +
                        a12 * a24 * a41 + " + " +
                        a14 * a21 * a42 + " - " +
                        a14 * a22 * a41 + " - " +
                        a11 * a24 * a42 + " - " +
                        a12 * a21 * a44 + " = " + M33 +
                        "\n  A₃₃ = (-1)³⁺³M₃₃ = " + A33 +
                        "\n\n• У матриці А викреслюємо рядок 3 та стовпець 4:" +
                        "\n\n  M₃₄ = " +
                        "a₁₁ × a₂₂ × a₄₃ + " +
                        "a₁₂ × a₂₃ × a₄₁ + " +
                        "a₁₃ × a₂₁ × a₄₂ - " +
                        "a₁₃ × a₂₂ × a₄₁ - " +
                        "a₁₁ × a₂₃ × a₄₂ - " +
                        "a₁₂ × a₂₁ × a₄₃ = " +
                        a11 + " × " + a22 + " × " + a43 + " + " +
                        a12 + " × " + a23 + " × " + a41 + " + " +
                        a13 + " × " + a21 + " × " + a42 + " - " +
                        a13 + " × " + a22 + " × " + a41 + " - " +
                        a11 + " × " + a23 + " × " + a42 + " - " +
                        a12 + " × " + a21 + " × " + a43 + " = " +
                        a11 * a22 * a43 + " + " +
                        a12 * a23 * a41 + " + " +
                        a13 * a21 * a42 + " - " +
                        a13 * a22 * a41 + " - " +
                        a11 * a23 * a42 + " - " +
                        a12 * a21 * a43 + " = " + M34 +
                        "\n  A₃₄ = (-1)³⁺⁴M₃₄ = " + A34 +
                        "\n\n• У матриці А викреслюємо рядок 4 та стовпець 1:" +
                        "\n\n  M₄₁ = " +
                        "a₁₂ × a₂₃ × a₃₄ + " +
                        "a₁₃ × a₂₄ × a₃₂ + " +
                        "a₁₄ × a₂₂ × a₃₃ - " +
                        "a₁₄ × a₂₃ × a₃₂ - " +
                        "a₁₂ × a₂₄ × a₃₃ - " +
                        "a₁₃ × a₂₂ × a₃₄ = " +
                        a12 + " × " + a23 + " × " + a34 + " + " +
                        a13 + " × " + a24 + " × " + a32 + " + " +
                        a14 + " × " + a22 + " × " + a33 + " - " +
                        a14 + " × " + a23 + " × " + a32 + " - " +
                        a12 + " × " + a24 + " × " + a33 + " - " +
                        a13 + " × " + a22 + " × " + a34 + " = " +
                        a12 * a23 * a34 + " + " +
                        a13 * a24 * a32 + " + " +
                        a14 * a22 * a33 + " - " +
                        a14 * a23 * a32 + " - " +
                        a12 * a24 * a33 + " - " +
                        a13 * a22 * a34 + " = " + M41 +
                        "\n  A₄₁ = (-1)⁴⁺¹M₄₁ = " + A41 +
                        "\n\n• У матриці А викреслюємо рядок 4 та стовпець 2:" +
                        "\n\n  M₄₂ = " +
                        "a₁₁ × a₂₃ × a₃₄ + " +
                        "a₁₃ × a₂₄ × a₃₁ + " +
                        "a₁₄ × a₂₁ × a₃₃ - " +
                        "a₁₄ × a₂₃ × a₃₁ - " +
                        "a₁₁ × a₂₄ × a₃₃ - " +
                        "a₁₃ × a₂₁ × a₃₄ = " +
                        a11 + " × " + a23 + " × " + a34 + " + " +
                        a13 + " × " + a24 + " × " + a31 + " + " +
                        a14 + " × " + a21 + " × " + a33 + " - " +
                        a14 + " × " + a23 + " × " + a31 + " - " +
                        a11 + " × " + a24 + " × " + a33 + " - " +
                        a13 + " × " + a21 + " × " + a34 + " = " +
                        a11 * a23 * a34 + " + " +
                        a13 * a24 * a31 + " + " +
                        a14 * a21 * a33 + " - " +
                        a14 * a23 * a31 + " - " +
                        a11 * a24 * a33 + " - " +
                        a13 * a21 * a34 + " = " + M42 +
                        "\n  A₄₂ = (-1)⁴⁺²M₄₂ = " + A42 +
                        "\n\n• У матриці А викреслюємо рядок 4 та стовпець 3:" +
                        "\n\n  M₄₃ = " +
                        "a₁₁ × a₂₂ × a₃₄ + " +
                        "a₁₂ × a₂₄ × a₃₁ + " +
                        "a₁₄ × a₂₁ × a₃₂ - " +
                        "a₁₄ × a₂₂ × a₃₁ - " +
                        "a₁₁ × a₂₄ × a₃₂ - " +
                        "a₁₂ × a₂₁ × a₃₄ = " +
                        a11 + " × " + a22 + " × " + a34 + " + " +
                        a12 + " × " + a24 + " × " + a31 + " + " +
                        a14 + " × " + a21 + " × " + a32 + " - " +
                        a14 + " × " + a22 + " × " + a31 + " - " +
                        a11 + " × " + a24 + " × " + a32 + " - " +
                        a12 + " × " + a21 + " × " + a34 + " = " +
                        a11 * a22 * a34 + " + " +
                        a12 * a24 * a31 + " + " +
                        a14 * a21 * a32 + " - " +
                        a14 * a22 * a31 + " - " +
                        a11 * a24 * a32 + " - " +
                        a12 * a21 * a34 + " = " + M43 +
                        "\n  A₄₃ = (-1)⁴⁺³M₄₃ = " + A43 +
                        "\n\n• У матриці А викреслюємо рядок 4 та стовпець 4:" +
                        "\n\n  M₄₄ = " +
                        "a₁₁ × a₂₂ × a₃₃ + " +
                        "a₁₂ × a₂₃ × a₃₁ + " +
                        "a₁₃ × a₂₁ × a₃₂ - " +
                        "a₁₃ × a₂₂ × a₃₁ - " +
                        "a₁₁ × a₂₃ × a₃₂ - " +
                        "a₁₂ × a₂₁ × a₃₃ = " +
                        a11 + " × " + a22 + " × " + a33 + " + " +
                        a12 + " × " + a23 + " × " + a31 + " + " +
                        a13 + " × " + a21 + " × " + a32 + " - " +
                        a13 + " × " + a22 + " × " + a31 + " - " +
                        a11 + " × " + a23 + " × " + a32 + " - " +
                        a12 + " × " + a21 + " × " + a33 + " = " +
                        a11 * a22 * a33 + " + " +
                        a12 * a23 * a31 + " + " +
                        a13 * a21 * a32 + " - " +
                        a13 * a22 * a31 + " - " +
                        a11 * a23 * a32 + " - " +
                        a12 * a21 * a33 + " = " + M44 +
                        "\n  A₄₄ = (-1)⁴⁺⁴M₄₄ = " + A44 +
                        "\n\nКорені рівняння:" +
                        "\n\n•  X₁ = " +
                        "A₁₁ ÷ Δ × a₁₅ + " +
                        "A₂₁ ÷ Δ × a₂₅ + " +
                        "A₃₁ ÷ Δ × a₃₅ + " +
                        "A₄₁ ÷ Δ × a₄₅ = " +
                        A11 + " ÷ " + det + " × " + a15 + " + " +
                        A21 + " ÷ " + det + " × " + a25 + " + " +
                        A31 + " ÷ " + det + " × " + a35 + " + " +
                        A41 + " ÷ " + det + " × " + a45 + " = " +
                        A11 / det * a15 + " + " +
                        A21 / det * a25 + " + " +
                        A31 / det * a35 + " + " +
                        A41 / det * a45 + " = " + x1.ToString("F2") +
                        "\n\n•  X₂ = " +
                        "A₁₂ ÷ Δ × a₁₅ + " +
                        "A₂₂ ÷ Δ × a₂₅ + " +
                        "A₃₂ ÷ Δ × a₃₅ + " +
                        "A₄₂ ÷ Δ × a₄₅ = " +
                        A12 + " ÷ " + det + " × " + a15 + " + " +
                        A22 + " ÷ " + det + " × " + a25 + " + " +
                        A32 + " ÷ " + det + " × " + a35 + " + " +
                        A42 + " ÷ " + det + " × " + a45 + " = " +
                        A12 / det * a15 + " + " +
                        A22 / det * a25 + " + " +
                        A32 / det * a35 + " + " +
                        A42 / det * a45 + " = " + x2.ToString("F2") +
                        "\n\n•  X₃ = " +
                        "A₁₃ ÷ Δ × a₁₅ + " +
                        "A₂₃ ÷ Δ × a₂₅ + " +
                        "A₃₃ ÷ Δ × a₃₅ + " +
                        "A₄₃ ÷ Δ × a₄₅ = " +
                        A13 + " ÷ " + det + " × " + a15 + " + " +
                        A23 + " ÷ " + det + " × " + a25 + " + " +
                        A33 + " ÷ " + det + " × " + a35 + " + " +
                        A43 + " ÷ " + det + " × " + a45 + " = " +
                        A13 / det * a15 + " + " +
                        A23 / det * a25 + " + " +
                        A33 / det * a35 + " + " +
                        A43 / det * a45 + " = " + x3.ToString("F2") +
                        "\n\n•  X₄ = " +
                        "A₁₄ ÷ Δ × a₁₅ + " +
                        "A₂₄ ÷ Δ × a₂₅ + " +
                        "A₃₄ ÷ Δ × a₃₅ + " +
                        "A₄₄ ÷ Δ × a₄₅ = " +
                        A14 + " ÷ " + det + " × " + a15 + " + " +
                        A24 + " ÷ " + det + " × " + a25 + " + " +
                        A34 + " ÷ " + det + " × " + a35 + " + " +
                        A44 + " ÷ " + det + " × " + a45 + " = " +
                        A14 / det * a15 + " + " +
                        A24 / det * a25 + " + " +
                        A34 / det * a35 + " + " +
                        A44 / det * a45 + " = " + x4.ToString("F2") + "\n\n";

                    //  ₁₁  ₁₂  ₁₃  ₁₄  ₁₅  ×
                    //  ₂₁  ₂₂  ₂₃  ₂₄  ₂₅  ÷
                    //  ₃₁  ₃₂  ₃₃  ₃₄  ₃₅  Δ
                    //  ₄₁  ₄₂  ₄₃  ₄₄  ₄₅  •
                }
            }
            else
            {
                if (det == 0)
                {
                    label1.Text = "Детермінант матриці:" +
                        "\n\nΔ = a₁₁ × M₁₁ - a₁₂ × M₁₂ + a₁₃ × M₁₃ - a₁₄ × M₁₄" +
                        "\n\nЗнайдемо мінори:" +
                        "\n\n• У матриці А викреслюємо рядок 1 та стовпець 1:" +
                        "\n\n  M₁₁ = " +
                        "a₂₂ × a₃₃ × a₄₄ + " +
                        "a₂₃ × a₃₄ × a₄₂ + " +
                        "a₃₂ × a₄₃ × a₂₄ - " +
                        "a₂₄ × a₃₃ × a₄₂ - " +
                        "a₂₂ × a₃₄ × a₄₃ - " +
                        "a₄₄ × a₃₂ × a₂₃ = " +
                        a22 + " × " + a33 + " × " + a44 + " + " +
                        a23 + " × " + a34 + " × " + a42 + " + " +
                        a32 + " × " + a43 + " × " + a24 + " - " +
                        a24 + " × " + a33 + " × " + a42 + " - " +
                        a22 + " × " + a34 + " × " + a43 + " - " +
                        a44 + " × " + a32 + " × " + a23 + " = " +
                        a22 * a33 * a44 + " + " +
                        a23 * a34 * a42 + " + " +
                        a32 * a43 * a24 + " - " +
                        a24 * a33 * a42 + " - " +
                        a22 * a34 * a43 + " - " +
                        a44 * a32 * a23 + " = " + minor1det +
                        "\n\n• У матриці А викреслюємо рядок 1 та стовпець 2:" +
                        "\n\n  M₁₂ = " +
                        "a₂₁ × a₃₃ × a₄₄ + " +
                        "a₂₃ × a₃₄ × a₄₁ + " +
                        "a₃₁ × a₄₃ × a₂₄ - " +
                        "a₂₄ × a₃₃ × a₄₁ - " +
                        "a₂₁ × a₃₄ × a₄₃ - " +
                        "a₂₃ × a₃₁ × a₄₄ = " +
                        a21 + " × " + a33 + " × " + a44 + " + " +
                        a23 + " × " + a34 + " × " + a41 + " + " +
                        a31 + " × " + a43 + " × " + a24 + " - " +
                        a24 + " × " + a33 + " × " + a41 + " - " +
                        a21 + " × " + a34 + " × " + a43 + " - " +
                        a23 + " × " + a31 + " × " + a44 + " = " +
                        a21 * a33 * a44 + " + " +
                        a23 * a34 * a41 + " + " +
                        a31 * a43 * a24 + " - " +
                        a24 * a33 * a41 + " - " +
                        a21 * a34 * a43 + " - " +
                        a23 * a31 * a44 + " = " + minor2det +
                        "\n\n• У матриці А викреслюємо рядок 1 та стовпець 3:" +
                        "\n\n  M₁₃ = " +
                        "a₂₁ × a₃₂ × a₄₄ + " +
                        "a₂₂ × a₃₄ × a₄₁ + " +
                        "a₃₁ × a₄₂ × a₂₄ - " +
                        "a₂₄ × a₃₂ × a₄₁ - " +
                        "a₂₁ × a₃₄ × a₄₂ - " +
                        "a₂₂ × a₃₁ × a₄₄ = " +
                        a21 + " × " + a32 + " × " + a44 + " + " +
                        a22 + " × " + a34 + " × " + a41 + " + " +
                        a31 + " × " + a42 + " × " + a24 + " - " +
                        a24 + " × " + a32 + " × " + a41 + " - " +
                        a21 + " × " + a34 + " × " + a42 + " - " +
                        a22 + " × " + a31 + " × " + a44 + " = " +
                        a21 * a32 * a44 + " + " +
                        a22 * a34 * a41 + " + " +
                        a31 * a42 * a24 + " - " +
                        a24 * a32 * a41 + " - " +
                        a21 * a34 * a42 + " - " +
                        a22 * a31 * a44 + " = " + minor3det +
                        "\n\n• У матриці А викреслюємо рядок 1 та стовпець 4:" +
                        "\n\n  M₁₄ = " +
                        "a₂₁ × a₃₂ × a₄₃ + " +
                        "a₂₂ × a₃₃ × a₄₁ + " +
                        "a₃₁ × a₄₂ × a₂₃ - " +
                        "a₂₃ × a₃₂ × a₄₁ - " +
                        "a₂₁ × a₃₃ × a₄₂ - " +
                        "a₂₂ × a₃₁ × a₄₃ = " +
                        a21 + " × " + a32 + " × " + a43 + " + " +
                        a22 + " × " + a33 + " × " + a41 + " + " +
                        a31 + " × " + a42 + " × " + a23 + " - " +
                        a23 + " × " + a32 + " × " + a41 + " - " +
                        a21 + " × " + a33 + " × " + a42 + " - " +
                        a22 + " × " + a31 + " × " + a43 + " = " +
                        a21 * a32 * a43 + " + " +
                        a22 * a33 * a41 + " + " +
                        a31 * a42 * a23 + " - " +
                        a23 * a32 * a41 + " - " +
                        a21 * a33 * a42 + " - " +
                        a22 * a31 * a43 + " = " + minor4det +
                        "\n\nПідставимо знайдені мінори у формулу:\n\nΔ = " +
                        a11 + " × " + minor1det + " - " +
                        a12 + " × " + minor2det + " + " +
                        a13 + " × " + minor3det + " - " +
                        a14 + " × " + minor4det + " = " + det +
                        "\n\nТак як детермінант матриці дорівнює нулю, то система не має рішень або має безліч рішень" + "\n\n";
                }
                else
                {
                    // kremer sposob esli det ne 0

                    minor1det1 = minor1det;
                    minor2det1 = a25 * a33 * a44 + a23 * a34 * a45 + a24 * a35 * a43 - a24 * a33 * a45 - a25 * a34 * a43 - a23 * a35 * a44;
                    minor3det1 = a25 * a32 * a44 + a22 * a34 * a45 + a24 * a35 * a42 - a24 * a32 * a45 - a25 * a34 * a42 - a22 * a35 * a44;
                    minor4det1 = a25 * a32 * a43 + a22 * a33 * a45 + a23 * a35 * a42 - a23 * a32 * a45 - a22 * a35 * a43 - a25 * a33 * a42;
                    det1 = a15 * minor1det1 - a12 * minor2det1 + a13 * minor3det1 - a14 * minor4det1;

                    minor1det2 = a25 * a33 * a44 + a23 * a34 * a45 + a24 * a35 * a43 - a24 * a33 * a45 - a25 * a34 * a43 - a23 * a35 * a44;
                    minor2det2 = minor2det;
                    minor3det2 = a21 * a35 * a44 + a25 * a34 * a41 + a24 * a31 * a45 - a24 * a35 * a41 - a21 * a34 * a45 - a25 * a31 * a44;
                    minor4det2 = a21 * a35 * a43 + a25 * a33 * a41 + a23 * a31 * a45 - a23 * a35 * a41 - a21 * a33 * a45 - a25 * a31 * a43;
                    det2 = a11 * minor1det2 - a15 * minor2det2 + a13 * minor3det2 - a14 * minor4det2;

                    minor1det3 = a22 * a35 * a44 + a25 * a34 * a42 + a24 * a32 * a45 - a24 * a35 * a42 - a22 * a34 * a45 - a25 * a32 * a44;
                    minor2det3 = a21 * a35 * a44 + a25 * a34 * a41 + a24 * a31 * a45 - a24 * a35 * a41 - a21 * a34 * a45 - a25 * a31 * a44;
                    minor3det3 = minor3det;
                    minor4det3 = a21 * a32 * a45 + a22 * a35 * a41 + a25 * a31 * a42 - a25 * a32 * a41 - a21 * a35 * a42 - a22 * a31 * a45;
                    det3 = a11 * minor1det3 - a12 * minor2det3 + a15 * minor3det3 - a14 * minor4det3;

                    minor1det4 = a22 * a33 * a45 + a23 * a35 * a42 + a25 * a32 * a43 - a25 * a33 * a42 - a22 * a35 * a43 - a23 * a32 * a45;
                    minor2det4 = a21 * a33 * a45 + a23 * a35 * a41 + a25 * a31 * a43 - a25 * a33 * a41 - a21 * a35 * a43 - a23 * a31 * a45;
                    minor3det4 = a21 * a32 * a45 + a22 * a35 * a41 + a25 * a31 * a42 - a25 * a32 * a41 - a21 * a35 * a42 - a22 * a31 * a45;
                    minor4det4 = minor4det;
                    det4 = a11 * minor1det4 - a12 * minor2det4 + a13 * minor3det4 - a15 * minor4det4;

                    x1 = det1 / det;
                    x2 = det2 / det;
                    x3 = det3 / det;
                    x4 = det4 / det;

                    label1.Text = "Детермінант матриці:" +
                        "\n\nΔ = a₁₁ × M₁₁ - a₁₂ × M₁₂ + a₁₃ × M₁₃ - a₁₄ × M₁₄" +
                        "\n\nЗнайдемо мінори:" +
                        "\n\n• У матриці А викреслюємо рядок 1 та стовпець 1:" +
                        "\n\n  M₁₁ = " +
                        "a₂₂ × a₃₃ × a₄₄ + " +
                        "a₂₃ × a₃₄ × a₄₂ + " +
                        "a₃₂ × a₄₃ × a₂₄ - " +
                        "a₂₄ × a₃₃ × a₄₂ - " +
                        "a₂₂ × a₃₄ × a₄₃ - " +
                        "a₄₄ × a₃₂ × a₂₃ = " +
                        a22 + " × " + a33 + " × " + a44 + " + " +
                        a23 + " × " + a34 + " × " + a42 + " + " +
                        a32 + " × " + a43 + " × " + a24 + " - " +
                        a24 + " × " + a33 + " × " + a42 + " - " +
                        a22 + " × " + a34 + " × " + a43 + " - " +
                        a44 + " × " + a32 + " × " + a23 + " = " +
                        a22 * a33 * a44 + " + " +
                        a23 * a34 * a42 + " + " +
                        a32 * a43 * a24 + " - " +
                        a24 * a33 * a42 + " - " +
                        a22 * a34 * a43 + " - " +
                        a44 * a32 * a23 + " = " + minor1det +
                        "\n\n• У матриці А викреслюємо рядок 1 та стовпець 2:" +
                        "\n\n  M₁₂ = " +
                        "a₂₁ × a₃₃ × a₄₄ + " +
                        "a₂₃ × a₃₄ × a₄₁ + " +
                        "a₃₁ × a₄₃ × a₂₄ - " +
                        "a₂₄ × a₃₃ × a₄₁ - " +
                        "a₂₁ × a₃₄ × a₄₃ - " +
                        "a₂₃ × a₃₁ × a₄₄ = " +
                        a21 + " × " + a33 + " × " + a44 + " + " +
                        a23 + " × " + a34 + " × " + a41 + " + " +
                        a31 + " × " + a43 + " × " + a24 + " - " +
                        a24 + " × " + a33 + " × " + a41 + " - " +
                        a21 + " × " + a34 + " × " + a43 + " - " +
                        a23 + " × " + a31 + " × " + a44 + " = " +
                        a21 * a33 * a44 + " + " +
                        a23 * a34 * a41 + " + " +
                        a31 * a43 * a24 + " - " +
                        a24 * a33 * a41 + " - " +
                        a21 * a34 * a43 + " - " +
                        a23 * a31 * a44 + " = " + minor2det +
                        "\n\n• У матриці А викреслюємо рядок 1 та стовпець 3:" +
                        "\n\n  M₁₃ = " +
                        "a₂₁ × a₃₂ × a₄₄ + " +
                        "a₂₂ × a₃₄ × a₄₁ + " +
                        "a₃₁ × a₄₂ × a₂₄ - " +
                        "a₂₄ × a₃₂ × a₄₁ - " +
                        "a₂₁ × a₃₄ × a₄₂ - " +
                        "a₂₂ × a₃₁ × a₄₄ = " +
                        a21 + " × " + a32 + " × " + a44 + " + " +
                        a22 + " × " + a34 + " × " + a41 + " + " +
                        a31 + " × " + a42 + " × " + a24 + " - " +
                        a24 + " × " + a32 + " × " + a41 + " - " +
                        a21 + " × " + a34 + " × " + a42 + " - " +
                        a22 + " × " + a31 + " × " + a44 + " = " +
                        a21 * a32 * a44 + " + " +
                        a22 * a34 * a41 + " + " +
                        a31 * a42 * a24 + " - " +
                        a24 * a32 * a41 + " - " +
                        a21 * a34 * a42 + " - " +
                        a22 * a31 * a44 + " = " + minor3det +
                        "\n\n• У матриці А викреслюємо рядок 1 та стовпець 4:" +
                        "\n\n  M₁₄ = " +
                        "a₂₁ × a₃₂ × a₄₃ + " +
                        "a₂₂ × a₃₃ × a₄₁ + " +
                        "a₃₁ × a₄₂ × a₂₃ - " +
                        "a₂₃ × a₃₂ × a₄₁ - " +
                        "a₂₁ × a₃₃ × a₄₂ - " +
                        "a₂₂ × a₃₁ × a₄₃ = " +
                        a21 + " × " + a32 + " × " + a43 + " + " +
                        a22 + " × " + a33 + " × " + a41 + " + " +
                        a31 + " × " + a42 + " × " + a23 + " - " +
                        a23 + " × " + a32 + " × " + a41 + " - " +
                        a21 + " × " + a33 + " × " + a42 + " - " +
                        a22 + " × " + a31 + " × " + a43 + " = " +
                        a21 * a32 * a43 + " + " +
                        a22 * a33 * a41 + " + " +
                        a31 * a42 * a23 + " - " +
                        a23 * a32 * a41 + " - " +
                        a21 * a33 * a42 + " - " +
                        a22 * a31 * a43 + " = " + minor4det +
                        "\n\nПідставимо знайдені мінори у формулу:\n\nΔ = " +
                        a11 + " × " + minor1det + " - " +
                        a12 + " × " + minor2det + " + " +
                        a13 + " × " + minor3det + " - " +
                        a14 + " × " + minor4det + " = " + det +
                        "\n\n   Перший визначник:" +
                        "\n\nΔ₁ = a₁₅ × M₁₅ - a₁₂ × M₁₂ + a₁₃ × M₁₃ - a₁₄ × M₁₄" +
                        "\n\nЗнайдемо мінори, але поміняємо місцями стовпці 1 та 5:" +
                        "\n\n• M₁₅ та M₁₁ у Δ однакові, бо стовпці 2, 3 та 4 однакові, тому:" +
                        "\n\n  M₁₅ = " + minor1det1 +
                        "\n\n• У матриці А викреслюємо рядок 1 та стовпець 2:" +
                        "\n\n  M₁₂ = " +
                        "a₂₅ × a₃₃ × a₄₄ + " +
                        "a₂₃ × a₃₄ × a₄₅ + " +
                        "a₂₄ × a₃₅ × a₄₃ - " +
                        "a₂₄ × a₃₃ × a₄₅ - " +
                        "a₂₅ × a₃₄ × a₄₃ - " +
                        "a₂₃ × a₃₅ × a₄₄ = " +
                        a25 + " × " + a33 + " × " + a44 + " + " +
                        a23 + " × " + a34 + " × " + a45 + " + " +
                        a24 + " × " + a35 + " × " + a43 + " - " +
                        a24 + " × " + a33 + " × " + a45 + " - " +
                        a25 + " × " + a34 + " × " + a43 + " - " +
                        a23 + " × " + a35 + " × " + a44 + " = " +
                        a25 * a33 * a44 + " + " +
                        a23 * a34 * a45 + " + " +
                        a24 * a35 * a43 + " - " +
                        a24 * a33 * a45 + " - " +
                        a25 * a34 * a43 + " - " +
                        a23 * a35 * a44 + " = " + minor2det1 +
                        "\n\n• У матриці А викреслюємо рядок 1 та стовпець 3:" +
                        "\n\n  M₁₃ = " +
                        "a₂₅ × a₃₂ × a₄₄ + " +
                        "a₂₂ × a₃₄ × a₄₅ + " +
                        "a₂₄ × a₃₅ × a₄₂ - " +
                        "a₂₄ × a₃₂ × a₄₅ - " +
                        "a₂₅ × a₃₄ × a₄₂ - " +
                        "a₂₂ × a₃₅ × a₄₄ = " +
                        a25 + " × " + a32 + " × " + a44 + " + " +
                        a22 + " × " + a34 + " × " + a45 + " + " +
                        a24 + " × " + a35 + " × " + a42 + " - " +
                        a24 + " × " + a32 + " × " + a45 + " - " +
                        a25 + " × " + a34 + " × " + a42 + " - " +
                        a22 + " × " + a35 + " × " + a44 + " = " +
                        a25 * a32 * a44 + " + " +
                        a22 * a34 * a45 + " + " +
                        a24 * a35 * a42 + " - " +
                        a24 * a32 * a45 + " - " +
                        a25 * a34 * a42 + " - " +
                        a22 * a35 * a44 + " = " + minor3det1 +
                        "\n\n• У матриці А викреслюємо рядок 1 та стовпець 4:" +
                        "\n\n  M₁₄ = " +
                        "a₂₅ × a₃₂ × a₄₃ + " +
                        "a₂₂ × a₃₃ × a₄₅ + " +
                        "a₂₃ × a₃₅ × a₄₂ - " +
                        "a₂₃ × a₃₂ × a₄₅ - " +
                        "a₂₂ × a₃₅ × a₄₃ - " +
                        "a₂₅ × a₃₃ × a₄₂ = " +
                        a25 + " × " + a32 + " × " + a43 + " + " +
                        a22 + " × " + a33 + " × " + a45 + " + " +
                        a23 + " × " + a35 + " × " + a42 + " - " +
                        a23 + " × " + a32 + " × " + a45 + " - " +
                        a22 + " × " + a35 + " × " + a43 + " - " +
                        a25 + " × " + a33 + " × " + a42 + " = " +
                        a25 * a32 * a43 + " + " +
                        a22 * a33 * a45 + " + " +
                        a23 * a35 * a42 + " - " +
                        a23 * a32 * a45 + " - " +
                        a22 * a35 * a43 + " - " +
                        a25 * a33 * a42 + " = " + minor4det1 +
                        "\n\nПідставимо знайдені мінори у формулу:\n\nΔ₁ = " +
                        a15 + " × " + minor1det1 + " - " +
                        a12 + " × " + minor2det1 + " + " +
                        a13 + " × " + minor3det1 + " - " +
                        a14 + " × " + minor4det1 + " = " + det1 +
                        "\n\n   Другий визначник:" +
                        "\n\nΔ₂ = a₁₁ × M₁₁ - a₁₅ × M₁₅ + a₁₃ × M₁₃ - a₁₄ × M₁₄" +
                        "\n\nЗнайдемо мінори, але поміняємо місцями стовпці 2 та 5:" +
                        "\n\n• У матриці А викреслюємо рядок 1 та стовпець 1:" +
                        "\n\n  M₁₁ = " +
                        "a₂₅ × a₃₃ × a₄₄ + " +
                        "a₂₃ × a₃₄ × a₄₅ + " +
                        "a₂₄ × a₃₅ × a₄₃ - " +
                        "a₂₄ × a₃₃ × a₄₅ - " +
                        "a₂₅ × a₃₄ × a₄₃ - " +
                        "a₂₃ × a₃₅ × a₄₄ = " +
                        a25 + " × " + a33 + " × " + a44 + " + " +
                        a23 + " × " + a34 + " × " + a45 + " + " +
                        a24 + " × " + a35 + " × " + a43 + " - " +
                        a24 + " × " + a33 + " × " + a45 + " - " +
                        a25 + " × " + a34 + " × " + a43 + " - " +
                        a23 + " × " + a35 + " × " + a44 + " = " +
                        a25 * a33 * a44 + " + " +
                        a23 * a34 * a45 + " + " +
                        a24 * a35 * a43 + " - " +
                        a24 * a33 * a45 + " - " +
                        a25 * a34 * a43 + " - " +
                        a23 * a35 * a44 + " = " + minor1det2 +
                        "\n\n• M₁₅ та M₁₂ у Δ однакові, бо стовпці 1, 3 та 4 однакові, тому:" +
                        "\n\n  M₁₅ = " + minor2det2 +
                        "\n\n• У матриці А викреслюємо рядок 1 та стовпець 3:" +
                        "\n\n  M₁₃ = " +
                        "a₂₁ × a₃₅ × a₄₄ + " +
                        "a₂₅ × a₃₄ × a₄₁ + " +
                        "a₂₄ × a₃₁ × a₄₅ - " +
                        "a₂₄ × a₃₅ × a₄₁ - " +
                        "a₂₁ × a₃₄ × a₄₅ - " +
                        "a₂₅ × a₃₁ × a₄₄ = " +
                        a21 + " × " + a35 + " × " + a44 + " + " +
                        a25 + " × " + a34 + " × " + a41 + " + " +
                        a24 + " × " + a31 + " × " + a45 + " - " +
                        a24 + " × " + a35 + " × " + a41 + " - " +
                        a21 + " × " + a34 + " × " + a45 + " - " +
                        a25 + " × " + a31 + " × " + a44 + " = " +
                        a21 * a35 * a44 + " + " +
                        a25 * a34 * a41 + " + " +
                        a24 * a31 * a45 + " - " +
                        a24 * a35 * a41 + " - " +
                        a21 * a34 * a45 + " - " +
                        a25 * a31 * a44 + " = " + minor3det2 +
                        "\n\n• У матриці А викреслюємо рядок 1 та стовпець 4:" +
                        "\n\n  M₁₄ = " +
                        "a₂₁ × a₃₅ × a₄₃ + " +
                        "a₂₅ × a₃₃ × a₄₁ + " +
                        "a₂₃ × a₃₁ × a₄₅ - " +
                        "a₂₃ × a₃₅ × a₄₁ - " +
                        "a₂₁ × a₃₃ × a₄₅ - " +
                        "a₂₅ × a₃₁ × a₄₃ = " +
                        a21 + " × " + a35 + " × " + a43 + " + " +
                        a25 + " × " + a33 + " × " + a41 + " + " +
                        a23 + " × " + a31 + " × " + a45 + " - " +
                        a23 + " × " + a35 + " × " + a41 + " - " +
                        a21 + " × " + a33 + " × " + a45 + " - " +
                        a25 + " × " + a31 + " × " + a43 + " = " +
                        a21 * a35 * a43 + " + " +
                        a25 * a33 * a41 + " + " +
                        a23 * a31 * a45 + " - " +
                        a23 * a35 * a41 + " - " +
                        a21 * a33 * a45 + " - " +
                        a25 * a31 * a43 + " = " + minor4det2 +
                        "\n\nПідставимо знайдені мінори у формулу:\n\nΔ₂ = " +
                        a11 + " × " + minor1det2 + " - " +
                        a15 + " × " + minor2det2 + " + " +
                        a13 + " × " + minor3det2 + " - " +
                        a14 + " × " + minor4det2 + " = " + det2 +
                        "\n\n   Третій визначник:" +
                        "\n\nΔ₃ = a₁₁ × M₁₁ - a₁₂ × M₁₂ + a₁₅ × M₁₅ - a₁₄ × M₁₄" +
                        "\n\nЗнайдемо мінори, але поміняємо місцями стовпці 3 та 5:" +
                        "\n\n• У матриці А викреслюємо рядок 1 та стовпець 1:" +
                        "\n\n  M₁₁ = " +
                        "a₂₂ × a₃₅ × a₄₄ + " +
                        "a₂₅ × a₃₄ × a₄₂ + " +
                        "a₂₄ × a₃₂ × a₄₅ - " +
                        "a₂₄ × a₃₅ × a₄₂ - " +
                        "a₂₂ × a₃₄ × a₄₅ - " +
                        "a₂₅ × a₃₂ × a₄₄ = " +
                        a22 + " × " + a35 + " × " + a44 + " + " +
                        a25 + " × " + a34 + " × " + a42 + " + " +
                        a24 + " × " + a32 + " × " + a45 + " - " +
                        a24 + " × " + a35 + " × " + a42 + " - " +
                        a22 + " × " + a34 + " × " + a45 + " - " +
                        a25 + " × " + a32 + " × " + a44 + " = " +
                        a22 * a35 * a44 + " + " +
                        a25 * a34 * a42 + " + " +
                        a24 * a32 * a45 + " - " +
                        a24 * a35 * a42 + " - " +
                        a22 * a34 * a45 + " - " +
                        a25 * a32 * a44 + " = " + minor1det3 +
                        "\n\n• У матриці А викреслюємо рядок 1 та стовпець 2:" +
                        "\n\n  M₁₂ = " +
                        "a₂₁ × a₃₅ × a₄₄ + " +
                        "a₂₅ × a₃₄ × a₄₁ + " +
                        "a₂₄ × a₃₁ × a₄₅ - " +
                        "a₂₄ × a₃₅ × a₄₁ - " +
                        "a₂₁ × a₃₄ × a₄₅ - " +
                        "a₂₅ × a₃₁ × a₄₄ = " +
                        a21 + " × " + a35 + " × " + a44 + " + " +
                        a25 + " × " + a34 + " × " + a41 + " + " +
                        a24 + " × " + a31 + " × " + a45 + " - " +
                        a24 + " × " + a35 + " × " + a41 + " - " +
                        a21 + " × " + a34 + " × " + a45 + " - " +
                        a25 + " × " + a31 + " × " + a44 + " = " +
                        a21 * a35 * a44 + " + " +
                        a25 * a34 * a41 + " + " +
                        a24 * a31 * a45 + " - " +
                        a24 * a35 * a41 + " - " +
                        a21 * a34 * a45 + " - " +
                        a25 * a31 * a44 + " = " + minor2det3 +
                        "\n\n• M₁₅ та M₁₃ у Δ однакові, бо стовпці 1, 2 та 4 однакові, тому:" +
                        "\n\n  M₁₅ = " + minor3det3 +
                        "\n\n• У матриці А викреслюємо рядок 1 та стовпець 4:" +
                        "\n\n  M₁₄ = " +
                        "a₂₁ × a₃₂ × a₄₅ + " +
                        "a₂₂ × a₃₅ × a₄₁ + " +
                        "a₂₅ × a₃₁ × a₄₂ - " +
                        "a₂₅ × a₃₂ × a₄₁ - " +
                        "a₂₁ × a₃₅ × a₄₂ - " +
                        "a₂₂ × a₃₁ × a₄₅ = " +
                        a21 + " × " + a32 + " × " + a45 + " + " +
                        a22 + " × " + a35 + " × " + a41 + " + " +
                        a25 + " × " + a31 + " × " + a42 + " - " +
                        a25 + " × " + a32 + " × " + a41 + " - " +
                        a21 + " × " + a35 + " × " + a42 + " - " +
                        a22 + " × " + a31 + " × " + a45 + " = " +
                        a21 * a32 * a45 + " + " +
                        a22 * a35 * a41 + " + " +
                        a25 * a31 * a42 + " - " +
                        a25 * a32 * a41 + " - " +
                        a21 * a35 * a42 + " - " +
                        a22 * a31 * a45 + " = " + minor4det3 +
                        "\n\nПідставимо знайдені мінори у формулу:\n\nΔ₃ = " +
                        a11 + " × " + minor1det3 + " - " +
                        a12 + " × " + minor2det3 + " + " +
                        a15 + " × " + minor3det3 + " - " +
                        a14 + " × " + minor4det3 + " = " + det3 +
                        "\n\n   Четвертий визначник:" +
                        "\n\nΔ₄ = a₁₁ × M₁₁ - a₁₂ × M₁₂ + a₁₃ × M₁₃ - a₁₅ × M₁₅" +
                        "\n\nЗнайдемо мінори, але поміняємо місцями стовпці 4 та 5:" +
                        "\n\n• У матриці А викреслюємо рядок 1 та стовпець 1:" +
                        "\n\n  M₁₁ = " +
                        "a₂₂ × a₃₃ × a₄₅ + " +
                        "a₂₃ × a₃₅ × a₄₂ + " +
                        "a₂₅ × a₃₂ × a₄₃ - " +
                        "a₂₅ × a₃₃ × a₄₂ - " +
                        "a₂₂ × a₃₅ × a₄₃ - " +
                        "a₂₃ × a₃₂ × a₄₅ = " +
                        a22 + " × " + a33 + " × " + a45 + " + " +
                        a23 + " × " + a35 + " × " + a42 + " + " +
                        a25 + " × " + a32 + " × " + a43 + " - " +
                        a25 + " × " + a33 + " × " + a42 + " - " +
                        a22 + " × " + a35 + " × " + a43 + " - " +
                        a23 + " × " + a32 + " × " + a45 + " = " +
                        a22 * a33 * a45 + " + " +
                        a23 * a35 * a42 + " + " +
                        a25 * a32 * a43 + " - " +
                        a25 * a33 * a42 + " - " +
                        a22 * a35 * a43 + " - " +
                        a23 * a32 * a45 + " = " + minor1det4 +
                        "\n\n• У матриці А викреслюємо рядок 1 та стовпець 2:" +
                        "\n\n  M₁₂ = " +
                        "a₂₁ × a₃₃ × a₄₅ + " +
                        "a₂₃ × a₃₅ × a₄₁ + " +
                        "a₂₅ × a₃₁ × a₄₃ - " +
                        "a₂₅ × a₃₃ × a₄₁ - " +
                        "a₂₁ × a₃₅ × a₄₃ - " +
                        "a₂₃ × a₃₁ × a₄₅ = " +
                        a21 + " × " + a33 + " × " + a45 + " + " +
                        a23 + " × " + a35 + " × " + a41 + " + " +
                        a25 + " × " + a31 + " × " + a43 + " - " +
                        a25 + " × " + a33 + " × " + a41 + " - " +
                        a21 + " × " + a35 + " × " + a43 + " - " +
                        a23 + " × " + a31 + " × " + a45 + " = " +
                        a21 * a33 * a45 + " + " +
                        a23 * a35 * a41 + " + " +
                        a25 * a31 * a43 + " - " +
                        a25 * a33 * a41 + " - " +
                        a21 * a35 * a43 + " - " +
                        a23 * a31 * a45 + " = " + minor2det4 +
                        "\n\n• У матриці А викреслюємо рядок 1 та стовпець 3:" +
                        "\n\n  M₁₃ = " +
                        "a₂₁ × a₃₂ × a₄₅ + " +
                        "a₂₂ × a₃₅ × a₄₁ + " +
                        "a₂₅ × a₃₁ × a₄₂ - " +
                        "a₂₅ × a₃₂ × a₄₁ - " +
                        "a₂₁ × a₃₅ × a₄₂ - " +
                        "a₂₂ × a₃₁ × a₄₅ = " +
                        a21 + " × " + a32 + " × " + a45 + " + " +
                        a22 + " × " + a35 + " × " + a41 + " + " +
                        a25 + " × " + a31 + " × " + a42 + " - " +
                        a25 + " × " + a32 + " × " + a41 + " - " +
                        a21 + " × " + a35 + " × " + a42 + " - " +
                        a22 + " × " + a31 + " × " + a45 + " = " +
                        a21 * a32 * a45 + " + " +
                        a22 * a35 * a41 + " + " +
                        a25 * a31 * a42 + " - " +
                        a25 * a32 * a41 + " - " +
                        a21 * a35 * a42 + " - " +
                        a22 * a31 * a45 + " = " + minor3det4 +
                        "\n\n• M₁₅ та M₁₄ у Δ однакові, бо стовпці 1, 2 та 3 однакові, тому:" +
                        "\n\n  M₁₅ = " + minor4det4 +
                        "\n\nПідставимо знайдені мінори у формулу:\n\nΔ₄ = " +
                        a11 + " × " + minor1det4 + " - " +
                        a12 + " × " + minor2det4 + " + " +
                        a13 + " × " + minor3det4 + " - " +
                        a15 + " × " + minor4det4 + " = " + det4 +
                        "\n\nКорені рівняння:" +
                        "\n\n•  X₁ = Δ₁ ÷ Δ = " + det1 + " ÷ " + det + " = " + x1.ToString("F2") +
                        "\n\n•  X₂ = Δ₂ ÷ Δ = " + det2 + " ÷ " + det + " = " + x2.ToString("F2") +
                        "\n\n•  X₃ = Δ₃ ÷ Δ = " + det3 + " ÷ " + det + " = " + x3.ToString("F2") +
                        "\n\n•  X₄ = Δ₄ ÷ Δ = " + det4 + " ÷ " + det + " = " + x4.ToString("F2") + "\n\n";

                    //  ₁₁  ₁₂  ₁₃  ₁₄  ₁₅  ×
                    //  ₂₁  ₂₂  ₂₃  ₂₄  ₂₅  ÷
                    //  ₃₁  ₃₂  ₃₃  ₃₄  ₃₅  Δ
                    //  ₄₁  ₄₂  ₄₃  ₄₄  ₄₅  •
                }

            }

            label1.Visible = true;
            button4.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string path = saveFileDialog1.FileName;
            File.WriteAllText(path, label1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 2)
            {
                if (double.Parse(textBox1.Text) > 10000)
                {
                    textBox1.Text = textBox1.Text.Remove(4);
                }
                if (double.Parse(textBox1.Text) < -10000 && double.Parse(textBox1.Text) < 0)
                {
                    textBox1.Text = textBox1.Text.Remove(5);
                }

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 2)
            {
                if (double.Parse(textBox2.Text) > 10000)
                {
                    textBox2.Text = textBox2.Text.Remove(4);
                }
                if (double.Parse(textBox2.Text) < -10000 && double.Parse(textBox2.Text) < 0)
                {
                    textBox2.Text = textBox2.Text.Remove(5);
                }

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length > 2)
            {
                if (double.Parse(textBox3.Text) > 10000)
                {
                    textBox3.Text = textBox3.Text.Remove(4);
                }
                if (double.Parse(textBox3.Text) < -10000 && double.Parse(textBox3.Text) < 0)
                {
                    textBox3.Text = textBox3.Text.Remove(5);
                }

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text.Length > 2)
            {
                if (double.Parse(textBox4.Text) > 10000)
                {
                    textBox4.Text = textBox4.Text.Remove(4);
                }
                if (double.Parse(textBox4.Text) < -10000 && double.Parse(textBox4.Text) < 0)
                {
                    textBox4.Text = textBox4.Text.Remove(5);
                }

            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text.Length > 2)
            {
                if (double.Parse(textBox5.Text) > 10000)
                {
                    textBox5.Text = textBox5.Text.Remove(4);
                }
                if (double.Parse(textBox5.Text) < -10000 && double.Parse(textBox5.Text) < 0)
                {
                    textBox5.Text = textBox5.Text.Remove(5);
                }

            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text.Length > 2)
            {
                if (double.Parse(textBox6.Text) > 10000)
                {
                    textBox6.Text = textBox6.Text.Remove(4);
                }
                if (double.Parse(textBox6.Text) < -10000 && double.Parse(textBox6.Text) < 0)
                {
                    textBox6.Text = textBox6.Text.Remove(5);
                }

            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text.Length > 2)
            {
                if (double.Parse(textBox7.Text) > 10000)
                {
                    textBox7.Text = textBox7.Text.Remove(4);
                }
                if (double.Parse(textBox7.Text) < -10000 && double.Parse(textBox7.Text) < 0)
                {
                    textBox7.Text = textBox7.Text.Remove(5);
                }

            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text.Length > 2)
            {
                if (double.Parse(textBox8.Text) > 10000)
                {
                    textBox8.Text = textBox8.Text.Remove(4);
                }
                if (double.Parse(textBox8.Text) < -10000 && double.Parse(textBox8.Text) < 0)
                {
                    textBox8.Text = textBox8.Text.Remove(5);
                }

            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text.Length > 2)
            {
                if (double.Parse(textBox9.Text) > 10000)
                {
                    textBox9.Text = textBox9.Text.Remove(4);
                }
                if (double.Parse(textBox9.Text) < -10000 && double.Parse(textBox9.Text) < 0)
                {
                    textBox9.Text = textBox9.Text.Remove(5);
                }

            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text.Length > 2)
            {
                if (double.Parse(textBox10.Text) > 10000)
                {
                    textBox10.Text = textBox10.Text.Remove(4);
                }
                if (double.Parse(textBox10.Text) < -10000 && double.Parse(textBox10.Text) < 0)
                {
                    textBox10.Text = textBox10.Text.Remove(5);
                }

            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (textBox11.Text.Length > 2)
            {
                if (double.Parse(textBox11.Text) > 10000)
                {
                    textBox11.Text = textBox11.Text.Remove(4);
                }
                if (double.Parse(textBox11.Text) < -10000 && double.Parse(textBox11.Text) < 0)
                {
                    textBox11.Text = textBox11.Text.Remove(5);
                }

            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (textBox12.Text.Length > 2)
            {
                if (double.Parse(textBox12.Text) > 10000)
                {
                    textBox12.Text = textBox12.Text.Remove(4);
                }
                if (double.Parse(textBox12.Text) < -10000 && double.Parse(textBox12.Text) < 0)
                {
                    textBox12.Text = textBox12.Text.Remove(5);
                }

            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (textBox13.Text.Length > 2)
            {
                if (double.Parse(textBox13.Text) > 10000)
                {
                    textBox13.Text = textBox13.Text.Remove(4);
                }
                if (double.Parse(textBox13.Text) < -10000 && double.Parse(textBox13.Text) < 0)
                {
                    textBox13.Text = textBox13.Text.Remove(5);
                }

            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            if (textBox14.Text.Length > 2)
            {
                if (double.Parse(textBox14.Text) > 10000)
                {
                    textBox14.Text = textBox14.Text.Remove(4);
                }
                if (double.Parse(textBox14.Text) < -10000 && double.Parse(textBox14.Text) < 0)
                {
                    textBox14.Text = textBox14.Text.Remove(5);
                }

            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            if (textBox15.Text.Length > 2)
            {
                if (double.Parse(textBox15.Text) > 10000)
                {
                    textBox15.Text = textBox15.Text.Remove(4);
                }
                if (double.Parse(textBox15.Text) < -10000 && double.Parse(textBox15.Text) < 0)
                {
                    textBox15.Text = textBox15.Text.Remove(5);
                }

            }
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            if (textBox16.Text.Length > 2)
            {
                if (double.Parse(textBox16.Text) > 10000)
                {
                    textBox16.Text = textBox16.Text.Remove(4);
                }
                if (double.Parse(textBox16.Text) < -10000 && double.Parse(textBox16.Text) < 0)
                {
                    textBox16.Text = textBox16.Text.Remove(5);
                }

            }
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            if (textBox17.Text.Length > 2)
            {
                if (double.Parse(textBox17.Text) > 10000)
                {
                    textBox17.Text = textBox17.Text.Remove(4);
                }
                if (double.Parse(textBox17.Text) < -10000 && double.Parse(textBox17.Text) < 0)
                {
                    textBox17.Text = textBox17.Text.Remove(5);
                }

            }
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            if (textBox18.Text.Length > 2)
            {
                if (double.Parse(textBox18.Text) > 10000)
                {
                    textBox18.Text = textBox18.Text.Remove(4);
                }
                if (double.Parse(textBox18.Text) < -10000 && double.Parse(textBox18.Text) < 0)
                {
                    textBox18.Text = textBox18.Text.Remove(5);
                }

            }
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            if (textBox19.Text.Length > 2)
            {
                if (double.Parse(textBox19.Text) > 10000)
                {
                    textBox19.Text = textBox19.Text.Remove(4);
                }
                if (double.Parse(textBox19.Text) < -10000 && double.Parse(textBox19.Text) < 0)
                {
                    textBox19.Text = textBox19.Text.Remove(5);
                }

            }
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            if (textBox20.Text.Length > 2)
            {
                if (double.Parse(textBox20.Text) > 10000)
                {
                    textBox20.Text = textBox20.Text.Remove(4);
                }
                if (double.Parse(textBox20.Text) < -10000 && double.Parse(textBox20.Text) < 0)
                {
                    textBox20.Text = textBox20.Text.Remove(5);
                }

            }
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            if (textBox21.Text.Length > 2)
            {
                if (double.Parse(textBox21.Text) > 10000)
                {
                    textBox21.Text = textBox21.Text.Remove(4);
                }
                if (double.Parse(textBox21.Text) < -10000 && double.Parse(textBox21.Text) < 0)
                {
                    textBox21.Text = textBox21.Text.Remove(5);
                }

            }
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            if (textBox22.Text.Length > 2)
            {
                if (double.Parse(textBox22.Text) > 10000)
                {
                    textBox22.Text = textBox22.Text.Remove(4);
                }
                if (double.Parse(textBox22.Text) < -10000 && double.Parse(textBox22.Text) < 0)
                {
                    textBox22.Text = textBox22.Text.Remove(5);
                }

            }
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            if (textBox23.Text.Length > 2)
            {
                if (double.Parse(textBox23.Text) > 10000)
                {
                    textBox23.Text = textBox23.Text.Remove(4);
                }
                if (double.Parse(textBox23.Text) < -10000 && double.Parse(textBox23.Text) < 0)
                {
                    textBox23.Text = textBox23.Text.Remove(5);
                }

            }
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            if (textBox24.Text.Length > 2)
            {
                if (double.Parse(textBox24.Text) > 10000)
                {
                    textBox24.Text = textBox24.Text.Remove(4);
                }
                if (double.Parse(textBox24.Text) < -10000 && double.Parse(textBox24.Text) < 0)
                {
                    textBox24.Text = textBox24.Text.Remove(5);
                }

            }
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            if (textBox25.Text.Length > 2)
            {
                if (double.Parse(textBox25.Text) > 10000)
                {
                    textBox25.Text = textBox25.Text.Remove(4);
                }
                if (double.Parse(textBox25.Text) < -10000 && double.Parse(textBox25.Text) < 0)
                {
                    textBox25.Text = textBox25.Text.Remove(5);
                }

            }
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            if (textBox26.Text.Length > 2)
            {
                if (double.Parse(textBox26.Text) > 10000)
                {
                    textBox26.Text = textBox26.Text.Remove(4);
                }
                if (double.Parse(textBox26.Text) < -10000 && double.Parse(textBox26.Text) < 0)
                {
                    textBox26.Text = textBox26.Text.Remove(5);
                }

            }
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            if (textBox27.Text.Length > 2)
            {
                if (double.Parse(textBox27.Text) > 10000)
                {
                    textBox27.Text = textBox27.Text.Remove(4);
                }
                if (double.Parse(textBox27.Text) < -10000 && double.Parse(textBox27.Text) < 0)
                {
                    textBox27.Text = textBox27.Text.Remove(5);
                }

            }
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            if (textBox28.Text.Length > 2)
            {
                if (double.Parse(textBox28.Text) > 10000)
                {
                    textBox28.Text = textBox28.Text.Remove(4);
                }
                if (double.Parse(textBox28.Text) < -10000 && double.Parse(textBox28.Text) < 0)
                {
                    textBox28.Text = textBox28.Text.Remove(5);
                }

            }
        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {
            if (textBox29.Text.Length > 2)
            {
                if (double.Parse(textBox29.Text) > 10000)
                {
                    textBox29.Text = textBox29.Text.Remove(4);
                }
                if (double.Parse(textBox29.Text) < -10000 && double.Parse(textBox29.Text) < 0)
                {
                    textBox29.Text = textBox29.Text.Remove(5);
                }

            }
        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {
            if (textBox30.Text.Length > 2)
            {
                if (double.Parse(textBox30.Text) > 10000)
                {
                    textBox30.Text = textBox30.Text.Remove(4);
                }
                if (double.Parse(textBox30.Text) < -10000 && double.Parse(textBox30.Text) < 0)
                {
                    textBox30.Text = textBox30.Text.Remove(5);
                }

            }
        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {
            if (textBox31.Text.Length > 2)
            {
                if (double.Parse(textBox31.Text) > 10000)
                {
                    textBox31.Text = textBox31.Text.Remove(4);
                }
                if (double.Parse(textBox31.Text) < -10000 && double.Parse(textBox31.Text) < 0)
                {
                    textBox31.Text = textBox31.Text.Remove(5);
                }

            }
        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {
            if (textBox32.Text.Length > 2)
            {
                if (double.Parse(textBox32.Text) > 10000)
                {
                    textBox32.Text = textBox32.Text.Remove(4);
                }
                if (double.Parse(textBox32.Text) < -10000 && double.Parse(textBox32.Text) < 0)
                {
                    textBox32.Text = textBox32.Text.Remove(5);
                }

            }
        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {
            if (textBox33.Text.Length > 2)
            {
                if (double.Parse(textBox33.Text) > 10000)
                {
                    textBox33.Text = textBox33.Text.Remove(4);
                }
                if (double.Parse(textBox33.Text) < -10000 && double.Parse(textBox33.Text) < 0)
                {
                    textBox33.Text = textBox33.Text.Remove(5);
                }

            }
        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {
            if (textBox34.Text.Length > 2)
            {
                if (double.Parse(textBox34.Text) > 10000)
                {
                    textBox34.Text = textBox34.Text.Remove(4);
                }
                if (double.Parse(textBox34.Text) < -10000 && double.Parse(textBox34.Text) < 0)
                {
                    textBox34.Text = textBox34.Text.Remove(5);
                }

            }
        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {
            if (textBox35.Text.Length > 2)
            {
                if (double.Parse(textBox35.Text) > 10000)
                {
                    textBox35.Text = textBox35.Text.Remove(4);
                }
                if (double.Parse(textBox35.Text) < -10000 && double.Parse(textBox35.Text) < 0)
                {
                    textBox35.Text = textBox35.Text.Remove(5);
                }

            }
        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {
            if (textBox36.Text.Length > 2)
            {
                if (double.Parse(textBox36.Text) > 10000)
                {
                    textBox36.Text = textBox36.Text.Remove(4);
                }
                if (double.Parse(textBox36.Text) < -10000 && double.Parse(textBox36.Text) < 0)
                {
                    textBox36.Text = textBox36.Text.Remove(5);
                }

            }
        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {
            if (textBox37.Text.Length > 2)
            {
                if (double.Parse(textBox37.Text) > 10000)
                {
                    textBox37.Text = textBox37.Text.Remove(4);
                }
                if (double.Parse(textBox37.Text) < -10000 && double.Parse(textBox37.Text) < 0)
                {
                    textBox37.Text = textBox37.Text.Remove(5);
                }

            }
        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {
            if (textBox38.Text.Length > 2)
            {
                if (double.Parse(textBox38.Text) > 10000)
                {
                    textBox38.Text = textBox38.Text.Remove(4);
                }
                if (double.Parse(textBox38.Text) < -10000 && double.Parse(textBox38.Text) < 0)
                {
                    textBox38.Text = textBox38.Text.Remove(5);
                }

            }
        }
    }
}
