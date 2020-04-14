using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stacks
{
    public partial class Form1 : Form
    {
        Stack Base;
        public Form1()
        {
            InitializeComponent();
            Base = new Stack();
        }

        

        private void Button5_Click_1(object sender, EventArgs e)
        {
            Base.Push(Int32.Parse(textBox6.Text));
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Base.Push(textBox7.Text);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Base.Push(true);
                radioButton1.Checked = false;
            }
            else
            {
                Base.Push(false);
            }

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            object temp = Base.Pop();
            if (temp is null)
                textBox8.Text = "null";
            else
            {
                if (temp is Int32)
                    textBox8.Text = "int   " + temp.ToString();
                else if (temp is bool)
                    textBox8.Text = "bool   " + temp.ToString();
                else
                    textBox8.Text = "string    " + temp;
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            try
            {
                textBox9.Text = Base.Peek().ToString();
            }
            catch
            {
                textBox9.Text = "null";
            }
        }
    }
}
