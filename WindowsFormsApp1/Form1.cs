using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string name = "admin";
        string password = "111";
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Equals(name)&&textBox2.Text.Equals(password))
            {
                errorProvider1.Clear();
                errorProvider2.Clear();
                MessageBox.Show("login success");
                
            }
            else
            {
                if (!textBox1.Text.Equals(name))
                    errorProvider1.SetError(textBox1, "username is not crroct");
                else
                    errorProvider1.Clear();
                if(!textBox2.Text.Equals(password))
                    errorProvider2.SetError(textBox2, "password is not crroct");
                else
                    errorProvider2.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
