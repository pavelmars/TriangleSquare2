using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquareDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        { // для равнобедренного прямоугольного треугольника
            Proverka myCheck = new Proverka(textBox1.Text);
            if ((myCheck.DataCheck() == true) && (myCheck.Empty_Check() == true) 
                && (myCheck.Space_Check() == true))
            {
                Triangle90 t90 = new Triangle90(Convert.ToInt32(textBox1.Text));
                label2.Text = Convert.ToString(t90.SquareCalculate1());
            }
            else 
            { 
                MessageBox.Show("Warning! The input value is incorrect! Repeat please."); 
            }
        }


        private void button2_Click(object sender, EventArgs e)
        { // для неравнобедренного прямоугольного треугольника
            Proverka myCheck_a = new Proverka(textBox_a.Text);
            if ((myCheck_a.DataCheck() == true) && (myCheck_a.Empty_Check() == true)
                && (myCheck_a.Space_Check() == true))
            {
                Proverka myCheck_b = new Proverka(textBox_b.Text);
                if ((myCheck_b.DataCheck() == true) && (myCheck_b.Empty_Check() == true)
                    && (myCheck_b.Space_Check() == true))
                {
                    Proverka myCheck_c = new Proverka(textBox_c.Text);
                    if ((myCheck_c.DataCheck() == true) && (myCheck_c.Empty_Check() == true)
                        && (myCheck_c.Space_Check() == true))
                    {
                        Triangle90 t90 = new Triangle90(Convert.ToDouble(textBox_a.Text),
                                         Convert.ToDouble(textBox_b.Text), Convert.ToDouble(textBox_c.Text));
                        if (t90.Katets() == true)
                        {
                            label7.Text = Convert.ToString(t90.SquareCalculate2());
                        }
                        else { MessageBox.Show("Неправильно введены стороны прямоугольного треугольника."); }
                    }
                    else { MessageBox.Show("Warning! The input value is incorrect! Repeat please."); }
                }
                else { MessageBox.Show("Warning! The input value is incorrect! Repeat please."); }
            }
            else { MessageBox.Show("Warning! The input value is incorrect! Repeat please."); }

        }
    }
}
