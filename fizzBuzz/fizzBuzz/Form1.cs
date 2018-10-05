using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fizzBuzz
{
    public partial class Form1 : Form
    {
        int fizz, buzz;
        const int count = 100;

        public Form1()
        {
            InitializeComponent();
            fizz = 0;
            buzz = 0;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            fizzInput.Clear();
            buzzInput.Clear();
            outputBox.Items.Clear();
        }

        private void fizzBuzzButton_Click(object sender, EventArgs e)
        {
            outputBox.Items.Clear();

            try
            {
                fizz = int.Parse(fizzInput.Text);
                buzz = int.Parse(buzzInput.Text);

                for(int i = 1; i <= count; i++)
                {
                    if ((i % fizz == 0) && (i % buzz == 0))
                        outputBox.Items.Add("fizzbuzz");
                    else if (i % fizz == 0)
                        outputBox.Items.Add("fizz");
                    else if (i % buzz == 0)
                        outputBox.Items.Add("buzz");
                    else
                        outputBox.Items.Add(i.ToString());
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("fizz buzz machine broke :(" + ex.ToString());
            }
        }
    }
}
